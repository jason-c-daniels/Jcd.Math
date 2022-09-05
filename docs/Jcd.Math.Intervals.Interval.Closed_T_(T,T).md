### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval](Jcd.Math.Intervals.Interval.md 'Jcd.Math.Intervals.Interval')

## Interval.Closed<T>(T, T) Method

Creates an closed interval: [closedStart,closedEnd]  
(i.e. includes both closedStart and closedEnd)

```csharp
public static Jcd.Math.Intervals.Interval<T> Closed<T>(T closedStart, T closedEnd)
    where T : System.IComparable<T>, System.IEquatable<T>;
```
#### Type parameters

<a name='Jcd.Math.Intervals.Interval.Closed_T_(T,T).T'></a>

`T`
#### Parameters

<a name='Jcd.Math.Intervals.Interval.Closed_T_(T,T).closedStart'></a>

`closedStart` [T](Jcd.Math.Intervals.Interval.Closed_T_(T,T).md#Jcd.Math.Intervals.Interval.Closed_T_(T,T).T 'Jcd.Math.Intervals.Interval.Closed<T>(T, T).T')

the inclusive start to the interval

<a name='Jcd.Math.Intervals.Interval.Closed_T_(T,T).closedEnd'></a>

`closedEnd` [T](Jcd.Math.Intervals.Interval.Closed_T_(T,T).md#Jcd.Math.Intervals.Interval.Closed_T_(T,T).T 'Jcd.Math.Intervals.Interval.Closed<T>(T, T).T')

The inclusive end to the interval

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval.Closed_T_(T,T).md#Jcd.Math.Intervals.Interval.Closed_T_(T,T).T 'Jcd.Math.Intervals.Interval.Closed<T>(T, T).T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval