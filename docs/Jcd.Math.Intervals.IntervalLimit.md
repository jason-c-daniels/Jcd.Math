#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals')

## IntervalLimit Class

Helper class to simplify the notation when creating an interval limit.

```csharp
public static class IntervalLimit
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IntervalLimit

| Methods | |
| :--- | :--- |
| [ClosedEnd&lt;T&gt;(T)](Jcd.Math.Intervals.IntervalLimit.ClosedEnd_T_(T).md 'Jcd.Math.Intervals.IntervalLimit.ClosedEnd<T>(T)') | Creates a closed end interval limit.<br/>In other words: creates an inclusive end limit.  <br/>For example: ...,limit] |
| [ClosedStart&lt;T&gt;(T)](Jcd.Math.Intervals.IntervalLimit.ClosedStart_T_(T).md 'Jcd.Math.Intervals.IntervalLimit.ClosedStart<T>(T)') | Creates a closed start interval limit.<br/>In other words: creates an inclusive start limit.  <br/>For example: [limit,... |
| [OpenEnd&lt;T&gt;(T)](Jcd.Math.Intervals.IntervalLimit.OpenEnd_T_(T).md 'Jcd.Math.Intervals.IntervalLimit.OpenEnd<T>(T)') | Creates an open end interval limit.<br/>In other words: creates an exclusive end limit.  <br/>For example: ...,limit) |
| [OpenStart&lt;T&gt;(T)](Jcd.Math.Intervals.IntervalLimit.OpenStart_T_(T).md 'Jcd.Math.Intervals.IntervalLimit.OpenStart<T>(T)') | Creates an open start interval limit.<br/>In other words: creates an exclusive start limit.  <br/>For example: (limit,... |
| [UnboundedEnd&lt;T&gt;()](Jcd.Math.Intervals.IntervalLimit.UnboundedEnd_T_().md 'Jcd.Math.Intervals.IntervalLimit.UnboundedEnd<T>()') | Creates an unbounded end interval limit.<br/>In other words: creates an exclusive infinite end limit.  <br/>For example: ...,+infinity) |
| [UnboundedStart&lt;T&gt;()](Jcd.Math.Intervals.IntervalLimit.UnboundedStart_T_().md 'Jcd.Math.Intervals.IntervalLimit.UnboundedStart<T>()') | Creates an unbounded start interval limit.<br/>In other words: creates an exclusive infinite start limit.  <br/>For example: (-infinity,... |
