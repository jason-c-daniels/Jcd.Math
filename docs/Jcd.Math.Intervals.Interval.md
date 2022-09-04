### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals')

## Interval Class

A helper class to simplify the notation for creating intervals.

```csharp
public static class Interval
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Interval

| Methods | |
| :--- | :--- |
| [Closed&lt;T&gt;(T, T)](Jcd.Math.Intervals.Interval.Closed_T_(T,T).md 'Jcd.Math.Intervals.Interval.Closed<T>(T, T)') | Creates an closed interval: [start,end]<br/>(i.e. includes both start and end) |
| [ClosedOpen&lt;T&gt;(T, T)](Jcd.Math.Intervals.Interval.ClosedOpen_T_(T,T).md 'Jcd.Math.Intervals.Interval.ClosedOpen<T>(T, T)') | Creates a closed-open interval: [start,end)<br/>(i.e. includes start and excludes end) |
| [ClosedUnbounded&lt;T&gt;(T)](Jcd.Math.Intervals.Interval.ClosedUnbounded_T_(T).md 'Jcd.Math.Intervals.Interval.ClosedUnbounded<T>(T)') | Creates a left-closed, right-unbounded interval: [start, +infinity)<br/>(i.e. start to +infinity - includes start.) |
| [Open&lt;T&gt;(T, T)](Jcd.Math.Intervals.Interval.Open_T_(T,T).md 'Jcd.Math.Intervals.Interval.Open<T>(T, T)') | Creates an open interval: (start,end)<br/>(i.e. excludes both start and end) |
| [OpenClosed&lt;T&gt;(T, T)](Jcd.Math.Intervals.Interval.OpenClosed_T_(T,T).md 'Jcd.Math.Intervals.Interval.OpenClosed<T>(T, T)') | Creates an open-closed interval: (start,end]<br/>(i.e. excludes start and includes end) |
| [OpenUnbounded&lt;T&gt;(T)](Jcd.Math.Intervals.Interval.OpenUnbounded_T_(T).md 'Jcd.Math.Intervals.Interval.OpenUnbounded<T>(T)') | Creates a left-open, right-unbounded interval: (start, +infinity)<br/>(i.e. start to +infinity - excludes start.) |
| [Unbounded&lt;T&gt;()](Jcd.Math.Intervals.Interval.Unbounded_T_().md 'Jcd.Math.Intervals.Interval.Unbounded<T>()') | Creates a completely unbounded interval. (-infinity, +infinity)<br/>(i.e. -infinity to +infinity - excluding the infinities, of course.) |
| [UnboundedClosed&lt;T&gt;(T)](Jcd.Math.Intervals.Interval.UnboundedClosed_T_(T).md 'Jcd.Math.Intervals.Interval.UnboundedClosed<T>(T)') | Creates a left-unbounded, right-closed interval: (-infinity, end]<br/>(i.e. -infinity to end - includes end.) |
| [UnboundedOpen&lt;T&gt;(T)](Jcd.Math.Intervals.Interval.UnboundedOpen_T_(T).md 'Jcd.Math.Intervals.Interval.UnboundedOpen<T>(T)') | Creates a left-unbounded, right-open interval: (-infinity, end)<br/>(i.e. -infinity to end - excludes end.) |
