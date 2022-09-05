#### [Jcd.Math](index.md 'index')
### [Jcd.Math](Jcd.Math.md 'Jcd.Math').[Compare](Jcd.Math.Compare.md 'Jcd.Math.Compare')

## Compare.InRange<T>(this T, T, T) Method

Checks if a value is within a closed interval. (i.e. interval includes start and endpoints)

```csharp
public static bool InRange<T>(this T value, T start, T end)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='Jcd.Math.Compare.InRange_T_(thisT,T,T).T'></a>

`T`

The data type being compared.
#### Parameters

<a name='Jcd.Math.Compare.InRange_T_(thisT,T,T).value'></a>

`value` [T](Jcd.Math.Compare.InRange_T_(thisT,T,T).md#Jcd.Math.Compare.InRange_T_(thisT,T,T).T 'Jcd.Math.Compare.InRange<T>(this T, T, T).T')

The value to compare

<a name='Jcd.Math.Compare.InRange_T_(thisT,T,T).start'></a>

`start` [T](Jcd.Math.Compare.InRange_T_(thisT,T,T).md#Jcd.Math.Compare.InRange_T_(thisT,T,T).T 'Jcd.Math.Compare.InRange<T>(this T, T, T).T')

Start of the range to check

<a name='Jcd.Math.Compare.InRange_T_(thisT,T,T).end'></a>

`end` [T](Jcd.Math.Compare.InRange_T_(thisT,T,T).md#Jcd.Math.Compare.InRange_T_(thisT,T,T).T 'Jcd.Math.Compare.InRange<T>(this T, T, T).T')

End of the range to check.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the value is within the range.