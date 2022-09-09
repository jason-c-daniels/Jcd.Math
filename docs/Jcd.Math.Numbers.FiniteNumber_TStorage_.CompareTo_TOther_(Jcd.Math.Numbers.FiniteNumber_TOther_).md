#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Numbers](Jcd.Math.Numbers.md 'Jcd.Math.Numbers').[FiniteNumber&lt;TStorage&gt;](Jcd.Math.Numbers.FiniteNumber_TStorage_.md 'Jcd.Math.Numbers.FiniteNumber<TStorage>')

## FiniteNumber<TStorage>.CompareTo<TOther>(FiniteNumber<TOther>) Method

Compare to another FiniteNumber with a different base storage type.

```csharp
public int CompareTo<TOther>(Jcd.Math.Numbers.FiniteNumber<TOther> other)
    where TOther : struct, System.IComparable<TOther>, System.IEquatable<TOther>, System.IComparable, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Jcd.Math.Numbers.FiniteNumber_TStorage_.CompareTo_TOther_(Jcd.Math.Numbers.FiniteNumber_TOther_).TOther'></a>

`TOther`

The other storage type.
#### Parameters

<a name='Jcd.Math.Numbers.FiniteNumber_TStorage_.CompareTo_TOther_(Jcd.Math.Numbers.FiniteNumber_TOther_).other'></a>

`other` [Jcd.Math.Numbers.FiniteNumber&lt;](Jcd.Math.Numbers.FiniteNumber_TStorage_.md 'Jcd.Math.Numbers.FiniteNumber<TStorage>')[TOther](Jcd.Math.Numbers.FiniteNumber_TStorage_.CompareTo_TOther_(Jcd.Math.Numbers.FiniteNumber_TOther_).md#Jcd.Math.Numbers.FiniteNumber_TStorage_.CompareTo_TOther_(Jcd.Math.Numbers.FiniteNumber_TOther_).TOther 'Jcd.Math.Numbers.FiniteNumber<TStorage>.CompareTo<TOther>(Jcd.Math.Numbers.FiniteNumber<TOther>).TOther')[&gt;](Jcd.Math.Numbers.FiniteNumber_TStorage_.md 'Jcd.Math.Numbers.FiniteNumber<TStorage>')

The other value.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
0 if equivalent, -1 if less than, 1 if greater.