using System.Diagnostics;
using Jcd.Math.Numbers;

namespace Jcd.Math.Examples.PerfTiming;

public static class FiniteNumbers
{
    public static void RunAll()
    {
        OfUInt64CompareToInt64();
        OfUInt64CompareToNegativeInfinity();
        OfDoubleCompareToInfinity();
        ActualDoubleCompareToInfinity();
        OfTypeByteCreates();
        OfTypeUInt64Creates();
        OfTypeDoubleCreates();
    }
    
    static void OfUInt64CompareToInt64()
    {
        var negOne = -1L;
        var value = new FiniteNumber<long>(long.MaxValue);
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _ = value.CompareTo(negOne);
        }

        sw.Stop();
        OperationSpeed.Report($"{typeof(FiniteNumber<ulong>).Name}<ulong>.CompareTo(-1L)", sw.Elapsed, Repetition.Count);
    }
    static void OfUInt64CompareToNegativeInfinity()
    {
        var negInf = Infinity.Negative;
        var value = new FiniteNumber<ulong>(ulong.MinValue);
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _ = value.CompareTo(negInf);
        }

        sw.Stop();
        OperationSpeed.Report($"{typeof(FiniteNumber<ulong>).Name}<ulong>.CompareTo(negInf)", sw.Elapsed, Repetition.Count);
    }
 
static void OfTypeByteCreates()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < Repetition.Count; i++)
    {
        var _ = new FiniteNumber<byte>(10);
    }

    sw.Stop();
    ReportTiming($"new {typeof(FiniteNumber<byte>).Name}<byte>", sw.Elapsed);
}

static void OfTypeDoubleCreates()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < Repetition.Count; i++)
    {
        var _ = new FiniteNumber<double>(10);
    }

    sw.Stop();
    ReportTiming($"new {typeof(FiniteNumber<byte>).Name}<double>", sw.Elapsed);
}

static void OfTypeUInt64Creates()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < Repetition.Count; i++)
    {
        var _ = new FiniteNumber<ulong>(10);
    }

    sw.Stop();
    ReportTiming($"new {typeof(FiniteNumber<ulong>).Name}<ulong>", sw.Elapsed);
}


static void OfDoubleCompareToInfinity()
{
    var negInf = Infinity.Negative;
    var value = new FiniteNumber<double>(double.MinValue);
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < Repetition.Count; i++)
    {
        var _ = value.CompareTo(negInf);
    }

    sw.Stop();
    ReportTiming($"{typeof(FiniteNumber<double>).Name}<double>.CompareTo(negInf)", sw.Elapsed);
}

static void ActualDoubleCompareToInfinity()
{
    var negInf = double.NegativeInfinity;
    var value = double.MinValue;
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < Repetition.Count; i++)
    {
        var _ = value.CompareTo(negInf);
    }

    sw.Stop();
    ReportTiming($"double.CompareTo(double.NegativeInfinity)", sw.Elapsed);
}
    
    static void ReportTiming(string name, TimeSpan elapsed, int operationsPerRepetition = 1)
    {
        OperationSpeed.Report(name, elapsed, Repetition.Count, operationsPerRepetition);
    }

}