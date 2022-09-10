#### [Jcd.Math](index.md 'index')
### [Jcd.Math](Jcd.Math.md 'Jcd.Math').[Comparer](Jcd.Math.Comparer.md 'Jcd.Math.Comparer')

## Comparer.Compare<TX,TY>(TX, TY) Method

Compares two values of disparate types.

```csharp
public static int Compare<TX,TY>(TX x, TY y)
    where TX : System.IComparable<TY>;
```
#### Type parameters

<a name='Jcd.Math.Comparer.Compare_TX,TY_(TX,TY).TX'></a>

`TX`

The type for x

<a name='Jcd.Math.Comparer.Compare_TX,TY_(TX,TY).TY'></a>

`TY`

The type for y
#### Parameters

<a name='Jcd.Math.Comparer.Compare_TX,TY_(TX,TY).x'></a>

`x` [TX](Jcd.Math.Comparer.Compare_TX,TY_(TX,TY).md#Jcd.Math.Comparer.Compare_TX,TY_(TX,TY).TX 'Jcd.Math.Comparer.Compare<TX,TY>(TX, TY).TX')

The first item to compare

<a name='Jcd.Math.Comparer.Compare_TX,TY_(TX,TY).y'></a>

`y` [TY](Jcd.Math.Comparer.Compare_TX,TY_(TX,TY).md#Jcd.Math.Comparer.Compare_TX,TY_(TX,TY).TY 'Jcd.Math.Comparer.Compare<TX,TY>(TX, TY).TY')

The second item to compare

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
*  0 when x == y  
* -1 when x lt; y  
*  1 when x gt; y