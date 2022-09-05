#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval&lt;T&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')

## Interval<T>.Contains(IInterval<T>) Method

Returns true if this interval completely contains the provided interval.

```csharp
public bool Contains(Jcd.Math.Intervals.IInterval<T> other);
```
#### Parameters

<a name='Jcd.Math.Intervals.Interval_T_.Contains(Jcd.Math.Intervals.IInterval_T_).other'></a>

`other` [Jcd.Math.Intervals.IInterval&lt;](Jcd.Math.Intervals.IInterval_T_.md 'Jcd.Math.Intervals.IInterval<T>')[T](Jcd.Math.Intervals.Interval_T_.md#Jcd.Math.Intervals.Interval_T_.T 'Jcd.Math.Intervals.Interval<T>.T')[&gt;](Jcd.Math.Intervals.IInterval_T_.md 'Jcd.Math.Intervals.IInterval<T>')

The interval being compared for containment within the current.

Implements [Contains(IInterval&lt;T&gt;)](Jcd.Math.Intervals.IInterval_T_.Contains(Jcd.Math.Intervals.IInterval_T_).md 'Jcd.Math.Intervals.IInterval<T>.Contains(Jcd.Math.Intervals.IInterval<T>)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if this interval contains both endpoints of `other`.