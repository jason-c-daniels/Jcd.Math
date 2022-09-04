using System;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Math.Intervals;

/// <summary>
/// Represents a mathematical interval whose limits can be any valid
/// combination of Unbounded, Closed or Open.
/// </summary>
/// <typeparam name="T">The underlying data type for the interval.</typeparam>
public readonly struct Interval<T> : 
    IInterval<T>, 
    IEquatable<Interval<T>>
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
    /// The openStart of the interval.
    /// </summary>
    public IntervalLimit<T> Start { get; }
    
    #region factory methods
    
    /// <summary>
    /// The closedEnd of the interval.
    /// </summary>
    public IntervalLimit<T> End { get; }

    /// <summary>
    /// Creates an closed interval: [closedStart,closedEnd]
    /// (i.e. includes both closedStart and closedEnd)
    /// </summary>
    /// <param name="closedStart">The inclusive starting point of the interval</param>
    /// <param name="closedEnd">The inclusive openEnd point of the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> Closed(T closedStart, T closedEnd)
        => new (IntervalLimit.ClosedStart(closedStart), IntervalLimit.ClosedEnd(closedEnd));

    /// <summary>
    /// Creates an open interval: (openStart,openEnd)
    /// (i.e. excludes both openStart and openEnd)
    /// </summary>
    /// <param name="openStart">The exclusive starting point of the interval</param>
    /// <param name="openEnd">The exclusive openEnd point of the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> Open(T openStart, T openEnd)
        => new (IntervalLimit.OpenStart(openStart), IntervalLimit.OpenEnd(openEnd));

    /// <summary>
    /// Creates an open-closed interval: (openStart,closedEnd]
    /// (i.e. excludes openStart and includes closedEnd)
    /// </summary>
    /// <param name="openStart">The exclusive starting point of the interval</param>
    /// <param name="closedEnd">The inclusive openEnd point of the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> OpenClosed(T openStart, T closedEnd)
        => new (IntervalLimit.OpenStart(openStart), IntervalLimit.ClosedEnd(closedEnd));


    /// <summary>
    /// Creates a closed-open interval: [openStart,closedEnd)
    /// (i.e. includes openStart and excludes closedEnd)
    /// </summary>
    /// <param name="closedStart">The inclusive starting point of the interval</param>
    /// <param name="openEnd">The exclusive openEnd point of the interval.</param>
    /// <returns>The new interval</returns>
    public static Interval<T> ClosedOpen(T closedStart, T openEnd)
        => new (IntervalLimit.ClosedStart(closedStart), IntervalLimit.OpenEnd(openEnd));


    /// <summary>
    /// Creates a left-unbounded, right-open interval: (-infinity, openEnd)
    /// (i.e. -infinity to openEnd - excludes openEnd.)
    /// </summary>
    /// <param name="openEnd">The exclusive end point of the interval.</param>
    /// <returns>The new interval</returns>
    public static Interval<T> UnboundedOpen(T openEnd)
        => new (IntervalLimit.UnboundedStart<T>(), IntervalLimit.OpenEnd(openEnd));


    /// <summary>
    /// Creates a left-unbounded, right-closed interval: (-infinity, closedEnd]
    /// (i.e. -infinity to closedEnd - includes closedEnd.)
    /// </summary>
    /// <param name="closedEnd">The inclusive end point of the interval.</param>
    /// <returns>The new interval</returns>
    public static Interval<T> UnboundedClosed(T closedEnd)
        => new (IntervalLimit.UnboundedStart<T>(), IntervalLimit.ClosedEnd(closedEnd));


    /// <summary>
    /// Creates a left-closed, right-unbounded interval: [closedStart, +infinity)
    /// (i.e. openStart to +infinity - includes openStart.)
    /// </summary>
    /// <param name="closedStart">The inclusive openStart point of the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> ClosedUnbounded(T closedStart)
        => new (IntervalLimit.ClosedStart(closedStart), IntervalLimit.UnboundedEnd<T>());


    /// <summary>
    /// Creates a left-open, right-unbounded interval: (openStart, +infinity)
    /// (i.e. openStart to +infinity - excludes openStart.)
    /// </summary>
    /// <param name="openStart">the exclusive start to the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> OpenUnbounded(T openStart)
        => new (IntervalLimit.OpenStart(openStart), IntervalLimit.UnboundedEnd<T>());

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
            throw new ArgumentOutOfRangeException(nameof(start), "End provided for interval openStart.");
        
        if (!end.IsEnd)
            throw new ArgumentOutOfRangeException(nameof(end), "Start provided for interval closedEnd.");
        
        if (start.CompareTo(end) > 0)
            throw new ArgumentOutOfRangeException(nameof(end), $"Detected openStart ({start}) > closedEnd ({end}). closedEnd must be >= openStart");
        
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
        if (!IsValid)
            throw new ArgumentOutOfRangeException(nameof(IsValid),
                $"\"this\" is a default, and therefore uninitialized, of {nameof(Interval<T>)}. Do not use default Interval instances.");

        if (!other.IsValid)
            throw new ArgumentOutOfRangeException(nameof(other.IsValid),
                $"other.IsValid is false. It's likely a default instance of {other.GetType().Name}. Do not use default interval instances.");
        
        return Start <= other.Start && End >= other.End;
    }

    /// <summary>
    /// Determines if this interval completely contains another.
    /// </summary>
    /// <param name="other">The interval being compared for containment within the current.</param>
    /// <returns>True if this interval contains the other.</returns>
    public bool Contains(Interval<T> other)
    {
        if (!IsValid)
            throw new ArgumentOutOfRangeException(nameof(IsValid),
                $"\"this\" is a default, and therefore uninitialized, of {nameof(Interval<T>)}. Do not use default Interval instances.");

        if (!other.IsValid)
            throw new ArgumentOutOfRangeException(nameof(other.IsValid),
                $"other.IsValid is false. It's likely a default instance of {other.GetType().Name}. Do not use default interval instances.");
        
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

    #region Implementation of IEquatable<Interval<T>>

    /// <inheritdoc />
    public bool Equals(Interval<T> other)
    {
        return Start.Equals(other.Start) && End.Equals(other.End);
    }

    #endregion

    #region Equality members

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        return obj is Interval<T> other && Equals(other);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return HashCode.Combine(Start, End);
    }

    /// <summary>
    /// Performs equivalence comparisons between two intervals.
    /// </summary>
    /// <param name="left">The left hand parameter</param>
    /// <param name="right">The right hand parameter</param>
    /// <returns>True if they're equivalent.</returns>
    public static bool operator ==(Interval<T> left, Interval<T> right)
    {
        return left.Equals(right);
    }

    /// <summary>
    /// Performs non-equivalence comparison between two intervals.
    /// </summary>
    /// <param name="left">The left hand parameter</param>
    /// <param name="right">The right hand parameter</param>
    /// <returns>True if they're not equivalent.</returns>
    public static bool operator !=(Interval<T> left, Interval<T> right)
    {
        return !left.Equals(right);
    }

    #endregion
}

/// <summary>
/// A helper class to simplify the notation for creating intervals.
/// </summary>
public static class Interval
{
    /// <summary>
    /// Creates an closed interval: [closedStart,closedEnd]
    /// (i.e. includes both closedStart and closedEnd)
    /// </summary>
    /// <param name="closedStart">the inclusive start to the interval</param>
    /// <param name="closedEnd">The inclusive end to the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> Closed<T>(T closedStart, T closedEnd)
        where T :IComparable<T>
        =>  Interval<T>.Closed(closedStart,closedEnd);

    /// <summary>
    /// Creates an open interval: (openStart,openEnd)
    /// (i.e. excludes both openStart and openEnd)
    /// </summary>
    /// <param name="openStart">The exclusive start to the interval.</param>
    /// <param name="openEnd">The exclusive end to the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> Open<T>(T openStart, T openEnd)
        where T :IComparable<T>
        =>  Interval<T>.Open(openStart,openEnd);

    /// <summary>
    /// Creates an open-closed interval: (openStart,closedEnd]
    /// (i.e. excludes openStart and includes closedEnd)
    /// </summary>
    /// <param name="openStart">The exclusive start to the interval.</param>
    /// <param name="closedEnd">The inclusive end to the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> OpenClosed<T>(T openStart, T closedEnd)
        where T :IComparable<T>
        =>  Interval<T>.OpenClosed(openStart,closedEnd);

    /// <summary>
    /// Creates a closed-open interval: [closedStart,openEnd)
    /// (i.e. includes closedStart and excludes openEnd)
    /// </summary>
    /// <param name="closedStart">the inclusive start to the interval</param>
    /// <param name="openEnd">The exclusive end to the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> ClosedOpen<T>(T closedStart, T openEnd)
        where T :IComparable<T>
        =>  Interval<T>.ClosedOpen(closedStart,openEnd);
    
    /// <summary>
    /// Creates a left-unbounded, right-open interval: (-infinity, openEnd)
    /// (i.e. -infinity to openEnd - excludes openEnd.)
    /// </summary>
    /// <param name="openEnd">The exclusive end to the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> UnboundedOpen<T>(T openEnd)
        where T :IComparable<T>
        =>  Interval<T>.UnboundedOpen(openEnd);
    
    /// <summary>
    /// Creates a left-unbounded, right-closed interval: (-infinity, closedEnd]
    /// (i.e. -infinity to closedEnd - includes closedEnd.)
    /// </summary>
    /// <param name="closedEnd">The inclusive end to the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> UnboundedClosed<T>(T closedEnd)
        where T :IComparable<T>
        =>  Interval<T>.UnboundedClosed(closedEnd);

    /// <summary>
    /// Creates a left-closed, right-unbounded interval: [closedStart, +infinity)
    /// (i.e. closedStart to +infinity - includes closedStart.)
    /// </summary>
    /// <param name="closedStart">the inclusive start to the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> ClosedUnbounded<T>(T closedStart)
        where T :IComparable<T>
        =>  Interval<T>.ClosedUnbounded(closedStart);

    /// <summary>
    /// Creates a left-open, right-unbounded interval: (openStart, +infinity)
    /// (i.e. openStart to +infinity - excludes openStart.)
    /// </summary>
    /// <param name="openStart">The exclusive start to the interval.</param>
    /// <returns>The new interval</returns>
    public static Interval<T> OpenUnbounded<T>(T openStart)
        where T :IComparable<T>
        =>  Interval<T>.OpenUnbounded(openStart);

    /// <summary>
    /// Creates a completely unbounded interval. (-infinity, +infinity)
    /// (i.e. -infinity to +infinity - excluding the infinities, of course.)
    /// </summary>
    /// <returns>The new interval</returns>
    public static Interval<T> Unbounded<T>()
        where T :IComparable<T>
        =>  Interval<T>.Unbounded();
}