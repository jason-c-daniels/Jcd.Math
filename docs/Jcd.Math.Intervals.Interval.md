#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals')

## Interval Class

A helper class to simplify the notation for creating intervals.

```csharp
public static class Interval
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Interval

| Methods | |
| :--- | :--- |
| [Closed&lt;T&gt;(T, T)](Jcd.Math.Intervals.Interval.Closed_T_(T,T).md 'Jcd.Math.Intervals.Interval.Closed<T>(T, T)') | Creates an closed interval: [closedStart,closedEnd]<br/>(i.e. includes both closedStart and closedEnd) |
| [ClosedOpen&lt;T&gt;(T, T)](Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).md 'Jcd.Math.Intervals.Interval.ClosedOpen<T>(T, T)') | Creates a closed-open interval: [closedStart,openEnd)<br/>(i.e. includes closedStart and excludes openEnd) |
| [ClosedUnbounded&lt;T&gt;(T)](Jcd.Math.Intervals.Interval.ClosedUnbounded_T_(T).md 'Jcd.Math.Intervals.Interval.ClosedUnbounded<T>(T)') | Creates a left-closed, right-unbounded interval: [closedStart, +infinity)<br/>(i.e. closedStart to +infinity - includes closedStart.) |
| [Create&lt;T&gt;(IntervalLimit&lt;T&gt;, IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.Interval.Create_T_(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.Interval.Create<T>(Jcd.Math.Intervals.IntervalLimit<T>, Jcd.Math.Intervals.IntervalLimit<T>)') | Creates an interval from two limits. |
| [Intersect&lt;T&gt;(this Interval&lt;T&gt;, Interval&lt;T&gt;)](Jcd.Math.Intervals.Interval.Intersect_T_(thisJcd.Math.Intervals.Interval_T_,Jcd.Math.Intervals.Interval_T_).md 'Jcd.Math.Intervals.Interval.Intersect<T>(this Jcd.Math.Intervals.Interval<T>, Jcd.Math.Intervals.Interval<T>)') | Creates the intersection of two intervals. |
| [Open&lt;T&gt;(T, T)](Jcd.Math.Intervals.Interval.Open_T_(T,T).md 'Jcd.Math.Intervals.Interval.Open<T>(T, T)') | Creates an open interval: (openStart,openEnd)<br/>(i.e. excludes both openStart and openEnd) |
| [OpenClosed&lt;T&gt;(T, T)](Jcd.Math.Intervals.Interval.OpenClosed_T_(T,T).md 'Jcd.Math.Intervals.Interval.OpenClosed<T>(T, T)') | Creates an open-closed interval: (openStart,closedEnd]<br/>(i.e. excludes openStart and includes closedEnd) |
| [OpenUnbounded&lt;T&gt;(T)](Jcd.Math.Intervals.Interval.OpenUnbounded_T_(T).md 'Jcd.Math.Intervals.Interval.OpenUnbounded<T>(T)') | Creates a left-open, right-unbounded interval: (openStart, +infinity)<br/>(i.e. openStart to +infinity - excludes openStart.) |
| [Unbounded&lt;T&gt;()](Jcd.Math.Intervals.Interval.Unbounded_T_().md 'Jcd.Math.Intervals.Interval.Unbounded<T>()') | Creates a completely unbounded interval. (-infinity, +infinity)<br/>(i.e. -infinity to +infinity - excluding the infinities, of course.) |
| [UnboundedClosed&lt;T&gt;(T)](Jcd.Math.Intervals.Interval.UnboundedClosed_T_(T).md 'Jcd.Math.Intervals.Interval.UnboundedClosed<T>(T)') | Creates a left-unbounded, right-closed interval: (-infinity, closedEnd]<br/>(i.e. -infinity to closedEnd - includes closedEnd.) |
| [UnboundedOpen&lt;T&gt;(T)](Jcd.Math.Intervals.Interval.UnboundedOpen_T_(T).md 'Jcd.Math.Intervals.Interval.UnboundedOpen<T>(T)') | Creates a left-unbounded, right-open interval: (-infinity, openEnd)<br/>(i.e. -infinity to openEnd - excludes openEnd.) |
