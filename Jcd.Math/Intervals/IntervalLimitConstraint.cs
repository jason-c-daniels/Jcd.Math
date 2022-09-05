using System;

namespace Jcd.Math.Intervals;

/// <summary>
/// Describes how an endpoint in an interval is to be handled (Open with limit?
/// Fully open? Closed on the limit?)
/// </summary>
public readonly struct IntervalLimitConstraint : IEquatable<IntervalLimitConstraint>
{
    /// <summary>
    /// The endpoint in question has no limit and therefore is fully open.
    /// </summary>
    /// <remarks>
    /// For a start point on a one dimensional scale this implies all values from -infinity
    /// to the end limit are part of the interval. (The end limit may be an open limit
    /// and therefore exclude the limit point making [-infinity,end) the appropriate
    /// representation for the interval.
    /// </remarks> 
    public static readonly IntervalLimitConstraint Unbounded = new (false, false);
    
    /// <summary>
    /// The endpoint in question has a limit and is open. (i.e. excludes the limit point)
    /// </summary>
    public static readonly IntervalLimitConstraint Open = new (false,true);
    
    /// <summary>
    /// The endpoint in question has a limit and is closed. (i.e. includes the limit point)
    /// </summary>
    public static readonly IntervalLimitConstraint Closed = new (true,true);

    /// <summary>
    /// Indicates if the specified interval endpoint contains the
    /// point in question.
    /// </summary>
    public bool IsClosed => _state == ClosedValue;

    /// <summary>
    /// Indicates if the specified interval endpoint includes the
    /// start/end point in question.
    /// </summary>
    public bool IsOpen => !IsClosed;

    /// <summary>
    /// Indicates if the specified interval endpoint contains any
    /// limit whatsoever. (i.e. is it fully open at the start or end?)
    /// </summary>
    public bool HasLimitValue => !IsUnbounded;

    /// <summary>
    /// Indicates if there is no limit on the bounds of this constraint.
    /// This is effectively -infinity or +infinity depending on context.
    /// </summary>
    public bool IsUnbounded => _state==UnboundedState;

    private const byte UnboundedState = 0;
    private const byte OpenValue = 1;
    private const byte ClosedValue = 2;

    private readonly byte _state;
    private IntervalLimitConstraint(bool isClosed, bool hasLimitValue)
    {
        if (isClosed && !hasLimitValue)
            throw new ArgumentOutOfRangeException(nameof(hasLimitValue),
                $"The endpoint of an interval may not be both fully open and required to contain a limit.");
        _state = isClosed
            ? ClosedValue
            : hasLimitValue
                ? OpenValue
                : UnboundedState;
    }

    #region Equality members

    /// <inheritdoc />
    public bool Equals(IntervalLimitConstraint other)
    {
        return _state == other._state; 
    }

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        return obj is IntervalLimitConstraint other && Equals(other);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        unchecked
        {
            return (IsClosed.GetHashCode() * 397) ^ HasLimitValue.GetHashCode();
        }
    }

    /// <summary>
    /// Equivalence operator
    /// </summary>
    /// <param name="left">The left hand parameter</param>
    /// <param name="right">The right hand parameter</param>
    /// <returns>true if equivalent.</returns>
    public static bool operator ==(IntervalLimitConstraint left, IntervalLimitConstraint right)
    {
        return left._state == right._state;
    }

    /// <summary>
    /// Non-equivalence operator
    /// </summary>
    /// <param name="left">The left hand parameter</param>
    /// <param name="right">The right hand parameter</param>
    /// <returns>true if not equivalent.</returns>
    public static bool operator !=(IntervalLimitConstraint left, IntervalLimitConstraint right)
    {
        return left._state != right._state;
    }

    #endregion
}