### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals')

## RangeExtensions Class

Provides IComparable<T> range (closed interval) comparison facilities.  
Use this if you need things to be as fast as possible.

```csharp
public static class RangeExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; RangeExtensions

| Methods | |
| :--- | :--- |
| [CompareToRange&lt;T&gt;(this T, T, T)](Jcd.Math.Intervals.RangeExtensions.CompareToRange_T_(thisT,T,T).md 'Jcd.Math.Intervals.RangeExtensions.CompareToRange<T>(this T, T, T)') | Determines if a value is less than the start (-1) of the<br/>closed interval [start,end], within the interval (0),<br/>or after the end of the interval (1) |
| [InRange&lt;T&gt;(this T, T, T)](Jcd.Math.Intervals.RangeExtensions.InRange_T_(thisT,T,T).md 'Jcd.Math.Intervals.RangeExtensions.InRange<T>(this T, T, T)') | Checks if a value is within a closed interval. (i.e. interval includes start and endpoints) |
