#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval&lt;T&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')

## Interval<T>.Create(IntervalLimit<T>, IntervalLimit<T>) Method

Creates an interval from two limits.

```csharp
public static Jcd.Math.Intervals.Interval<T> Create(Jcd.Math.Intervals.IntervalLimit<T> start, Jcd.Math.Intervals.IntervalLimit<T> end);
```
#### Parameters

<a name='Jcd.Math.Intervals.Interval_T_.Create(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).start'></a>

`start` [Jcd.Math.Intervals.IntervalLimit&lt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')[T](Jcd.Math.Intervals.Interval_T_.md#Jcd.Math.Intervals.Interval_T_.T 'Jcd.Math.Intervals.Interval<T>.T')[&gt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')

The starting limit for the interval

<a name='Jcd.Math.Intervals.Interval_T_.Create(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).end'></a>

`end` [Jcd.Math.Intervals.IntervalLimit&lt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')[T](Jcd.Math.Intervals.Interval_T_.md#Jcd.Math.Intervals.Interval_T_.T 'Jcd.Math.Intervals.Interval<T>.T')[&gt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')

The end limit for the interval

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval_T_.md#Jcd.Math.Intervals.Interval_T_.T 'Jcd.Math.Intervals.Interval<T>.T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval

### Remarks
Any limit type can be passed in. Their types are converted  
and all other attributes are preserved.