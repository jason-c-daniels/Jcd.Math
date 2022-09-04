### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals')

## ComparableExtensions Class

Provides IComparable<T> range (closed interval) comparison facilities.  
Use this if you need things to be as fast as possible.

```csharp
public static class ComparableExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ComparableExtensions

| Methods | |
| :--- | :--- |
| [CompareToRange&lt;T&gt;(this T, T, T)](Jcd.Math.Intervals.ComparableExtensions.CompareToRange_T_(thisT,T,T).md 'Jcd.Math.Intervals.ComparableExtensions.CompareToRange<T>(this T, T, T)') | Determines if a value is less than the start (-1) of the<br/>closed interval [start,end], within the interval (0),<br/>or after the end of the interval (1) |
| [InRange&lt;T&gt;(this T, T, T)](Jcd.Math.Intervals.ComparableExtensions.InRange_T_(thisT,T,T).md 'Jcd.Math.Intervals.ComparableExtensions.InRange<T>(this T, T, T)') | Checks if a value is within a closed interval. (i.e. interval includes start and endpoints) |
