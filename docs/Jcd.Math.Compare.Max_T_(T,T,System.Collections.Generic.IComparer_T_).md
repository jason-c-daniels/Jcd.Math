#### [Jcd.Math](index.md 'index')
### [Jcd.Math](Jcd.Math.md 'Jcd.Math').[Compare](Jcd.Math.Compare.md 'Jcd.Math.Compare')

## Compare.Max<T>(T, T, IComparer<T>) Method

Returns the greater of two values for an IComparable

```csharp
public static T Max<T>(T val1, T val2, System.Collections.Generic.IComparer<T> comparer)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='Jcd.Math.Compare.Max_T_(T,T,System.Collections.Generic.IComparer_T_).T'></a>

`T`

The data type of the values.
#### Parameters

<a name='Jcd.Math.Compare.Max_T_(T,T,System.Collections.Generic.IComparer_T_).val1'></a>

`val1` [T](Jcd.Math.Compare.Max_T_(T,T,System.Collections.Generic.IComparer_T_).md#Jcd.Math.Compare.Max_T_(T,T,System.Collections.Generic.IComparer_T_).T 'Jcd.Math.Compare.Max<T>(T, T, System.Collections.Generic.IComparer<T>).T')

The first of two values to compare.

<a name='Jcd.Math.Compare.Max_T_(T,T,System.Collections.Generic.IComparer_T_).val2'></a>

`val2` [T](Jcd.Math.Compare.Max_T_(T,T,System.Collections.Generic.IComparer_T_).md#Jcd.Math.Compare.Max_T_(T,T,System.Collections.Generic.IComparer_T_).T 'Jcd.Math.Compare.Max<T>(T, T, System.Collections.Generic.IComparer<T>).T')

The second of two values to compare.

<a name='Jcd.Math.Compare.Max_T_(T,T,System.Collections.Generic.IComparer_T_).comparer'></a>

`comparer` [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[T](Jcd.Math.Compare.Max_T_(T,T,System.Collections.Generic.IComparer_T_).md#Jcd.Math.Compare.Max_T_(T,T,System.Collections.Generic.IComparer_T_).T 'Jcd.Math.Compare.Max<T>(T, T, System.Collections.Generic.IComparer<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')

A value comparer to use for the comparisons.

#### Returns
[T](Jcd.Math.Compare.Max_T_(T,T,System.Collections.Generic.IComparer_T_).md#Jcd.Math.Compare.Max_T_(T,T,System.Collections.Generic.IComparer_T_).T 'Jcd.Math.Compare.Max<T>(T, T, System.Collections.Generic.IComparer<T>).T')  
The greater of the two values. `val1` if equivalent.