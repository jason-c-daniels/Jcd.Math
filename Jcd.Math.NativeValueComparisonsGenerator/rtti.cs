namespace Jcd.Math.NativeValueComparisonsGenerator;

public readonly record struct rtti(bool IsSigned, 
                                   bool IsFloatingPoint, 
                                   int Size,
                                   Type Type
)
{
    public rtti(Type t) : this(
        t.IsSigned(),
        t.IsFloatingPoint(),
        t.SizeOf(),
        t
    )
    {
        
    }
}