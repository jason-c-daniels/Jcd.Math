#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval](Jcd.Math.Intervals.Interval.md 'Jcd.Math.Intervals.Interval')

## Interval.Create<T>(IntervalLimit<T>, IntervalLimit<T>) Method

Creates an interval from two limits.

```csharp
public static Jcd.Math.Intervals.Interval<T> Create<T>(Jcd.Math.Intervals.IntervalLimit<T> start, Jcd.Math.Intervals.IntervalLimit<T> end)
    where T : System.IComparable<T>, System.IEquatable<T>;
```
#### Type parameters

<a name='Jcd.Math.Intervals.Interval.Create_T_(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).T'></a>

`T`
#### Parameters

<a name='Jcd.Math.Intervals.Interval.Create_T_(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).start'></a>

`start` [Jcd.Math.Intervals.IntervalLimit&lt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')[T](Jcd.Math.Intervals.Interval.Create_T_(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).md#Jcd.Math.Intervals.Interval.Create_T_(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).T 'Jcd.Math.Intervals.Interval.Create<T>(Jcd.Math.Intervals.IntervalLimit<T>, Jcd.Math.Intervals.IntervalLimit<T>).T')[&gt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')

The starting limit of the interval

<a name='Jcd.Math.Intervals.Interval.Create_T_(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).end'></a>

`end` [Jcd.Math.Intervals.IntervalLimit&lt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')[T](Jcd.Math.Intervals.Interval.Create_T_(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).md#Jcd.Math.Intervals.Interval.Create_T_(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).T 'Jcd.Math.Intervals.Interval.Create<T>(Jcd.Math.Intervals.IntervalLimit<T>, Jcd.Math.Intervals.IntervalLimit<T>).T')[&gt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')

The end limit of the interval

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval.Create_T_(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).md#Jcd.Math.Intervals.Interval.Create_T_(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).T 'Jcd.Math.Intervals.Interval.Create<T>(Jcd.Math.Intervals.IntervalLimit<T>, Jcd.Math.Intervals.IntervalLimit<T>).T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval