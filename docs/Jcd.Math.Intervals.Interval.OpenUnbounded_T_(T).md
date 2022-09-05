#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval](Jcd.Math.Intervals.Interval.md 'Jcd.Math.Intervals.Interval')

## Interval.OpenUnbounded<T>(T) Method

Creates a left-open, right-unbounded interval: (openStart, +infinity)  
(i.e. openStart to +infinity - excludes openStart.)

```csharp
public static Jcd.Math.Intervals.Interval<T> OpenUnbounded<T>(T openStart)
    where T : System.IComparable<T>, System.IEquatable<T>;
```
#### Type parameters

<a name='Jcd.Math.Intervals.Interval.OpenUnbounded_T_(T).T'></a>

`T`
#### Parameters

<a name='Jcd.Math.Intervals.Interval.OpenUnbounded_T_(T).openStart'></a>

`openStart` [T](Jcd.Math.Intervals.Interval.OpenUnbounded_T_(T).md#Jcd.Math.Intervals.Interval.OpenUnbounded_T_(T).T 'Jcd.Math.Intervals.Interval.OpenUnbounded<T>(T).T')

The exclusive start to the interval.

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval.OpenUnbounded_T_(T).md#Jcd.Math.Intervals.Interval.OpenUnbounded_T_(T).T 'Jcd.Math.Intervals.Interval.OpenUnbounded<T>(T).T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval