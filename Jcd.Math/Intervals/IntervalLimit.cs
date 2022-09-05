using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// ReSharper disable UnassignedReadonlyField
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Math.Intervals;

/// <summary>
/// Defines a limit point in an interval. (i.e. starting point or ending point.) 
/// </summary>
/// <typeparam name="T">The data type for the interval using this limit.</typeparam>
/// <remarks>
/// For the purposes of this library:
///   * An Unbounded interval limit is both open and infinite. (HasLimitValue == false &amp;&amp; IsUnbounded == true &amp;&amp; IsOpen == true).
///   * An Open interval limit is a finite and open limit.  (i.e. HasLimitValue == true &amp;&amp; IsUnbounded == false &amp;&amp; IsOpen == true).
///   * A Closed interval limit is both closed and finite. (i.e. HasLimitValue == true &amp;&amp; IsUnbounded == false &amp;&amp; IsOpen == false).
///   * Start interval limits compare as less than or equal to End interval limits for the same non-infinite limit value, depending on the Closed-Open nature of the limits being compared.
///   * Start interval limits compare as less than End interval limits for infinite (Unbounded) limit values.
///   * Open-Start interval limits compare greater than Closed-Start interval limits.
///   * Open-End interval limits compare less than Closed-End interval limits.
///   * Unbounded-Start interval limits compare less than Open or Closed-Start interval limits.
///   * Unbounded-End interval limits compare greater than Open or Closed-End interval limits.
/// </remarks>
public readonly struct IntervalLimit<T> : 
        IComparable<IntervalLimit<T>>, 
        IComparable, 
        IEquatable<IntervalLimit<T>>,
        IComparable<T>,
        IEquatable<T>
    where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// The default IntervalLimit. This is equivalent to IntervalLimit&lt;T&gt;.UnboundedStart
    /// </summary>
    // ReSharper disable once UnassignedField.Global
    public static readonly IntervalLimit<T> Default;
    
    /// <summary>
    /// Unbounded (i.e. no limit), Open, Closed. 
    /// </summary>
    public IntervalLimitConstraint Constraint { get; }
    
    /// <summary>
    /// The limit value for the interval point, if applicable. (Unbounded = default(T), the value is ignored for comparisons.)
    /// </summary>
    public T? Limit { get; }
    
    /// <summary>
    /// The type of interval limit, Start or End. This dictates how comparisons happen.
    /// </summary>
    public IntervalLimitType LimitType { get; }

    /// <summary>
    /// Indicates if this interval limit is a start limit.
    /// When true and Unbounded is true the Limit value is treated as -infinity.
    /// </summary>
    public bool IsStart => LimitType.IsStart;
    
    /// <summary>
    /// Indicates if this interval limit is an interval end limit.
    /// When true and Unbounded is true the Limit value is treated as +infinity.
    /// </summary>
    public bool IsEnd => LimitType.IsEnd;
    
    /// <summary>
    /// Indicates if the limit is open. (Note: Unbounded is open at +/-infinity)
    /// </summary>
    public bool IsOpen => Constraint.IsOpen;
    
    /// <summary>
    /// Indicates if the limit is closed.
    /// </summary>
    public bool IsClosed => Constraint.IsClosed;
    
    /// <summary>
    /// Indicates if the limit is unbounded.
    /// </summary>
    public bool IsUnbounded => Constraint.IsUnbounded;

    /// <summary>
    /// Indicates if there is a discrete, non-infinite value for the limit.
    /// </summary>
    public bool HasLimitValue => Constraint.HasLimitValue;
    
    #region Constructor and Factory methods

    /// <summary>
    /// Construct an interval limit from a limit value, constraint and type. 
    /// </summary>
    /// <param name="limitType">The interval limit type.</param>
    /// <param name="constraint">The limit constraints.</param>
    /// <param name="limit">The limit value.</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    private IntervalLimit(IntervalLimitType limitType, 
                          IntervalLimitConstraint constraint, 
                          T? limit)
    {
        if (limit is null && constraint.HasLimitValue)
            throw new ArgumentOutOfRangeException(nameof(limit),
                "Limit constraint indicates a non-null limit value would be provided, yet null was provided. Please use a different constraint, or provide the limit value.");
        Constraint = constraint;
        LimitType = limitType;
        Limit = limit;
    }

    /// <summary>
    /// Creates an unbounded start interval limit.
    /// In other words: creates an exclusive infinite start limit.  
    /// For example: (-infinity,... 
    /// </summary>
    /// <returns>The new interval limit</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IntervalLimit<T> UnboundedStart() => UnboundedStartData;

    private static readonly IntervalLimit<T> UnboundedStartData =
        new(IntervalLimitType.Start, IntervalLimitConstraint.Unbounded, default(T?));

    /// <summary>
    /// Creates an unbounded end interval limit
    /// In other words: creates an exclusive infinite end limit.  
    /// For example: ...,+infinity) 
    /// </summary>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IntervalLimit<T> UnboundedEnd() => UnboundedEndData;
    private static readonly IntervalLimit<T> UnboundedEndData = 
        new (IntervalLimitType.End, IntervalLimitConstraint.Unbounded, default(T?));

    /// <summary>
    /// Creates an open-start interval limit.
    /// In other words: creates an exclusive start limit.  
    /// For example: (limit,... 
    /// </summary>
    /// <param name="limit">the limiting value.</param>
    /// <returns>The new interval limit.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IntervalLimit<T> OpenStart(T limit) =>
        new (IntervalLimitType.Start, IntervalLimitConstraint.Open, limit);

    /// <summary>
    /// Creates a closed start interval limit.
    /// In other words: creates an inclusive start limit.  
    /// For example: [limit,... 
    /// </summary>
    /// <param name="limit">the limiting value.</param>
    /// <returns>The new interval limit.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IntervalLimit<T> ClosedStart(T limit) =>
        new (IntervalLimitType.Start, IntervalLimitConstraint.Closed, limit);

    /// <summary>
    /// Creates an open end interval limit.
    /// In other words: creates an exclusive end limit.  
    /// For example: ...,limit) 
    /// </summary>
    /// <param name="limit">the limiting value.</param>
    /// <returns>The new interval limit.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IntervalLimit<T> OpenEnd(T limit) =>
        new (IntervalLimitType.End, IntervalLimitConstraint.Open, limit);

    /// <summary>
    /// Creates an open end interval limit.
    /// In other words: creates an inclusive end limit.  
    /// For example: ...,limit]
    /// </summary>
    /// <param name="limit">the limiting value.</param>
    /// <returns>The new interval limit.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IntervalLimit<T> ClosedEnd(T limit) =>
        new (IntervalLimitType.End, IntervalLimitConstraint.Closed, limit);
    
    #endregion
    
    #region Relational members

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int CompareTo(IntervalLimit<T> y)
    {
        // nomenclature:
        //     x = left hand side of the comparison.
        //     y = right hand side of the comparison.
        var x = this;
        
        // when dealing with both start constraints or both end constraints
        if (x.LimitType == y.LimitType)
        {
            // Unbounded on both means -infinity or +infinity for both, therefore they're the same limit point.
            if (x.IsUnbounded && y.IsUnbounded) return 0;
            
            // The left hand side has no limit and the right hand side has a limit.
            // When both are a start this is x = -infinity, therefore x < y.
            // conversely when it's an end limit, x = +infinity, therefore x > y.
            if (x.IsUnbounded && y.HasLimitValue)
                return y.LimitType == IntervalLimitType.Start ? -1 : 1;
            
            // The right hand side has no limit and the left hand side has a limit.
            // When both are a start this makes y = -infinity, therefore x > y.
            // conversely when it's an end limit, y = +infinity, therefore x < y.
            if (x.HasLimitValue && y.IsUnbounded) 
                return x.LimitType == IntervalLimitType.Start ? 1 : -1;
            
            // At this point, we know that both have a limit value.
            // So compare the limit values directly and cache the result.
            // Also, suppress possible null warning with "!". 
            var limitComparison = x.Limit!.CompareTo(y.Limit!);
            
            // When we have the same limit value check for differences in constraint. (Open vs Closed)
            if (limitComparison == 0 
                && x.Constraint != y.Constraint
                // We already know the following two commented out lines are true. Left here to keep the full logic in view.
                // && x.HasLimitValue  
                // && y.HasLimitValue 
                )
            {
                // For the same non-infinite limit value
                
                // A closed start is less than an open start.
                //    in other words [start,...) < (start,...)   
                // conversely a closed end is greater than an open end.
                //    in other words (...,end] > (...,end)
                if (x.IsClosed && y.IsOpen) 
                    return x.LimitType == IntervalLimitType.Start ? -1 : 1;
                
                // An open start is greater than a closed start.
                //    in other words (start,...) > [start,...)
                // conversely an open end is less than an closed end.
                //    in other words (...,end) < (...,end]
                if (x.IsOpen && y.IsClosed) 
                    return x.LimitType == IntervalLimitType.Start ? 1 : -1;
            }
            
            // The limit value comparison was not equal, return the computed result
            return limitComparison;
        }

        // if x is a start, we know y is an end.
        if (x.IsStart)
        {
            // compare actual limit values if both have them.
            // starts always come before ends.
            // Therefore:
            //      if x.Limit <= y.Limit : x < y
            //      otherwise x > y
            if (x.HasLimitValue && y.HasLimitValue)
            {
                var lc = x.Limit!.CompareTo(y.Limit!);
                if (lc <= 0) return -1; // if x.Limit <= y.Limit : x < y
                return 1; // otherwise x > y
            }
            
            // when x extends to -infinity. a discrete value for y will always be > -infinity.
            //    in other words, if (x.IsUnbounded && y.HasLimitValue) ... x < y
            //
            // when y extends to +infinity. a discrete value for x will always be < +infinity.
            //    in other words, if (x.HasLimitValue && y.IsUnbounded) ... x < y
            //
            // in both cases we find that x < y
            return -1;
        }

        // if x is an end, we know y is a start.
        if (x.IsEnd)
        {
            // compare actual limit values if both have them.
            // ends always come after starts.
            // Therefore:
            //      if x.Limit >= y.Limit : x > y
            //      otherwise x < y
            if (x.HasLimitValue && y.HasLimitValue)
            {
                var lc = x.Limit!.CompareTo(y.Limit!);
                if (lc >= 0) return 1; // if x.Limit >= y.Limit : x > y
                return -1; // otherwise x < y
            }
            
            // when x extends to +infinity. a discrete value for y will always be < +infinity.
            //    in other words, if (x.IsUnbounded && y.HasLimitValue) ... x > y
            // when y extends to -infinity. a discrete value for x will always be > -infinity.
            //    in other words, if (x.HasLimitValue && y.IsUnbounded) ... x > y
            // in both cases we find that x > y
            return 1;
        }
        
        // This is theoretically unreachable code.
        // But by default we'll just call starts less than ends just to cover our bases.
        return x.LimitType.CompareTo(y.LimitType);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        if (obj is T value) return CompareTo(value);
        return obj is IntervalLimit<T> other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(IntervalLimit<T>)}");
    }

    /// <summary>
    /// Determines if an interval limit is less than a specified value. 
    /// </summary>
    /// <param name="left">The interval limit to compare.</param>
    /// <param name="right">The value to compare</param>
    /// <returns>True if the interval limit is less than the specified value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <(IntervalLimit<T> left, T right)
    {
        return left.CompareTo(right) < 0;
    }

    /// <summary>
    /// Determines if an interval limit is greater than a specified value. 
    /// </summary>
    /// <param name="left">The interval limit to compare.</param>
    /// <param name="right">The value to compare</param>
    /// <returns>True if the interval limit is greater than the specified value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator >(IntervalLimit<T> left, T right)
    {
        return left.CompareTo(right) > 0;
    }

    /// <summary>
    /// Determines if an interval limit is less than or equal to a specified value. 
    /// </summary>
    /// <param name="left">The interval limit to compare.</param>
    /// <param name="right">The value to compare</param>
    /// <returns>True if the interval limit is less than or equal to the specified value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <=(IntervalLimit<T> left, T right)
    {
        return left.CompareTo(right) <= 0;
    }

    /// <summary>
    /// Determines if an interval limit is less greater or equal to a specified value. 
    /// </summary>
    /// <param name="left">The interval limit to compare.</param>
    /// <param name="right">The value to compare</param>
    /// <returns>True if the interval limit is greater than or equal to the specified value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator >=(IntervalLimit<T> left, T right)
    {
        return left.CompareTo(right) >= 0;
    }

    /// <summary>
    /// Determines if a specified value is less than an interval limit.
    /// </summary>
    /// <param name="left">the specified value.</param>
    /// <param name="right">The interval limit</param>
    /// <returns>True if the specified value is less than the interval limit</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <(T left, IntervalLimit<T> right)
    {
        return right.CompareTo(left) > 0;
    }

    /// <summary>
    /// Determines if a specified value is greater than an interval limit.
    /// </summary>
    /// <param name="left">the specified value.</param>
    /// <param name="right">The interval limit</param>
    /// <returns>True if the specified value is greater than the interval limit</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator >(T left, IntervalLimit<T> right)
    {
        return right.CompareTo(left) < 0;
    }

    /// <summary>
    /// Determines if a specified value is less than or equal to an interval limit.
    /// </summary>
    /// <param name="left">the specified value.</param>
    /// <param name="right">The interval limit</param>
    /// <returns>True if the specified value is less than or equal to the interval limit</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <=(T left, IntervalLimit<T> right)
    {
        return right.CompareTo(left) >= 0;
    }

    /// <summary>
    /// Determines if a specified value is greater than or equal to an interval limit.
    /// </summary>
    /// <param name="left">the specified value.</param>
    /// <param name="right">The interval limit</param>
    /// <returns>True if the specified value is greater than or equal to the interval limit</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator >=(T left, IntervalLimit<T> right)
    {
        return right.CompareTo(left) <= 0;
    }

    /// <summary>
    /// Determines if one interval limit is less than another.
    /// </summary>
    /// <param name="left">the left hand parameter</param>
    /// <param name="right">the right hand parameter</param>
    /// <returns>True if left is less than right</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <(IntervalLimit<T> left, IntervalLimit<T> right)
    {
        return left.CompareTo(right) < 0;
    }

    /// <summary>
    /// Determines if one interval limit is greater than another.
    /// </summary>
    /// <param name="left">the left hand parameter</param>
    /// <param name="right">the right hand parameter</param>
    /// <returns>True if left is greater than right</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator >(IntervalLimit<T> left, IntervalLimit<T> right)
    {
        return left.CompareTo(right) > 0;
    }

    /// <summary>
    /// Determines if one interval limit is less than or equal to another.
    /// </summary>
    /// <param name="left">the left hand parameter</param>
    /// <param name="right">the right hand parameter</param>
    /// <returns>True if left is less than or equal to right</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <=(IntervalLimit<T> left, IntervalLimit<T> right)
    {
        return left.CompareTo(right) <= 0;
    }

    /// <summary>
    /// Determines if one interval limit is greater than or equal to another.
    /// </summary>
    /// <param name="left">the left hand parameter</param>
    /// <param name="right">the right hand parameter</param>
    /// <returns>True if left is greater than or equal to right</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator >=(IntervalLimit<T> left, IntervalLimit<T> right)
    {
        return left.CompareTo(right) >= 0;
    }

    #endregion

    #region Equality members

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(IntervalLimit<T> other)
    {
        return Constraint.Equals(other.Constraint) && EqualityComparer<T?>.Default.Equals(Limit, other.Limit) && LimitType == other.LimitType;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int CompareTo(T value)
    {
        if (Constraint.IsUnbounded)
        {
            if (IsStart) return -1; // the limit is < the value.
            
            // since IsStart == false, we know IsEnd == true 
            return 1; // the limit is > the value.
        }

        var limitComparison = Limit!.CompareTo(value);
        if (Constraint.IsOpen /* && HasLimitValue*/)
        {
            if (LimitType == IntervalLimitType.Start && limitComparison == 0) return 1; // value is at the exact start limit, limit > value.
            if (LimitType == IntervalLimitType.End && limitComparison == 0) return -1; // value is at the exact end limit, limit < value.
            return limitComparison;
        }
        
        // when comparing against a closed limit,
        // no adjustment to the underlying comparison is needed.
        return limitComparison;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(T other)
    {
        return CompareTo(other) == 0;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override bool Equals(object? obj)
    {
        return obj is IntervalLimit<T> other && Equals(other);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = Constraint.GetHashCode();
            if (Constraint.HasLimitValue) hashCode = (hashCode * 397) ^ Limit!.GetHashCode();
            hashCode = (hashCode * 397) ^ (int)LimitType;
            return hashCode;
        }
    }

    /// <summary>
    /// Equivalence operator.
    /// </summary>
    /// <param name="left">The left hand parameter</param>
    /// <param name="right">The right hand parameter</param>
    /// <returns>True if equivalent.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(IntervalLimit<T> left, IntervalLimit<T> right)
    {
        return left.Equals(right);
    }

    /// <summary>
    /// Non=equivalence operator.
    /// </summary>
    /// <param name="left">The left hand parameter</param>
    /// <param name="right">The right hand parameter</param>
    /// <returns>True if not equivalent.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(IntervalLimit<T> left, IntervalLimit<T> right)
    {
        return !left.Equals(right);
    }

    /// <summary>
    /// Equivalence operator.
    /// </summary>
    /// <param name="left">The left hand parameter</param>
    /// <param name="right">The right hand parameter</param>
    /// <returns>True if equivalent.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(IntervalLimit<T> left, T right)
    {
        return left.Equals(right);
    }

    /// <summary>
    /// Non=equivalence operator.
    /// </summary>
    /// <param name="left">The left hand parameter</param>
    /// <param name="right">The right hand parameter</param>
    /// <returns>True if not equivalent.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(IntervalLimit<T> left, T right)
    {
        return !left.Equals(right);
    }

    /// <summary>
    /// Equivalence operator.
    /// </summary>
    /// <param name="left">The left hand parameter</param>
    /// <param name="right">The right hand parameter</param>
    /// <returns>True if equivalent.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(T left, IntervalLimit<T> right)
    {
        return right.Equals(left);
    }

    /// <summary>
    /// Non=equivalence operator.
    /// </summary>
    /// <param name="left">The left hand parameter</param>
    /// <param name="right">The right hand parameter</param>
    /// <returns>True if not equivalent.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(T left, IntervalLimit<T> right)
    {
        return !right.Equals(left);
    }

    #endregion
    
    #region conversion operator

    /// <summary>
    /// Converts to the underlying value type.
    /// </summary>
    /// <param name="limit">The limit to convert.</param>
    /// <returns>The underlying value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator T?(IntervalLimit<T> limit) => limit.Limit;

    #endregion

    #region Overrides of ValueType

    /// <inheritdoc />
    public override string ToString()
    {
        if (LimitType == IntervalLimitType.Start)
        {
            if (Constraint.IsUnbounded) return "(-infinity";
            if (Constraint.IsOpen) return $"({Limit}";
            
            // We know IsClosed == true 
            return $"[{Limit}";
        }
        
        if (Constraint.IsUnbounded) return "+infinity)";
        if (Constraint.IsOpen) return $"{Limit})";
            
        // We know IsClosed == true 
        return $"{Limit}]";
    }

    #endregion

    /// <summary>
    /// Ensures that an interval limit is a start limit by examining properties
    /// and, if necessary returning a new instance. Boundedness, Openness and
    /// Limit value are all retained.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <typeparam name="T">The underlying data type.</typeparam>
    /// <returns>A start limit</returns>
    public static IntervalLimit<T> MakeStart(IntervalLimit<T> value)
    {
        if (value.IsStart) return value;
        if (value.IsUnbounded) return IntervalLimit<T>.UnboundedStart();
        return value.IsOpen
            ? OpenStart(value.Limit!)
            : ClosedStart(value.Limit!);
    }

    /// <summary>
    /// Ensures that an interval limit is a end limit by examining properties
    /// and, if necessary returning a new instance. Boundedness, Openness and
    /// Limit value are all retained.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <typeparam name="T">The underlying data type.</typeparam>
    /// <returns>An end limit</returns>
    public static IntervalLimit<T> MakeEnd(IntervalLimit<T> value) 
    {
        if (value.IsEnd) return value;
        if (value.IsUnbounded) return UnboundedEnd();
        return value.IsOpen
            ? OpenEnd(value.Limit!)
            : ClosedEnd(value.Limit!);
    }
}

/// <summary>
/// Helper class to simplify the notation when creating an interval limit.
/// </summary>
public static class IntervalLimit
{
    /// <summary>
    /// Creates an unbounded start interval limit.
    /// In other words: creates an exclusive infinite start limit.  
    /// For example: (-infinity,... 
    /// </summary>
    /// <returns>The new interval limit</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IntervalLimit<T> UnboundedStart<T>()
        where T: IComparable<T>, IEquatable<T>
        => IntervalLimit<T>.UnboundedStart();

    /// <summary>
    /// Creates an unbounded end interval limit.
    /// In other words: creates an exclusive infinite end limit.  
    /// For example: ...,+infinity) 
    /// </summary>
    /// <returns>The new interval limit</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IntervalLimit<T> UnboundedEnd<T>()
        where T: IComparable<T>, IEquatable<T>
        => IntervalLimit<T>.UnboundedEnd();

    /// <summary>
    /// Creates an open start interval limit.
    /// In other words: creates an exclusive start limit.  
    /// For example: (limit,... 
    /// </summary>
    /// <returns>The new interval limit</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IntervalLimit<T> OpenStart<T>(T limit)
        where T : IComparable<T>, IEquatable<T>
        => IntervalLimit<T>.OpenStart(limit);

    /// <summary>
    /// Creates a closed start interval limit.
    /// In other words: creates an inclusive start limit.  
    /// For example: [limit,... 
    /// </summary>
    /// <returns>The new interval limit</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IntervalLimit<T> ClosedStart<T>(T limit)
        where T : IComparable<T>, IEquatable<T>
        => IntervalLimit<T>.ClosedStart(limit);
    
    /// <summary>
    /// Creates an open end interval limit.
    /// In other words: creates an exclusive end limit.  
    /// For example: ...,limit) 
    /// </summary>
    /// <returns>The new interval limit</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IntervalLimit<T> OpenEnd<T>(T limit)
        where T : IComparable<T>, IEquatable<T>
        => IntervalLimit<T>.OpenEnd(limit);

    /// <summary>
    /// Creates a closed end interval limit.
    /// In other words: creates an inclusive end limit.  
    /// For example: ...,limit] 
    /// </summary>
    /// <returns>The new interval limit</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static IntervalLimit<T> ClosedEnd<T>(T limit)
        where T : IComparable<T>, IEquatable<T>
        => IntervalLimit<T>.ClosedEnd(limit);   
}
