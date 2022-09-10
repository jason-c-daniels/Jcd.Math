#### [Jcd.Math](index.md 'index')
### [Jcd.Math](Jcd.Math.md 'Jcd.Math').[Comparer](Jcd.Math.Comparer.md 'Jcd.Math.Comparer')

## Comparer.Clamp<T>(T, T, T, IComparer<T>) Method

Clamps a value to the specified range.

```csharp
public static T Clamp<T>(T value, T min, T max, System.Collections.Generic.IComparer<T> comparer)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).T'></a>

`T`

The data type.
#### Parameters

<a name='Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).value'></a>

`value` [T](Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).md#Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).T 'Jcd.Math.Comparer.Clamp<T>(T, T, T, System.Collections.Generic.IComparer<T>).T')

The value to clamp.

<a name='Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).min'></a>

`min` [T](Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).md#Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).T 'Jcd.Math.Comparer.Clamp<T>(T, T, T, System.Collections.Generic.IComparer<T>).T')

The minimum value for the range.

<a name='Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).max'></a>

`max` [T](Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).md#Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).T 'Jcd.Math.Comparer.Clamp<T>(T, T, T, System.Collections.Generic.IComparer<T>).T')

The maximum value for the range.

<a name='Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).comparer'></a>

`comparer` [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[T](Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).md#Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).T 'Jcd.Math.Comparer.Clamp<T>(T, T, T, System.Collections.Generic.IComparer<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')

The value comparer

#### Returns
[T](Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).md#Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).T 'Jcd.Math.Comparer.Clamp<T>(T, T, T, System.Collections.Generic.IComparer<T>).T')  
- min if value less than min,  
- max if value greater than max,  
- value otherwise.