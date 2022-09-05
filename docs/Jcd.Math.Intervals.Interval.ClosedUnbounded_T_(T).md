### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval](Jcd.Math.Intervals.Interval.md 'Jcd.Math.Intervals.Interval')

## Interval.ClosedUnbounded<T>(T) Method

Creates a left-closed, right-unbounded interval: [closedStart, +infinity)  
(i.e. closedStart to +infinity - includes closedStart.)

```csharp
public static Jcd.Math.Intervals.Interval<T> ClosedUnbounded<T>(T closedStart)
    where T : System.IComparable<T>, System.IEquatable<T>;
```
#### Type parameters

<a name='Jcd.Math.Intervals.Interval.ClosedUnbounded_T_(T).T'></a>

`T`
#### Parameters

<a name='Jcd.Math.Intervals.Interval.ClosedUnbounded_T_(T).closedStart'></a>

`closedStart` [T](Jcd.Math.Intervals.Interval.ClosedUnbounded_T_(T).md#Jcd.Math.Intervals.Interval.ClosedUnbounded_T_(T).T 'Jcd.Math.Intervals.Interval.ClosedUnbounded<T>(T).T')

the inclusive start to the interval

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval.ClosedUnbounded_T_(T).md#Jcd.Math.Intervals.Interval.ClosedUnbounded_T_(T).T 'Jcd.Math.Intervals.Interval.ClosedUnbounded<T>(T).T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval