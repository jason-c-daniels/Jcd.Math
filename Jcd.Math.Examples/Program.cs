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
TryIt("long1.CompareTo(int1)", () => { long1.CompareTo(int1); });
TryIt("int1.CompareTo(double2)", () => { int1.CompareTo(double2); });
TryIt("double2.CompareTo(int1)", () => double2.CompareTo(int1));
TryIt("uint1.CompareTo(double2)", () => { uint1.CompareTo(double2); });
TryIt("double2.CompareTo(uint1)", () => double2.CompareTo(uint1));
TryIt("uint1.CompareTo(int1)", () => { uint1.CompareTo(int1); });
TryIt("int1.CompareTo(uint1)", () => { int1.CompareTo(uint1); });
TryIt("int1 == double1", () => { var _r = int1 == uint1; });
TryIt("int1 == double2", () => { var _r = uint1 == double1; });
TryIt("int1 <= double1", () => { var _r = int1 <= uint1; });
TryIt("int1 <= double2", () => { var _r = int1 <= double1; });
TryIt("int1 == double1", () => { var _r = int1 == double2; });
TryIt("int1 == double2", () => { var _r = int1 == double1; });
TryIt("int1 <= double1", () => { var _r = int1 <= double2; });
TryIt("int1 <= double2", () => { var _r = int1 <= double1; });

PerfTiming.FiniteNumbers.RunAll();
PerfTiming.Intervals.RunAll();
PerfTiming.IntegralDataTypes.RunAll();

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
