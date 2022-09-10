#### [Jcd.Math](index.md 'index')
### [Jcd.Math](Jcd.Math.md 'Jcd.Math')

## Comparer Class

A comparison class that provides:  
1. A set of upcoming C# features:  
   Generic `Min`, `Max`, and `Clamp`. Once MS has implemented these  
   (C# 11, .NET7?) they will be off of the Math. class.  
  
2. Some custom extension methods that everyone seems to have to  
   create, despite well known algorithms.  
   (InRange and CompareToRange, T1 Compare<T2> where T1 : IComparable<T2>...etc)

```csharp
public static class Comparer
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Comparer

| Methods | |
| :--- | :--- |
| [Clamp&lt;T&gt;(T, T, T, IComparer&lt;T&gt;)](Jcd.Math.Comparer.Clamp_T_(T,T,T,System.Collections.Generic.IComparer_T_).md 'Jcd.Math.Comparer.Clamp<T>(T, T, T, System.Collections.Generic.IComparer<T>)') | Clamps a value to the specified range. |
| [Clamp&lt;T&gt;(T, T, T)](Jcd.Math.Comparer.Clamp_T_(T,T,T).md 'Jcd.Math.Comparer.Clamp<T>(T, T, T)') | Returns a `value` clamped to the inclusive range of `min` and `max`. |
| [Compare&lt;T&gt;(T, T)](Jcd.Math.Comparer.Compare_T_(T,T).md 'Jcd.Math.Comparer.Compare<T>(T, T)') | Compares two IComparable<T> values |
| [Compare&lt;TX,TY&gt;(TX, TY)](Jcd.Math.Comparer.Compare_TX,TY_(TX,TY).md 'Jcd.Math.Comparer.Compare<TX,TY>(TX, TY)') | Compares two values of disparate types. |
| [Equals&lt;T&gt;(T, T)](Jcd.Math.Comparer.Equals_T_(T,T).md 'Jcd.Math.Comparer.Equals<T>(T, T)') | Compares two IEquatable<T> values for equality |
| [Equals&lt;TX,TY&gt;(TX, TY)](Jcd.Math.Comparer.Equals_TX,TY_(TX,TY).md 'Jcd.Math.Comparer.Equals<TX,TY>(TX, TY)') | Compares two values of disparate types. |
| [InRange&lt;T&gt;(this T, T, T)](Jcd.Math.Comparer.InRange_T_(thisT,T,T).md 'Jcd.Math.Comparer.InRange<T>(this T, T, T)') | Checks if a value is within a closed interval. (i.e. interval includes start and endpoints) |
| [Max&lt;T&gt;(T, T, IComparer&lt;T&gt;)](Jcd.Math.Comparer.Max_T_(T,T,System.Collections.Generic.IComparer_T_).md 'Jcd.Math.Comparer.Max<T>(T, T, System.Collections.Generic.IComparer<T>)') | Returns the greater of two values for an IComparable<T> |
| [Max&lt;T&gt;(T, T)](Jcd.Math.Comparer.Max_T_(T,T).md 'Jcd.Math.Comparer.Max<T>(T, T)') | Returns the greater of two values for an IComparable<T> |
| [Min&lt;T&gt;(T, T, IComparer&lt;T&gt;)](Jcd.Math.Comparer.Min_T_(T,T,System.Collections.Generic.IComparer_T_).md 'Jcd.Math.Comparer.Min<T>(T, T, System.Collections.Generic.IComparer<T>)') | Returns the lesser of two values for an IComparable<T> |
| [Min&lt;T&gt;(T, T)](Jcd.Math.Comparer.Min_T_(T,T).md 'Jcd.Math.Comparer.Min<T>(T, T)') | Returns the lesser of two values for an IComparable<T> |
| [ToRange&lt;T&gt;(this T, T, T)](Jcd.Math.Comparer.ToRange_T_(thisT,T,T).md 'Jcd.Math.Comparer.ToRange<T>(this T, T, T)') | Determines if a value is less than the start (-1) of the<br/>closed interval [start,end], within the interval (0),<br/>or after the end of the interval (1) |
