// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Jcd.Math;
using Jcd.Math.Examples;
using Jcd.Math.Intervals;
const int repetitionCount = 100_000_000;

var _ = Interval<byte>.Closed(10,100);
var __ = _.Contains(11);
TimeOpenIntervalCreates();
TimeOpenClosedIntervalCreates();
TimeClosedOpenIntervalCreates();
TimeClosedUnboundedIntervalCreates();
TimeUnboundedClosedIntervalCreates();
TimeUnboundedIntervalCreates();
TimeClosedIntervalCreates();
TimeClosedIntervalCopies();
TimeClosedIntervalContainsValue();
TimeClosedIntervalContainsAnotherInterval();
TimeRangeExtensionsInRange();
TimeRangeExtensionsCompareToRange();
TimeIntervalLimitCreates();
TimeIntervalLimitCompareToValue();
TimeIntervalLimitConstraintIsClosedRetrieval();
TimeIntervalLimitConstraintIsOpenRetrieval();
TimeIntervalLimitTypeCasts();
TimeIntervalLimitTypeCompareToCalls();
TimeIntervalLimitLessThanCalls();
TimeRawEnumTypeCasts();
TimeRawEnumCompareToCalls();
TimeRawCompareToCalls<byte>(1, 10);
TimeInterfaceCompareToCalls((byte)1, (byte)10);
TimeRawEnumLessThanCalls();

IntervalLimit<int> ild;
var ild2=IntervalLimit<int>.Default;
var il=IntervalLimit<int>.UnboundedStart();
var il2 = IntervalLimit.OpenStart(10);
var il3 = IntervalLimit.ClosedStart(10);
var il4 = IntervalLimit.UnboundedEnd<int>();
var il5 = IntervalLimit.OpenEnd(10);
var il6 = IntervalLimit.ClosedEnd(10);

var b1 = il.CompareTo(il2);
var b2 = il2.CompareTo(il3);

IntervalLimitConstraint ilc;

var ildc1 = IntervalLimit<CustomValue>.Default;
var ildc2 = IntervalLimit.UnboundedStart<CustomValue>();

int i=0;

static void TimeIntervalLimitTypeCasts()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _ = (IntervalLimitType)0;
        var _2 = (IntervalLimitType)1;
    }

    sw.Stop();
    ReportTiming($"Cast Interval {nameof(IntervalLimitType)} to byte", sw.Elapsed, 2);
}


static void TimeIntervalLimitCompareToValue()
{
    var s = IntervalLimit.ClosedStart(10);
    var e = IntervalLimit.ClosedEnd(100);
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _ = s.CompareTo(12);
        var __ = e.CompareTo(12);
    }

    sw.Stop();
    ReportTiming($"{typeof(IntervalLimit<byte>).Name}.{nameof(IntervalLimit<byte>.CompareTo)}", sw.Elapsed, 2);
}

static void TimeIntervalLimitConstraintIsClosedRetrieval()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _1 = IntervalLimitConstraint.Open.IsClosed;
        var _2 = IntervalLimitConstraint.Closed.IsClosed;
        var _3 = IntervalLimitConstraint.Unbounded.IsClosed;
    }

    sw.Stop();
    ReportTiming($"{nameof(IntervalLimitConstraint)}.{nameof(IntervalLimitConstraint.IsClosed)} on .Open, .Closed and .Unbounded", sw.Elapsed, 3);
}

static void TimeIntervalLimitConstraintIsOpenRetrieval()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _1 = IntervalLimitConstraint.Open.IsOpen;
        var _2 = IntervalLimitConstraint.Closed.IsOpen;
        var _3 = IntervalLimitConstraint.Unbounded.IsOpen;
    }

    sw.Stop();
    ReportTiming($"{nameof(IntervalLimitConstraint)}.{nameof(IntervalLimitConstraint.IsOpen)} on .Open, .Closed and .Unbounded", sw.Elapsed, 3);
}

static void TimeIntervalLimitTypeCompareToCalls()
{
    var ilt0 = (IntervalLimitType)0;
    var ilt1 = (IntervalLimitType)1;
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var r0 = ilt0.CompareTo(ilt1);
    }

    sw.Stop();
    ReportTiming($"{nameof(IntervalLimitType)}.{nameof(IntervalLimitType.CompareTo)}", sw.Elapsed);
}

static void TimeIntervalLimitLessThanCalls()
{
    var ilt0 = (IntervalLimitType)0;
    var ilt1 = (IntervalLimitType)1;
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var r0 = ilt0 < ilt1;
    }

    sw.Stop();
    ReportTiming($"{nameof(IntervalLimitType)} < other", sw.Elapsed);
}

static void TimeRawEnumTypeCasts()
{
    var sw = new Stopwatch();
    sw.Start();
    const byte b0 = 0;
    const byte b1 = 1;
    for (var i = 0; i < repetitionCount; i++)
    {
        var _ = (RawEnum)b0;
        var _2 = (RawEnum)b1;
    }

    sw.Stop();
    ReportTiming($"Cast a byte (0 and then 1) to {nameof(RawEnum)}", sw.Elapsed,2);
}

static void TimeRawEnumCompareToCalls()
{
    var ilt0 = (RawEnum)0;
    var ilt1 = (RawEnum)1;
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        // this boxing allocation slows down comparisons and hammers the GC.
        var r0 = ilt0.CompareTo(ilt1); 
    }

    sw.Stop();
    ReportTiming($"{nameof(RawEnum)}.CompareTo", sw.Elapsed);
}

static void TimeRawCompareToCalls<T>(T ilt0, T ilt1)
   where T : IComparable<T>
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        // this interface usage slows down comparisons vs built in operators for native types.
        var r0 = ilt0.CompareTo(ilt1); 
    }

    sw.Stop();
    ReportTiming($"{typeof(T).Name}.CompareTo", sw.Elapsed);
}

static void TimeInterfaceCompareToCalls<T>(IComparable<T> ilt0, T ilt1)
    where T : IComparable<T>
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        // this interface access slows down comparisons by at least an order of magnitude.
        var r0 = ilt0.CompareTo(ilt1); 
    }

    sw.Stop();
    ReportTiming($"IComparable<{typeof(T).Name}>.CompareTo", sw.Elapsed);
}

static void TimeRawEnumLessThanCalls()
{
    var ilt0 = (RawEnum)0;
    var ilt1 = (RawEnum)1;
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var r0 = ilt0 < ilt1;
    }

    sw.Stop();
    ReportTiming($"{nameof(RawEnum)} < other", sw.Elapsed);
}

static void TimeIntervalLimitCreates()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _ = IntervalLimit<byte>.ClosedStart(1);
        var __ = IntervalLimit<byte>.ClosedEnd(10);
    }

    sw.Stop();
    ReportTiming($"{typeof(IntervalLimit<byte>).Name} ClosedStart and ClosedEnd creation", sw.Elapsed,2);
}

static void TimeClosedIntervalCreates()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _ = Interval<byte>.Closed(1,10);
    }

    sw.Stop();
    ReportTiming($"{typeof(Interval<byte>).Name}.Closed", sw.Elapsed);
}

static void TimeOpenIntervalCreates()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _ = Interval<byte>.Open(1,10);
    }

    sw.Stop();
    ReportTiming($"{typeof(Interval<byte>).Name}.Open", sw.Elapsed);
}

static void TimeOpenClosedIntervalCreates()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _ = Interval<byte>.OpenClosed(1,10);
    }

    sw.Stop();
    ReportTiming($"{typeof(Interval<byte>).Name}.OpenClosed", sw.Elapsed);
}

static void TimeClosedOpenIntervalCreates()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _ = Interval<byte>.ClosedOpen(1,10);
    }

    sw.Stop();
    ReportTiming($"{typeof(Interval<byte>).Name}.ClosedOpen", sw.Elapsed);
}

static void TimeClosedUnboundedIntervalCreates()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _ = Interval<byte>.ClosedUnbounded(1);
    }

    sw.Stop();
    ReportTiming($"{typeof(Interval<byte>).Name}.ClosedUnbounded", sw.Elapsed);
}

static void TimeUnboundedClosedIntervalCreates()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _ = Interval<byte>.UnboundedClosed(1);
    }

    sw.Stop();
    ReportTiming($"{typeof(Interval<byte>).Name}.UnboundedClosed", sw.Elapsed);
}

static void TimeUnboundedIntervalCreates()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _ = Interval<byte>.Unbounded();
    }

    sw.Stop();
    ReportTiming($"{typeof(Interval<byte>).Name}.Unbounded", sw.Elapsed);
}

static void TimeClosedIntervalCopies()
{
    var source = Interval<byte>.Closed(1, 10);
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _ = source;
    }

    sw.Stop();
    ReportTiming($"Copy {typeof(Interval<byte>).Name}", sw.Elapsed);
}

static void TimeClosedIntervalContainsValue()
{
    var interval = Interval<byte>.Closed(1, 254);
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _ =interval.Contains(10);
    }

    sw.Stop();
    ReportTiming($"{typeof(Interval<byte>).Name}.Contains(value)", sw.Elapsed);
}

static void TimeClosedIntervalContainsAnotherInterval()
{
    var interval = Interval<byte>.Closed(1, 254);
    var interval2 = Interval<byte>.Closed(2, 253);
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _ =interval.Contains(interval2);
    }

    sw.Stop();
    ReportTiming($"{typeof(Interval<byte>).Name}.Contains(otherInterval)", sw.Elapsed);
}

static void TimeRangeExtensionsInRange()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _=i.InRange(200,20_000_000);
    }

    sw.Stop();
    ReportTiming($"{nameof(Compare)}.{nameof(Compare.InRange)}(repetition,200,20_000_000)", sw.Elapsed);
}

static void TimeRangeExtensionsCompareToRange()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < repetitionCount; i++)
    {
        var _=i.CompareToRange(200,20_000_000);
    }

    sw.Stop();
    ReportTiming($"{nameof(Compare)}.{nameof(Compare.CompareToRange)}(repetition,200,20_000_000)", sw.Elapsed);
}

static void ReportTiming(string name, TimeSpan elapsed, int operationsPerRepetition = 1)
{
    OperationSpeed.Report(name, repetitionCount, elapsed, operationsPerRepetition);
}