using System.Diagnostics;
using Jcd.Math.Intervals;

namespace Jcd.Math.Examples.PerfTiming;

public static class Intervals
{
    public static void RunAll()
    {
        CreateOpenInterval();
        CreateOpenClosedInterval();
        CreateClosedOpenInterval();
        CreateClosedUnboundedInterval();
        CreateUnboundedClosedInterval();
        CreateUnboundedInterval();
        CreateClosedInterval();
        CopyClosedInterval();
        ClosedIntervalContainsValue();
        ClosedIntervalContainsAnotherInterval();
        CreateIntervalLimit();
        IntervalLimitCompareToValue();
        IntervalLimitConstraintIsClosedRetrieval();
        IntervalLimitConstraintIsOpenRetrieval();
        IntervalLimitTypeCasts();
        IntervalLimitTypeCompareToCalls();
        IntervalLimitLessThanCalls();
    }

    static void IntervalLimitTypeCasts()
    {
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _ = (IntervalLimitType)0;
            var _2 = (IntervalLimitType)1;
        }

        sw.Stop();
        ReportTiming($"Cast Interval {nameof(IntervalLimitType)} to byte", sw.Elapsed, 2);
    }


    static void IntervalLimitCompareToValue()
    {
        var s = IntervalLimit.ClosedStart(10);
        var e = IntervalLimit.ClosedEnd(100);
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _ = s.CompareTo(12);
            var __ = e.CompareTo(12);
        }

        sw.Stop();
        ReportTiming($"{typeof(IntervalLimit<byte>).Name}.{nameof(IntervalLimit<byte>.CompareTo)}", sw.Elapsed, 2);
    }

    static void IntervalLimitConstraintIsClosedRetrieval()
    {
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _1 = IntervalLimitConstraint.Open.IsClosed;
            var _2 = IntervalLimitConstraint.Closed.IsClosed;
            var _3 = IntervalLimitConstraint.Unbounded.IsClosed;
        }

        sw.Stop();
        ReportTiming(
            $"{nameof(IntervalLimitConstraint)}.{nameof(IntervalLimitConstraint.IsClosed)} on .Open, .Closed and .Unbounded",
            sw.Elapsed, 3);
    }

    static void IntervalLimitConstraintIsOpenRetrieval()
    {
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _1 = IntervalLimitConstraint.Open.IsOpen;
            var _2 = IntervalLimitConstraint.Closed.IsOpen;
            var _3 = IntervalLimitConstraint.Unbounded.IsOpen;
        }

        sw.Stop();
        ReportTiming(
            $"{nameof(IntervalLimitConstraint)}.{nameof(IntervalLimitConstraint.IsOpen)} on .Open, .Closed and .Unbounded",
            sw.Elapsed, 3);
    }

    static void IntervalLimitTypeCompareToCalls()
    {
        var ilt0 = (IntervalLimitType)0;
        var ilt1 = (IntervalLimitType)1;
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var r0 = ilt0.CompareTo(ilt1);
        }

        sw.Stop();
        ReportTiming($"{nameof(IntervalLimitType)}.{nameof(IntervalLimitType.CompareTo)}", sw.Elapsed);
    }

    static void IntervalLimitLessThanCalls()
    {
        var ilt0 = (IntervalLimitType)0;
        var ilt1 = (IntervalLimitType)1;
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var r0 = ilt0 < ilt1;
        }

        sw.Stop();
        ReportTiming($"{nameof(IntervalLimitType)} < other", sw.Elapsed);
    }

    static void CreateIntervalLimit()
    {
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _ = IntervalLimit<byte>.ClosedStart(1);
            var __ = IntervalLimit<byte>.ClosedEnd(10);
        }

        sw.Stop();
        ReportTiming($"{typeof(IntervalLimit<byte>).Name} ClosedStart and ClosedEnd creation", sw.Elapsed, 2);
    }

    static void CreateClosedInterval()
    {
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _ = Interval<byte>.Closed(1, 10);
        }

        sw.Stop();
        ReportTiming($"{typeof(Interval<byte>).Name}.Closed", sw.Elapsed);
    }

    static void CreateOpenInterval()
    {
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _ = Interval<byte>.Open(1, 10);
        }

        sw.Stop();
        ReportTiming($"{typeof(Interval<byte>).Name}.Open", sw.Elapsed);
    }

    static void CreateOpenClosedInterval()
    {
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _ = Interval<byte>.OpenClosed(1, 10);
        }

        sw.Stop();
        ReportTiming($"{typeof(Interval<byte>).Name}.OpenClosed", sw.Elapsed);
    }

    static void CreateClosedOpenInterval()
    {
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _ = Interval<byte>.ClosedOpen(1, 10);
        }

        sw.Stop();
        ReportTiming($"{typeof(Interval<byte>).Name}.ClosedOpen", sw.Elapsed);
    }

    static void CreateClosedUnboundedInterval()
    {
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _ = Interval<byte>.ClosedUnbounded(1);
        }

        sw.Stop();
        ReportTiming($"{typeof(Interval<byte>).Name}.ClosedUnbounded", sw.Elapsed);
    }

    static void CreateUnboundedClosedInterval()
    {
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _ = Interval<byte>.UnboundedClosed(1);
        }

        sw.Stop();
        ReportTiming($"{typeof(Interval<byte>).Name}.UnboundedClosed", sw.Elapsed);
    }

    static void CreateUnboundedInterval()
    {
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _ = Interval<byte>.Unbounded();
        }

        sw.Stop();
        ReportTiming($"{typeof(Interval<byte>).Name}.Unbounded", sw.Elapsed);
    }

    static void CopyClosedInterval()
    {
        var source = Interval<byte>.Closed(1, 10);
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _ = source;
        }

        sw.Stop();
        ReportTiming($"Copy {typeof(Interval<byte>).Name}", sw.Elapsed);
    }

    static void ClosedIntervalContainsValue()
    {
        var interval = Interval<byte>.Closed(1, 254);
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _ = interval.Contains(10);
        }

        sw.Stop();
        ReportTiming($"{typeof(Interval<byte>).Name}.Contains(value)", sw.Elapsed);
    }

    static void ClosedIntervalContainsAnotherInterval()
    {
        var interval = Interval<byte>.Closed(1, 254);
        var interval2 = Interval<byte>.Closed(2, 253);
        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < Repetition.Count; i++)
        {
            var _ = interval.Contains(interval2);
        }

        sw.Stop();
        ReportTiming($"{typeof(Interval<byte>).Name}.Contains(otherInterval)", sw.Elapsed);
    }

    static void ReportTiming(string name, TimeSpan elapsed, int operationsPerRepetition = 1)
    {
        OperationSpeed.Report(name, elapsed, Repetition.Count, operationsPerRepetition);
    }
}