using System;

namespace Jcd.Math.Intervals;

/// <summary>
/// Defines the operations and properties needed to create an interval.
/// </summary>
/// <typeparam name="T">The underlying data type for the interval.</typeparam>
public interface IInterval<T> : IEquatable<IInterval<T>> 
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
    bool IsValid { get; }

    /// <summary>
    ///  Indicates if the interval is empty:
    /// (0,0), (1,1) ...etc. are empty intervals.
    /// </summary>
    bool IsEmpty { get; }

    /// <summary>
    /// Indicates if the interval is empty:
    /// [0,0], [1,1] ...etc. are single value intervals.
    /// </summary>
    bool IsSingleValue { get; }

    /// <summary>
    /// The start of the interval.
    /// </summary>
    IntervalLimit<T> Start { get; }

    /// <summary>
    /// The end of the interval.
    /// </summary>
    IntervalLimit<T> End { get; }

    /// <summary>
    /// Determines if the interval contains the provided point.
    /// </summary>
    /// <param name="value">The point to compare</param>
    /// <returns>True if the interval contains the point.</returns>
    bool Contains(T value);
    
    /// <summary>
    /// Determines if the interval contains the provided limit.
    /// </summary>
    /// <param name="limit">The limit to inspect.</param>
    /// <returns>True if the interval contains the limit.</returns>
    bool Contains(IntervalLimit<T> limit);

    /// <summary>
    /// Determines if this interval completely contains another.
    /// </summary>
    /// <param name="other">The interval being compared for containment within the current.</param>
    /// <returns>True if this interval contains the other.</returns>
    bool Contains(IInterval<T> other);
    
    /// <summary>
    /// Determines if the current interval contains any values
    /// in common with another interval.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    bool IntersectsWith(IInterval<T> other);
}