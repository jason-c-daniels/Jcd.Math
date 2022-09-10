#### [Jcd.Math](index.md 'index')
### [Jcd.Math](Jcd.Math.md 'Jcd.Math').[Comparer](Jcd.Math.Comparer.md 'Jcd.Math.Comparer')

## Comparer.Equals<TX,TY>(TX, TY) Method

Compares two values of disparate types.

```csharp
public static bool Equals<TX,TY>(TX x, TY y)
    where TX : System.IEquatable<TY>;
```
#### Type parameters

<a name='Jcd.Math.Comparer.Equals_TX,TY_(TX,TY).TX'></a>

`TX`

The type for x

<a name='Jcd.Math.Comparer.Equals_TX,TY_(TX,TY).TY'></a>

`TY`

The type for y
#### Parameters

<a name='Jcd.Math.Comparer.Equals_TX,TY_(TX,TY).x'></a>

`x` [TX](Jcd.Math.Comparer.Equals_TX,TY_(TX,TY).md#Jcd.Math.Comparer.Equals_TX,TY_(TX,TY).TX 'Jcd.Math.Comparer.Equals<TX,TY>(TX, TY).TX')

The first item to compare

<a name='Jcd.Math.Comparer.Equals_TX,TY_(TX,TY).y'></a>

`y` [TY](Jcd.Math.Comparer.Equals_TX,TY_(TX,TY).md#Jcd.Math.Comparer.Equals_TX,TY_(TX,TY).TY 'Jcd.Math.Comparer.Equals<TX,TY>(TX, TY).TY')

The second item to compare

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if x == y; false otherwise.