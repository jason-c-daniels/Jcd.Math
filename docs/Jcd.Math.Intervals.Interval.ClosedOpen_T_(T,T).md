### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval](Jcd.Math.Intervals.Interval.md 'Jcd.Math.Intervals.Interval')

## Interval.ClosedOpen<T>(T, T) Method

Creates a closed-open interval: [closedStart,openEnd)  
(i.e. includes closedStart and excludes openEnd)

```csharp
public static Jcd.Math.Intervals.Interval<T> ClosedOpen<T>(T closedStart, T openEnd)
    where T : System.IComparable<T>, System.IEquatable<T>;
```
#### Type parameters

<a name='Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).T'></a>

`T`
#### Parameters

<a name='Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).closedStart'></a>

`closedStart` [T](Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).md#Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).T 'Jcd.Math.Intervals.Interval.ClosedOpen<T>(T, T).T')

the inclusive start to the interval

<a name='Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).openEnd'></a>

`openEnd` [T](Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).md#Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).T 'Jcd.Math.Intervals.Interval.ClosedOpen<T>(T, T).T')

The exclusive end to the interval

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).md#Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).T 'Jcd.Math.Intervals.Interval.ClosedOpen<T>(T, T).T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval