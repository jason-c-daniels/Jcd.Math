#### [Jcd.Math](index.md 'index')
### [Jcd.Math](Jcd.Math.md 'Jcd.Math')

## Compare Class

1. A set of upcoming C# features:  
   Generic `Min`, `Max`, and `Clamp`. Once MS has implemented these  
   (C# 11, .NET7?) they will be off of the Math. class.  
  
2. Some custom extension methods that everyone seems to have to  
   create, despite well known algorithms.

```csharp
public static class Compare
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Compare

| Methods | |
| :--- | :--- |
| [Clamp&lt;T&gt;(T, T, T, IComparer&lt;T&gt;)](Jcd.Math.Compare.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).md 'Jcd.Math.Compare.Clamp<T>(T, T, T, System.Collections.Generic.IComparer<T>)') | Clamps a value to the specified range. |
| [Clamp&lt;T&gt;(T, T, T)](Jcd.Math.Compare.Clamp_T_(T,T,T).md 'Jcd.Math.Compare.Clamp<T>(T, T, T)') | Returns a `value` clamped to the inclusive range of `min` and `max`. |
| [CompareToRange&lt;T&gt;(this T, T, T)](Jcd.Math.Compare.CompareToRange_T_(thisT,T,T).md 'Jcd.Math.Compare.CompareToRange<T>(this T, T, T)') | Determines if a value is less than the start (-1) of the<br/>closed interval [start,end], within the interval (0),<br/>or after the end of the interval (1) |
| [InRange&lt;T&gt;(this T, T, T)](Jcd.Math.Compare.InRange_T_(thisT,T,T).md 'Jcd.Math.Compare.InRange<T>(this T, T, T)') | Checks if a value is within a closed interval. (i.e. interval includes start and endpoints) |
| [Max&lt;T&gt;(T, T, IComparer&lt;T&gt;)](Jcd.Math.Compare.Max_T_(T,T,System.Collections.Generic.IComparer_T_).md 'Jcd.Math.Compare.Max<T>(T, T, System.Collections.Generic.IComparer<T>)') | Returns the greater of two values for an IComparable |
| [Max&lt;T&gt;(T, T)](Jcd.Math.Compare.Max_T_(T,T).md 'Jcd.Math.Compare.Max<T>(T, T)') | Returns the greater of two values for an IComparable |
| [Min&lt;T&gt;(T, T, IComparer&lt;T&gt;)](Jcd.Math.Compare.Min_T_(T,T,System.Collections.Generic.IComparer_T_).md 'Jcd.Math.Compare.Min<T>(T, T, System.Collections.Generic.IComparer<T>)') | Returns the lesser of two values for an IComparable |
| [Min&lt;T&gt;(T, T)](Jcd.Math.Compare.Min_T_(T,T).md 'Jcd.Math.Compare.Min<T>(T, T)') | Returns the lesser of two values for an IComparable |
