#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Numbers](Jcd.Math.Numbers.md 'Jcd.Math.Numbers')

## Infinity Struct

The default representation of any infinite value,  
positive or negative, regardless (this one uses a  
double implementation, for now. We'll see how  
performant it is.)

```csharp
public readonly struct Infinity :
System.IComparable<Jcd.Math.Numbers.Infinity>,
System.IEquatable<Jcd.Math.Numbers.Infinity>,
System.IComparable
```

Implements [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[Infinity](Jcd.Math.Numbers.Infinity.md 'Jcd.Math.Numbers.Infinity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Infinity](Jcd.Math.Numbers.Infinity.md 'Jcd.Math.Numbers.Infinity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1'), [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable')

| Constructors | |
| :--- | :--- |
| [Infinity(bool)](Jcd.Math.Numbers.Infinity.Infinity(bool).md 'Jcd.Math.Numbers.Infinity.Infinity(bool)') | Constructs a new instance of Infinity. |

| Fields | |
| :--- | :--- |
| [Negative](Jcd.Math.Numbers.Infinity.Negative.md 'Jcd.Math.Numbers.Infinity.Negative') | The default instance of Negative Infinity. |
| [Positive](Jcd.Math.Numbers.Infinity.Positive.md 'Jcd.Math.Numbers.Infinity.Positive') | The default instance of Positive Infinity. |

| Properties | |
| :--- | :--- |
| [IsNegative](Jcd.Math.Numbers.Infinity.IsNegative.md 'Jcd.Math.Numbers.Infinity.IsNegative') | Indicates if this is Negative Infinity. |

| Methods | |
| :--- | :--- |
| [CompareTo(object)](Jcd.Math.Numbers.Infinity.CompareTo(object).md 'Jcd.Math.Numbers.Infinity.CompareTo(object)') | Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object. |
| [CompareTo&lt;T&gt;(T)](Jcd.Math.Numbers.Infinity.CompareTo_T_(T).md 'Jcd.Math.Numbers.Infinity.CompareTo<T>(T)') | Compares the infinity instance vs any other value/class. |
| [Equals(object)](Jcd.Math.Numbers.Infinity.Equals(object).md 'Jcd.Math.Numbers.Infinity.Equals(object)') | Indicates whether this instance and a specified object are equal. |
| [GetHashCode()](Jcd.Math.Numbers.Infinity.GetHashCode().md 'Jcd.Math.Numbers.Infinity.GetHashCode()') | Returns the hash code for this instance. |

| Operators | |
| :--- | :--- |
| [operator ==(Infinity, Infinity)](Jcd.Math.Numbers.Infinity.op_Equality(Jcd.Math.Numbers.Infinity,Jcd.Math.Numbers.Infinity).md 'Jcd.Math.Numbers.Infinity.op_Equality(Jcd.Math.Numbers.Infinity, Jcd.Math.Numbers.Infinity)') | Compares an two Infinity instances for equivalence. |
| [operator &gt;(Infinity, Infinity)](Jcd.Math.Numbers.Infinity.op_GreaterThan(Jcd.Math.Numbers.Infinity,Jcd.Math.Numbers.Infinity).md 'Jcd.Math.Numbers.Infinity.op_GreaterThan(Jcd.Math.Numbers.Infinity, Jcd.Math.Numbers.Infinity)') | Determines if an infinity is greater than another infinity. |
| [operator &gt;=(Infinity, Infinity)](Jcd.Math.Numbers.Infinity.op_GreaterThanOrEqual(Jcd.Math.Numbers.Infinity,Jcd.Math.Numbers.Infinity).md 'Jcd.Math.Numbers.Infinity.op_GreaterThanOrEqual(Jcd.Math.Numbers.Infinity, Jcd.Math.Numbers.Infinity)') | Determines if an infinity is greater than another infinity. |
| [operator !=(Infinity, Infinity)](Jcd.Math.Numbers.Infinity.op_Inequality(Jcd.Math.Numbers.Infinity,Jcd.Math.Numbers.Infinity).md 'Jcd.Math.Numbers.Infinity.op_Inequality(Jcd.Math.Numbers.Infinity, Jcd.Math.Numbers.Infinity)') | Compares an two Infinity instances for non-equivalence. |
| [operator &lt;(Infinity, Infinity)](Jcd.Math.Numbers.Infinity.op_LessThan(Jcd.Math.Numbers.Infinity,Jcd.Math.Numbers.Infinity).md 'Jcd.Math.Numbers.Infinity.op_LessThan(Jcd.Math.Numbers.Infinity, Jcd.Math.Numbers.Infinity)') | Determines if an infinity is less than another infinity. |
| [operator &lt;=(Infinity, Infinity)](Jcd.Math.Numbers.Infinity.op_LessThanOrEqual(Jcd.Math.Numbers.Infinity,Jcd.Math.Numbers.Infinity).md 'Jcd.Math.Numbers.Infinity.op_LessThanOrEqual(Jcd.Math.Numbers.Infinity, Jcd.Math.Numbers.Infinity)') | Determines if an infinity is less than or equal to another infinity. |
