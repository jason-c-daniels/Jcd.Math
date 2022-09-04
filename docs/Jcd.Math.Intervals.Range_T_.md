### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals')

## Range<T> Struct

A specialization of Interval that represents a closed interval [start,end]  
(i.e. an interval that contains the start and end points)

```csharp
public readonly struct Range<T> :
Jcd.Math.Intervals.IInterval<T>,
System.IEquatable<Jcd.Math.Intervals.IInterval<T>>
    where T : System.IComparable<T>
```
#### Type parameters

<a name='Jcd.Math.Intervals.Range_T_.T'></a>

`T`

The underlying data type.

Implements [Jcd.Math.Intervals.IInterval&lt;](Jcd.Math.Intervals.IInterval_T_.md 'Jcd.Math.Intervals.IInterval<T>')[T](Jcd.Math.Intervals.Range_T_.md#Jcd.Math.Intervals.Range_T_.T 'Jcd.Math.Intervals.Range<T>.T')[&gt;](Jcd.Math.Intervals.IInterval_T_.md 'Jcd.Math.Intervals.IInterval<T>'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Jcd.Math.Intervals.IInterval&lt;](Jcd.Math.Intervals.IInterval_T_.md 'Jcd.Math.Intervals.IInterval<T>')[T](Jcd.Math.Intervals.Range_T_.md#Jcd.Math.Intervals.Range_T_.T 'Jcd.Math.Intervals.Range<T>.T')[&gt;](Jcd.Math.Intervals.IInterval_T_.md 'Jcd.Math.Intervals.IInterval<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Range(T, T)](Jcd.Math.Intervals.Range_T_.Range(T,T).md 'Jcd.Math.Intervals.Range<T>.Range(T, T)') | Create a new range from a start and end |

| Properties | |
| :--- | :--- |
| [End](Jcd.Math.Intervals.Range_T_.End.md 'Jcd.Math.Intervals.Range<T>.End') | The end of the interval. |
| [IsEmpty](Jcd.Math.Intervals.Range_T_.IsEmpty.md 'Jcd.Math.Intervals.Range<T>.IsEmpty') | Indicates if the interval is empty:<br/>0,0), (1,1) ...etc. are empty intervals. |
| [IsSingleValue](Jcd.Math.Intervals.Range_T_.IsSingleValue.md 'Jcd.Math.Intervals.Range<T>.IsSingleValue') | Indicates if the interval is empty:<br/>[0,0], [1,1] ...etc. are single value intervals. |
| [IsValid](Jcd.Math.Intervals.Range_T_.IsValid.md 'Jcd.Math.Intervals.Range<T>.IsValid') | Indicates if the interval was properly constructed. |
| [Start](Jcd.Math.Intervals.Range_T_.Start.md 'Jcd.Math.Intervals.Range<T>.Start') | The start of the interval. |

| Methods | |
| :--- | :--- |
| [Contains(IInterval&lt;T&gt;)](Jcd.Math.Intervals.Range_T_.Contains(Jcd.Math.Intervals.IInterval_T_).md 'Jcd.Math.Intervals.Range<T>.Contains(Jcd.Math.Intervals.IInterval<T>)') | Determines if this interval completely contains another. |
| [Contains(T)](Jcd.Math.Intervals.Range_T_.Contains(T).md 'Jcd.Math.Intervals.Range<T>.Contains(T)') | Determines if the interval contains the provided point. |
