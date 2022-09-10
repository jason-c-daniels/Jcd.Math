#### [Jcd.Math](index.md 'index')
### [Jcd.Math](Jcd.Math.md 'Jcd.Math').[Comparer](Jcd.Math.Comparer.md 'Jcd.Math.Comparer')

## Comparer.Min<T>(T, T, IComparer<T>) Method

Returns the lesser of two values for an IComparable<T>

```csharp
public static T Min<T>(T val1, T val2, System.Collections.Generic.IComparer<T> comparer)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='Jcd.Math.Comparer.Min_T_(T,T,System.Collections.Generic.IComparer_T_).T'></a>

`T`

The data type of the values.
#### Parameters

<a name='Jcd.Math.Comparer.Min_T_(T,T,System.Collections.Generic.IComparer_T_).val1'></a>

`val1` [T](Jcd.Math.Comparer.Min_T_(T,T,System.Collections.Generic.IComparer_T_).md#Jcd.Math.Comparer.Min_T_(T,T,System.Collections.Generic.IComparer_T_).T 'Jcd.Math.Comparer.Min<T>(T, T, System.Collections.Generic.IComparer<T>).T')

The first of two values to compare.

<a name='Jcd.Math.Comparer.Min_T_(T,T,System.Collections.Generic.IComparer_T_).val2'></a>

`val2` [T](Jcd.Math.Comparer.Min_T_(T,T,System.Collections.Generic.IComparer_T_).md#Jcd.Math.Comparer.Min_T_(T,T,System.Collections.Generic.IComparer_T_).T 'Jcd.Math.Comparer.Min<T>(T, T, System.Collections.Generic.IComparer<T>).T')

The second of two values to compare.

<a name='Jcd.Math.Comparer.Min_T_(T,T,System.Collections.Generic.IComparer_T_).comparer'></a>

`comparer` [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[T](Jcd.Math.Comparer.Min_T_(T,T,System.Collections.Generic.IComparer_T_).md#Jcd.Math.Comparer.Min_T_(T,T,System.Collections.Generic.IComparer_T_).T 'Jcd.Math.Comparer.Min<T>(T, T, System.Collections.Generic.IComparer<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')

A value comparer to use for the comparisons.

#### Returns
[T](Jcd.Math.Comparer.Min_T_(T,T,System.Collections.Generic.IComparer_T_).md#Jcd.Math.Comparer.Min_T_(T,T,System.Collections.Generic.IComparer_T_).T 'Jcd.Math.Comparer.Min<T>(T, T, System.Collections.Generic.IComparer<T>).T')  
The smaller of the two values. `val1` if equivalent.