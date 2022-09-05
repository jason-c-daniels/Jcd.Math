using System;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace Jcd.Math.Intervals;

/// <summary>
/// Represents a mathematical interval whose limits can be any 
/// pairing of Unbounded, Closed or Open.
/// </summary>
/// <typeparam name="T">The underlying data type for the interval.</typeparam>
public readonly struct Interval<T> : 
    IInterval<T>, 
    IEquatable<Interval<T>>
    where T : IComparable<T>, IEquatable<T>
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
    /// Indicates if this interval is the interval of all numbers.
    /// </summary>
    public bool ContainsAll => Start.IsUnbounded && End.IsUnbounded;
    
    /// <summary>
    ///  Indicates if the interval is empty:
    /// (0,0), (1,1) ...etc. are empty intervals.
    /// </summary>
    public bool IsEmpty =>    Start.HasLimitValue 
                           && End.HasLimitValue 
                           && Start.IsOpen 
                           && End.IsOpen 
                           && Start.Limit!.Equals(End.Limit!);
    
    /// <summary>
    /// Indicates if the interval is empty:
    /// [0,0], [1,1] ...etc. are single value intervals.
    /// </summary>
    public bool IsSingleValue => Start.IsClosed 
                           && End.IsClosed 
                           && Start.Limit!.Equals(End.Limit!);

    /// <summary>
    /// The empty interval
    /// </summary>
    public static readonly Interval<T> Empty = Create(default, default);

    /// <summary>
    /// The interval containing all values.
    /// </summary>
    public static readonly Interval<T> All = Unbounded();

    /// <summary>
    /// By default an uninitialized and invalid instance.
    /// </summary>
    public static Interval<T> Invalid;
    
    /// <summary>
    /// The start of the interval.
    /// </summary>
    public IntervalLimit<T> Start { get; }
    
    /// <summary>
    /// The end of the interval.
    /// </summary>
    public IntervalLimit<T> End { get; }

    #region factory methods
    
    /// <summary>
    /// Creates an interval from two limits.
    /// </summary>
    /// <remarks>
    /// Any limit type can be passed in. Their types are converted
    /// and all other attributes are preserved.
    /// </remarks>
    /// <param name="start">The starting limit for the interval</param>
    /// <param name="end">The end limit for the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> Create(IntervalLimit<T> start, IntervalLimit<T>  end)
    {
        if (start.CompareTo(end) > 0)
            throw new ArgumentOutOfRangeException(nameof(end), $"Detected start ({start}) > end ({end}). End must be >= start");
    
        return new Interval<T>(IntervalLimit<T>.MakeStart(start), IntervalLimit<T>.MakeEnd(end));
    }

    /// <summary>
    /// Creates an closed interval: [closedStart,closedEnd]
    /// (i.e. includes both closedStart and closedEnd)
    /// </summary>
    /// <param name="closedStart">The inclusive starting point of the interval</param>
    /// <param name="closedEnd">The inclusive openEnd point of the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> Closed(T closedStart, T closedEnd)
    {
        if (closedStart.CompareTo(closedEnd) > 0)
            throw new ArgumentOutOfRangeException(nameof(closedEnd), $"Detected start ({closedStart}) > end ({closedEnd}). End must be >= start");
        return new Interval<T>(IntervalLimit.ClosedStart(closedStart), IntervalLimit.ClosedEnd(closedEnd));
    }

    /// <summary>
    /// Creates an open interval: (openStart,openEnd)
    /// (i.e. excludes both openStart and openEnd)
    /// </summary>
    /// <param name="openStart">The exclusive starting point of the interval</param>
    /// <param name="openEnd">The exclusive openEnd point of the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> Open(T openStart, T openEnd)
    {
        if (openStart.CompareTo(openEnd) > 0)
            throw new ArgumentOutOfRangeException(nameof(openEnd),
                $"Detected start ({openStart}) > end ({openEnd}). End must be >= start");

        return new Interval<T>(IntervalLimit.OpenStart(openStart), IntervalLimit.OpenEnd(openEnd));
    }

    /// <summary>
    /// Creates an open-closed interval: (openStart,closedEnd]
    /// (i.e. excludes openStart and includes closedEnd)
    /// </summary>
    /// <param name="openStart">The exclusive starting point of the interval</param>
    /// <param name="closedEnd">The inclusive openEnd point of the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> OpenClosed(T openStart, T closedEnd)
    {
        if (openStart.CompareTo(closedEnd) > 0)
            throw new ArgumentOutOfRangeException(nameof(closedEnd),
                $"Detected start ({openStart}) > end ({closedEnd}). End must be >= start");

        return new Interval<T>(IntervalLimit.OpenStart(openStart), IntervalLimit.ClosedEnd(closedEnd));
    }

    /// <summary>
    /// Creates a closed-open interval: [openStart,closedEnd)
    /// (i.e. includes openStart and excludes closedEnd)
    /// </summary>
    /// <param name="closedStart">The inclusive starting point of the interval</param>
    /// <param name="openEnd">The exclusive openEnd point of the interval.</param>
    /// <returns>The new interval</returns>
    public static Interval<T> ClosedOpen(T closedStart, T openEnd)
    {
        if (closedStart.CompareTo(openEnd) > 0)
            throw new ArgumentOutOfRangeException(nameof(openEnd),
                $"Detected start ({closedStart}) > end ({openEnd}). End must be >= start");

        return new Interval<T>(IntervalLimit.ClosedStart(closedStart), IntervalLimit.OpenEnd(openEnd));
    }

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
        Start = start;
        End = end;
    }

    #endregion

    #region Implementation of IInterval<T>
    
    /// <summary>
    /// Determines if the interval contains the provided value.
    /// </summary>
    /// <param name="value">The value to check for inclusion in the interval.</param>
    /// <returns>True if the interval contains the value.</returns>
    public bool Contains(T value)
    {
        ThrowIfInvalid();
        return Start <= value && value <= End;
    }

    /// <summary>
    /// Determines if the interval contains the value represented by limit.
    /// (e.g. A left-unbounded interval will contain any discrete value less
    /// than or equal to the end of the interval.)
    /// </summary>
    /// <param name="limit">The limit to inspect.</param>
    /// <returns>True if the interval contains the limit.</returns>
    public bool Contains(IntervalLimit<T> limit)
    {
        ThrowIfInvalid();
        return Start <= limit && limit <= End;
    }

    private void ThrowIfInvalid()
    {
        if (!IsValid)
            throw new ArgumentOutOfRangeException(nameof(IsValid),
                $"\"this\" is a default, and therefore uninitialized, of {nameof(Interval<T>)}. Do not use default Interval instances.");
    }

    /// <summary>
    /// Returns true if this interval completely contains the provided interval.
    /// </summary>
    /// <param name="other">The interval being compared for containment within the current.</param>
    /// <returns>True if this interval contains both endpoints of `other`.</returns>
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

    /// <inheritdoc />
    public bool IntersectsWith(IInterval<T> other)
    {
         return Contains(other.Start) || Contains(other.End);
    }
    
    /// <summary>
    /// Determines if this interval completely contains another.
    /// </summary>
    /// <param name="other">The interval being compared for containment within the current.</param>
    /// <returns>True if this interval contains the other.</returns>
    public bool Contains(Interval<T> other)
    {
        ThrowIfInvalid();
        other.ThrowIfInvalid();
        return Start <= other.Start && End >= other.End;
    }
    #endregion
    
    #region Implementation of IEquatable<IInterval<T>>

    /// <inheritdoc />
    public bool Equals(IInterval<T> other)
    {
        ThrowIfInvalid();
        if (IsEmpty && other.IsEmpty) return true;
        return Start == other.Start && End == other.End;
    }

    #endregion

    #region Implementation of IEquatable<Interval<T>>

    /// <inheritdoc />
    public bool Equals(Interval<T> other)
    {
        ThrowIfInvalid();
        if (IsEmpty && other.IsEmpty) return true;
        return Start.Equals(other.Start) && End.Equals(other.End);
    }

    #endregion

    #region Equality members

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        ThrowIfInvalid();
        return obj is Interval<T> other && Equals(other);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        ThrowIfInvalid();
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

    #region Overrides of ValueType

    /// <inheritdoc />
    public override string ToString()
    {
        ThrowIfInvalid();
        return IsEmpty ? "{}" : $"{Start};{End}";
    }

    #endregion
}

/// <summary>
/// A helper class to simplify the notation for creating intervals.
/// </summary>
public static class Interval
{
    #region Factory methods
    
    /// <summary>
    /// Creates an interval from two limits.
    /// </summary>
    /// <param name="start">The starting limit of the interval</param>
    /// <param name="end">The end limit of the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> Create<T>(IntervalLimit<T> start, IntervalLimit<T>  end)
        where T : IComparable<T>, IEquatable<T>
    {
        return Interval<T>.Create(start,end);
    }    
    
    /// <summary>
    /// Creates an closed interval: [closedStart,closedEnd]
    /// (i.e. includes both closedStart and closedEnd)
    /// </summary>
    /// <param name="closedStart">the inclusive start to the interval</param>
    /// <param name="closedEnd">The inclusive end to the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> Closed<T>(T closedStart, T closedEnd)
        where T : IComparable<T>, IEquatable<T>
        =>  Interval<T>.Closed(closedStart,closedEnd);

    /// <summary>
    /// Creates an open interval: (openStart,openEnd)
    /// (i.e. excludes both openStart and openEnd)
    /// </summary>
    /// <param name="openStart">The exclusive start to the interval.</param>
    /// <param name="openEnd">The exclusive end to the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> Open<T>(T openStart, T openEnd)
        where T : IComparable<T>, IEquatable<T>
        =>  Interval<T>.Open(openStart,openEnd);

    /// <summary>
    /// Creates an open-closed interval: (openStart,closedEnd]
    /// (i.e. excludes openStart and includes closedEnd)
    /// </summary>
    /// <param name="openStart">The exclusive start to the interval.</param>
    /// <param name="closedEnd">The inclusive end to the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> OpenClosed<T>(T openStart, T closedEnd)
        where T : IComparable<T>, IEquatable<T>
        =>  Interval<T>.OpenClosed(openStart,closedEnd);

    /// <summary>
    /// Creates a closed-open interval: [closedStart,openEnd)
    /// (i.e. includes closedStart and excludes openEnd)
    /// </summary>
    /// <param name="closedStart">the inclusive start to the interval</param>
    /// <param name="openEnd">The exclusive end to the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> ClosedOpen<T>(T closedStart, T openEnd)
        where T : IComparable<T>, IEquatable<T>
        =>  Interval<T>.ClosedOpen(closedStart,openEnd);
    
    /// <summary>
    /// Creates a left-unbounded, right-open interval: (-infinity, openEnd)
    /// (i.e. -infinity to openEnd - excludes openEnd.)
    /// </summary>
    /// <param name="openEnd">The exclusive end to the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> UnboundedOpen<T>(T openEnd)
        where T : IComparable<T>, IEquatable<T>
        =>  Interval<T>.UnboundedOpen(openEnd);
    
    /// <summary>
    /// Creates a left-unbounded, right-closed interval: (-infinity, closedEnd]
    /// (i.e. -infinity to closedEnd - includes closedEnd.)
    /// </summary>
    /// <param name="closedEnd">The inclusive end to the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> UnboundedClosed<T>(T closedEnd)
        where T : IComparable<T>, IEquatable<T>
        =>  Interval<T>.UnboundedClosed(closedEnd);

    /// <summary>
    /// Creates a left-closed, right-unbounded interval: [closedStart, +infinity)
    /// (i.e. closedStart to +infinity - includes closedStart.)
    /// </summary>
    /// <param name="closedStart">the inclusive start to the interval</param>
    /// <returns>The new interval</returns>
    public static Interval<T> ClosedUnbounded<T>(T closedStart)
        where T : IComparable<T>, IEquatable<T>
        =>  Interval<T>.ClosedUnbounded(closedStart);

    /// <summary>
    /// Creates a left-open, right-unbounded interval: (openStart, +infinity)
    /// (i.e. openStart to +infinity - excludes openStart.)
    /// </summary>
    /// <param name="openStart">The exclusive start to the interval.</param>
    /// <returns>The new interval</returns>
    public static Interval<T> OpenUnbounded<T>(T openStart)
        where T : IComparable<T>, IEquatable<T>
        =>  Interval<T>.OpenUnbounded(openStart);

    /// <summary>
    /// Creates a completely unbounded interval. (-infinity, +infinity)
    /// (i.e. -infinity to +infinity - excluding the infinities, of course.)
    /// </summary>
    /// <returns>The new interval</returns>
    public static Interval<T> Unbounded<T>()
        where T : IComparable<T>, IEquatable<T>
        =>  Interval<T>.Unbounded();

    #endregion
    
    /// <summary>
    /// Creates the intersection of two intervals.
    /// </summary>
    /// <param name="first"></param>
    /// <param name="second"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static Interval<T> Intersect<T>(this Interval<T> first, Interval<T> second)
        where T : IComparable<T>, IEquatable<T>
    {
        if (first.ContainsAll) return Interval<T>.All;
        if (second.ContainsAll) return Interval<T>.All;
        if (!first.Contains(second.Start) && !first.Contains(second.End))
            return Interval<T>.Empty; // disjoint. Return the empty set.

        var start = first.Contains(second.Start)
            ? Compare.Max(first.Start, second.Start)
            : first.Start;
        
        var end  = first.Contains(second.End)
            ? Compare.Min(first.End, second.End)
            : first.End;
        
        return Create(start, end);
    }
}