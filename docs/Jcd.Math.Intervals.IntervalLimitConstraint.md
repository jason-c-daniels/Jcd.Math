### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals')

## IntervalLimitConstraint Struct

Describes how an endpoint in an interval is to be handled (Open with limit?  
Fully open? Closed on the limit?)

```csharp
public readonly struct IntervalLimitConstraint :
System.IEquatable<Jcd.Math.Intervals.IntervalLimitConstraint>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[IntervalLimitConstraint](Jcd.Math.Intervals.IntervalLimitConstraint.md 'Jcd.Math.Intervals.IntervalLimitConstraint')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Fields | |
| :--- | :--- |
| [Closed](Jcd.Math.Intervals.IntervalLimitConstraint.Closed.md 'Jcd.Math.Intervals.IntervalLimitConstraint.Closed') | The endpoint in question has a limit and is closed. (i.e. includes the limit point) |
| [Open](Jcd.Math.Intervals.IntervalLimitConstraint.Open.md 'Jcd.Math.Intervals.IntervalLimitConstraint.Open') | The endpoint in question has a limit and is open. (i.e. excludes the limit point) |
| [Unbounded](Jcd.Math.Intervals.IntervalLimitConstraint.Unbounded.md 'Jcd.Math.Intervals.IntervalLimitConstraint.Unbounded') | The endpoint in question has no limit and therefore is fully open. |

| Properties | |
| :--- | :--- |
| [HasLimitValue](Jcd.Math.Intervals.IntervalLimitConstraint.HasLimitValue.md 'Jcd.Math.Intervals.IntervalLimitConstraint.HasLimitValue') | Indicates if the specified interval endpoint contains any<br/>limit whatsoever. (i.e. is it fully open at the start or end?) |
| [IsClosed](Jcd.Math.Intervals.IntervalLimitConstraint.IsClosed.md 'Jcd.Math.Intervals.IntervalLimitConstraint.IsClosed') | Indicates if the specified interval endpoint contains the<br/>point in question. |
| [IsOpen](Jcd.Math.Intervals.IntervalLimitConstraint.IsOpen.md 'Jcd.Math.Intervals.IntervalLimitConstraint.IsOpen') | Indicates if the specified interval endpoint contains the<br/>point in question. |
| [IsUnbounded](Jcd.Math.Intervals.IntervalLimitConstraint.IsUnbounded.md 'Jcd.Math.Intervals.IntervalLimitConstraint.IsUnbounded') | Indicates if there is no limit on the bounds of this constraint.<br/>This is effectively -infinity or +infinity depending on context. |

| Methods | |
| :--- | :--- |
| [Equals(object)](Jcd.Math.Intervals.IntervalLimitConstraint.Equals(object).md 'Jcd.Math.Intervals.IntervalLimitConstraint.Equals(object)') | Indicates whether this instance and a specified object are equal. |
| [GetHashCode()](Jcd.Math.Intervals.IntervalLimitConstraint.GetHashCode().md 'Jcd.Math.Intervals.IntervalLimitConstraint.GetHashCode()') | Returns the hash code for this instance. |

| Operators | |
| :--- | :--- |
| [operator ==(IntervalLimitConstraint, IntervalLimitConstraint)](Jcd.Math.Intervals.IntervalLimitConstraint.op_Equality(Jcd.Math.Intervals.IntervalLimitConstraint,Jcd.Math.Intervals.IntervalLimitConstraint).md 'Jcd.Math.Intervals.IntervalLimitConstraint.op_Equality(Jcd.Math.Intervals.IntervalLimitConstraint, Jcd.Math.Intervals.IntervalLimitConstraint)') | Equivalence operator |
| [operator !=(IntervalLimitConstraint, IntervalLimitConstraint)](Jcd.Math.Intervals.IntervalLimitConstraint.op_Inequality(Jcd.Math.Intervals.IntervalLimitConstraint,Jcd.Math.Intervals.IntervalLimitConstraint).md 'Jcd.Math.Intervals.IntervalLimitConstraint.op_Inequality(Jcd.Math.Intervals.IntervalLimitConstraint, Jcd.Math.Intervals.IntervalLimitConstraint)') | Non-equivalence operator |
