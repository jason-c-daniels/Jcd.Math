### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval](Jcd.Math.Intervals.Interval.md 'Jcd.Math.Intervals.Interval')

## Interval.OpenUnbounded<T>(T) Method

Creates a left-open, right-unbounded interval: (start, +infinity)  
(i.e. start to +infinity - excludes start.)

```csharp
public static Jcd.Math.Intervals.Interval<T> OpenUnbounded<T>(T start)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='Jcd.Math.Intervals.Interval.OpenUnbounded_T_(T).T'></a>

`T`
#### Parameters

<a name='Jcd.Math.Intervals.Interval.OpenUnbounded_T_(T).start'></a>

`start` [T](Jcd.Math.Intervals.Interval.OpenUnbounded_T_(T).md#Jcd.Math.Intervals.Interval.OpenUnbounded_T_(T).T 'Jcd.Math.Intervals.Interval.OpenUnbounded<T>(T).T')

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval.OpenUnbounded_T_(T).md#Jcd.Math.Intervals.Interval.OpenUnbounded_T_(T).T 'Jcd.Math.Intervals.Interval.OpenUnbounded<T>(T).T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval