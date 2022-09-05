#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[IInterval&lt;T&gt;](Jcd.Math.Intervals.IInterval_T_.md 'Jcd.Math.Intervals.IInterval<T>')

## IInterval<T>.Contains(IInterval<T>) Method

Determines if this interval completely contains another.

```csharp
bool Contains(Jcd.Math.Intervals.IInterval<T> other);
```
#### Parameters

<a name='Jcd.Math.Intervals.IInterval_T_.Contains(Jcd.Math.Intervals.IInterval_T_).other'></a>

`other` [Jcd.Math.Intervals.IInterval&lt;](Jcd.Math.Intervals.IInterval_T_.md 'Jcd.Math.Intervals.IInterval<T>')[T](Jcd.Math.Intervals.IInterval_T_.md#Jcd.Math.Intervals.IInterval_T_.T 'Jcd.Math.Intervals.IInterval<T>.T')[&gt;](Jcd.Math.Intervals.IInterval_T_.md 'Jcd.Math.Intervals.IInterval<T>')

The interval being compared for containment within the current.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if this interval contains the other.