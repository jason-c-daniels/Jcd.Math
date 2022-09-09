#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Numbers](Jcd.Math.Numbers.md 'Jcd.Math.Numbers').[FiniteNumber&lt;TStorage&gt;](Jcd.Math.Numbers.FiniteNumber_TStorage_.md 'Jcd.Math.Numbers.FiniteNumber<TStorage>')

## FiniteNumber<TStorage>.Equals<TValue>(TValue) Method

Compare this FiniteNumber to an arbitrary struct.  
This may incur a boxing operation if the struct isn't one  
it knows how to handle.

```csharp
public bool Equals<TValue>(TValue other)
    where TValue : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Jcd.Math.Numbers.FiniteNumber_TStorage_.Equals_TValue_(TValue).TValue'></a>

`TValue`

The data type of the value.
#### Parameters

<a name='Jcd.Math.Numbers.FiniteNumber_TStorage_.Equals_TValue_(TValue).other'></a>

`other` [TValue](Jcd.Math.Numbers.FiniteNumber_TStorage_.Equals_TValue_(TValue).md#Jcd.Math.Numbers.FiniteNumber_TStorage_.Equals_TValue_(TValue).TValue 'Jcd.Math.Numbers.FiniteNumber<TStorage>.Equals<TValue>(TValue).TValue')

The value to compare against.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')