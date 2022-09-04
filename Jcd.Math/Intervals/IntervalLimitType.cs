using System;

namespace Jcd.Math.Intervals;

/// <summary>
/// An equatable and comparable type-safe and highly performant DDD-like enumeration type.
/// To keep high performance the usual DDD name/description property is omitted.
/// </summary>
public readonly struct IntervalLimitType : 
    IEquatable<IntervalLimitType>, 
    IComparable<IntervalLimitType>, 
    IComparable
{
    private readonly byte _value;
    private const byte StartValue = 0;
    private const byte EndValue = 1;

    /// <summary>
    /// The start point of an interval. Start must be &lt;= end
    /// </summary>
    public static IntervalLimitType Start = new (StartValue);

    /// <summary>
    /// The end point of an interval. End must be &gt;= start
    /// </summary>
    public static IntervalLimitType End = new (EndValue);

    private IntervalLimitType(byte value)
    {
        if (value != StartValue && value != EndValue)
            throw new ArgumentOutOfRangeException(nameof(value), $"type can only be 0 or 1. Found {value}."); 
        _value = value;
    }

    #region Equality members

    /// <inheritdoc />
    public bool Equals(IntervalLimitType other)
    {
        return _value == other._value;
    }

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        return obj is IntervalLimitType other && Equals(other);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return _value.GetHashCode();
    }

    public static bool operator ==(IntervalLimitType left, IntervalLimitType right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(IntervalLimitType left, IntervalLimitType right)
    {
        return !left.Equals(right);
    }

    #endregion

    #region Relational members

    /// <inheritdoc />
    public int CompareTo(IntervalLimitType other)
    {
        return _value.CompareTo(other._value);
    }

    /// <inheritdoc />
    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        return obj is IntervalLimitType other ? _value.CompareTo(other._value) : throw new ArgumentException($"Object must be of type {nameof(IntervalLimitType)}");
    }

    public static bool operator <(IntervalLimitType left, IntervalLimitType right)
    {
        return left._value < right._value;
    }

    public static bool operator >(IntervalLimitType left, IntervalLimitType right)
    {
        return left._value > right._value;
    }

    public static bool operator <=(IntervalLimitType left, IntervalLimitType right)
    {
        return left._value <= right._value;
    }

    public static bool operator >=(IntervalLimitType left, IntervalLimitType right)
    {
        return left._value >= right._value;
    }

    #endregion
    
    #region conversion operators
    
    /// <summary>
    /// Conversion operator from byte.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static explicit operator IntervalLimitType(byte value)
        => new (value);

    /// <summary>
    /// Convert to byte operator.
    /// </summary>
    /// <param name="type">the type to convert</param>
    /// <returns>The underlying value.</returns>
    public static explicit operator byte(IntervalLimitType type) => type._value; 
    
    #endregion
    
    /// <inheritdoc />
    public override string ToString()
    {
        return $"{_value}";
    }
}