namespace Jcd.Math.NativeValueComparisonsGenerator;

public static class TypeExtensions
{
    public static int SizeOf(this Type t)
    {
        if (t == typeof(bool)) return sizeof(bool);
        if (t == typeof(byte)) return sizeof(byte);
        if (t == typeof(sbyte)) return sizeof(sbyte);
        if (t == typeof(short)) return sizeof(short);
        if (t == typeof(ushort)) return sizeof(ushort);
        if (t == typeof(int)) return sizeof(int);
        if (t == typeof(uint)) return sizeof(uint);
        if (t == typeof(long)) return sizeof(long);
        if (t == typeof(ulong)) return sizeof(ulong);
        if (t == typeof(float)) return sizeof(float);
        if (t == typeof(double)) return sizeof(double);
        if (t == typeof(decimal)) return sizeof(decimal);
        return 0;
    }

    public static bool IsSigned(this Type t)
    {
        return t == typeof(float)
               || t == typeof(decimal)
               || t == typeof(double)
               || t == typeof(sbyte)
               || t == typeof(short)
               || t == typeof(int)
               || t == typeof(long)
            ;
    }

    public static bool IsFloatingPoint(this Type t)
    {
        return t == typeof(float)
               || t == typeof(double)
               || t == typeof(decimal)
            ;
    }
    
    public static rtti GetRtti(this Type t) => new (t);
}