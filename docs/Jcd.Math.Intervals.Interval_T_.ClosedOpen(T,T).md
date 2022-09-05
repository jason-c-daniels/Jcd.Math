#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval&lt;T&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')

## Interval<T>.ClosedOpen(T, T) Method

Creates a closed-open interval: [openStart,closedEnd)  
(i.e. includes openStart and excludes closedEnd)

```csharp
public static Jcd.Math.Intervals.Interval<T> ClosedOpen(T closedStart, T openEnd);
```
#### Parameters

<a name='Jcd.Math.Intervals.Interval_T_.ClosedOpen(T,T).closedStart'></a>

`closedStart` [T](Jcd.Math.Intervals.Interval_T_.md#Jcd.Math.Intervals.Interval_T_.T 'Jcd.Math.Intervals.Interval<T>.T')

The inclusive starting point of the interval

<a name='Jcd.Math.Intervals.Interval_T_.ClosedOpen(T,T).openEnd'></a>

`openEnd` [T](Jcd.Math.Intervals.Interval_T_.md#Jcd.Math.Intervals.Interval_T_.T 'Jcd.Math.Intervals.Interval<T>.T')

The exclusive openEnd point of the interval.

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval_T_.md#Jcd.Math.Intervals.Interval_T_.T 'Jcd.Math.Intervals.Interval<T>.T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval