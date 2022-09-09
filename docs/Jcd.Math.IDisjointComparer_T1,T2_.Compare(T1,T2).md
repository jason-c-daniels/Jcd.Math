#### [Jcd.Math](index.md 'index')
### [Jcd.Math](Jcd.Math.md 'Jcd.Math').[IDisjointComparer&lt;T1,T2&gt;](Jcd.Math.IDisjointComparer_T1,T2_.md 'Jcd.Math.IDisjointComparer<T1,T2>')

## IDisjointComparer<T1,T2>.Compare(T1, T2) Method

Compares an instance of T1 to an instance of T2.

```csharp
int Compare(T1 x, T2 y);
```
#### Parameters

<a name='Jcd.Math.IDisjointComparer_T1,T2_.Compare(T1,T2).x'></a>

`x` [T1](Jcd.Math.IDisjointComparer_T1,T2_.md#Jcd.Math.IDisjointComparer_T1,T2_.T1 'Jcd.Math.IDisjointComparer<T1,T2>.T1')

The first item to compare

<a name='Jcd.Math.IDisjointComparer_T1,T2_.Compare(T1,T2).y'></a>

`y` [T2](Jcd.Math.IDisjointComparer_T1,T2_.md#Jcd.Math.IDisjointComparer_T1,T2_.T2 'Jcd.Math.IDisjointComparer<T1,T2>.T2')

The second item to compare

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
*  0 when x == y  
* -1 when x lt; y  
*  1 when x gt; y