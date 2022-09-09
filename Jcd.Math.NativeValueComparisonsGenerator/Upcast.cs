namespace Jcd.Math.NativeValueComparisonsGenerator;

record struct Upcast(Type First, Type Second, Type Target)
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
        typeof(long),
        typeof(ulong),
        typeof(float),
        typeof(double)
    };
    public Upcast(Type first, Type second) : this(first, second, first) { }
    public static Upcast FromFirst(Type t1, Type t2) => new Upcast(t1, t2);
    public static Upcast BothTo(Type t1, Type t2, Type t3) => new Upcast(t1,t2,t3);
    public static Upcast FromFirst<T1, T2>() => new Upcast(typeof(T1), typeof(T2));
    public static Upcast BothTo<T1, T2, T3>() => new Upcast(typeof(T1), typeof(T2), typeof(T3));

    IEnumerable<Upcast> GenerateMappings()
    {
        foreach (var t1 in Types)
        {
            foreach (var t2 in Types)
            {
                if (t1 == t2) continue;
                if (t2 == typeof(bool)) continue;
                if (t1 == typeof(bool))
                    yield return new Upcast(t1, t2);
            }
        }        
    }
}
