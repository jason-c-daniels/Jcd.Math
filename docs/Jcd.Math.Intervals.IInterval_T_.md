### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals')

## IInterval<T> Interface

Defines the operations and properties needed to create an interval.

```csharp
public interface IInterval<T> :
System.IEquatable<Jcd.Math.Intervals.IInterval<T>>
    where T : System.IComparable<T>
```
#### Type parameters

<a name='Jcd.Math.Intervals.IInterval_T_.T'></a>

`T`

The underlying data type for the interval.

Derived  
&#8627; [Interval&lt;T&gt;](Jcd.Math.Intervals.Interval_T_.md 'Jcd.Math.Intervals.Interval<T>')  
&#8627; [Range&lt;T&gt;](Jcd.Math.Intervals.Range_T_.md 'Jcd.Math.Intervals.Range<T>')

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Jcd.Math.Intervals.IInterval&lt;](Jcd.Math.Intervals.IInterval_T_.md 'Jcd.Math.Intervals.IInterval<T>')[T](Jcd.Math.Intervals.IInterval_T_.md#Jcd.Math.Intervals.IInterval_T_.T 'Jcd.Math.Intervals.IInterval<T>.T')[&gt;](Jcd.Math.Intervals.IInterval_T_.md 'Jcd.Math.Intervals.IInterval<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Properties | |
| :--- | :--- |
| [End](Jcd.Math.Intervals.IInterval_T_.End.md 'Jcd.Math.Intervals.IInterval<T>.End') | The end of the interval. |
| [IsEmpty](Jcd.Math.Intervals.IInterval_T_.IsEmpty.md 'Jcd.Math.Intervals.IInterval<T>.IsEmpty') | Indicates if the interval is empty:<br/>0,0), (1,1) ...etc. are empty intervals. |
| [IsSingleValue](Jcd.Math.Intervals.IInterval_T_.IsSingleValue.md 'Jcd.Math.Intervals.IInterval<T>.IsSingleValue') | Indicates if the interval is empty:<br/>[0,0], [1,1] ...etc. are single value intervals. |
| [IsValid](Jcd.Math.Intervals.IInterval_T_.IsValid.md 'Jcd.Math.Intervals.IInterval<T>.IsValid') | Indicates if the interval was properly constructed. |
| [Start](Jcd.Math.Intervals.IInterval_T_.Start.md 'Jcd.Math.Intervals.IInterval<T>.Start') | The start of the interval. |

| Methods | |
| :--- | :--- |
| [Contains(IInterval&lt;T&gt;)](Jcd.Math.Intervals.IInterval_T_.Contains(Jcd.Math.Intervals.IInterval_T_).md 'Jcd.Math.Intervals.IInterval<T>.Contains(Jcd.Math.Intervals.IInterval<T>)') | Determines if this interval completely contains another. |
| [Contains(T)](Jcd.Math.Intervals.IInterval_T_.Contains(T).md 'Jcd.Math.Intervals.IInterval<T>.Contains(T)') | Determines if the interval contains the provided point. |
