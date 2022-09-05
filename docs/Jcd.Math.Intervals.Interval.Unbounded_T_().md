#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval](Jcd.Math.Intervals.Interval.md 'Jcd.Math.Intervals.Interval')

## Interval.Unbounded<T>() Method

Creates a completely unbounded interval. (-infinity, +infinity)  
(i.e. -infinity to +infinity - excluding the infinities, of course.)

```csharp
public static Jcd.Math.Intervals.Interval<T> Unbounded<T>()
    where T : System.IComparable<T>, System.IEquatable<T>;
```
#### Type parameters

<a name='Jcd.Math.Intervals.Interval.Unbounded_T_().T'></a>

`T`

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval.Unbounded_T_().md#Jcd.Math.Intervals.Interval.Unbounded_T_().T 'Jcd.Math.Intervals.Interval.Unbounded<T>().T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval