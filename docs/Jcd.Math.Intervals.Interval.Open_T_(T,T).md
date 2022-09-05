#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Interval](Jcd.Math.Intervals.Interval.md 'Jcd.Math.Intervals.Interval')

## Interval.Open<T>(T, T) Method

Creates an open interval: (openStart,openEnd)  
(i.e. excludes both openStart and openEnd)

```csharp
public static Jcd.Math.Intervals.Interval<T> Open<T>(T openStart, T openEnd)
    where T : System.IComparable<T>, System.IEquatable<T>;
```
#### Type parameters

<a name='Jcd.Math.Intervals.Interval.Open_T_(T,T).T'></a>

`T`
#### Parameters

<a name='Jcd.Math.Intervals.Interval.Open_T_(T,T).openStart'></a>

`openStart` [T](Jcd.Math.Intervals.Interval.Open_T_(T,T).md#Jcd.Math.Intervals.Interval.Open_T_(T,T).T 'Jcd.Math.Intervals.Interval.Open<T>(T, T).T')

The exclusive start to the interval.

<a name='Jcd.Math.Intervals.Interval.Open_T_(T,T).openEnd'></a>

`openEnd` [T](Jcd.Math.Intervals.Interval.Open_T_(T,T).md#Jcd.Math.Intervals.Interval.Open_T_(T,T).T 'Jcd.Math.Intervals.Interval.Open<T>(T, T).T')

The exclusive end to the interval

#### Returns
[Jcd.Math.Intervals.Interval&lt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')[T](Jcd.Math.Intervals.Interval.Open_T_(T,T).md#Jcd.Math.Intervals.Interval.Open_T_(T,T).T 'Jcd.Math.Intervals.Interval.Open<T>(T, T).T')[&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
The new interval