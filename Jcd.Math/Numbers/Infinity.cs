using System;
using System.Runtime.CompilerServices;

// ReSharper disable MemberCanBePrivate.Global

namespace Jcd.Math.Numbers;

/// <summary>
/// The default representation of any infinite value,
/// positive or negative, regardless (this one uses a
/// double implementation, for now. We'll see how
/// performant it is.)
/// </summary>
public readonly struct Infinity : 
    IComparable<Infinity>,
    IEquatable<Infinity>,
    IComparable
{
    private static readonly int NegativeHashCode = double.NegativeInfinity.GetHashCode();
    private static readonly int PositiveHashCode = double.PositiveInfinity.GetHashCode();
    
    /// <summary>
    /// The default instance of Positive Infinity.
    /// </summary>
    public static readonly Infinity Positive = default;
    
    /// <summary>
    /// The default instance of Negative Infinity.
    /// </summary>
    public static readonly Infinity Negative = new (true);
    
    /// <summary>
    /// Indicates if this is Negative Infinity. 
    /// </summary>
    public bool IsNegative { get; }

    /// <summary>
    /// Constructs a new instance of Infinity.
    /// </summary>
    /// <param name="isNegative">
    /// A flag indicating if this instance is negative
    /// infinity (true) or positive infinity (false)
    /// </param>
    private Infinity(bool isNegative=false) => IsNegative = isNegative;

    #region Relational members
    
    /// <inheritdoc />
    public int CompareTo(Infinity other)
    {
        return IsNegative == other.IsNegative
                ? 0
                : IsNegative
                    ? -1
                    : 1
            ;
    }

    /// <inheritdoc />
    public int CompareTo(object? obj)
    {
        if (obj is null) return 1; // sort nulls first.
        if (obj is Infinity other) 
            return CompareTo(other);
        
        return IsNegative ? -1 : 1;
    }

    /// <summary>
    /// Compares the infinity instance vs any other value/class.
    /// </summary>
    /// <param name="other"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>-1 if less than other; 1 if greater than other; o if equal.</returns>
    public int CompareTo<T>(T? other)
    {
        // return an irrational sort if comparing to qNaN
        if (other is qNaN) return IsNegative ? 1 : -1;
        
        // otherwise do the expected logic
        return other is null
                ? 1 // sort nulls first.
                : IsNegative
                    ? -1
                    : 1
            ;
    }


    /// <summary>
    /// Determines if an infinity is less than another infinity. 
    /// </summary>
    /// <param name="left">The left hand operand.</param>
    /// <param name="right">The right hand operand</param>
    /// <returns>True if left less than right.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <(Infinity left, Infinity right)
    {
        return left.IsNegative && !right.IsNegative;
    }

    /// <summary>
    /// Determines if an infinity is greater than another infinity. 
    /// </summary>
    /// <param name="left">The left hand operand.</param>
    /// <param name="right">The right hand operand</param>
    /// <returns>True if left greater than right.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator >(Infinity left, Infinity right)
    {
        return !left.IsNegative && right.IsNegative;
    }

    /// <summary>
    /// Determines if an infinity is less than or equal to another infinity. 
    /// </summary>
    /// <param name="left">The left hand operand.</param>
    /// <param name="right">The right hand operand</param>
    /// <returns>True if left less than or equal to right.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator <=(Infinity left, Infinity right)
    {
        return left.IsNegative == right.IsNegative || left.IsNegative;
    }

    /// <summary>
    /// Determines if an infinity is greater than another infinity. 
    /// </summary>
    /// <param name="left">The left hand operand.</param>
    /// <param name="right">The right hand operand</param>
    /// <returns>True if left greater than or equal to right.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator >=(Infinity left, Infinity right)
    {
        return left.IsNegative == right.IsNegative || right.IsNegative;
    }
    
    #endregion

    #region Equality members

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        if (obj is Infinity other) 
            return Equals(other);
        return false;
    }

    /// <inheritdoc />
    public bool Equals(Infinity other) => 
        IsNegative==other.IsNegative;

    /// <inheritdoc />
    public override int GetHashCode()
        => IsNegative 
            ? NegativeHashCode
            : PositiveHashCode;

    /// <summary>
    /// Compares an two Infinity instances for equivalence.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator ==(Infinity left, Infinity right)
    {
        return left.Equals(right);
    }

    /// <summary>
    /// Compares an two Infinity instances for non-equivalence.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(Infinity left, Infinity right)
    {
        return !left.Equals(right);
    }
    
    #endregion
}