#### [Jcd.Math](index.md 'index')

## Jcd.Math Namespace

Provides some rudimentary (and generic) math types and algorithms not   
found in .NET by default.

| Classes | |
| :--- | :--- |
| [Compare](Jcd.Math.Compare.md 'Jcd.Math.Compare') | 1. A set of upcoming C# features:<br/>   Generic `Min`, `Max`, and `Clamp`. Once MS has implemented these<br/>   (C# 11, .NET7?) they will be off of the Math. class.<br/><br/>2. Some custom extension methods that everyone seems to have to<br/>   create, despite well known algorithms. (InRange and CompareToRange) |
| [TypeExtensions](Jcd.Math.TypeExtensions.md 'Jcd.Math.TypeExtensions') | |

| Interfaces | |
| :--- | :--- |
| [IDisjointComparer&lt;T1,T2&gt;](Jcd.Math.IDisjointComparer_T1,T2_.md 'Jcd.Math.IDisjointComparer<T1,T2>') | A generic IComparer interface implements a method that compares <br/>two objects of differing types. It is used in conjunction with<br/>the Infinity and Number structs to provide comparisons. |
| [IDisjointEqualityComparer&lt;T1,T2&gt;](Jcd.Math.IDisjointEqualityComparer_T1,T2_.md 'Jcd.Math.IDisjointEqualityComparer<T1,T2>') | Defines methods to support the comparison of two items of differing<br/>types for equality. |
