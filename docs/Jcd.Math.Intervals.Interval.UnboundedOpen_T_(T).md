#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval](Jcd.Math.Intervals.Interval.md 'Jcd.Math.Intervals.Interval')

## Interval.UnboundedOpen<T>(T) Method

Creates a left-unbounded, right-open interval: (-infinity, openEnd)  
(i.e. -infinity to openEnd - excludes openEnd.)

```csharp
public static Jcd.Math.Intervals.Interval<T> UnboundedOpen<T>(T openEnd)
    where T : System.IComparable<T>, System.IEquatable<T>;
```
#### Type parameters

<a name='Jcd.Math.Intervals.Interval.UnboundedOpen_T_(T).T'></a>

`T`
#### Parameters

<a name='Jcd.Math.Intervals.Interval.UnboundedOpen_T_(T).openEnd'></a>

`openEnd` [T](Jcd.Math.Intervals.Interval.UnboundedOpen_T_(T).md#Jcd.Math.Intervals.Interval.UnboundedOpen_T_(T).T 'Jcd.Math.Intervals.Interval.UnboundedOpen<T>(T).T')

The exclusive end to the interval

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval.UnboundedOpen_T_(T).md#Jcd.Math.Intervals.Interval.UnboundedOpen_T_(T).T 'Jcd.Math.Intervals.Interval.UnboundedOpen<T>(T).T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval