namespace Jcd.Math.Examples;

internal class CustomValue : IComparable<CustomValue>, IComparable, IEquatable<CustomValue>
{
    private readonly byte _value;

    public CustomValue(byte value)
    {
        _value = value;
    }

    #region Relational members

    /// <inheritdoc />
    public int CompareTo(CustomValue? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        return _value.CompareTo(other._value);
    }

    /// <inheritdoc />
    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        if (ReferenceEquals(this, obj)) return 0;
        return obj is CustomValue other ? _value.CompareTo(other._value) : throw new ArgumentException($"Object must be of type {nameof(CustomValue)}");
    }
    
    #endregion

    #region Implementation of IEquatable<CustomValue>

    /// <inheritdoc />
    public bool Equals(CustomValue? other)
    {
        return CompareTo(other) == 0;
    }

    #endregion
}