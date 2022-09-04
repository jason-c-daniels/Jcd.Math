### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[Range&lt;T&gt;](Jcd.Math.Intervals.Range_T_.md 'Jcd.Math.Intervals.Range<T>')

## Range<T>.IsValid Property

Indicates if the interval was properly constructed.

```csharp
public bool IsValid { get; }
```

Implements [IsValid](Jcd.Math.Intervals.IInterval_T_.IsValid.md 'Jcd.Math.Intervals.IInterval<T>.IsValid')

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

### Remarks
The only way for this to be false is by using an  
uninitialized instance. Sadly, structs zero out all  
fields and properties in an uninitialized instance.  
(This is a .Net standard 2.0 assembly after all)