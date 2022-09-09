#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Numbers](Jcd.Math.Numbers.md 'Jcd.Math.Numbers')

## qNaN Struct

A storage agnostic non-signaling NaN implementation.

```csharp
public readonly struct qNaN :
System.IEquatable<Jcd.Math.Numbers.qNaN>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[qNaN](Jcd.Math.Numbers.qNaN.md 'Jcd.Math.Numbers.qNaN')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Fields | |
| :--- | :--- |
| [NaN](Jcd.Math.Numbers.qNaN.NaN.md 'Jcd.Math.Numbers.qNaN.NaN') | The singular instance of qNaN.<br/>Not sure HOW I'll use this just yet...<br/>I'll likely just implement operators for it against<br/>other integral data types. Most, will compare to false. |

| Methods | |
| :--- | :--- |
| [Equals(object)](Jcd.Math.Numbers.qNaN.Equals(object).md 'Jcd.Math.Numbers.qNaN.Equals(object)') | Indicates whether this instance and a specified object are equal. |
| [Equals&lt;T&gt;(T)](Jcd.Math.Numbers.qNaN.Equals_T_(T).md 'Jcd.Math.Numbers.qNaN.Equals<T>(T)') | qNaN is always not equal to any value. |
| [GetHashCode()](Jcd.Math.Numbers.qNaN.GetHashCode().md 'Jcd.Math.Numbers.qNaN.GetHashCode()') | Returns the hash code for this instance. |

| Operators | |
| :--- | :--- |
| [operator ==(Infinity, qNaN)](Jcd.Math.Numbers.qNaN.op_Equality(Jcd.Math.Numbers.Infinity,Jcd.Math.Numbers.qNaN).md 'Jcd.Math.Numbers.qNaN.op_Equality(Jcd.Math.Numbers.Infinity, Jcd.Math.Numbers.qNaN)') | The equals operator. |
| [operator ==(qNaN, qNaN)](Jcd.Math.Numbers.qNaN.op_Equality(Jcd.Math.Numbers.qNaN,Jcd.Math.Numbers.qNaN).md 'Jcd.Math.Numbers.qNaN.op_Equality(Jcd.Math.Numbers.qNaN, Jcd.Math.Numbers.qNaN)') | The equals operator. |
| [operator &gt;(qNaN, qNaN)](Jcd.Math.Numbers.qNaN.op_GreaterThan(Jcd.Math.Numbers.qNaN,Jcd.Math.Numbers.qNaN).md 'Jcd.Math.Numbers.qNaN.op_GreaterThan(Jcd.Math.Numbers.qNaN, Jcd.Math.Numbers.qNaN)') | The greater than operator. |
| [operator &gt;=(qNaN, qNaN)](Jcd.Math.Numbers.qNaN.op_GreaterThanOrEqual(Jcd.Math.Numbers.qNaN,Jcd.Math.Numbers.qNaN).md 'Jcd.Math.Numbers.qNaN.op_GreaterThanOrEqual(Jcd.Math.Numbers.qNaN, Jcd.Math.Numbers.qNaN)') | The greater than or equals operator. |
| [operator !=(Infinity, qNaN)](Jcd.Math.Numbers.qNaN.op_Inequality(Jcd.Math.Numbers.Infinity,Jcd.Math.Numbers.qNaN).md 'Jcd.Math.Numbers.qNaN.op_Inequality(Jcd.Math.Numbers.Infinity, Jcd.Math.Numbers.qNaN)') | The not equals operator. |
| [operator !=(qNaN, qNaN)](Jcd.Math.Numbers.qNaN.op_Inequality(Jcd.Math.Numbers.qNaN,Jcd.Math.Numbers.qNaN).md 'Jcd.Math.Numbers.qNaN.op_Inequality(Jcd.Math.Numbers.qNaN, Jcd.Math.Numbers.qNaN)') | The not equals operator. |
| [operator &lt;(qNaN, qNaN)](Jcd.Math.Numbers.qNaN.op_LessThan(Jcd.Math.Numbers.qNaN,Jcd.Math.Numbers.qNaN).md 'Jcd.Math.Numbers.qNaN.op_LessThan(Jcd.Math.Numbers.qNaN, Jcd.Math.Numbers.qNaN)') | The less than operator. |
| [operator &lt;=(qNaN, qNaN)](Jcd.Math.Numbers.qNaN.op_LessThanOrEqual(Jcd.Math.Numbers.qNaN,Jcd.Math.Numbers.qNaN).md 'Jcd.Math.Numbers.qNaN.op_LessThanOrEqual(Jcd.Math.Numbers.qNaN, Jcd.Math.Numbers.qNaN)') | The less than or equals operator. |
