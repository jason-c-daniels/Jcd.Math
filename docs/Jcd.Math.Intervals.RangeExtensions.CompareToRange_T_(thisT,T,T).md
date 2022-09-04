### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[RangeExtensions](Jcd.Math.Intervals.RangeExtensions.md 'Jcd.Math.Intervals.RangeExtensions')

## RangeExtensions.CompareToRange<T>(this T, T, T) Method

Determines if a value is less than the start (-1) of the  
closed interval [start,end], within the interval (0),  
or after the end of the interval (1)

```csharp
public static int CompareToRange<T>(this T value, T start, T end)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='Jcd.Math.Intervals.RangeExtensions.CompareToRange_T_(thisT,T,T).T'></a>

`T`

The data type being compared.
#### Parameters

<a name='Jcd.Math.Intervals.RangeExtensions.CompareToRange_T_(thisT,T,T).value'></a>

`value` [T](Jcd.Math.Intervals.RangeExtensions.CompareToRange_T_(thisT,T,T).md#Jcd.Math.Intervals.RangeExtensions.CompareToRange_T_(thisT,T,T).T 'Jcd.Math.Intervals.RangeExtensions.CompareToRange<T>(this T, T, T).T')

The value to compare

<a name='Jcd.Math.Intervals.RangeExtensions.CompareToRange_T_(thisT,T,T).start'></a>

`start` [T](Jcd.Math.Intervals.RangeExtensions.CompareToRange_T_(thisT,T,T).md#Jcd.Math.Intervals.RangeExtensions.CompareToRange_T_(thisT,T,T).T 'Jcd.Math.Intervals.RangeExtensions.CompareToRange<T>(this T, T, T).T')

Start of the range to check

<a name='Jcd.Math.Intervals.RangeExtensions.CompareToRange_T_(thisT,T,T).end'></a>

`end` [T](Jcd.Math.Intervals.RangeExtensions.CompareToRange_T_(thisT,T,T).md#Jcd.Math.Intervals.RangeExtensions.CompareToRange_T_(thisT,T,T).T 'Jcd.Math.Intervals.RangeExtensions.CompareToRange<T>(this T, T, T).T')

End of the range to check.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
-1, for less than, 0 for in range, 1 for greater than end.