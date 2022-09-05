### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals')

## IntervalLimitType Struct

An equatable and comparable type-safe and highly performant DDD-like enumeration type.  
To keep high performance the usual DDD name/description property is omitted.

```csharp
public readonly struct IntervalLimitType :
System.IEquatable<Jcd.Math.Intervals.IntervalLimitType>,
System.IComparable<Jcd.Math.Intervals.IntervalLimitType>,
System.IComparable
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[IntervalLimitType](Jcd.Math.Intervals.IntervalLimitType.md 'Jcd.Math.Intervals.IntervalLimitType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[IntervalLimitType](Jcd.Math.Intervals.IntervalLimitType.md 'Jcd.Math.Intervals.IntervalLimitType')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable')

| Fields | |
| :--- | :--- |
| [End](Jcd.Math.Intervals.IntervalLimitType.End.md 'Jcd.Math.Intervals.IntervalLimitType.End') | The end point of an interval. End must be >= start |
| [Start](Jcd.Math.Intervals.IntervalLimitType.Start.md 'Jcd.Math.Intervals.IntervalLimitType.Start') | The start point of an interval. Start must be <= end |

| Properties | |
| :--- | :--- |
| [IsEnd](Jcd.Math.Intervals.IntervalLimitType.IsEnd.md 'Jcd.Math.Intervals.IntervalLimitType.IsEnd') | Indicates if this is an End IntervalLimitType |
| [IsStart](Jcd.Math.Intervals.IntervalLimitType.IsStart.md 'Jcd.Math.Intervals.IntervalLimitType.IsStart') | Indicates if this is a Start IntervalLimitType |

| Methods | |
| :--- | :--- |
| [CompareTo(object)](Jcd.Math.Intervals.IntervalLimitType.CompareTo(object).md 'Jcd.Math.Intervals.IntervalLimitType.CompareTo(object)') | Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object. |
| [Equals(object)](Jcd.Math.Intervals.IntervalLimitType.Equals(object).md 'Jcd.Math.Intervals.IntervalLimitType.Equals(object)') | Indicates whether this instance and a specified object are equal. |
| [GetHashCode()](Jcd.Math.Intervals.IntervalLimitType.GetHashCode().md 'Jcd.Math.Intervals.IntervalLimitType.GetHashCode()') | Returns the hash code for this instance. |
| [ToString()](Jcd.Math.Intervals.IntervalLimitType.ToString().md 'Jcd.Math.Intervals.IntervalLimitType.ToString()') | Returns the fully qualified type name of this instance. |

| Operators | |
| :--- | :--- |
| [operator ==(IntervalLimitType, IntervalLimitType)](Jcd.Math.Intervals.IntervalLimitType.op_Equality(Jcd.Math.Intervals.IntervalLimitType,Jcd.Math.Intervals.IntervalLimitType).md 'Jcd.Math.Intervals.IntervalLimitType.op_Equality(Jcd.Math.Intervals.IntervalLimitType, Jcd.Math.Intervals.IntervalLimitType)') | Compares two IntervalLimitTypes for equality. |
| [explicit operator byte(IntervalLimitType)](Jcd.Math.Intervals.IntervalLimitType.op_Explicitbyte(Jcd.Math.Intervals.IntervalLimitType).md 'Jcd.Math.Intervals.IntervalLimitType.op_Explicit byte(Jcd.Math.Intervals.IntervalLimitType)') | Convert to byte operator. |
| [explicit operator IntervalLimitType(byte)](Jcd.Math.Intervals.IntervalLimitType.op_ExplicitJcd.Math.Intervals.IntervalLimitType(byte).md 'Jcd.Math.Intervals.IntervalLimitType.op_Explicit Jcd.Math.Intervals.IntervalLimitType(byte)') | Conversion operator from byte. |
| [operator &gt;(IntervalLimitType, IntervalLimitType)](Jcd.Math.Intervals.IntervalLimitType.op_GreaterThan(Jcd.Math.Intervals.IntervalLimitType,Jcd.Math.Intervals.IntervalLimitType).md 'Jcd.Math.Intervals.IntervalLimitType.op_GreaterThan(Jcd.Math.Intervals.IntervalLimitType, Jcd.Math.Intervals.IntervalLimitType)') | Checks if the left hand IntervalLimitType is greater than the right hand IntervalLimitType. |
| [operator &gt;=(IntervalLimitType, IntervalLimitType)](Jcd.Math.Intervals.IntervalLimitType.op_GreaterThanOrEqual(Jcd.Math.Intervals.IntervalLimitType,Jcd.Math.Intervals.IntervalLimitType).md 'Jcd.Math.Intervals.IntervalLimitType.op_GreaterThanOrEqual(Jcd.Math.Intervals.IntervalLimitType, Jcd.Math.Intervals.IntervalLimitType)') | Checks if the left hand IntervalLimitType is greater than or equal to the right hand IntervalLimitType. |
| [operator !=(IntervalLimitType, IntervalLimitType)](Jcd.Math.Intervals.IntervalLimitType.op_Inequality(Jcd.Math.Intervals.IntervalLimitType,Jcd.Math.Intervals.IntervalLimitType).md 'Jcd.Math.Intervals.IntervalLimitType.op_Inequality(Jcd.Math.Intervals.IntervalLimitType, Jcd.Math.Intervals.IntervalLimitType)') | Compares two IntervalLimitTypes for inequality. |
| [operator &lt;(IntervalLimitType, IntervalLimitType)](Jcd.Math.Intervals.IntervalLimitType.op_LessThan(Jcd.Math.Intervals.IntervalLimitType,Jcd.Math.Intervals.IntervalLimitType).md 'Jcd.Math.Intervals.IntervalLimitType.op_LessThan(Jcd.Math.Intervals.IntervalLimitType, Jcd.Math.Intervals.IntervalLimitType)') | Checks if the left hand IntervalLimitType is less than the right hand IntervalLimitType. |
| [operator &lt;=(IntervalLimitType, IntervalLimitType)](Jcd.Math.Intervals.IntervalLimitType.op_LessThanOrEqual(Jcd.Math.Intervals.IntervalLimitType,Jcd.Math.Intervals.IntervalLimitType).md 'Jcd.Math.Intervals.IntervalLimitType.op_LessThanOrEqual(Jcd.Math.Intervals.IntervalLimitType, Jcd.Math.Intervals.IntervalLimitType)') | Checks if the left hand IntervalLimitType is less than or equal to the right hand IntervalLimitType. |
