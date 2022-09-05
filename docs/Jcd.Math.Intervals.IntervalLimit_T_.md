#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals')

## IntervalLimit<T> Struct

Defines a limit point in an interval. (i.e. starting point or ending point.)

```csharp
public readonly struct IntervalLimit<T> :
System.IComparable<Jcd.Math.Intervals.IntervalLimit<T>>,
System.IComparable,
System.IEquatable<Jcd.Math.Intervals.IntervalLimit<T>>,
System.IComparable<T>,
System.IEquatable<T>
    where T : System.IComparable<T>, System.IEquatable<T>
```
#### Type parameters

<a name='Jcd.Math.Intervals.IntervalLimit_T_.T'></a>

`T`

The data type for the interval using this limit.

Implements [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[Jcd.Math.Intervals.IntervalLimit&lt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')[T](Jcd.Math.Intervals.IntervalLimit_T_.md#Jcd.Math.Intervals.IntervalLimit_T_.T 'Jcd.Math.Intervals.IntervalLimit<T>.T')[&gt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Jcd.Math.Intervals.IntervalLimit&lt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')[T](Jcd.Math.Intervals.IntervalLimit_T_.md#Jcd.Math.Intervals.IntervalLimit_T_.T 'Jcd.Math.Intervals.IntervalLimit<T>.T')[&gt;](Jcd.Math.Intervals.IntervalLimit_T_.md 'Jcd.Math.Intervals.IntervalLimit<T>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[T](Jcd.Math.Intervals.IntervalLimit_T_.md#Jcd.Math.Intervals.IntervalLimit_T_.T 'Jcd.Math.Intervals.IntervalLimit<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[T](Jcd.Math.Intervals.IntervalLimit_T_.md#Jcd.Math.Intervals.IntervalLimit_T_.T 'Jcd.Math.Intervals.IntervalLimit<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

### Remarks
For the purposes of this library:  
  * An Unbounded interval limit is both open and infinite. (HasLimitValue == false && IsUnbounded == true && IsOpen == true).  
  * An Open interval limit is a finite and open limit.  (i.e. HasLimitValue == true && IsUnbounded == false && IsOpen == true).  
  * A Closed interval limit is both closed and finite. (i.e. HasLimitValue == true && IsUnbounded == false && IsOpen == false).  
  * Start interval limits compare as less than or equal to End interval limits for the same non-infinite limit value, depending on the Closed-Open nature of the limits being compared.  
  * Start interval limits compare as less than End interval limits for infinite (Unbounded) limit values.  
  * Open-Start interval limits compare greater than Closed-Start interval limits.  
  * Open-End interval limits compare less than Closed-End interval limits.  
  * Unbounded-Start interval limits compare less than Open or Closed-Start interval limits.  
  * Unbounded-End interval limits compare greater than Open or Closed-End interval limits.

| Constructors | |
| :--- | :--- |
| [IntervalLimit(IntervalLimitType, IntervalLimitConstraint, T)](Jcd.Math.Intervals.IntervalLimit_T_.IntervalLimit(Jcd.Math.Intervals.IntervalLimitType,Jcd.Math.Intervals.IntervalLimitConstraint,T).md 'Jcd.Math.Intervals.IntervalLimit<T>.IntervalLimit(Jcd.Math.Intervals.IntervalLimitType, Jcd.Math.Intervals.IntervalLimitConstraint, T)') | Construct an interval limit from a limit value, constraint and type. |

| Fields | |
| :--- | :--- |
| [Default](Jcd.Math.Intervals.IntervalLimit_T_.Default.md 'Jcd.Math.Intervals.IntervalLimit<T>.Default') | The default IntervalLimit. This is equivalent to IntervalLimit<T>.UnboundedStart |

| Properties | |
| :--- | :--- |
| [Constraint](Jcd.Math.Intervals.IntervalLimit_T_.Constraint.md 'Jcd.Math.Intervals.IntervalLimit<T>.Constraint') | Unbounded (i.e. no limit), Open, Closed. |
| [HasLimitValue](Jcd.Math.Intervals.IntervalLimit_T_.HasLimitValue.md 'Jcd.Math.Intervals.IntervalLimit<T>.HasLimitValue') | Indicates if there is a discrete, non-infinite value for the limit. |
| [IsClosed](Jcd.Math.Intervals.IntervalLimit_T_.IsClosed.md 'Jcd.Math.Intervals.IntervalLimit<T>.IsClosed') | Indicates if the limit is closed. |
| [IsEnd](Jcd.Math.Intervals.IntervalLimit_T_.IsEnd.md 'Jcd.Math.Intervals.IntervalLimit<T>.IsEnd') | Indicates if this interval limit is an interval end limit.<br/>When true and Unbounded is true the Limit value is treated as +infinity. |
| [IsOpen](Jcd.Math.Intervals.IntervalLimit_T_.IsOpen.md 'Jcd.Math.Intervals.IntervalLimit<T>.IsOpen') | Indicates if the limit is open. (Note: Unbounded is open at +/-infinity) |
| [IsStart](Jcd.Math.Intervals.IntervalLimit_T_.IsStart.md 'Jcd.Math.Intervals.IntervalLimit<T>.IsStart') | Indicates if this interval limit is a start limit.<br/>When true and Unbounded is true the Limit value is treated as -infinity. |
| [IsUnbounded](Jcd.Math.Intervals.IntervalLimit_T_.IsUnbounded.md 'Jcd.Math.Intervals.IntervalLimit<T>.IsUnbounded') | Indicates if the limit is unbounded. |
| [Limit](Jcd.Math.Intervals.IntervalLimit_T_.Limit.md 'Jcd.Math.Intervals.IntervalLimit<T>.Limit') | The limit value for the interval point, if applicable. (Unbounded = default(T), the value is ignored for comparisons.) |
| [LimitType](Jcd.Math.Intervals.IntervalLimit_T_.LimitType.md 'Jcd.Math.Intervals.IntervalLimit<T>.LimitType') | The type of interval limit, Start or End. This dictates how comparisons happen. |

| Methods | |
| :--- | :--- |
| [ClosedEnd(T)](Jcd.Math.Intervals.IntervalLimit_T_.ClosedEnd(T).md 'Jcd.Math.Intervals.IntervalLimit<T>.ClosedEnd(T)') | Creates an open end interval limit.<br/>In other words: creates an inclusive end limit.  <br/>For example: ...,limit] |
| [ClosedStart(T)](Jcd.Math.Intervals.IntervalLimit_T_.ClosedStart(T).md 'Jcd.Math.Intervals.IntervalLimit<T>.ClosedStart(T)') | Creates a closed start interval limit.<br/>In other words: creates an inclusive start limit.  <br/>For example: [limit,... |
| [CompareTo(object)](Jcd.Math.Intervals.IntervalLimit_T_.CompareTo(object).md 'Jcd.Math.Intervals.IntervalLimit<T>.CompareTo(object)') | Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object. |
| [CompareTo(T)](Jcd.Math.Intervals.IntervalLimit_T_.CompareTo(T).md 'Jcd.Math.Intervals.IntervalLimit<T>.CompareTo(T)') | Compares the current object with another object of the same type. |
| [Equals(object)](Jcd.Math.Intervals.IntervalLimit_T_.Equals(object).md 'Jcd.Math.Intervals.IntervalLimit<T>.Equals(object)') | Indicates whether this instance and a specified object are equal. |
| [Equals(T)](Jcd.Math.Intervals.IntervalLimit_T_.Equals(T).md 'Jcd.Math.Intervals.IntervalLimit<T>.Equals(T)') | Indicates whether the current object is equal to another object of the same type. |
| [GetHashCode()](Jcd.Math.Intervals.IntervalLimit_T_.GetHashCode().md 'Jcd.Math.Intervals.IntervalLimit<T>.GetHashCode()') | Returns the hash code for this instance. |
| [MakeEnd(IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IntervalLimit_T_.MakeEnd(Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IntervalLimit<T>.MakeEnd(Jcd.Math.Intervals.IntervalLimit<T>)') | Ensures that an interval limit is a end limit by examining properties<br/>and, if necessary returning a new instance. Boundedness, Openness and<br/>Limit value are all retained. |
| [MakeStart(IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IntervalLimit_T_.MakeStart(Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IntervalLimit<T>.MakeStart(Jcd.Math.Intervals.IntervalLimit<T>)') | Ensures that an interval limit is a start limit by examining properties<br/>and, if necessary returning a new instance. Boundedness, Openness and<br/>Limit value are all retained. |
| [OpenEnd(T)](Jcd.Math.Intervals.IntervalLimit_T_.OpenEnd(T).md 'Jcd.Math.Intervals.IntervalLimit<T>.OpenEnd(T)') | Creates an open end interval limit.<br/>In other words: creates an exclusive end limit.  <br/>For example: ...,limit) |
| [OpenStart(T)](Jcd.Math.Intervals.IntervalLimit_T_.OpenStart(T).md 'Jcd.Math.Intervals.IntervalLimit<T>.OpenStart(T)') | Creates an open-start interval limit.<br/>In other words: creates an exclusive start limit.  <br/>For example: (limit,... |
| [ToString()](Jcd.Math.Intervals.IntervalLimit_T_.ToString().md 'Jcd.Math.Intervals.IntervalLimit<T>.ToString()') | Returns the fully qualified type name of this instance. |
| [UnboundedEnd()](Jcd.Math.Intervals.IntervalLimit_T_.UnboundedEnd().md 'Jcd.Math.Intervals.IntervalLimit<T>.UnboundedEnd()') | Creates an unbounded end interval limit<br/>In other words: creates an exclusive infinite end limit.  <br/>For example: ...,+infinity) |
| [UnboundedStart()](Jcd.Math.Intervals.IntervalLimit_T_.UnboundedStart().md 'Jcd.Math.Intervals.IntervalLimit<T>.UnboundedStart()') | Creates an unbounded start interval limit.<br/>In other words: creates an exclusive infinite start limit.  <br/>For example: (-infinity,... |

| Operators | |
| :--- | :--- |
| [operator ==(IntervalLimit&lt;T&gt;, IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IntervalLimit_T_.op_Equality(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_Equality(Jcd.Math.Intervals.IntervalLimit<T>, Jcd.Math.Intervals.IntervalLimit<T>)') | Equivalence operator. |
| [operator ==(IntervalLimit&lt;T&gt;, T)](Jcd.Math.Intervals.IntervalLimit_T_.op_Equality(Jcd.Math.Intervals.IntervalLimit_T_,T).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_Equality(Jcd.Math.Intervals.IntervalLimit<T>, T)') | Equivalence operator. |
| [operator ==(T, IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IntervalLimit_T_.op_Equality(T,Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_Equality(T, Jcd.Math.Intervals.IntervalLimit<T>)') | Equivalence operator. |
| [explicit operator T(IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IntervalLimit_T_.op_ExplicitT(Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_Explicit T(Jcd.Math.Intervals.IntervalLimit<T>)') | Converts to the underlying value type. |
| [operator &gt;(IntervalLimit&lt;T&gt;, IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IntervalLimit_T_.op_GreaterThan(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_GreaterThan(Jcd.Math.Intervals.IntervalLimit<T>, Jcd.Math.Intervals.IntervalLimit<T>)') | Determines if one interval limit is greater than another. |
| [operator &gt;(IntervalLimit&lt;T&gt;, T)](Jcd.Math.Intervals.IntervalLimit_T_.op_GreaterThan(Jcd.Math.Intervals.IntervalLimit_T_,T).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_GreaterThan(Jcd.Math.Intervals.IntervalLimit<T>, T)') | Determines if an interval limit is greater than a specified value. |
| [operator &gt;(T, IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IntervalLimit_T_.op_GreaterThan(T,Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_GreaterThan(T, Jcd.Math.Intervals.IntervalLimit<T>)') | Determines if a specified value is greater than an interval limit. |
| [operator &gt;=(IntervalLimit&lt;T&gt;, IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IntervalLimit_T_.op_GreaterThanOrEqual(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_GreaterThanOrEqual(Jcd.Math.Intervals.IntervalLimit<T>, Jcd.Math.Intervals.IntervalLimit<T>)') | Determines if one interval limit is greater than or equal to another. |
| [operator &gt;=(IntervalLimit&lt;T&gt;, T)](Jcd.Math.Intervals.IntervalLimit_T_.op_GreaterThanOrEqual(Jcd.Math.Intervals.IntervalLimit_T_,T).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_GreaterThanOrEqual(Jcd.Math.Intervals.IntervalLimit<T>, T)') | Determines if an interval limit is less greater or equal to a specified value. |
| [operator &gt;=(T, IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IntervalLimit_T_.op_GreaterThanOrEqual(T,Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_GreaterThanOrEqual(T, Jcd.Math.Intervals.IntervalLimit<T>)') | Determines if a specified value is greater than or equal to an interval limit. |
| [operator !=(IntervalLimit&lt;T&gt;, IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IntervalLimit_T_.op_Inequality(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_Inequality(Jcd.Math.Intervals.IntervalLimit<T>, Jcd.Math.Intervals.IntervalLimit<T>)') | Non=equivalence operator. |
| [operator !=(IntervalLimit&lt;T&gt;, T)](Jcd.Math.Intervals.IntervalLimit_T_.op_Inequality(Jcd.Math.Intervals.IntervalLimit_T_,T).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_Inequality(Jcd.Math.Intervals.IntervalLimit<T>, T)') | Non=equivalence operator. |
| [operator !=(T, IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IntervalLimit_T_.op_Inequality(T,Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_Inequality(T, Jcd.Math.Intervals.IntervalLimit<T>)') | Non=equivalence operator. |
| [operator &lt;(IntervalLimit&lt;T&gt;, IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IntervalLimit_T_.op_LessThan(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_LessThan(Jcd.Math.Intervals.IntervalLimit<T>, Jcd.Math.Intervals.IntervalLimit<T>)') | Determines if one interval limit is less than another. |
| [operator &lt;(IntervalLimit&lt;T&gt;, T)](Jcd.Math.Intervals.IntervalLimit_T_.op_LessThan(Jcd.Math.Intervals.IntervalLimit_T_,T).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_LessThan(Jcd.Math.Intervals.IntervalLimit<T>, T)') | Determines if an interval limit is less than a specified value. |
| [operator &lt;(T, IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IntervalLimit_T_.op_LessThan(T,Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_LessThan(T, Jcd.Math.Intervals.IntervalLimit<T>)') | Determines if a specified value is less than an interval limit. |
| [operator &lt;=(IntervalLimit&lt;T&gt;, IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IntervalLimit_T_.op_LessThanOrEqual(Jcd.Math.Intervals.IntervalLimit_T_,Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_LessThanOrEqual(Jcd.Math.Intervals.IntervalLimit<T>, Jcd.Math.Intervals.IntervalLimit<T>)') | Determines if one interval limit is less than or equal to another. |
| [operator &lt;=(IntervalLimit&lt;T&gt;, T)](Jcd.Math.Intervals.IntervalLimit_T_.op_LessThanOrEqual(Jcd.Math.Intervals.IntervalLimit_T_,T).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_LessThanOrEqual(Jcd.Math.Intervals.IntervalLimit<T>, T)') | Determines if an interval limit is less than or equal to a specified value. |
| [operator &lt;=(T, IntervalLimit&lt;T&gt;)](Jcd.Math.Intervals.IntervalLimit_T_.op_LessThanOrEqual(T,Jcd.Math.Intervals.IntervalLimit_T_).md 'Jcd.Math.Intervals.IntervalLimit<T>.op_LessThanOrEqual(T, Jcd.Math.Intervals.IntervalLimit<T>)') | Determines if a specified value is less than or equal to an interval limit. |
