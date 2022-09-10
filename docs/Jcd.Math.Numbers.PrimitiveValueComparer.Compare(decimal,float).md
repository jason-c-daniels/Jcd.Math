#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Numbers](Jcd.Math.Numbers.md 'Jcd.Math.Numbers').[PrimitiveValueComparer](Jcd.Math.Numbers.PrimitiveValueComparer.md 'Jcd.Math.Numbers.PrimitiveValueComparer')

## PrimitiveValueComparer.Compare(decimal, float) Method

Compares a Decimal to a Single

```csharp
public static int Compare(decimal x, float y);
```
#### Parameters

<a name='Jcd.Math.Numbers.PrimitiveValueComparer.Compare(decimal,float).x'></a>

`x` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The first item to compare

<a name='Jcd.Math.Numbers.PrimitiveValueComparer.Compare(decimal,float).y'></a>

`y` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The second item to compare

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
*  0 when x == y  
* -1 when x lt; y  
*  1 when x gt; y