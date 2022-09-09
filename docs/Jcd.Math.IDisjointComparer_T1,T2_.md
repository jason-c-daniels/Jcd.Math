#### [Jcd.Math](index.md 'index')
### [Jcd.Math](Jcd.Math.md 'Jcd.Math')

## IDisjointComparer<T1,T2> Interface

A generic IComparer interface implements a method that compares   
two objects of differing types. It is used in conjunction with  
the Infinity and Number structs to provide comparisons.

```csharp
public interface IDisjointComparer<in T1,in T2>
```
#### Type parameters

<a name='Jcd.Math.IDisjointComparer_T1,T2_.T1'></a>

`T1`

The first type.

<a name='Jcd.Math.IDisjointComparer_T1,T2_.T2'></a>

`T2`

The second type.

Derived  
&#8627; [Comparer&lt;T&gt;](Jcd.Math.Numbers.qNaN.Comparer_T_.md 'Jcd.Math.Numbers.qNaN.Comparer<T>')

| Methods | |
| :--- | :--- |
| [Compare(T1, T2)](Jcd.Math.IDisjointComparer_T1,T2_.Compare(T1,T2).md 'Jcd.Math.IDisjointComparer<T1,T2>.Compare(T1, T2)') | Compares an instance of T1 to an instance of T2. |
| [Compare(T2, T1)](Jcd.Math.IDisjointComparer_T1,T2_.Compare(T2,T1).md 'Jcd.Math.IDisjointComparer<T1,T2>.Compare(T2, T1)') | Compares an instance of T1 to an instance of T2. |
