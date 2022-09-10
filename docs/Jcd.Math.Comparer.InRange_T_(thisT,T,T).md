#### [Jcd.Math](index.md 'index')
### [Jcd.Math](Jcd.Math.md 'Jcd.Math').[Comparer](Jcd.Math.Comparer.md 'Jcd.Math.Comparer')

## Comparer.InRange<T>(this T, T, T) Method

Checks if a value is within a closed interval. (i.e. interval includes start and endpoints)

```csharp
public static bool InRange<T>(this T value, T start, T end)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='Jcd.Math.Comparer.InRange_T_(thisT,T,T).T'></a>

`T`

The data type being compared.
#### Parameters

<a name='Jcd.Math.Comparer.InRange_T_(thisT,T,T).value'></a>

`value` [T](Jcd.Math.Comparer.InRange_T_(thisT,T,T).md#Jcd.Math.Comparer.InRange_T_(thisT,T,T).T 'Jcd.Math.Comparer.InRange<T>(this T, T, T).T')

The value to compare

<a name='Jcd.Math.Comparer.InRange_T_(thisT,T,T).start'></a>

`start` [T](Jcd.Math.Comparer.InRange_T_(thisT,T,T).md#Jcd.Math.Comparer.InRange_T_(thisT,T,T).T 'Jcd.Math.Comparer.InRange<T>(this T, T, T).T')

Start of the range to check

<a name='Jcd.Math.Comparer.InRange_T_(thisT,T,T).end'></a>

`end` [T](Jcd.Math.Comparer.InRange_T_(thisT,T,T).md#Jcd.Math.Comparer.InRange_T_(thisT,T,T).T 'Jcd.Math.Comparer.InRange<T>(this T, T, T).T')

End of the range to check.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the value is within the range.