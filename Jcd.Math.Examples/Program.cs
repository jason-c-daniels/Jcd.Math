// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Jcd.Math;
using Jcd.Math.Examples;
using PerfTiming=Jcd.Math.Examples.PerfTiming;
using Jcd.Math.Intervals;
using Jcd.Math.Numbers;

var _ = Interval<byte>.Closed(10,100);
var __ = _.Contains(11);


var fnUInt = new FiniteNumber<uint>(10);
int int1 = 1;
uint uint1 = 1;
double double2 = 2;
double double1 = 1;
long long1 = 1;

var x=(ushort)1;
TryIt("upcast ushort to double", () => { var x1=(double)x; });
x = 2;
TryIt("long1.CompareTo(int1)", () => { long1.CompareTo(int1); });
TryIt("int1.CompareTo(double2)", () => { int1.CompareTo(double2); });
TryIt("double2.CompareTo(int1)", () => double2.CompareTo(int1));
TryIt("uint1.CompareTo(double2)", () => { uint1.CompareTo(double2); });
TryIt("double2.CompareTo(uint1)", () => double2.CompareTo(uint1));
TryIt("uint1.CompareTo(int1)", () => { uint1.CompareTo(int1); });
TryIt("int1.CompareTo(uint1)", () => { int1.CompareTo(uint1); });
TryIt("int1 == double1", () => { var _r = int1 == double2; });
TryIt("int1 == double2", () => { var _r = int1 == double1; });
TryIt("int1 <= double1", () => { var _r = int1 <= double2; });
TryIt("int1 <= double2", () => { var _r = int1 <= double1; });

PerfTiming.FiniteNumbers.RunAll();
PerfTiming.Intervals.RunAll();

TimeRangeExtensionsInRange();
TimeRangeExtensionsCompareToRange();
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


static void TimeRawEnumTypeCasts()
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

static void TimeRawEnumCompareToCalls()
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

static void TimeRawCompareToCalls<T>(T ilt0, T ilt1)
   where T : IComparable<T>
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < Repetition.Count; i++)
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
    for (var i = 0; i < Repetition.Count; i++)
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
    for (var i = 0; i < Repetition.Count; i++)
    {
        var r0 = ilt0 < ilt1;
    }

    sw.Stop();
    ReportTiming($"{nameof(RawEnum)} < other", sw.Elapsed);
}

static void TimeRangeExtensionsInRange()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < Repetition.Count; i++)
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
    for (var i = 0; i < Repetition.Count; i++)
    {
        var _=i.ToRange(200,20_000_000);
    }

    sw.Stop();
    ReportTiming($"{nameof(Compare)}.{nameof(Compare.ToRange)}(repetition,200,20_000_000)", sw.Elapsed);
}

static void ReportTiming(string name, TimeSpan elapsed, int operationsPerRepetition = 1)
{
    OperationSpeed.Report(name, elapsed, Repetition.Count, operationsPerRepetition);
}

void TryIt(string actionName, Action runme)
{
    try
    {
        runme?.Invoke();
        Console.WriteLine($"{actionName} worked");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"{actionName} Exception:{ex.Message}");
    }
}
