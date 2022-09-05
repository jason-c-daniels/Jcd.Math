#### [Jcd.Math](index.md 'index')
### [Jcd.Math.Intervals](Jcd.Math.Intervals.md 'Jcd.Math.Intervals').[IntervalLimitConstraint](Jcd.Math.Intervals.IntervalLimitConstraint.md 'Jcd.Math.Intervals.IntervalLimitConstraint')

## IntervalLimitConstraint.Unbounded Field

The endpoint in question has no limit and therefore is fully open.

```csharp
public static readonly IntervalLimitConstraint Unbounded;
```

#### Field Value
[IntervalLimitConstraint](Jcd.Math.Intervals.IntervalLimitConstraint.md 'Jcd.Math.Intervals.IntervalLimitConstraint')

### Remarks
For a start point on a one dimensional scale this implies all values from -infinity  
to the end limit are part of the interval. (The end limit may be an open limit  
and therefore exclude the limit point making [-infinity,end) the appropriate  
representation for the interval.