using System;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Math.Intervals;

/// <summary>
/// Represents a mathematical interval whose limits can be any valid
/// combination of Unbounded, Closed or Open.
/// </summary>
/// <typeparam name="T">The underlying data type for the interval.</typeparam>
public readonly struct Interval<T> : IInterval<T>
    where T : IComparable<T>
{
    /// <summary>
    /// Indicates if the interval was properly constructed.
    /// </summary>
    /// <remarks>
    /// The only way for this to be false is by using an
    /// uninitialized instance. Sadly, structs zero out all
    /// fields and properties in an uninitialized instance.
    /// (This is a .Net standard 2.0 assembly after all)
    /// </remarks> 
    public bool IsValid => Start.IsStart && End.IsEnd;

    /// <summary>
    ///  Indicates if the interval is empty:
    /// (0,0), (1,1) ...etc. are empty intervals.
    /// </summary>
    public bool IsEmpty => Start.HasLimitValue 
                           && End.HasLimitValue 
                           && Start.IsOpen && End.IsOpen 
                           && Start.Limit!.CompareTo(End.Limit!)==0;
    
    /// <summary>
    /// Indicates if the interval is empty:
    /// [0,0], [1,1] ...etc. are single value intervals.
    /// </summary>
    public bool IsSingleValue => Start.HasLimitValue 
                           && End.HasLimitValue 
                           && Start.IsClosed && End.IsClosed 
                           && Start.Limit!.CompareTo(End.Limit!)==0;

    /// <summary>
    /// By default an uninitialized 
    /// </summary>
    public static Interval<T> Invalid;
    
    /// <summary>
    /// The start of the interval.
    /// </summary>
    public IntervalLimit<T> Start { get; }
    
    #region factory methods
    
    /// <summary>
    /// The end of the interval.
    /// </summary>
    public IntervalLimit<T> End { get; }

    /// <summary>
    /// Creates an closed interval: [start,end]
    /// (i.e. includes both start and end)
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> Closed(T start, T end)
        => new (IntervalLimit.ClosedStart(start), IntervalLimit.ClosedEnd(end));

    /// <summary>
    /// Creates an open interval: (start,end)
    /// (i.e. excludes both start and end)
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> Open(T start, T end)
        => new (IntervalLimit.OpenStart(start), IntervalLimit.OpenEnd(end));

    /// <summary>
    /// Creates an open-closed interval: (start,end]
    /// (i.e. excludes start and includes end)
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> OpenClosed(T start, T end)
        => new (IntervalLimit.OpenStart(start), IntervalLimit.ClosedEnd(end));


    /// <summary>
    /// Creates a closed-open interval: [start,end)
    /// (i.e. includes start and excludes end)
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> ClosedOpen(T start, T end)
        => new (IntervalLimit.ClosedStart(start), IntervalLimit.OpenEnd(end));


    /// <summary>
    /// Creates a left-unbounded, right-open interval: (-infinity, end)
    /// (i.e. -infinity to end - excludes end.)
    /// </summary>
    /// <param name="end"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> UnboundedOpen(T end)
        => new (IntervalLimit.UnboundedStart<T>(), IntervalLimit.OpenEnd(end));


    /// <summary>
    /// Creates a left-unbounded, right-closed interval: (-infinity, end]
    /// (i.e. -infinity to end - includes end.)
    /// </summary>
    /// <param name="end"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> UnboundedClosed(T end)
        => new (IntervalLimit.UnboundedStart<T>(), IntervalLimit.ClosedEnd(end));


    /// <summary>
    /// Creates a left-closed, right-unbounded interval: [start, +infinity)
    /// (i.e. start to +infinity - includes start.)
    /// </summary>
    /// <param name="start"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> ClosedUnbounded(T start)
        => new (IntervalLimit.ClosedStart(start), IntervalLimit.UnboundedEnd<T>());


    /// <summary>
    /// Creates a left-open, right-unbounded interval: (start, +infinity)
    /// (i.e. start to +infinity - excludes start.)
    /// </summary>
    /// <param name="start"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> OpenUnbounded(T start)
        => new (IntervalLimit.OpenStart(start), IntervalLimit.UnboundedEnd<T>());

    /// <summary>
    /// Creates a completely unbounded interval. (-infinity, +infinity)
    /// (i.e. -infinity to +infinity - excluding the infinities, of course.)
    /// </summary>
    /// <returns></returns>
    public static Interval<T> Unbounded()
        => new (IntervalLimit.UnboundedStart<T>(), IntervalLimit.UnboundedEnd<T>());
    
    private Interval(IntervalLimit<T> start, IntervalLimit<T> end)
    {
        if (!start.IsStart)
            throw new ArgumentOutOfRangeException(nameof(start), "End provided for interval start.");
        
        if (!end.IsEnd)
            throw new ArgumentOutOfRangeException(nameof(end), "Start provided for interval end.");
        
        if (start.CompareTo(end) > 0)
            throw new ArgumentOutOfRangeException(nameof(end), $"Detected start ({start}) > end ({end}). end must be >= start");
        
        Start = start;
        End = end;
    }

    #endregion

    #region Implementation of IInterval<T>
    
    /// <summary>
    /// Determines if the interval contains the provided point.
    /// </summary>
    /// <param name="point">The point to compare</param>
    /// <returns>True if the interval contains the point.</returns>
    public bool Contains(T point)
    {
        return Start <= point && point <= End;
    }

    /// <summary>
    /// Determines if this interval completely contains another.
    /// </summary>
    /// <param name="other">The interval being compared for containment within the current.</param>
    /// <returns>True if this interval contains the other.</returns>
    public bool Contains(IInterval<T> other)
    {
        return Start <= other.Start && End >= other.End;
    }

    #endregion
    
    #region Implementation of IEquatable<IInterval<T>>

    /// <inheritdoc />
    public bool Equals(IInterval<T> other)
    {
        return Start == other.Start && End == other.End;
    }

    #endregion
}

/// <summary>
/// A helper class to simplify the notation for creating intervals.
/// </summary>
public static class Interval
{
    /// <summary>
    /// Creates an closed interval: [start,end]
    /// (i.e. includes both start and end)
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> Closed<T>(T start, T end)
        where T :IComparable<T>
        =>  Interval<T>.Closed(start,end);

    /// <summary>
    /// Creates an open interval: (start,end)
    /// (i.e. excludes both start and end)
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> Open<T>(T start, T end)
        where T :IComparable<T>
        =>  Interval<T>.Open(start,end);

    /// <summary>
    /// Creates an open-closed interval: (start,end]
    /// (i.e. excludes start and includes end)
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> OpenClosed<T>(T start, T end)
        where T :IComparable<T>
        =>  Interval<T>.OpenClosed(start,end);

    /// <summary>
    /// Creates a closed-open interval: [start,end)
    /// (i.e. includes start and excludes end)
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> ClosedOpen<T>(T start, T end)
        where T :IComparable<T>
        =>  Interval<T>.ClosedOpen(start,end);
    
    /// <summary>
    /// Creates a left-unbounded, right-open interval: (-infinity, end)
    /// (i.e. -infinity to end - excludes end.)
    /// </summary>
    /// <param name="end"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> UnboundedOpen<T>(T end)
        where T :IComparable<T>
        =>  Interval<T>.UnboundedOpen(end);
    
    /// <summary>
    /// Creates a left-unbounded, right-closed interval: (-infinity, end]
    /// (i.e. -infinity to end - includes end.)
    /// </summary>
    /// <param name="end"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> UnboundedClosed<T>(T end)
        where T :IComparable<T>
        =>  Interval<T>.UnboundedClosed(end);

    /// <summary>
    /// Creates a left-closed, right-unbounded interval: [start, +infinity)
    /// (i.e. start to +infinity - includes start.)
    /// </summary>
    /// <param name="start"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> ClosedUnbounded<T>(T start)
        where T :IComparable<T>
        =>  Interval<T>.ClosedUnbounded(start);

    /// <summary>
    /// Creates a left-open, right-unbounded interval: (start, +infinity)
    /// (i.e. start to +infinity - excludes start.)
    /// </summary>
    /// <param name="start"></param>
    /// <returns>The new interval</returns>
    public static Interval<T> OpenUnbounded<T>(T start)
        where T :IComparable<T>
        =>  Interval<T>.OpenUnbounded(start);

    /// <summary>
    /// Creates a completely unbounded interval. (-infinity, +infinity)
    /// (i.e. -infinity to +infinity - excluding the infinities, of course.)
    /// </summary>
    /// <returns>The new interval</returns>
    public static Interval<T> Unbounded<T>()
        where T :IComparable<T>
        =>  Interval<T>.Unbounded();
}