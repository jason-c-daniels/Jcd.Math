### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval&lt;T&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')

## Interval<T>.OpenClosed(T, T) Method

Creates an open-closed interval: (openStart,closedEnd]  
(i.e. excludes openStart and includes closedEnd)

```csharp
public static Jcd.Math.Intervals.Interval<T> OpenClosed(T openStart, T closedEnd);
```
#### Parameters

<a name='Jcd.Math.Intervals.Interval_T_.OpenClosed(T,T).openStart'></a>

`openStart` [T](Jcd.Math.Intervals.Interval_T_.md#Jcd.Math.Intervals.Interval_T_.T 'Jcd.Math.Intervals.Interval<T>.T')

The exclusive starting point of the interval

<a name='Jcd.Math.Intervals.Interval_T_.OpenClosed(T,T).closedEnd'></a>

`closedEnd` [T](Jcd.Math.Intervals.Interval_T_.md#Jcd.Math.Intervals.Interval_T_.T 'Jcd.Math.Intervals.Interval<T>.T')

The inclusive openEnd point of the interval

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval_T_.md#Jcd.Math.Intervals.Interval_T_.T 'Jcd.Math.Intervals.Interval<T>.T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval