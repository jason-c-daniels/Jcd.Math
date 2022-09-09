#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Numbers](Jcd.Math.Numbers.md 'Jcd.Math.Numbers').[FiniteNumber&lt;TStorage&gt;](Jcd.Math.Numbers.FiniteNumber_TStorage_.md 'Jcd.Math.Numbers.FiniteNumber<TStorage>')

## FiniteNumber<TStorage>.CompareTo<TValue>(TValue) Method

Compare the value to another struct with a different base storage type.

```csharp
public int CompareTo<TValue>(TValue other)
    where TValue : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Jcd.Math.Numbers.FiniteNumber_TStorage_.CompareTo_TValue_(TValue).TValue'></a>

`TValue`

The value storage type.
#### Parameters

<a name='Jcd.Math.Numbers.FiniteNumber_TStorage_.CompareTo_TValue_(TValue).other'></a>

`other` [TValue](Jcd.Math.Numbers.FiniteNumber_TStorage_.CompareTo_TValue_(TValue).md#Jcd.Math.Numbers.FiniteNumber_TStorage_.CompareTo_TValue_(TValue).TValue 'Jcd.Math.Numbers.FiniteNumber<TStorage>.CompareTo<TValue>(TValue).TValue')

The other value.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
0 if equivalent, -1 if less than, 1 if greater.