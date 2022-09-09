#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Numbers](Jcd.Math.Numbers.md 'Jcd.Math.Numbers').[FiniteNumber&lt;TStorage&gt;](Jcd.Math.Numbers.FiniteNumber_TStorage_.md 'Jcd.Math.Numbers.FiniteNumber<TStorage>')

## FiniteNumber<TStorage>.CompareTo(Infinity) Method

Compares this number to an infinity.  
A finite number is always larger than negative infinity.  
Also it's always smaller than positive infinity.

```csharp
public int CompareTo(Jcd.Math.Numbers.Infinity other);
```
#### Parameters

<a name='Jcd.Math.Numbers.FiniteNumber_TStorage_.CompareTo(Jcd.Math.Numbers.Infinity).other'></a>

`other` [Infinity](Jcd.Math.Numbers.Infinity.md 'Jcd.Math.Numbers.Infinity')

The infinity.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
-1 for Infinity.Positive; 1 for Infinity.Negative