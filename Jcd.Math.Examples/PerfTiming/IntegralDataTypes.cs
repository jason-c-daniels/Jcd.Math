using System.Diagnostics;

namespace Jcd.Math.Examples.PerfTiming;

public class IntegralDataTypes
{
    public static void RunAll()
    {
        RangeExtensionsInRange();
        RangeExtensionsCompareToRange();
        RawCompareToCalls<byte>(1, byte.MaxValue/2);
        RawCompareToCalls<short>(1, short.MaxValue/2);
        RawCompareToCalls<uint>(1, uint.MaxValue/2);
        RawCompareToCalls<ulong>(1, ulong.MaxValue/2);
        //RawCompareToCalls<ulong, uint>(ulong.MaxValue/2, uint.MaxValue/2 ); does not compile. ulong has no IComparable<uint>.CompareTo(uint other)!
        RawULongCompareToUIntCalls(ulong.MaxValue / 2, uint.MaxValue / 2);
        InterfaceCompareToCalls((byte)1, (byte)10);
        RawEnumTypeCasts();
        RawEnumCompareToCalls();
        RawEnumLessThanCalls();
    }
    
static void RawEnumTypeCasts()
{
    var sw = new Stopwatch();
    sw.Start();
    const byte b0 = 0;
    const byte b1 = 1;
    for (var i = 0; i < Repetition.Count; i++)
    {
        var _ = (RawEnum)b0;
        var _2 = (RawEnum)b1;
    }

    sw.Stop();
    ReportTiming($"Cast a byte (0 and then 1) to {nameof(RawEnum)}", sw.Elapsed,2);
}

static void RawEnumCompareToCalls()
{
    var ilt0 = (RawEnum)0;
    var ilt1 = (RawEnum)1;
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < Repetition.Count; i++)
    {
        // this boxing allocation slows down comparisons and hammers the GC.
        var r0 = ilt0.CompareTo(ilt1); 
    }

    sw.Stop();
    ReportTiming($"{nameof(RawEnum)}.CompareTo", sw.Elapsed);
}


static void RawULongCompareToUIntCalls(ulong v1, uint v2)
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < Repetition.Count; i++)
    {
        var r0 = v1.CompareTo(v2); 
    }

    sw.Stop();
    ReportTiming($"{nameof(UInt64)}.CompareTo({nameof(UInt32)})", sw.Elapsed);
}


static void RawCompareToCalls<T>(T v1, T v2)
   where T : IComparable<T>
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < Repetition.Count; i++)
    {
        // this interface usage slows down comparisons vs built in operators for native types.
        var r0 = v1.CompareTo(v2); 
    }

    sw.Stop();
    ReportTiming($"{typeof(T).Name}.CompareTo", sw.Elapsed);
}

static void RawCompareToCalls<T1,T2>(T1 v1, T2 v2)
    where T1 : IComparable<T2>
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < Repetition.Count; i++)
    {
        var r0 = v1.CompareTo(v2); 
    }

    sw.Stop();
    ReportTiming($"{typeof(T1).Name}.CompareTo({typeof(T2).Name})", sw.Elapsed);
}


static void InterfaceCompareToCalls<T>(IComparable<T> ictiV1, T v2)
    where T : IComparable<T>
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < Repetition.Count; i++)
    {
        // this is at least an order of magnitude slower than ((T) ictiV1).CompareTo(T v2)!!
        var r0 = ictiV1.CompareTo(v2); 
    }

    sw.Stop();
    ReportTiming($"IComparable<{typeof(T).Name}>.CompareTo({typeof(T).Name})", sw.Elapsed);
}

static void RawEnumLessThanCalls()
{
    var ilt0 = (RawEnum)0;
    var ilt1 = (RawEnum)1;
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < Repetition.Count; i++)
    {
        var r0 = ilt0 < ilt1;
    }

    sw.Stop();
    ReportTiming($"{nameof(RawEnum)} < other", sw.Elapsed);
}

static void RangeExtensionsInRange()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < Repetition.Count; i++)
    {
        var _=i.InRange(200,20_000_000);
    }

    sw.Stop();
    ReportTiming($"{nameof(Comparer)}.{nameof(Comparer.InRange)}(repetition,200,20_000_000)", sw.Elapsed);
}

static void RangeExtensionsCompareToRange()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < Repetition.Count; i++)
    {
        var _=i.ToRange(200,20_000_000);
    }

    sw.Stop();
    ReportTiming($"{nameof(Comparer)}.{nameof(Comparer.ToRange)}(repetition,200,20_000_000)", sw.Elapsed);
}
    
    static void ReportTiming(string name, TimeSpan elapsed, int operationsPerRepetition = 1)
    {
        OperationSpeed.Report(name, elapsed, Repetition.Count, operationsPerRepetition);
    }

}