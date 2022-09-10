#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Numbers](Jcd.Math.Numbers.md 'Jcd.Math.Numbers').[PrimitiveValueComparer](Jcd.Math.Numbers.PrimitiveValueComparer.md 'Jcd.Math.Numbers.PrimitiveValueComparer')

## PrimitiveValueComparer.Compare(ulong, float) Method

Compares a UInt64 to a Single

```csharp
public static int Compare(ulong x, float y);
```
#### Parameters

<a name='Jcd.Math.Numbers.PrimitiveValueComparer.Compare(ulong,float).x'></a>

`x` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The first item to compare

<a name='Jcd.Math.Numbers.PrimitiveValueComparer.Compare(ulong,float).y'></a>

`y` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The second item to compare

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
*  0 when x == y  
* -1 when x lt; y  
*  1 when x gt; y