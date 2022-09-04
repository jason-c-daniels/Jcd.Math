### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval](Jcd.Math.Intervals.Interval.md 'Jcd.Math.Intervals.Interval')

## Interval.OpenClosed<T>(T, T) Method

Creates an open-closed interval: (openStart,closedEnd]  
(i.e. excludes openStart and includes closedEnd)

```csharp
public static Jcd.Math.Intervals.Interval<T> OpenClosed<T>(T openStart, T closedEnd)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='Jcd.Math.Intervals.Interval.OpenClosed_T_(T,T).T'></a>

`T`
#### Parameters

<a name='Jcd.Math.Intervals.Interval.OpenClosed_T_(T,T).openStart'></a>

`openStart` [T](Jcd.Math.Intervals.Interval.OpenClosed_T_(T,T).md#Jcd.Math.Intervals.Interval.OpenClosed_T_(T,T).T 'Jcd.Math.Intervals.Interval.OpenClosed<T>(T, T).T')

The exclusive start to the interval.

<a name='Jcd.Math.Intervals.Interval.OpenClosed_T_(T,T).closedEnd'></a>

`closedEnd` [T](Jcd.Math.Intervals.Interval.OpenClosed_T_(T,T).md#Jcd.Math.Intervals.Interval.OpenClosed_T_(T,T).T 'Jcd.Math.Intervals.Interval.OpenClosed<T>(T, T).T')

The inclusive end to the interval

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval.OpenClosed_T_(T,T).md#Jcd.Math.Intervals.Interval.OpenClosed_T_(T,T).T 'Jcd.Math.Intervals.Interval.OpenClosed<T>(T, T).T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval