#### [Jcd.Math](index.md 'index')
### [Jcd.Math](Jcd.Math.md 'Jcd.Math').[Comparer](Jcd.Math.Comparer.md 'Jcd.Math.Comparer')

## Comparer.Equals<T>(T, T) Method

Compares two IEquatable<T> values for equality

```csharp
public static bool Equals<T>(T x, T y)
    where T : System.IEquatable<T>;
```
#### Type parameters

<a name='Jcd.Math.Comparer.Equals_T_(T,T).T'></a>

`T`

The data type
#### Parameters

<a name='Jcd.Math.Comparer.Equals_T_(T,T).x'></a>

`x` [T](Jcd.Math.Comparer.Equals_T_(T,T).md#Jcd.Math.Comparer.Equals_T_(T,T).T 'Jcd.Math.Comparer.Equals<T>(T, T).T')

The first item to compare

<a name='Jcd.Math.Comparer.Equals_T_(T,T).y'></a>

`y` [T](Jcd.Math.Comparer.Equals_T_(T,T).md#Jcd.Math.Comparer.Equals_T_(T,T).T 'Jcd.Math.Comparer.Equals<T>(T, T).T')

The second item to compare

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if x == y; false otherwise