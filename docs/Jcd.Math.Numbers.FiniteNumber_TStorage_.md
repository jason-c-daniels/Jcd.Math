#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Numbers](Jcd.Math.Numbers.md 'Jcd.Math.Numbers')

## FiniteNumber<TStorage> Struct

The representation of a finite number with a specified storage type.

```csharp
public readonly struct FiniteNumber<TStorage> :
System.IComparable<Jcd.Math.Numbers.FiniteNumber<TStorage>>,
System.IEquatable<Jcd.Math.Numbers.FiniteNumber<TStorage>>,
System.IComparable<TStorage>,
System.IEquatable<TStorage>,
System.IComparable
    where TStorage : struct, System.IComparable<TStorage>, System.IEquatable<TStorage>, System.IComparable, System.ValueType, System.ValueType
```
#### Type parameters

<a name='Jcd.Math.Numbers.FiniteNumber_TStorage_.TStorage'></a>

`TStorage`

The data type to use to represent the finite number.

Implements [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[Jcd.Math.Numbers.FiniteNumber&lt;](Jcd.Math.Numbers.FiniteNumber_TStorage_.md 'Jcd.Math.Numbers.FiniteNumber<TStorage>')[TStorage](Jcd.Math.Numbers.FiniteNumber_TStorage_.md#Jcd.Math.Numbers.FiniteNumber_TStorage_.TStorage 'Jcd.Math.Numbers.FiniteNumber<TStorage>.TStorage')[&gt;](Jcd.Math.Numbers.FiniteNumber_TStorage_.md 'Jcd.Math.Numbers.FiniteNumber<TStorage>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Jcd.Math.Numbers.FiniteNumber&lt;](Jcd.Math.Numbers.FiniteNumber_TStorage_.md 'Jcd.Math.Numbers.FiniteNumber<TStorage>')[TStorage](Jcd.Math.Numbers.FiniteNumber_TStorage_.md#Jcd.Math.Numbers.FiniteNumber_TStorage_.TStorage 'Jcd.Math.Numbers.FiniteNumber<TStorage>.TStorage')[&gt;](Jcd.Math.Numbers.FiniteNumber_TStorage_.md 'Jcd.Math.Numbers.FiniteNumber<TStorage>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[TStorage](Jcd.Math.Numbers.FiniteNumber_TStorage_.md#Jcd.Math.Numbers.FiniteNumber_TStorage_.TStorage 'Jcd.Math.Numbers.FiniteNumber<TStorage>.TStorage')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TStorage](Jcd.Math.Numbers.FiniteNumber_TStorage_.md#Jcd.Math.Numbers.FiniteNumber_TStorage_.TStorage 'Jcd.Math.Numbers.FiniteNumber<TStorage>.TStorage')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable')

| Constructors | |
| :--- | :--- |
| [FiniteNumber(TStorage)](Jcd.Math.Numbers.FiniteNumber_TStorage_.FiniteNumber(TStorage).md 'Jcd.Math.Numbers.FiniteNumber<TStorage>.FiniteNumber(TStorage)') | Construct a FiniteNumber from a specific value. |

| Fields | |
| :--- | :--- |
| [Zero](Jcd.Math.Numbers.FiniteNumber_TStorage_.Zero.md 'Jcd.Math.Numbers.FiniteNumber<TStorage>.Zero') | The value of Zero as a FiniteNumber<TStorage> |

| Properties | |
| :--- | :--- |
| [Value](Jcd.Math.Numbers.FiniteNumber_TStorage_.Value.md 'Jcd.Math.Numbers.FiniteNumber<TStorage>.Value') | The underlying value for this FiniteNumber. |

| Methods | |
| :--- | :--- |
| [CompareTo(Infinity)](Jcd.Math.Numbers.FiniteNumber_TStorage_.CompareTo(Jcd.Math.Numbers.Infinity).md 'Jcd.Math.Numbers.FiniteNumber<TStorage>.CompareTo(Jcd.Math.Numbers.Infinity)') | Compares this number to an infinity.<br/>A finite number is always larger than negative infinity.<br/>Also it's always smaller than positive infinity. |
| [CompareTo(object)](Jcd.Math.Numbers.FiniteNumber_TStorage_.CompareTo(object).md 'Jcd.Math.Numbers.FiniteNumber<TStorage>.CompareTo(object)') | Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object. |
| [CompareTo(TStorage)](Jcd.Math.Numbers.FiniteNumber_TStorage_.CompareTo(TStorage).md 'Jcd.Math.Numbers.FiniteNumber<TStorage>.CompareTo(TStorage)') | Compares the current object with another object of the same type. |
| [CompareTo&lt;TOther&gt;(FiniteNumber&lt;TOther&gt;)](Jcd.Math.Numbers.FiniteNumber_TStorage_.CompareTo_TOther_(Jcd.Math.Numbers.FiniteNumber_TOther_).md 'Jcd.Math.Numbers.FiniteNumber<TStorage>.CompareTo<TOther>(Jcd.Math.Numbers.FiniteNumber<TOther>)') | Compare to another FiniteNumber with a different base storage type. |
| [CompareTo&lt;TValue&gt;(TValue)](Jcd.Math.Numbers.FiniteNumber_TStorage_.CompareTo_TValue_(TValue).md 'Jcd.Math.Numbers.FiniteNumber<TStorage>.CompareTo<TValue>(TValue)') | Compare the value to another struct with a different base storage type. |
| [Equals(Infinity)](Jcd.Math.Numbers.FiniteNumber_TStorage_.Equals(Jcd.Math.Numbers.Infinity).md 'Jcd.Math.Numbers.FiniteNumber<TStorage>.Equals(Jcd.Math.Numbers.Infinity)') | We know that finite numbers are never equal to infinite<br/>numbers by definition. |
| [Equals(object)](Jcd.Math.Numbers.FiniteNumber_TStorage_.Equals(object).md 'Jcd.Math.Numbers.FiniteNumber<TStorage>.Equals(object)') | Indicates whether this instance and a specified object are equal. |
| [Equals(TStorage)](Jcd.Math.Numbers.FiniteNumber_TStorage_.Equals(TStorage).md 'Jcd.Math.Numbers.FiniteNumber<TStorage>.Equals(TStorage)') | Indicates whether the current object is equal to another object of the same type. |
| [Equals&lt;TOther&gt;(FiniteNumber&lt;TOther&gt;)](Jcd.Math.Numbers.FiniteNumber_TStorage_.Equals_TOther_(Jcd.Math.Numbers.FiniteNumber_TOther_).md 'Jcd.Math.Numbers.FiniteNumber<TStorage>.Equals<TOther>(Jcd.Math.Numbers.FiniteNumber<TOther>)') | Compare to another FiniteNumber with a different base storage type. |
| [Equals&lt;TValue&gt;(TValue)](Jcd.Math.Numbers.FiniteNumber_TStorage_.Equals_TValue_(TValue).md 'Jcd.Math.Numbers.FiniteNumber<TStorage>.Equals<TValue>(TValue)') | Compare this FiniteNumber to an arbitrary struct.<br/>This may incur a boxing operation if the struct isn't one<br/>it knows how to handle. |
| [GetHashCode()](Jcd.Math.Numbers.FiniteNumber_TStorage_.GetHashCode().md 'Jcd.Math.Numbers.FiniteNumber<TStorage>.GetHashCode()') | Returns the hash code for this instance. |
| [ToString()](Jcd.Math.Numbers.FiniteNumber_TStorage_.ToString().md 'Jcd.Math.Numbers.FiniteNumber<TStorage>.ToString()') | Returns the fully qualified type name of this instance. |
