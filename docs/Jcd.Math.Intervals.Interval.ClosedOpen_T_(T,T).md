### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval](Jcd.Math.Intervals.Interval.md 'Jcd.Math.Intervals.Interval')

## Interval.ClosedOpen<T>(T, T) Method

Creates a closed-open interval: [start,end)  
(i.e. includes start and excludes end)

```csharp
public static Jcd.Math.Intervals.Interval<T> ClosedOpen<T>(T start, T end)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).T'></a>

`T`
#### Parameters

<a name='Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).start'></a>

`start` [T](Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).md#Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).T 'Jcd.Math.Intervals.Interval.ClosedOpen<T>(T, T).T')

<a name='Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).end'></a>

`end` [T](Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).md#Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).T 'Jcd.Math.Intervals.Interval.ClosedOpen<T>(T, T).T')

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).md#Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).T 'Jcd.Math.Intervals.Interval.ClosedOpen<T>(T, T).T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval