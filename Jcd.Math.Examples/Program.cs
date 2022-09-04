// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Jcd.Math.Intervals;
const int numberOfItemsToCreate = 100_000_000;

var _ = Interval<byte>.Closed(10,100);
var __ = _.Contains(11);
TimeClosedIntervalCreates();
TimeClosedIntervalCopies();
TimeClosedIntervalContainsValue();
TimeRangeExtensionsInRange();
TimeRangeExtensionsCompareToRange();
TimeIntervalLimitCreates();
TimeIntervalLimitConstraintIsClosedRetrieval();
TimeIntervalLimitConstraintIsOpenRetrieval();
TimeIntervalLimitTypeCasts();
TimeIntervalLimitCompareToCalls();
TimeIntervalLimitLessThanCalls();
TimeRawEnumTypeCasts();
TimeRawEnumCompareToCalls();
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
    for (var i = 0; i < numberOfItemsToCreate; i++)
    {
        var _ = (IntervalLimitType)0;
        var _2 = (IntervalLimitType)1;
    }

    sw.Stop();
    Console.WriteLine(
        $"{numberOfItemsToCreate:n0} x 2 {nameof(IntervalLimitType)} instances cast from byte in {sw.ElapsedMilliseconds}ms");
}

static void TimeIntervalLimitConstraintIsClosedRetrieval()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < numberOfItemsToCreate; i++)
    {
        var _1 = IntervalLimitConstraint.Open.IsClosed;
        var _2 = IntervalLimitConstraint.Closed.IsClosed;
        var _3 = IntervalLimitConstraint.Unbounded.IsClosed;
    }

    sw.Stop();
    Console.WriteLine(
        $"{numberOfItemsToCreate:n0} x 3 {nameof(IntervalLimitConstraint)} IsClosed in {sw.ElapsedMilliseconds}ms");
}

static void TimeIntervalLimitConstraintIsOpenRetrieval()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < numberOfItemsToCreate; i++)
    {
        var _1 = IntervalLimitConstraint.Open.IsOpen;
        var _2 = IntervalLimitConstraint.Closed.IsOpen;
        var _3 = IntervalLimitConstraint.Unbounded.IsOpen;
    }

    sw.Stop();
    Console.WriteLine(
        $"{numberOfItemsToCreate:n0} x 3 {nameof(IntervalLimitConstraint)} IsOpen in {sw.ElapsedMilliseconds}ms");
}

static void TimeIntervalLimitCompareToCalls()
{
    var ilt0 = (IntervalLimitType)0;
    var ilt1 = (IntervalLimitType)1;
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < numberOfItemsToCreate; i++)
    {
        var r0 = ilt0.CompareTo(ilt1);
    }

    sw.Stop();
    Console.WriteLine($"{numberOfItemsToCreate:n0} {nameof(IntervalLimitType)} CompareTo calls in {sw.ElapsedMilliseconds}ms");
}

static void TimeIntervalLimitLessThanCalls()
{
    var ilt0 = (IntervalLimitType)0;
    var ilt1 = (IntervalLimitType)1;
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < numberOfItemsToCreate; i++)
    {
        var r0 = ilt0 < ilt1;
    }

    sw.Stop();
    Console.WriteLine($"{numberOfItemsToCreate:n0} {nameof(IntervalLimitType)} < calls in {sw.ElapsedMilliseconds}ms");
}

static void TimeRawEnumTypeCasts()
{
    var sw = new Stopwatch();
    sw.Start();
    const byte b0 = 0;
    const byte b1 = 1;
    for (var i = 0; i < numberOfItemsToCreate; i++)
    {
        var _ = (RawEnum)b0;
        var _2 = (RawEnum)b1;
    }

    sw.Stop();
    Console.WriteLine(
        $"{numberOfItemsToCreate:n0} x 2 {nameof(IntervalLimitType)} instances cast from byte in {sw.ElapsedMilliseconds}ms");
}

static void TimeRawEnumCompareToCalls()
{
    var ilt0 = (RawEnum)0;
    var ilt1 = (RawEnum)1;
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < numberOfItemsToCreate; i++)
    {
        // this boxing allocation slows down comparisons.
        var r0 = ilt0.CompareTo(ilt1); 
    }

    sw.Stop();
    Console.WriteLine($"{numberOfItemsToCreate:n0} {nameof(RawEnum)} CompareTo calls in {sw.ElapsedMilliseconds}ms");
}

static void TimeRawEnumLessThanCalls()
{
    var ilt0 = (RawEnum)0;
    var ilt1 = (RawEnum)1;
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < numberOfItemsToCreate; i++)
    {
        var r0 = ilt0 < ilt1;
    }

    sw.Stop();
    
    Console.WriteLine($"{numberOfItemsToCreate:n0} {nameof(RawEnum)} < calls in {sw.ElapsedMilliseconds}ms");
}

static void TimeIntervalLimitCreates()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < numberOfItemsToCreate; i++)
    {
        var _ = IntervalLimit<byte>.ClosedStart(10);
    }

    sw.Stop();
    Console.WriteLine(
        $"{numberOfItemsToCreate:n0} {nameof(IntervalLimit)}<byte> instances created in {sw.ElapsedMilliseconds}ms");
}

static void TimeClosedIntervalCreates()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < numberOfItemsToCreate; i++)
    {
        var _ = Interval<byte>.Closed(1,10);
    }

    sw.Stop();
    Console.WriteLine(
        $"{numberOfItemsToCreate:n0} {nameof(Interval)}.{nameof(Interval.Closed)} instances created in {sw.ElapsedMilliseconds}ms");
}

static void TimeClosedIntervalCopies()
{
    var source = Interval<byte>.Closed(1, 10);
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < numberOfItemsToCreate; i++)
    {
        var _ = source;
    }

    sw.Stop();
    Console.WriteLine(
        $"{numberOfItemsToCreate:n0} {nameof(Interval)}.{nameof(Interval.Closed)} copies performed in {sw.ElapsedMilliseconds}ms");
}

static void TimeClosedIntervalContainsValue()
{
    var interval = Interval<byte>.Closed(1, 254);
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < numberOfItemsToCreate; i++)
    {
        var _ =interval.Contains(10);
    }

    sw.Stop();
    Console.WriteLine(
        $"{numberOfItemsToCreate:n0} {nameof(Interval)}.{nameof(Interval.Closed)} contains a value performed in {sw.ElapsedMilliseconds}ms");
}

static void TimeRangeExtensionsInRange()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < numberOfItemsToCreate; i++)
    {
        var _=i.InRange(200,20_000_000);
    }

    sw.Stop();
    Console.WriteLine(
        $"{numberOfItemsToCreate:n0} {nameof(ComparableExtensions)}.{nameof(ComparableExtensions.InRange)} performed in {sw.ElapsedMilliseconds}ms");
}

static void TimeRangeExtensionsCompareToRange()
{
    var sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < numberOfItemsToCreate; i++)
    {
        var _=i.CompareToRange(200,20_000_000);
    }

    sw.Stop();
    Console.WriteLine(
        $"{numberOfItemsToCreate:n0} {nameof(ComparableExtensions)}.{nameof(ComparableExtensions.CompareToRange)} performed in {sw.ElapsedMilliseconds}ms");
}