namespace Jcd.Math.NativeValueComparisonsGenerator;

public record struct Upcast(Type First, Type Second, Type Target)
{
    private static readonly Type[] Types = 
    {
        typeof(bool),
        typeof(byte),
        typeof(sbyte),
        typeof(short),
        typeof(ushort),
        typeof(int),
        typeof(uint),
        typeof(float),
        typeof(long),
        typeof(ulong),
        typeof(double),
        typeof(decimal)
    };

    private static readonly IReadOnlyDictionary<Type, rtti> TypeToRtti = Types.Select(t => t.GetRtti()).ToDictionary(i => i.Type);
    
    public Upcast(Type first, Type second) : this(first, second, first) { }
    public static Upcast FromFirst(Type t1, Type t2) => new Upcast(t1, t2);
    public static Upcast BothTo(Type t1, Type t2, Type t3) => new Upcast(t1,t2,t3);
    public static Upcast FromFirst<T1, T2>() => new Upcast(typeof(T1), typeof(T2));
    public static Upcast BothTo<T1, T2, T3>() => new Upcast(typeof(T1), typeof(T2), typeof(T3));
    const int MaxSize = sizeof(ulong); 

    public static IEnumerable<Upcast> Generate()
    {
        return
            (from t1 in Types
             from t2 in Types
             let rtti1 = TypeToRtti[t1]
             let rtti2 = TypeToRtti[t2]
             where t1 != t2 && (rtti1.Size >= rtti2.Size || t1 == typeof(bool))
             let ut = GetUpcastFromFirstType(rtti1, rtti2)
             where ut != null
             select new Upcast(t1, t2, ut)
            ).Distinct();
    }

    #region Equality members

    /// <inheritdoc />
    public readonly bool Equals(Upcast other)
    {
        return (First.Equals(other.First) && Second.Equals(other.Second)) ||
                First.Equals(other.Second)  && Second.Equals(other.First)
               ;
    }

    /// <inheritdoc />
    public readonly override int GetHashCode()
    {
        return First.GetHashCode() ^ Second.GetHashCode();
    }


    /// <inheritdoc />
    public override string ToString()
    {
        return $"{First.Name} and {Second.Name} via {Target.Name}";
    }
    
    #endregion

    private static Type? GetUpcastFromFirstType(rtti rtti1, rtti rtti2)
    {
        // same types don't need upcasting. shouldn't ever be called this way, but we distrust callers.
        if (rtti1.Type == rtti2.Type) return null;
        
        // always select first when bool. It has special handling. No other logic applies.
        if (rtti1.Type == typeof(bool)) return rtti1.Type;

        // bool has special handling, no upcast available if it's on the right.
        if (rtti2.Type == typeof(bool)) return null;

        // all non-boolean types with 32bits or less can be converted safely to decimal 
        // decimal also has special handling. 
        if (rtti1.Type == typeof(decimal) && 
            (   (rtti2.Size <  MaxSize &&  rtti2.IsSigned) 
             || (rtti2.Size <= MaxSize && !rtti2.IsSigned)
             )
            )
            return typeof(decimal);
        
        // no upcast available if both are at the largest destination upcast type
        // without special handling. (i.e. long and double)
        if (rtti1.Size >= MaxSize && rtti2.Size >= MaxSize) return null;
        
        // only upcast type 2 to type 1, so type 1 must be of equal or larger size.
        if (rtti2.Size > rtti1.Size) return null;

        // determine upcast for floating points on left
        if (rtti1.IsFloatingPoint)
        {
            // Handle float left w/ some other value on the right.
            if (rtti1.Size < MaxSize)
            {
                if (/*rtti1.Type == typeof(float) &&*/ rtti1.Size==rtti2.Size)
                    return typeof(double); // same size, more space needed, upcast both to double.

                // 32bit float on left && 16/8bit type on right, upcast to 32 bit float.
                return rtti1.Type;
            }

            // both are floating point that makes the left (rtti1) a double as we handled 32bit floats above, so return that.
            if (rtti2.IsFloatingPoint) return rtti1.Type;

            // left is a double. upcast all smaller int types.
            if (rtti1.Size == MaxSize && rtti2.Size < rtti1.Size)
                return rtti1.Type;

            // we're dealing with a double on the left and a 64bit int on the right. No upcast available.
            return null;
        }

        // left int (32bit or smaller), right float (32bit) upcast both to decimal. 
        if (rtti2.IsFloatingPoint) return typeof(decimal);
        
        // we are now deciding how to handle this for ints (byte,sbyte .. uint,int ...etc)
        // recall above that no upcast to same type is available.
        // so rtti1.Type != rtti2.Type, since there is no larger int type than
        // ulong/long no upcast exists, so wel limit our logic to just those that matter
        if (rtti1.Size == rtti2.Size && rtti1.Size < MaxSize)
            return SelectNextLargerInt(rtti1.Size);

        if (rtti1.Size > rtti2.Size)
        {
            // left size is larger than right, and right is signed. Upcast to a 3rd type. 
            if (rtti1.IsSigned != rtti2.IsSigned && !rtti1.IsSigned)
                return SelectNextLargerInt(rtti1.Size);
            
            // 1. both share the same sign, left is larger size so that's our upcast type.
            // 2. Left is signed (and larger) right is unsigned. left side is our upcast type.
            return rtti1.Type;
        }

        // no valid upcast was determined.
        return null;
    }

    private static Type? SelectNextLargerInt(int size)
    {
        if (size == sizeof(byte)) return typeof(short);
        if (size == sizeof(short)) return typeof(int);
        if (size == sizeof(int)) return typeof(long);
        // NOTE: (u)long can't be sensibly upcast from so we return null.
        return null;
    }
}
