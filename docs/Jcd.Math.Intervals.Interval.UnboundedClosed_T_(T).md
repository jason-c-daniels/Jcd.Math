### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval](Jcd.Math.Intervals.Interval.md 'Jcd.Math.Intervals.Interval')

## Interval.UnboundedClosed<T>(T) Method

Creates a left-unbounded, right-closed interval: (-infinity, end]  
(i.e. -infinity to end - includes end.)

```csharp
public static Jcd.Math.Intervals.Interval<T> UnboundedClosed<T>(T end)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='Jcd.Math.Intervals.Interval.UnboundedClosed_T_(T).T'></a>

`T`
#### Parameters

<a name='Jcd.Math.Intervals.Interval.UnboundedClosed_T_(T).end'></a>

`end` [T](Jcd.Math.Intervals.Interval.UnboundedClosed_T_(T).md#Jcd.Math.Intervals.Interval.UnboundedClosed_T_(T).T 'Jcd.Math.Intervals.Interval.UnboundedClosed<T>(T).T')

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval.UnboundedClosed_T_(T).md#Jcd.Math.Intervals.Interval.UnboundedClosed_T_(T).T 'Jcd.Math.Intervals.Interval.UnboundedClosed<T>(T).T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval