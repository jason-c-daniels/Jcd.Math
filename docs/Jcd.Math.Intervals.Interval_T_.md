### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals')

## Interval<T> Struct

Represents a mathematical interval whose limits can be any valid  
combination of Unbounded, Closed or Open.

```csharp
public readonly struct Interval<T> :
Jcd.Math.Intervals.IInterval<T>,
System.IEquatable<Jcd.Math.Intervals.IInterval<T>>
    where T : System.IComparable<T>
```
#### Type parameters

<a name='Jcd.Math.Intervals.Interval_T_.T'></a>

`T`

The underlying data type for the interval.

Implements [Jcd.Math.Intervals.IInterval&lt;](Jcd.Math.Intervals.IInterval_T_.md 'Jcd.Math.Intervals.IInterval<T>')[T](Jcd.Math.Intervals.Interval_T_.md#Jcd.Math.Intervals.Interval_T_.T 'Jcd.Math.Intervals.Interval<T>.T')[&gt;](Jcd.Math.Intervals.IInterval_T_.md 'Jcd.Math.Intervals.IInterval<T>'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Jcd.Math.Intervals.IInterval&lt;](Jcd.Math.Intervals.IInterval_T_.md 'Jcd.Math.Intervals.IInterval<T>')[T](Jcd.Math.Intervals.Interval_T_.md#Jcd.Math.Intervals.Interval_T_.T 'Jcd.Math.Intervals.Interval<T>.T')[&gt;](Jcd.Math.Intervals.IInterval_T_.md 'Jcd.Math.Intervals.IInterval<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Fields | |
| :--- | :--- |
| [Invalid](Jcd.Math.Intervals.Interval_T_.Invalid.md 'Jcd.Math.Intervals.Interval<T>.Invalid') | By default an uninitialized |

| Properties | |
| :--- | :--- |
| [End](Jcd.Math.Intervals.Interval_T_.End.md 'Jcd.Math.Intervals.Interval<T>.End') | The end of the interval. |
| [IsEmpty](Jcd.Math.Intervals.Interval_T_.IsEmpty.md 'Jcd.Math.Intervals.Interval<T>.IsEmpty') | Indicates if the interval is empty:<br/>0,0), (1,1) ...etc. are empty intervals. |
| [IsSingleValue](Jcd.Math.Intervals.Interval_T_.IsSingleValue.md 'Jcd.Math.Intervals.Interval<T>.IsSingleValue') | Indicates if the interval is empty:<br/>[0,0], [1,1] ...etc. are single value intervals. |
| [IsValid](Jcd.Math.Intervals.Interval_T_.IsValid.md 'Jcd.Math.Intervals.Interval<T>.IsValid') | Indicates if the interval was properly constructed. |
| [Start](Jcd.Math.Intervals.Interval_T_.Start.md 'Jcd.Math.Intervals.Interval<T>.Start') | The start of the interval. |

| Methods | |
| :--- | :--- |
| [Closed(T, T)](Jcd.Math.Intervals.Interval_T_.Closed(T,T).md 'Jcd.Math.Intervals.Interval<T>.Closed(T, T)') | Creates an closed interval: [start,end]<br/>(i.e. includes both start and end) |
| [ClosedOpen(T, T)](Jcd.Math.Intervals.Interval_T_.ClosedOpen(T,T).md 'Jcd.Math.Intervals.Interval<T>.ClosedOpen(T, T)') | Creates a closed-open interval: [start,end)<br/>(i.e. includes start and excludes end) |
| [ClosedUnbounded(T)](Jcd.Math.Intervals.Interval_T_.ClosedUnbounded(T).md 'Jcd.Math.Intervals.Interval<T>.ClosedUnbounded(T)') | Creates a left-closed, right-unbounded interval: [start, +infinity)<br/>(i.e. start to +infinity - includes start.) |
| [Contains(IInterval&lt;T&gt;)](Jcd.Math.Intervals.Interval_T_.Contains(Jcd.Math.Intervals.IInterval_T_).md 'Jcd.Math.Intervals.Interval<T>.Contains(Jcd.Math.Intervals.IInterval<T>)') | Determines if this interval completely contains another. |
| [Contains(T)](Jcd.Math.Intervals.Interval_T_.Contains(T).md 'Jcd.Math.Intervals.Interval<T>.Contains(T)') | Determines if the interval contains the provided point. |
| [Open(T, T)](Jcd.Math.Intervals.Interval_T_.Open(T,T).md 'Jcd.Math.Intervals.Interval<T>.Open(T, T)') | Creates an open interval: (start,end)<br/>(i.e. excludes both start and end) |
| [OpenClosed(T, T)](Jcd.Math.Intervals.Interval_T_.OpenClosed(T,T).md 'Jcd.Math.Intervals.Interval<T>.OpenClosed(T, T)') | Creates an open-closed interval: (start,end]<br/>(i.e. excludes start and includes end) |
| [OpenUnbounded(T)](Jcd.Math.Intervals.Interval_T_.OpenUnbounded(T).md 'Jcd.Math.Intervals.Interval<T>.OpenUnbounded(T)') | Creates a left-open, right-unbounded interval: (start, +infinity)<br/>(i.e. start to +infinity - excludes start.) |
| [Unbounded()](Jcd.Math.Intervals.Interval_T_.Unbounded().md 'Jcd.Math.Intervals.Interval<T>.Unbounded()') | Creates a completely unbounded interval. (-infinity, +infinity)<br/>(i.e. -infinity to +infinity - excluding the infinities, of course.) |
| [UnboundedClosed(T)](Jcd.Math.Intervals.Interval_T_.UnboundedClosed(T).md 'Jcd.Math.Intervals.Interval<T>.UnboundedClosed(T)') | Creates a left-unbounded, right-closed interval: (-infinity, end]<br/>(i.e. -infinity to end - includes end.) |
| [UnboundedOpen(T)](Jcd.Math.Intervals.Interval_T_.UnboundedOpen(T).md 'Jcd.Math.Intervals.Interval<T>.UnboundedOpen(T)') | Creates a left-unbounded, right-open interval: (-infinity, end)<br/>(i.e. -infinity to end - excludes end.) |
