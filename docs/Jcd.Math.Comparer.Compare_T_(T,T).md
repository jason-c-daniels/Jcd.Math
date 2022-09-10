#### [Jcd.Math](index.md 'index')
### [Jcd.Math](Jcd.Math.md 'Jcd.Math').[Comparer](Jcd.Math.Comparer.md 'Jcd.Math.Comparer')

## Comparer.Compare<T>(T, T) Method

Compares two IComparable<T> values

```csharp
public static int Compare<T>(T x, T y)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='Jcd.Math.Comparer.Compare_T_(T,T).T'></a>

`T`

The data type
#### Parameters

<a name='Jcd.Math.Comparer.Compare_T_(T,T).x'></a>

`x` [T](Jcd.Math.Comparer.Compare_T_(T,T).md#Jcd.Math.Comparer.Compare_T_(T,T).T 'Jcd.Math.Comparer.Compare<T>(T, T).T')

The first item to compare

<a name='Jcd.Math.Comparer.Compare_T_(T,T).y'></a>

`y` [T](Jcd.Math.Comparer.Compare_T_(T,T).md#Jcd.Math.Comparer.Compare_T_(T,T).T 'Jcd.Math.Comparer.Compare<T>(T, T).T')

The second item to compare

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
*  0 when x == y  
* -1 when x lt; y  
*  1 when x gt; y