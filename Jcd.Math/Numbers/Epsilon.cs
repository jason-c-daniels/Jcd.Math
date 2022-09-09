using System;
// ReSharper disable UnusedType.Global
// ReSharper disable InconsistentNaming

namespace Jcd.Math.Numbers;

// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

/// <summary>
/// A DDD inspired enumeration for epsilon (ε). 
/// </summary>
public readonly struct Epsilon :
    IEquatable<Epsilon>, 
    IComparable<Epsilon>, 
    IComparable
{
    /// <summary>
    /// Infinitesimally less than zero.
    /// </summary>
    public static readonly Epsilon Negative = new(-1);

    /// <summary>
    /// None.
    /// </summary>
    public static readonly Epsilon None = default;
    
    /// <summary>
    /// Infinitesimally greater than zero.
    /// </summary>
    public static readonly Epsilon Positive = new(1);
    
    /// <summary>
    /// The identifier for this <c>Epsilon</c> instance.
    /// </summary>
    private readonly sbyte _value=0;
    
    /// <summary>
    /// Constructs an <c>Epsilon</c> instance from the numeric id.
    /// </summary>
    /// <param name="value">The numeric id of the infinitesimal component.</param>
    private Epsilon(sbyte value=0) => _value = value;

    #region Equality members

    /// <summary>
    /// Compares this instance to another for equivalence.
    /// </summary>
    /// <param name="other">the other instance to compare against.</param>
    /// <returns>True if equivalent.</returns>
    public bool Equals(Epsilon other)
    {
        return _value == other._value;
    }

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        return obj is Epsilon other && Equals(other);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return _value.GetHashCode();
    }

    /// <summary>
    /// The equals operator. 
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if equivalent</returns>
    public static bool operator ==(Epsilon left, Epsilon right)
    {
        return left.Equals(right);
    }

    /// <summary>
    /// The not equals operator.
    /// </summary>
    /// <param name="left">the left hand operand</param>
    /// <param name="right">the right hand operand</param>
    /// <returns>true if not equivalent</returns>
    public static bool operator !=(Epsilon left, Epsilon right)
    {
        return !left.Equals(right);
    }

    #endregion

    #region Relational members

    /// <summary>
    /// Performs a relational (greater, less, equal) comparison between this instance
    /// and another instance.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public int CompareTo(Epsilon other)
    {
        return _value.CompareTo(other._value);
    }

    /// <summary>
    /// Performs a relational (greater, less, equal) comparison between this instance
    /// and an arbitrary object.
    /// </summary>
    /// <param name="obj">the other thing to compare it to.</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">bad type for comparison.</exception>
    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        return obj is Epsilon other
            ? CompareTo(other)
            : throw new ArgumentException($"Object must be of type {nameof(Epsilon)}");
    }

    /// <summary>
    /// The less than operator.
    /// </summary>
    /// <param name="left">left hand operand</param>
    /// <param name="right">right hand operand</param>
    /// <returns>True if left is less than right</returns>
    public static bool operator <(Epsilon left, Epsilon right)
    {
        return left.CompareTo(right) < 0;
    }

    /// <summary>
    /// The greater than operator.
    /// </summary>
    /// <param name="left">left hand operand</param>
    /// <param name="right">right hand operand</param>
    /// <returns>True if left is greater than right</returns>
    public static bool operator >(Epsilon left, Epsilon right)
    {
        return left.CompareTo(right) > 0;
    }

    /// <summary>
    /// The less than or equals operator.
    /// </summary>
    /// <param name="left">left hand operand</param>
    /// <param name="right">right hand operand</param>
    /// <returns>True if left is less than or equal to right</returns>
    public static bool operator <=(Epsilon left, Epsilon right)
    {
        return left.CompareTo(right) <= 0;
    }

    /// <summary>
    /// The greater than or equals operator.
    /// </summary>
    /// <param name="left">left hand operand</param>
    /// <param name="right">right hand operand</param>
    /// <returns>True if left is greater than or equal to right</returns>
    public static bool operator >=(Epsilon left, Epsilon right)
    {
        return left.CompareTo(right) >= 0;
    }

    #endregion
    
    /// <inheritdoc />
    public override string ToString()
    {
        return $"{_value}";
    }
}