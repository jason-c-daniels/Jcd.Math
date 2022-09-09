using System;
// ReSharper disable MemberCanBePrivate.Global

namespace Jcd.Math.Numbers;

/// <summary>
/// The representation of a finite number with a specified storage type.
/// </summary>
/// <typeparam name="TStorage">The data type to use to represent the finite number.</typeparam>
public readonly struct FiniteNumber<TStorage> :
    IComparable<FiniteNumber<TStorage>>,
    IEquatable<FiniteNumber<TStorage>>,
    IComparable<TStorage>,
    IEquatable<TStorage>,
    IComparable
where TStorage : struct,
    IComparable<TStorage>,
    IEquatable<TStorage>,
    IComparable
{
    /// <summary>
    /// The underlying value for this FiniteNumber.
    /// </summary>
    public TStorage Value { get; } = default;

    /// <summary>
    /// The value of Zero as a FiniteNumber&lt;TStorage&gt;
    /// </summary>
    public static readonly FiniteNumber<TStorage> Zero = default;

    /// <summary>
    /// Construct a FiniteNumber from a specific value.
    /// </summary>
    /// <param name="value">The value to construct the number from.</param>
    public FiniteNumber(TStorage value = default)
    {
        // if (greaterThan && lessThan) ..
        // Do we care if someone makes a number that's
        // only equal to itself and false for all other operators?
        // returns (-1 on all other comparisons to itself.)  
        (Value) = (value);
    }

    #region Relational comparisons
    
    /// <inheritdoc />
    public int CompareTo(object obj)
    {
        if (obj is FiniteNumber<TStorage> other) return CompareTo(other);
        if (obj is Infinity infinity) return CompareTo(infinity);
        //if (other is Epsilon epsilon) return CompareTo(epsilon);
        if (obj is qNaN qNaN) return qNaN.Comparer<TStorage>.Default.Compare(Value, qNaN);
        if (obj is bool yBool && Value is bool xBool) return xBool.CompareTo(yBool);
        if (obj is byte yByte && Value is byte xByte) return xByte.CompareTo(yByte);
        if (obj is sbyte ySbyte && Value is sbyte xSbyte) return xSbyte.CompareTo(ySbyte);
        if (obj is ushort yUshort && Value is ushort xUshort) return xUshort.CompareTo(yUshort);
        if (obj is short yShort && Value is short xShort) return xShort.CompareTo(yShort);
        if (obj is int yInt && Value is int xInt) return xInt.CompareTo(yInt);
        if (obj is uint yUint && Value is uint xUint) return xUint.CompareTo(yUint);
        if (obj is long yLong && Value is long xLong) return xLong.CompareTo(yLong);
        if (obj is ulong yUlong && Value is ulong xUlong) return xUlong.CompareTo(yUlong);
        if (obj is float yFloat && Value is float xFloat) return xFloat.CompareTo(yFloat);
        if (obj is double yDouble && Value is double xDouble) return xDouble.CompareTo(yDouble);
        // TODO: figure out how to efficiently avoid this boxing allocation for other structs!
        return -1;
    }

    /// <summary>
    /// Compares this number to an infinity.
    /// A finite number is always larger than negative infinity.
    /// Also it's always smaller than positive infinity.
    /// </summary>
    /// <param name="other">The infinity.</param>
    /// <returns>-1 for Infinity.Positive; 1 for Infinity.Negative</returns>
    public int CompareTo(Infinity other) =>
        other.IsNegative ? 1 : -1;
    
    /// <inheritdoc />
    public int CompareTo(FiniteNumber<TStorage> other)
    {
        return Value.CompareTo(other.Value);
    }

    /// <inheritdoc />
    public int CompareTo(TStorage other) =>
        Value.CompareTo(other);
    
    /// <summary>
    /// Compare to another FiniteNumber with a different base storage type.
    /// </summary>
    /// <param name="other">The other value.</param>
    /// <typeparam name="TOther">The other storage type.</typeparam>
    /// <returns>0 if equivalent, -1 if less than, 1 if greater.</returns>
    public int CompareTo<TOther>(FiniteNumber<TOther> other)
        where TOther : struct,
        IComparable<TOther>,
        IEquatable<TOther>,
        IComparable
    => CompareTo(other.Value);

    /// <summary>
    /// Compare the value to another struct with a different base storage type.
    /// </summary>
    /// <param name="other">The other value.</param>
    /// <typeparam name="TValue">The value storage type.</typeparam>
    /// <returns>0 if equivalent, -1 if less than, 1 if greater.</returns>
    public int CompareTo<TValue>(TValue other)
        where TValue : struct
    {
        if (other is Infinity infinity) return CompareTo(infinity);
        //if (other is Epsilon epsilon) return CompareTo(epsilon);
        if (other is qNaN qNaN) return qNaN.Comparer<TStorage>.Default.Compare(Value, qNaN);
        if (other is bool yBool && Value is bool xBool) return xBool.CompareTo(yBool);
        if (other is byte yByte && Value is byte xByte) return xByte.CompareTo(yByte);
        if (other is sbyte ySbyte && Value is sbyte xSbyte) return xSbyte.CompareTo(ySbyte);
        if (other is ushort yUshort && Value is ushort xUshort) return xUshort.CompareTo(yUshort);
        if (other is short yShort && Value is short xShort) return xShort.CompareTo(yShort);
        if (other is int yInt && Value is int xInt) return xInt.CompareTo(yInt);
        if (other is uint yUint && Value is uint xUint) return xUint.CompareTo(yUint);
        if (other is long yLong && Value is long xLong) return xLong.CompareTo(yLong);
        if (other is ulong yUlong && Value is ulong xUlong) return xUlong.CompareTo(yUlong);
        if (other is float yFloat && Value is float xFloat) return xFloat.CompareTo(yFloat);
        if (other is double yDouble && Value is double xDouble) return xDouble.CompareTo(yDouble);
        // TODO: figure out how to efficiently avoid this boxing allocation for other structs!
        return Value.CompareTo(other);
    }
    #endregion
    
    #region Equivalence comparisons

    /// <summary>
    /// Compare to another FiniteNumber with a different base storage type.
    /// </summary>
    /// <param name="other">The other value.</param>
    /// <typeparam name="TOther">The other storage type.</typeparam>
    /// <returns>0 if equivalent, -1 if less than, 1 if greater.</returns>
    public bool Equals<TOther>(FiniteNumber<TOther> other)
        where TOther : struct,
        IComparable<TOther>,
        IEquatable<TOther>,
        IComparable
        => Equals(other.Value);


    /// <inheritdoc />
    public override bool Equals(object obj)
    {
        
        if (obj is FiniteNumber<TStorage> other) return Equals(other); 
        if (obj is Infinity) return false; // finite numbers are never infinite
        //if (other is Epsilon epsilon) return CompareTo(epsilon);
        if (obj is qNaN) return false; // qNaN is always not equal
        if (obj is bool yBool && Value is bool xBool) return xBool.Equals(yBool);
        if (obj is byte yByte && Value is byte xByte) return xByte.Equals(yByte);
        if (obj is sbyte ySbyte && Value is sbyte xSbyte) return xSbyte.Equals(ySbyte);
        if (obj is ushort yUshort && Value is ushort xUshort) return xUshort.Equals(yUshort);
        if (obj is short yShort && Value is short xShort) return xShort.Equals(yShort);
        if (obj is int yInt && Value is int xInt) return xInt.Equals(yInt);
        if (obj is uint yUint && Value is uint xUint) return xUint.Equals(yUint);
        if (obj is long yLong && Value is long xLong) return xLong.Equals(yLong);
        if (obj is ulong yUlong && Value is ulong xUlong) return xUlong.Equals(yUlong);
        if (obj is float yFloat && Value is float xFloat) return xFloat.Equals(yFloat);
        if (obj is double yDouble && Value is double xDouble) return xDouble.Equals(yDouble);
        // TODO: figure out how to efficiently avoid this boxing allocation for other structs!
        return false;
    }
    
    /// <summary>
    /// Compare this FiniteNumber to an arbitrary struct.
    /// This may incur a boxing operation if the struct isn't one
    /// it knows how to handle.
    /// </summary>
    /// <param name="other">The value to compare against.</param>
    /// <typeparam name="TValue">The data type of the value.</typeparam>
    /// <returns></returns>
    public bool Equals<TValue>(TValue other)
        where TValue : struct
    {
        if (other is Infinity) return false; // finite numbers are never infinite
        //if (other is Epsilon epsilon) return CompareTo(epsilon);
        if (other is qNaN) return false; // qNaN is always not equal
        if (other is bool yBool && Value is bool xBool) return xBool.Equals(yBool);
        if (other is byte yByte && Value is byte xByte) return xByte.Equals(yByte);
        if (other is sbyte ySbyte && Value is sbyte xSbyte) return xSbyte.Equals(ySbyte);
        if (other is ushort yUshort && Value is ushort xUshort) return xUshort.Equals(yUshort);
        if (other is short yShort && Value is short xShort) return xShort.Equals(yShort);
        if (other is int yInt && Value is int xInt) return xInt.Equals(yInt);
        if (other is uint yUint && Value is uint xUint) return xUint.Equals(yUint);
        if (other is long yLong && Value is long xLong) return xLong.Equals(yLong);
        if (other is ulong yUlong && Value is ulong xUlong) return xUlong.Equals(yUlong);
        if (other is float yFloat && Value is float xFloat) return xFloat.Equals(yFloat);
        if (other is double yDouble && Value is double xDouble) return xDouble.Equals(yDouble);
        // TODO: figure out how to efficiently avoid this boxing allocation for other structs!
        return Value.Equals(other);
    }

    /// <inheritdoc />
    public bool Equals(TStorage other) =>
        Value.Equals(other);

    /// <inheritdoc />
    public bool Equals(FiniteNumber<TStorage> other) =>
        Value.Equals(other.Value);

    /// <summary>
    /// We know that finite numbers are never equal to infinite
    /// numbers by definition.
    /// </summary>
    /// <param name="other">the infinite number</param>
    /// <returns>false. This is always false.</returns>
    public bool Equals(Infinity other) => false;
    
    #endregion
    
    #region Overrides of ValueType

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return Value.ToString();
    }

    #endregion
    
}   
 