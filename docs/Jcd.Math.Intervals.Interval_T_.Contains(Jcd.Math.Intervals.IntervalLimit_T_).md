#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval&lt;T&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')

## Interval<T>.Contains(IntervalLimit<T>) Method

Determines if the interval contains the value represented by limit.  
(e.g. A left-unbounded interval will contain any discrete value less  
than or equal to the end of the interval.)

```csharp
public bool Contains(Jcd.Math.Intervals.IntervalLimit<T> limit);
```
#### Parameters

<a name='Jcd.Math.Intervals.Interval_T_.Contains(Jcd.Math.Intervals.IntervalLimit_T_).limit'></a>

`limit` [Jcd.Math.Intervals.IntervalLimit&lt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')[T](Jcd.Math.Intervals.Interval_T_.md#Jcd.Math.Intervals.Interval_T_.T 'Jcd.Math.Intervals.Interval<T>.T')[&gt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')

The limit to inspect.

Implements [Contains(IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IInterval_T_.Contains(Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IInterval<T>.Contains(Jcd.Math.Intervals.IntervalLimit<T>)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the interval contains the limit.