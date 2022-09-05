using System;
using System.Runtime.CompilerServices;

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

    /// <summary>
    /// Indicates if this is a Start IntervalLimitType
    /// </summary>
    public bool IsStart => _value == StartValue;

    /// <summary>
    /// Indicates if this is an End IntervalLimitType
    /// </summary>
    public bool IsEnd => _value == EndValue;
    
    private IntervalLimitType(byte value)
    {
        if (value != StartValue && value != EndValue)
            throw new ArgumentOutOfRangeException(nameof(value), $"type can only be 0 or 1. Found {value}."); 
        _value = value;
    }

    #region Equality members

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(IntervalLimitType other)
    {
        return _value == other._value;
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override bool Equals(object? obj)
    {
        return obj is IntervalLimitType other && Equals(other);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return _value.GetHashCode();
    }

    /// <summary>
    /// Compares two IntervalLimitTypes for equality.
    /// </summary>
    /// <param name="left">The left hand operand.</param>
    /// <param name="right">The right hand operand.</param>
    /// <returns>True if they're equal.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(IntervalLimitType left, IntervalLimitType right)
    {
        return left.Equals(right);
    }

    /// <summary>
    /// Compares two IntervalLimitTypes for inequality.
    /// </summary>
    /// <param name="left">The left hand operand.</param>
    /// <param name="right">The right hand operand.</param>
    /// <returns>True if they're not equal.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(IntervalLimitType left, IntervalLimitType right)
    {
        return !left.Equals(right);
    }

    #endregion

    #region Relational members

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int CompareTo(IntervalLimitType other)
    {
        return _value.CompareTo(other._value);
    }

    /// <inheritdoc />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        return obj is IntervalLimitType other ? _value.CompareTo(other._value) : throw new ArgumentException($"Object must be of type {nameof(IntervalLimitType)}");
    }

    /// <summary>
    /// Checks if the left hand IntervalLimitType is less than the right hand IntervalLimitType.
    /// </summary>
    /// <param name="left">The left hand operand.</param>
    /// <param name="right">The right hand operand.</param>
    /// <returns>True if left is less than right.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <(IntervalLimitType left, IntervalLimitType right)
    {
        return left._value < right._value;
    }

    /// <summary>
    /// Checks if the left hand IntervalLimitType is greater than the right hand IntervalLimitType.
    /// </summary>
    /// <param name="left">The left hand operand.</param>
    /// <param name="right">The right hand operand.</param>
    /// <returns>True if left is greater than right.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator >(IntervalLimitType left, IntervalLimitType right)
    {
        return left._value > right._value;
    }

    /// <summary>
    /// Checks if the left hand IntervalLimitType is less than or equal to the right hand IntervalLimitType.
    /// </summary>
    /// <param name="left">The left hand operand.</param>
    /// <param name="right">The right hand operand.</param>
    /// <returns>True if left is less than or equal to right.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <=(IntervalLimitType left, IntervalLimitType right)
    {
        return left._value <= right._value;
    }

    /// <summary>
    /// Checks if the left hand IntervalLimitType is greater than or equal to the right hand IntervalLimitType.
    /// </summary>
    /// <param name="left">The left hand operand.</param>
    /// <param name="right">The right hand operand.</param>
    /// <returns>True if left is greater  than or equal to right.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator IntervalLimitType(byte value)
        => new (value);

    /// <summary>
    /// Convert to byte operator.
    /// </summary>
    /// <param name="type">the type to convert</param>
    /// <returns>The underlying value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator byte(IntervalLimitType type) => type._value; 
    
    #endregion
    
    /// <inheritdoc />
    public override string ToString()
    {
        return $"{_value}";
    }
}