using Jcd.Math.Intervals;

namespace Jcd.Math.Tests;

public class IntervalLimitTests
{
    #region factory method tests
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(8)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void ClosedEnd_Returns_A_Closed_End_Limit_With_Provided_Value(byte value)
    {
        var ce = IntervalLimit<byte>.ClosedEnd(value);
        var ce2 = IntervalLimit.ClosedEnd(value);
        Assert.Equal(IntervalLimitType.End, ce.LimitType);
        Assert.True(ce.HasLimitValue);
        Assert.True(ce.IsClosed);
        Assert.True(ce.IsEnd);
        Assert.False(ce.IsUnbounded);
        Assert.False(ce.IsOpen);
        Assert.False(ce.IsStart);
        Assert.Equal(IntervalLimitType.End, ce2.LimitType);
        Assert.True(ce2.HasLimitValue);
        Assert.True(ce2.IsClosed);
        Assert.True(ce2.IsEnd);
        Assert.False(ce2.IsUnbounded);
        Assert.False(ce2.IsOpen);
        Assert.False(ce2.IsStart);
    }
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(8)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void ClosedStart_Returns_A_Closed_Start_Limit_With_Provided_Value(byte value)
    {
        var ce = IntervalLimit<byte>.ClosedStart(value);
        var ce2 = IntervalLimit.ClosedStart(value);
        Assert.Equal(IntervalLimitType.Start, ce.LimitType);
        Assert.True(ce.HasLimitValue);
        Assert.True(ce.IsClosed);
        Assert.True(ce.IsStart);
        Assert.False(ce.IsUnbounded);
        Assert.False(ce.IsOpen);
        Assert.False(ce.IsEnd);
        Assert.Equal(IntervalLimitType.Start, ce2.LimitType);
        Assert.True(ce2.HasLimitValue);
        Assert.True(ce2.IsClosed);
        Assert.True(ce2.IsStart);
        Assert.False(ce2.IsUnbounded);
        Assert.False(ce2.IsOpen);
        Assert.False(ce2.IsEnd);
    }
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(8)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void OpenEnd_Returns_An_Open_End_Limit_With_Provided_Value(byte value)
    {
        var ce = IntervalLimit<byte>.OpenEnd(value);
        var ce2 = IntervalLimit.OpenEnd(value);
        Assert.Equal(IntervalLimitType.End, ce.LimitType);
        Assert.True(ce.HasLimitValue);
        Assert.True(ce.IsOpen);
        Assert.True(ce.IsEnd);
        Assert.False(ce.IsUnbounded);
        Assert.False(ce.IsClosed);
        Assert.False(ce.IsStart);
        Assert.Equal(IntervalLimitType.End, ce2.LimitType);
        Assert.True(ce2.HasLimitValue);
        Assert.True(ce2.IsOpen);
        Assert.True(ce2.IsEnd);
        Assert.False(ce2.IsUnbounded);
        Assert.False(ce2.IsClosed);
        Assert.False(ce2.IsStart);
    }
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(8)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void OpenStart_Returns_A_Open_Start_Limit_With_Provided_Value(byte value)
    {
        var ce = IntervalLimit<byte>.OpenStart(value);
        var ce2 = IntervalLimit.OpenStart(value);
        Assert.Equal(IntervalLimitType.Start, ce.LimitType);
        Assert.True(ce.HasLimitValue);
        Assert.True(ce.IsOpen);
        Assert.True(ce.IsStart);
        Assert.False(ce.IsUnbounded);
        Assert.False(ce.IsClosed);
        Assert.False(ce.IsEnd);
        Assert.Equal(IntervalLimitType.Start, ce2.LimitType);
        Assert.True(ce2.HasLimitValue);
        Assert.True(ce2.IsOpen);
        Assert.True(ce2.IsStart);
        Assert.False(ce2.IsUnbounded);
        Assert.False(ce2.IsClosed);
        Assert.False(ce2.IsEnd);
    }

    [Fact]
    public void UnboundedEnd_Returns_An_Unbounded_End_Limit_With_Default_Value()
    {
        var ce = IntervalLimit<byte>.UnboundedEnd();
        var ce2 = IntervalLimit.UnboundedEnd<byte>();
        Assert.Equal(IntervalLimitType.End, ce.LimitType);
        Assert.True(ce.IsUnbounded);
        Assert.True(ce.IsOpen);
        Assert.True(ce.IsEnd);
        Assert.False(ce.HasLimitValue);
        Assert.False(ce.IsClosed);
        Assert.False(ce.IsStart);
        Assert.Equal(IntervalLimitType.End, ce2.LimitType);
        Assert.True(ce2.IsUnbounded);
        Assert.True(ce2.IsOpen);
        Assert.True(ce2.IsEnd);
        Assert.False(ce2.HasLimitValue);
        Assert.False(ce2.IsClosed);
        Assert.False(ce2.IsStart);
    }
    
    [Fact]
    public void UnboundedStart_Returns_An_Unbounded_Start_Limit_With_Default_Value()
    {
        var ce = IntervalLimit<byte>.UnboundedStart();
        var ce2 = IntervalLimit.UnboundedStart<byte>();
        Assert.Equal(IntervalLimitType.Start, ce.LimitType);
        Assert.True(ce.IsUnbounded);
        Assert.True(ce.IsOpen);
        Assert.True(ce.IsStart);
        Assert.False(ce.HasLimitValue);
        Assert.False(ce.IsClosed);
        Assert.False(ce.IsEnd);
        Assert.Equal(IntervalLimitType.Start, ce2.LimitType);
        Assert.True(ce2.IsUnbounded);
        Assert.True(ce2.IsOpen);
        Assert.True(ce2.IsStart);
        Assert.False(ce2.HasLimitValue);
        Assert.False(ce2.IsClosed);
        Assert.False(ce2.IsEnd);
    }

    #endregion
    
    #region value to limit comparison tests
    [Fact]
    public void Value_At_Closed_Limit_Is_Equal_To_Limit()
    {
        byte value = 10;
        var limit1 = IntervalLimit.ClosedStart(value);
        Assert.True(limit1.Equals(value));
        Assert.True(limit1 == value);
        Assert.False(limit1 != value);
        Assert.Equal(0,limit1.CompareTo(value));
        var limit2 = IntervalLimit.ClosedEnd(value);
        Assert.True(limit2.Equals(value));
        Assert.True(limit2 == value);
        Assert.False(limit2 != value);
        Assert.Equal(0,limit2.CompareTo(value));
    }
    
    [Fact]
    public void Value_At_Open_Limit_Is_Not_Equal_To_Limit()
    {
        byte value = 10;
        var limit1 = IntervalLimit.OpenStart(value);
        Assert.False(limit1.Equals(value));
        Assert.False(limit1 == value);
        Assert.True(limit1 != value);
        Assert.NotEqual(0,limit1.CompareTo(value));
        var limit2 = IntervalLimit.OpenEnd(value);
        Assert.False(limit2.Equals(value));
        Assert.False(limit2 == value);
        Assert.True(limit2 != value);
        Assert.NotEqual(0,limit2.CompareTo(value));
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void Any_Value_Is_Always_Less_Than_UnboundedEnd(byte value)
    {
        var limit = IntervalLimit<byte>.UnboundedEnd();
        Assert.True(value < limit);
        Assert.False(value >= limit);
        Assert.Equal(1,limit.CompareTo(value));
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void Any_Value_Is_Always_Greater_Than_UnboundedStart(byte value)
    {
        var limit = IntervalLimit<byte>.UnboundedStart();
        Assert.True(value > limit);
        Assert.False(value <= limit);
        Assert.Equal(-1,limit.CompareTo(value));
    }
    
    #endregion

    #region IntervalLimit to IntervalLimit Relational and Equivalence operators 

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void ClosedStart_IntervalLimit_Is_Always_Less_Than_OpenStart_IntervalLimit_For_Any_Given_Limit_Value(byte value)
    {
        var closedStart = IntervalLimit.ClosedStart(value);
        var openStart = IntervalLimit.OpenStart(value);
        
        Assert.True(closedStart < openStart);
        Assert.True(openStart >= closedStart);
        Assert.False(closedStart >= openStart);
        Assert.False(openStart < closedStart);
        Assert.Equal(-1,closedStart.CompareTo(openStart));
    } 
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void ClosedEnd_IntervalLimit_Is_Always_Greater_Than_OpenEnd_IntervalLimit_For_Any_Given_Limit_Value(byte value)
    {
        var closedEnd = IntervalLimit.ClosedEnd(value);
        var openEnd = IntervalLimit.OpenEnd(value);
        
        Assert.True(closedEnd > openEnd);
        Assert.True(openEnd < closedEnd);
        Assert.False(closedEnd <= openEnd);
        Assert.False(openEnd >= closedEnd);
        Assert.Equal(1,closedEnd.CompareTo(openEnd));
        Assert.Equal(-1,openEnd.CompareTo(closedEnd));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void ClosedStart_IntervalLimit_Is_Less_Than_ClosedEnd_IntervalLimit_For_Any_Given_Limit_Value(byte value)
    {
        var closedStart = IntervalLimit.ClosedStart(value);
        var closedEnd = IntervalLimit.ClosedEnd(value);
        Assert.True(closedStart < closedEnd);
        Assert.True(closedEnd > closedStart);
        Assert.False(closedStart >= closedEnd);
        Assert.False(closedEnd <= closedStart);
        Assert.Equal(-1,closedStart.CompareTo(closedEnd));
        Assert.Equal(1,closedEnd.CompareTo(closedStart));
    }

    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(128)]
    [InlineData(129)]
    [InlineData(255)]
    public void ClosedStart_IntervalLimit_Is_Less_Than_ClosedEnd_IntervalLimit_When_Start_Limit_Is_Less_Than_End_Limit(byte closedEndLimit)
    {
        var closedStartLimit = (byte)(closedEndLimit - 1);
        var closedStart = IntervalLimit.ClosedStart(closedStartLimit);
        var closedEnd = IntervalLimit.ClosedEnd(closedEndLimit);
        Assert.True(closedStart<closedEnd);
        Assert.True(closedEnd>closedStart);
        Assert.False(closedStart>closedEnd);
        Assert.False(closedEnd<closedStart);
        Assert.Equal(-1,closedStart.CompareTo(closedEnd));
        Assert.Equal(-1,closedStart.CompareTo((object)closedEnd));
        Assert.Equal(1,closedEnd.CompareTo(closedStart));
        Assert.Equal(1,closedEnd.CompareTo((object)closedStart));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(128)]
    [InlineData(129)]
    [InlineData(255)]
    public void ClosedStart_IntervalLimit_Is_Less_Than_OpenEnd_IntervalLimit_When_Start_Limit_Is_Less_Than_End_Limit(byte openEndLimit)
    {
        var closedStartLimit = (byte)(openEndLimit - 1);
        var closedStart = IntervalLimit.ClosedStart(closedStartLimit);
        var openEnd = IntervalLimit.OpenEnd(openEndLimit);
        Assert.True(closedStart<openEnd);
        Assert.True(openEnd>closedStart);
        Assert.False(closedStart>openEnd);
        Assert.False(openEnd<closedStart);
        Assert.Equal(-1,closedStart.CompareTo(openEnd));
        Assert.Equal(-1,closedStart.CompareTo((object)openEnd));
        Assert.Equal(1,openEnd.CompareTo(closedStart));
        Assert.Equal(1,openEnd.CompareTo((object)closedStart));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(128)]
    [InlineData(129)]
    [InlineData(255)]
    public void OpenStart_IntervalLimit_Is_Less_Than_ClosedEnd_IntervalLimit_When_Start_Limit_Is_Less_Than_End_Limit(byte closedEndLimit)
    {
        var openStartLimit = (byte)(closedEndLimit - 1);
        var openStart = IntervalLimit.OpenStart(openStartLimit);
        var closedEnd = IntervalLimit.ClosedEnd(closedEndLimit);
        Assert.True(openStart<closedEnd);
        Assert.True(closedEnd>openStart);
        Assert.False(openStart>closedEnd);
        Assert.False(closedEnd<openStart);
        Assert.Equal(-1,openStart.CompareTo(closedEnd));
        Assert.Equal(-1,openStart.CompareTo((object)closedEnd));
        Assert.Equal(1,closedEnd.CompareTo(openStart));
        Assert.Equal(1,closedEnd.CompareTo((object)openStart));
    }
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(128)]
    [InlineData(129)]
    [InlineData(255)]
    public void OpenStart_IntervalLimit_Is_Less_Than_OpenEnd_IntervalLimit_When_Start_Limit_Is_Less_Than_End_Limit(byte openEndLimit)
    {
        var openStartLimit = (byte)(openEndLimit - 1);
        var openStart = IntervalLimit.OpenStart(openStartLimit);
        var openEnd = IntervalLimit.OpenEnd(openEndLimit);
        Assert.True(openStart<openEnd);
        Assert.True(openEnd>openStart);
        Assert.False(openStart>openEnd);
        Assert.False(openEnd<openStart);
        Assert.Equal(-1,openStart.CompareTo(openEnd));
        Assert.Equal(-1,openStart.CompareTo((object)openEnd));
        Assert.Equal(1,openEnd.CompareTo(openStart));
        Assert.Equal(1,openEnd.CompareTo((object)openStart));
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void OpenStart_IntervalLimit_Is_Less_Than_OpenEnd_IntervalLimit_For_Any_Given_Limit_Value(byte value)
    {
        var openStart = IntervalLimit.OpenStart(value);
        var openEnd = IntervalLimit.OpenEnd(value);
        Assert.True(openStart < openEnd);
        Assert.False(openStart >= openEnd);
        Assert.Equal(-1,openStart.CompareTo(openEnd));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(254)]
    public void
        ClosedStart_IntervalLimit_Is_Greater_Than_OpenStart_When_ClosedStart_Limit_Is_Greater_Than_OpenStart_Limit(byte openStartLimit)
    {
        var closedStartLimit = (byte)(openStartLimit + 1);
        var closedStart = IntervalLimit.ClosedStart(closedStartLimit);
        var openStart = IntervalLimit.OpenStart(openStartLimit);
        Assert.True(closedStart>openStart);
        Assert.True(openStart<closedStart);
        Assert.False(closedStart<openStart);
        Assert.False(openStart>closedStart);
        Assert.Equal(1,closedStart.CompareTo(openStart));
        Assert.Equal(1,closedStart.CompareTo((object)openStart));
        Assert.Equal(-1,openStart.CompareTo(closedStart));
        Assert.Equal(-1,openStart.CompareTo((object)closedStart));
    }
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(128)]
    [InlineData(129)]
    [InlineData(255)]
    public void
        ClosedEnd_IntervalLimit_Is_Less_Than_OpenEnd_When_ClosedEnd_Limit_Is_Less_Than_OpenEnd_Limit(byte openEndLimit)
    {
        var closedEndLimit = (byte)(openEndLimit - 1);
        var closedEnd = IntervalLimit.ClosedEnd(closedEndLimit);
        var openEnd = IntervalLimit.OpenEnd(openEndLimit);
        Assert.True(closedEnd<openEnd);
        Assert.True(openEnd>closedEnd);
        Assert.False(closedEnd>openEnd);
        Assert.False(openEnd<closedEnd);
        Assert.Equal(-1,closedEnd.CompareTo(openEnd));
        Assert.Equal(-1,closedEnd.CompareTo((object)openEnd));
        Assert.Equal(1,openEnd.CompareTo(closedEnd));
        Assert.Equal(1,openEnd.CompareTo((object)closedEnd));
    }
    
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void UnboundedStart_IntervalLimit_Is_Always_Less_Than_ClosedStart_IntervalLimit_For_Any_Given_Limit_Value(byte value)
    {
        var unboundedStart = IntervalLimit.UnboundedStart<byte>();
        var closedStart = IntervalLimit.ClosedStart(value);
        
        Assert.True(unboundedStart < closedStart);
        Assert.True(closedStart > unboundedStart);
        Assert.False(unboundedStart >= closedStart);
        Assert.False(closedStart <= unboundedStart);
        Assert.Equal(-1,unboundedStart.CompareTo(closedStart));
        Assert.Equal(-1,unboundedStart.CompareTo((object)closedStart));
        Assert.Equal(1,closedStart.CompareTo(unboundedStart));
        Assert.Equal(1,closedStart.CompareTo((object)unboundedStart));
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void UnboundedEnd_IntervalLimit_Is_Always_Greater_Than_ClosedEnd_IntervalLimit_For_Any_Given_Limit_Value(byte value)
    {
        var unboundedEnd = IntervalLimit.UnboundedEnd<byte>();
        var closedEnd = IntervalLimit.ClosedEnd(value);
        
        Assert.True(unboundedEnd > closedEnd);
        Assert.True(closedEnd < unboundedEnd);
        Assert.False(unboundedEnd <= closedEnd);
        Assert.False(closedEnd >= unboundedEnd);
        Assert.Equal(1,unboundedEnd.CompareTo(closedEnd));
        Assert.Equal(1,unboundedEnd.CompareTo((object)closedEnd));
        Assert.Equal(-1,closedEnd.CompareTo(unboundedEnd));
        Assert.Equal(-1,closedEnd.CompareTo((object)unboundedEnd));
    } 
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void UnboundedStart_IntervalLimit_Is_Always_Less_Than_OpenStart_IntervalLimit_For_Any_Given_Limit_Value(byte value)
    {
        var unboundedStart = IntervalLimit.UnboundedStart<byte>();
        var openStart = IntervalLimit.OpenStart(value);
        
        Assert.True(unboundedStart < openStart);
        Assert.True(openStart > unboundedStart);
        Assert.False(unboundedStart >= openStart);
        Assert.False(openStart <= unboundedStart);
        Assert.Equal(-1,unboundedStart.CompareTo(openStart));
        Assert.Equal(-1,unboundedStart.CompareTo((object)openStart));
        Assert.Equal(1,openStart.CompareTo(unboundedStart));
        Assert.Equal(1,openStart.CompareTo((object)unboundedStart));
    } 
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void UnboundedEnd_IntervalLimit_Is_Always_Greater_Than_OpenEnd_IntervalLimit_For_Any_Given_Limit_Value(byte value)
    {
        var unboundedEnd = IntervalLimit.UnboundedEnd<byte>();
        var openEnd = IntervalLimit.OpenEnd(value);
        
        Assert.True(unboundedEnd > openEnd);
        Assert.True(openEnd < unboundedEnd);
        Assert.False(unboundedEnd <= openEnd);
        Assert.False(openEnd >= unboundedEnd);
        Assert.Equal(1,unboundedEnd.CompareTo(openEnd));
        Assert.Equal(1,unboundedEnd.CompareTo((object)openEnd));
        Assert.Equal(-1,openEnd.CompareTo(unboundedEnd));
        Assert.Equal(-1,openEnd.CompareTo((object)unboundedEnd));
    } 
    
    
    [Fact]
    public void UnboundedStart_Equals_UnboundedStart()
    {
        var s1 = IntervalLimit.UnboundedStart<int>();
        var s2 = IntervalLimit.UnboundedStart<int>();
        Assert.Equal(s1,s2);
        Assert.Equal(0,s1.CompareTo(s2));
        Assert.True(s1.Equals(s2));
        Assert.Equal(0,s1.CompareTo((object)s2));
        Assert.True(s1.Equals((object)s2));
        Assert.True(s1 == s2);
    }

    [Fact]
    public void UnboundedEnd_Equals_UnboundedEnd()
    {
        var s1 = IntervalLimit.UnboundedStart<int>();
        var s2 = IntervalLimit.UnboundedStart<int>();
        Assert.Equal(s1,s2);
        Assert.Equal(0,s1.CompareTo(s2));
        Assert.True(s1.Equals(s2));
        Assert.Equal(0,s1.CompareTo((object)s2));
        Assert.True(s1.Equals((object)s2));
        Assert.True(s1 == s2);
    }

    #endregion
    
}
