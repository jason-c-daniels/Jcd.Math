#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[IntervalLimit](Jcd.Math.Intervals.IntervalLimit.md 'Jcd.Math.Intervals.IntervalLimit')

## IntervalLimit.OpenEnd<T>(T) Method

Creates an open end interval limit.  
In other words: creates an exclusive end limit.    
For example: ...,limit)

```csharp
public static Jcd.Math.Intervals.IntervalLimit<T> OpenEnd<T>(T limit)
    where T : System.IComparable<T>, System.IEquatable<T>;
```
#### Type parameters

<a name='Jcd.Math.Intervals.IntervalLimit.OpenEnd_T_(T).T'></a>

`T`
#### Parameters

<a name='Jcd.Math.Intervals.IntervalLimit.OpenEnd_T_(T).limit'></a>

`limit` [T](Jcd.Math.Intervals.IntervalLimit.OpenEnd_T_(T).md#Jcd.Math.Intervals.IntervalLimit.OpenEnd_T_(T).T 'Jcd.Math.Intervals.IntervalLimit.OpenEnd<T>(T).T')

#### Returns
[Jcd.Math.Intervals.IntervalLimit&lt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')[T](Jcd.Math.Intervals.IntervalLimit.OpenEnd_T_(T).md#Jcd.Math.Intervals.IntervalLimit.OpenEnd_T_(T).T 'Jcd.Math.Intervals.IntervalLimit.OpenEnd<T>(T).T')[&gt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')  
The new interval limit