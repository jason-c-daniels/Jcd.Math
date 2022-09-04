using System;
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace Jcd.Math.Intervals;

/// <summary>
/// A specialization of Interval that represents a closed interval [start,end]
/// (i.e. an interval that contains the start and end points)
/// </summary>
/// <typeparam name="T">The underlying data type.</typeparam>
public readonly struct Range<T> : IInterval<T>, IEquatable<Range<T>>
    where T: IComparable<T>
{
    #region Implementation of IInterval<T>

    /// <inheritdoc />
    public bool IsValid => Start.LimitType == IntervalLimitType.Start
                           && End.LimitType == IntervalLimitType.End
                           ;

    /// <inheritdoc />
    public bool IsEmpty => false;

    /// <inheritdoc />
    public bool IsSingleValue => Start.Limit!.CompareTo(End.Limit!) == 0;

    /// <inheritdoc />
    public IntervalLimit<T> Start { get; }

    /// <inheritdoc />
    public IntervalLimit<T> End { get; }

    /// <inheritdoc />
    public bool Contains(T point)
    {
        return Start <= point && point <= End;
    }
    
    /// <summary>
    /// Determines if this range completely contains an interval.
    /// </summary>
    /// <param name="other">The interval being compared for containment within the current.</param>
    /// <returns>True if this range contains the interval.</returns>
    public bool Contains(IInterval<T> other)
    {
        //return Start <= other.Start && End >= other.End;
        return Start.Limit!.CompareTo(other.Start.Limit!) <= 0
               && End.Limit!.CompareTo(other.End.Limit!) >= 0;
    }
    
    /// <summary>
    /// Determines if this range completely contains another.
    /// </summary>
    /// <param name="other">The interval being compared for containment within the current.</param>
    /// <returns>True if this interval contains the other.</returns>
    public bool Contains(Range<T> other)
    {
        //return Start <= other.Start && End >= other.End;
        return Start.Limit!.CompareTo(other.Start.Limit!) <= 0
               && End.Limit!.CompareTo(other.End.Limit!) >= 0;
    }

    /// <summary>
    /// Create a new range from a start and end
    /// </summary>
    /// <param name="start">The start of the range.</param>
    /// <param name="end">The end of the range.</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Range(T start, T end)
    {
        if (start.CompareTo(end) > 0)
            throw new ArgumentOutOfRangeException(nameof(start),
                $"Detected start ({start}) > end ({end}). start must be <= end");
        Start = IntervalLimit<T>.ClosedStart(start);
        End = IntervalLimit<T>.ClosedEnd(end);
    }
    
    #endregion
    
    #region Implementation of IEquatable<IInterval<T>>

    /// <inheritdoc />
    public bool Equals(IInterval<T> other)
    {
        //return Start == other.Start && End == other.End;
        return    Start.Limit!.CompareTo(other.Start.Limit!) == 0
               && End.Limit!.CompareTo(other.End.Limit!) == 0;
    }

    #endregion

    #region Implementation of IEquatable<Range<T>>

    /// <inheritdoc />
    public bool Equals(Range<T> other)
    {
        return    Start.Limit!.CompareTo(other.Start.Limit!) == 0
                  && End.Limit!.CompareTo(other.End.Limit!) == 0;
    }

    #endregion
}