#### [Jcd.Math](index.md 'index')
### [Jcd.Math](Jcd.Math.md 'Jcd.Math').[Compare](Jcd.Math.Compare.md 'Jcd.Math.Compare')

## Compare.Clamp<T>(T, T, T) Method

Returns a `value` clamped to the inclusive range of `min` and `max`.

```csharp
public static T Clamp<T>(T value, T min, T max)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='Jcd.Math.Compare.Clamp_T_(T,T,T).T'></a>

`T`

The data type.
#### Parameters

<a name='Jcd.Math.Compare.Clamp_T_(T,T,T).value'></a>

`value` [T](Jcd.Math.Compare.Clamp_T_(T,T,T).md#Jcd.Math.Compare.Clamp_T_(T,T,T).T 'Jcd.Math.Compare.Clamp<T>(T, T, T).T')

The value to be clamped.

<a name='Jcd.Math.Compare.Clamp_T_(T,T,T).min'></a>

`min` [T](Jcd.Math.Compare.Clamp_T_(T,T,T).md#Jcd.Math.Compare.Clamp_T_(T,T,T).T 'Jcd.Math.Compare.Clamp<T>(T, T, T).T')

The lower bounds of the result.

<a name='Jcd.Math.Compare.Clamp_T_(T,T,T).max'></a>

`max` [T](Jcd.Math.Compare.Clamp_T_(T,T,T).md#Jcd.Math.Compare.Clamp_T_(T,T,T).T 'Jcd.Math.Compare.Clamp<T>(T, T, T).T')

The upper bounds of the result.

#### Returns
[T](Jcd.Math.Compare.Clamp_T_(T,T,T).md#Jcd.Math.Compare.Clamp_T_(T,T,T).T 'Jcd.Math.Compare.Clamp<T>(T, T, T).T')  
- `min` : when `value` < `min`.  
  
- `max` : when `value` > `max`.  
  
- `value` : when `min` ≤ `value` ≤ `max`.