#### [Jcd.Math](index.md 'index')
### [Jcd.Math](Jcd.Math.md 'Jcd.Math').[Compare](Jcd.Math.Compare.md 'Jcd.Math.Compare')

## Compare.Min<T>(T, T) Method

Returns the lesser of two values for an IComparable<T>

```csharp
public static T Min<T>(T val1, T val2)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='Jcd.Math.Compare.Min_T_(T,T).T'></a>

`T`

The data type of the values.
#### Parameters

<a name='Jcd.Math.Compare.Min_T_(T,T).val1'></a>

`val1` [T](Jcd.Math.Compare.Min_T_(T,T).md#Jcd.Math.Compare.Min_T_(T,T).T 'Jcd.Math.Compare.Min<T>(T, T).T')

The first of two values to compare.

<a name='Jcd.Math.Compare.Min_T_(T,T).val2'></a>

`val2` [T](Jcd.Math.Compare.Min_T_(T,T).md#Jcd.Math.Compare.Min_T_(T,T).T 'Jcd.Math.Compare.Min<T>(T, T).T')

The second of two values to compare.

#### Returns
[T](Jcd.Math.Compare.Min_T_(T,T).md#Jcd.Math.Compare.Min_T_(T,T).T 'Jcd.Math.Compare.Min<T>(T, T).T')  
The smaller of the two values. `val1` if equivalent.