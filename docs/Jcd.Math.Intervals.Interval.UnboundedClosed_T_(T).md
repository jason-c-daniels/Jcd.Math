### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval](Jcd.Math.Intervals.Interval.md 'Jcd.Math.Intervals.Interval')

## Interval.UnboundedClosed<T>(T) Method

Creates a left-unbounded, right-closed interval: (-infinity, closedEnd]  
(i.e. -infinity to closedEnd - includes closedEnd.)

```csharp
public static Jcd.Math.Intervals.Interval<T> UnboundedClosed<T>(T closedEnd)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='Jcd.Math.Intervals.Interval.UnboundedClosed_T_(T).T'></a>

`T`
#### Parameters

<a name='Jcd.Math.Intervals.Interval.UnboundedClosed_T_(T).closedEnd'></a>

`closedEnd` [T](Jcd.Math.Intervals.Interval.UnboundedClosed_T_(T).md#Jcd.Math.Intervals.Interval.UnboundedClosed_T_(T).T 'Jcd.Math.Intervals.Interval.UnboundedClosed<T>(T).T')

The inclusive end to the interval

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval.UnboundedClosed_T_(T).md#Jcd.Math.Intervals.Interval.UnboundedClosed_T_(T).T 'Jcd.Math.Intervals.Interval.UnboundedClosed<T>(T).T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval