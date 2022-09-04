using Jcd.Math.Intervals;

namespace Jcd.Math.Tests.Intervals;

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
    public void CompareTo_Object_Returns_1_When_Given_Null()
    {
        var limit = IntervalLimit.ClosedStart(10);
        Assert.Equal(1,limit.CompareTo(null));
    }

    [Fact]
    public void CompareTo_Object_Returns_0_For_Underlying_Value()
    {
        var value = 10;
        var limit = IntervalLimit.ClosedStart(value);
        Assert.Equal(0,limit.CompareTo((object)value));
    }

    
    [Fact]
    public void Cast_To_Underlying_Type_Returns_Correct_Value()
    {
        var lv = 10;
        var cs = IntervalLimit.ClosedStart(lv);
        var os = IntervalLimit.OpenStart(lv);
        var ce = IntervalLimit.ClosedEnd(lv);
        var oe = IntervalLimit.OpenEnd(lv);
        Assert.Equal(lv,(int)cs);
        Assert.Equal(lv,(int)ce);
        Assert.Equal(lv,(int)os);
        Assert.Equal(lv,(int)oe);
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void Value_At_Closed_Limit_Is_Equal_To_Limit(byte limit)
    {
        var cs = IntervalLimit.ClosedStart(limit);
        var ce = IntervalLimit.ClosedEnd(limit);

        Assert.True(cs == limit);
        Assert.True(ce == limit);
        Assert.True(cs >= limit);
        Assert.True(ce >= limit);
        Assert.True(cs <= limit);
        Assert.True(ce <= limit);

        Assert.True(limit == cs);
        Assert.True(limit == ce);
        Assert.True(limit >= cs);
        Assert.True(limit >= ce);
        Assert.True(limit <= cs);
        Assert.True(limit <= ce);

        Assert.Equal(0, cs.CompareTo(limit));
        Assert.Equal(0, ce.CompareTo(limit));

        Assert.False(cs != limit);
        Assert.False(ce != limit);
        Assert.False(cs < limit);
        Assert.False(ce < limit);
        Assert.False(cs > limit);
        Assert.False(ce > limit);

        Assert.False(limit != cs);
        Assert.False(limit != ce);
        Assert.False(limit < cs);
        Assert.False(limit < ce);
        Assert.False(limit > cs);
        Assert.False(limit > ce);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void Value_At_Open_Limit_Is_Not_Equal_To_Limit(byte limit)
    {
        var os = IntervalLimit.OpenStart(limit);
        var oe = IntervalLimit.OpenEnd(limit);

        Assert.True(os != limit);
        Assert.True(oe != limit);
        Assert.True(os > limit);
        Assert.True(oe < limit);
        Assert.True(os >= limit);
        Assert.True(oe <= limit);
        Assert.True(limit != os);
        Assert.True(limit != oe);
        Assert.True(limit <= os);
        Assert.True(limit >= oe);
        Assert.True(limit < os);
        Assert.True(limit > oe);
        Assert.NotEqual(0, os.CompareTo(limit));
        Assert.NotEqual(0, oe.CompareTo(limit));
        Assert.False(os == limit);
        Assert.False(oe == limit);
        Assert.False(os <= limit);
        Assert.False(oe >= limit);
        Assert.False(limit == os);
        Assert.False(limit == oe);
        Assert.False(limit > os);
        Assert.False(limit < oe);
        Assert.False(limit >= os);
        Assert.False(limit <= oe);
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
        Assert.Equal(1, limit.CompareTo(value));
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
        Assert.Equal(-1, limit.CompareTo(value));
    }

    #endregion

    #region IntervalLimit to IntervalLimit Relational and Equivalence operator tests

    [Fact]
    public void ClosedStart_Equals_Returns_True_When_Both_Have_Same_Limit()
    {
        const byte value = 1;
        var cs1 = IntervalLimit.ClosedStart(value);
        var cs2 = IntervalLimit.ClosedStart(value);

        Assert.True(cs1 == cs2);
        Assert.Equal(0, cs1.CompareTo(cs2));
        Assert.Equal(0, cs2.CompareTo(cs1));
        Assert.False(cs1 != cs2);
    }

    [Fact]
    public void ClosedEnd_Equals_Returns_True_When_Both_Have_Same_Limit()
    {
        const byte value = 1;
        var l1 = IntervalLimit.ClosedEnd(value);
        var l2 = IntervalLimit.ClosedEnd(value);

        Assert.True(l1 == l2);
        Assert.Equal(0, l1.CompareTo(l2));
        Assert.Equal(0, l2.CompareTo(l1));
        Assert.False(l1 != l2);
    }

    [Fact]
    public void OpenStart_Equals_Returns_True_When_Both_Have_Same_Limit()
    {
        const byte value = 1;
        var os1 = IntervalLimit.OpenStart(value);
        var os2 = IntervalLimit.OpenStart(value);

        Assert.True(os1 == os2);
        Assert.Equal(0, os1.CompareTo(os2));
        Assert.Equal(0, os2.CompareTo(os1));
        Assert.False(os1 != os2);
    }

    [Fact]
    public void OpenEnd_Equals_Returns_True_When_Both_Have_Same_Limit()
    {
        const byte value = 1;
        var l1 = IntervalLimit.OpenEnd(value);
        var l2 = IntervalLimit.OpenEnd(value);

        Assert.True(l1 == l2);
        Assert.Equal(0, l1.CompareTo(l2));
        Assert.Equal(0, l2.CompareTo(l1));
        Assert.False(l1 != l2);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void ClosedStart_IntervalLimit_Is_Always_Less_Than_OpenStart_IntervalLimit_For_Any_Given_Limit_Value(
        byte value)
    {
        var closedStart = IntervalLimit.ClosedStart(value);
        var openStart = IntervalLimit.OpenStart(value);

        Assert.True(closedStart < openStart);
        Assert.True(openStart >= closedStart);
        Assert.False(closedStart >= openStart);
        Assert.False(openStart < closedStart);
        Assert.Equal(-1, closedStart.CompareTo(openStart));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void ClosedEnd_IntervalLimit_Is_Always_Greater_Than_OpenEnd_IntervalLimit_For_Any_Given_Limit_Value(
        byte value)
    {
        var closedEnd = IntervalLimit.ClosedEnd(value);
        var openEnd = IntervalLimit.OpenEnd(value);

        Assert.True(closedEnd > openEnd);
        Assert.True(openEnd < closedEnd);
        Assert.False(closedEnd <= openEnd);
        Assert.False(openEnd >= closedEnd);
        Assert.Equal(1, closedEnd.CompareTo(openEnd));
        Assert.Equal(-1, openEnd.CompareTo(closedEnd));
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
        Assert.Equal(-1, closedStart.CompareTo(closedEnd));
        Assert.Equal(1, closedEnd.CompareTo(closedStart));
    }


    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(128)]
    [InlineData(129)]
    [InlineData(255)]
    public void ClosedStart_IntervalLimit_Is_Less_Than_ClosedEnd_IntervalLimit_When_Start_Limit_Is_Less_Than_End_Limit(
        byte closedEndLimit)
    {
        var closedStartLimit = (byte)(closedEndLimit - 1);
        var closedStart = IntervalLimit.ClosedStart(closedStartLimit);
        var closedEnd = IntervalLimit.ClosedEnd(closedEndLimit);
        Assert.True(closedStart < closedEnd);
        Assert.True(closedEnd > closedStart);
        Assert.False(closedStart > closedEnd);
        Assert.False(closedEnd < closedStart);
        Assert.Equal(-1, closedStart.CompareTo(closedEnd));
        Assert.Equal(-1, closedStart.CompareTo((object)closedEnd));
        Assert.Equal(1, closedEnd.CompareTo(closedStart));
        Assert.Equal(1, closedEnd.CompareTo((object)closedStart));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(128)]
    [InlineData(129)]
    [InlineData(255)]
    public void ClosedStart_IntervalLimit_Is_Less_Than_OpenEnd_IntervalLimit_When_Start_Limit_Is_Less_Than_End_Limit(
        byte openEndLimit)
    {
        var closedStartLimit = (byte)(openEndLimit - 1);
        var closedStart = IntervalLimit.ClosedStart(closedStartLimit);
        var openEnd = IntervalLimit.OpenEnd(openEndLimit);
        Assert.True(closedStart < openEnd);
        Assert.True(openEnd > closedStart);
        Assert.False(closedStart > openEnd);
        Assert.False(openEnd < closedStart);
        Assert.Equal(-1, closedStart.CompareTo(openEnd));
        Assert.Equal(-1, closedStart.CompareTo((object)openEnd));
        Assert.Equal(1, openEnd.CompareTo(closedStart));
        Assert.Equal(1, openEnd.CompareTo((object)closedStart));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(128)]
    [InlineData(129)]
    [InlineData(255)]
    public void OpenStart_IntervalLimit_Is_Less_Than_ClosedEnd_IntervalLimit_When_Start_Limit_Is_Less_Than_End_Limit(
        byte closedEndLimit)
    {
        var openStartLimit = (byte)(closedEndLimit - 1);
        var openStart = IntervalLimit.OpenStart(openStartLimit);
        var closedEnd = IntervalLimit.ClosedEnd(closedEndLimit);
        Assert.True(openStart < closedEnd);
        Assert.True(closedEnd > openStart);
        Assert.False(openStart > closedEnd);
        Assert.False(closedEnd < openStart);
        Assert.Equal(-1, openStart.CompareTo(closedEnd));
        Assert.Equal(-1, openStart.CompareTo((object)closedEnd));
        Assert.Equal(1, closedEnd.CompareTo(openStart));
        Assert.Equal(1, closedEnd.CompareTo((object)openStart));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(128)]
    [InlineData(129)]
    [InlineData(255)]
    public void OpenStart_IntervalLimit_Is_Less_Than_OpenEnd_IntervalLimit_When_Start_Limit_Is_Less_Than_End_Limit(
        byte openEndLimit)
    {
        var openStartLimit = (byte)(openEndLimit - 1);
        var openStart = IntervalLimit.OpenStart(openStartLimit);
        var openEnd = IntervalLimit.OpenEnd(openEndLimit);
        Assert.True(openStart < openEnd);
        Assert.True(openEnd > openStart);
        Assert.False(openStart > openEnd);
        Assert.False(openEnd < openStart);
        Assert.Equal(-1, openStart.CompareTo(openEnd));
        Assert.Equal(-1, openStart.CompareTo((object)openEnd));
        Assert.Equal(1, openEnd.CompareTo(openStart));
        Assert.Equal(1, openEnd.CompareTo((object)openStart));
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
        Assert.Equal(-1, openStart.CompareTo(openEnd));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(254)]
    public void
        ClosedStart_IntervalLimit_Is_Greater_Than_ClosedEnd_IntervalLimit_When_Start_Limit_Is_Greater_Than_End_Limit(
            byte closedEndLimit)
    {
        var closedStartLimit = (byte)(closedEndLimit + 1);
        var closedStart = IntervalLimit.ClosedStart(closedStartLimit);
        var closedEnd = IntervalLimit.ClosedEnd(closedEndLimit);
        Assert.True(closedStart > closedEnd);
        Assert.True(closedEnd < closedStart);
        Assert.False(closedStart < closedEnd);
        Assert.False(closedEnd > closedStart);
        Assert.Equal(1, closedStart.CompareTo(closedEnd));
        Assert.Equal(1, closedStart.CompareTo((object)closedEnd));
        Assert.Equal(-1, closedEnd.CompareTo(closedStart));
        Assert.Equal(-1, closedEnd.CompareTo((object)closedStart));
    }

    
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(254)]
    public void
        ClosedStart_IntervalLimit_Is_Greater_Than_OpenStart_When_ClosedStart_Limit_Is_Greater_Than_OpenStart_Limit(
            byte openStartLimit)
    {
        var closedStartLimit = (byte)(openStartLimit + 1);
        var closedStart = IntervalLimit.ClosedStart(closedStartLimit);
        var openStart = IntervalLimit.OpenStart(openStartLimit);
        Assert.True(closedStart > openStart);
        Assert.True(openStart < closedStart);
        Assert.False(closedStart < openStart);
        Assert.False(openStart > closedStart);
        Assert.Equal(1, closedStart.CompareTo(openStart));
        Assert.Equal(1, closedStart.CompareTo((object)openStart));
        Assert.Equal(-1, openStart.CompareTo(closedStart));
        Assert.Equal(-1, openStart.CompareTo((object)closedStart));
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
        Assert.True(closedEnd < openEnd);
        Assert.True(openEnd > closedEnd);
        Assert.False(closedEnd > openEnd);
        Assert.False(openEnd < closedEnd);
        Assert.Equal(-1, closedEnd.CompareTo(openEnd));
        Assert.Equal(-1, closedEnd.CompareTo((object)openEnd));
        Assert.Equal(1, openEnd.CompareTo(closedEnd));
        Assert.Equal(1, openEnd.CompareTo((object)closedEnd));
    }


    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void UnboundedStart_IntervalLimit_Is_Always_Less_Than_ClosedStart_IntervalLimit_For_Any_Given_Limit_Value(
        byte value)
    {
        var unboundedStart = IntervalLimit.UnboundedStart<byte>();
        var closedStart = IntervalLimit.ClosedStart(value);

        Assert.True(unboundedStart < closedStart);
        Assert.True(closedStart > unboundedStart);
        Assert.False(unboundedStart >= closedStart);
        Assert.False(closedStart <= unboundedStart);
        Assert.Equal(-1, unboundedStart.CompareTo(closedStart));
        Assert.Equal(-1, unboundedStart.CompareTo((object)closedStart));
        Assert.Equal(1, closedStart.CompareTo(unboundedStart));
        Assert.Equal(1, closedStart.CompareTo((object)unboundedStart));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void UnboundedStart_IntervalLimit_Is_Always_Less_Than_ClosedEnd_IntervalLimit_For_Any_Given_Limit_Value(
        byte value)
    {
        var unboundedStart = IntervalLimit.UnboundedStart<byte>();
        var closedEnd = IntervalLimit.ClosedEnd(value);

        Assert.True(unboundedStart < closedEnd);
        Assert.True(closedEnd > unboundedStart);
        Assert.False(unboundedStart >= closedEnd);
        Assert.False(closedEnd <= unboundedStart);
        Assert.Equal(-1, unboundedStart.CompareTo(closedEnd));
        Assert.Equal(-1, unboundedStart.CompareTo((object)closedEnd));
        Assert.Equal(1, closedEnd.CompareTo(unboundedStart));
        Assert.Equal(1, closedEnd.CompareTo((object)unboundedStart));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void UnboundedEnd_IntervalLimit_Is_Always_Greater_Than_ClosedEnd_IntervalLimit_For_Any_Given_Limit_Value(
        byte value)
    {
        var unboundedEnd = IntervalLimit.UnboundedEnd<byte>();
        var closedEnd = IntervalLimit.ClosedEnd(value);

        Assert.True(unboundedEnd > closedEnd);
        Assert.True(closedEnd < unboundedEnd);
        Assert.False(unboundedEnd <= closedEnd);
        Assert.False(closedEnd >= unboundedEnd);
        Assert.Equal(1, unboundedEnd.CompareTo(closedEnd));
        Assert.Equal(1, unboundedEnd.CompareTo((object)closedEnd));
        Assert.Equal(-1, closedEnd.CompareTo(unboundedEnd));
        Assert.Equal(-1, closedEnd.CompareTo((object)unboundedEnd));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void UnboundedEnd_IntervalLimit_Is_Always_Greater_Than_ClosedStart_IntervalLimit_For_Any_Given_Limit_Value(
        byte value)
    {
        var unboundedEnd = IntervalLimit.UnboundedEnd<byte>();
        var closedStart = IntervalLimit.ClosedStart(value);

        Assert.True(unboundedEnd > closedStart);
        Assert.True(closedStart < unboundedEnd);
        Assert.False(unboundedEnd <= closedStart);
        Assert.False(closedStart >= unboundedEnd);
        Assert.Equal(1, unboundedEnd.CompareTo(closedStart));
        Assert.Equal(1, unboundedEnd.CompareTo((object)closedStart));
        Assert.Equal(-1, closedStart.CompareTo(unboundedEnd));
        Assert.Equal(-1, closedStart.CompareTo((object)unboundedEnd));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void UnboundedStart_IntervalLimit_Is_Always_Less_Than_OpenStart_IntervalLimit_For_Any_Given_Limit_Value(
        byte value)
    {
        var unboundedStart = IntervalLimit.UnboundedStart<byte>();
        var openStart = IntervalLimit.OpenStart(value);

        Assert.True(unboundedStart < openStart);
        Assert.True(openStart > unboundedStart);
        Assert.False(unboundedStart >= openStart);
        Assert.False(openStart <= unboundedStart);
        Assert.Equal(-1, unboundedStart.CompareTo(openStart));
        Assert.Equal(-1, unboundedStart.CompareTo((object)openStart));
        Assert.Equal(1, openStart.CompareTo(unboundedStart));
        Assert.Equal(1, openStart.CompareTo((object)unboundedStart));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void UnboundedEnd_IntervalLimit_Is_Always_Greater_Than_OpenEnd_IntervalLimit_For_Any_Given_Limit_Value(
        byte value)
    {
        var unboundedEnd = IntervalLimit.UnboundedEnd<byte>();
        var openEnd = IntervalLimit.OpenEnd(value);

        Assert.True(unboundedEnd > openEnd);
        Assert.True(openEnd < unboundedEnd);
        Assert.False(unboundedEnd <= openEnd);
        Assert.False(openEnd >= unboundedEnd);
        Assert.Equal(1, unboundedEnd.CompareTo(openEnd));
        Assert.Equal(1, unboundedEnd.CompareTo((object)openEnd));
        Assert.Equal(-1, openEnd.CompareTo(unboundedEnd));
        Assert.Equal(-1, openEnd.CompareTo((object)unboundedEnd));
    }

    [Fact]
    public void UnboundedStart_Equals_UnboundedStart()
    {
        var s1 = IntervalLimit.UnboundedStart<int>();
        var s2 = IntervalLimit.UnboundedStart<int>();
        Assert.Equal(s1, s2);
        Assert.Equal(0, s1.CompareTo(s2));
        Assert.True(s1.Equals(s2));
        Assert.Equal(0, s1.CompareTo((object)s2));
        Assert.True(s1.Equals((object)s2));
        Assert.True(s1 == s2);
    }

    [Fact]
    public void UnboundedEnd_Equals_UnboundedEnd()
    {
        var s1 = IntervalLimit.UnboundedStart<int>();
        var s2 = IntervalLimit.UnboundedStart<int>();
        Assert.Equal(s1, s2);
        Assert.Equal(0, s1.CompareTo(s2));
        Assert.True(s1.Equals(s2));
        Assert.Equal(0, s1.CompareTo((object)s2));
        Assert.True(s1.Equals((object)s2));
        Assert.True(s1 == s2);
    }

    #endregion

    #region GetHashCode Tests

    [Theory]
    [MemberData(nameof(CrossProductOfLimitTypes))]
    public void GetHashCode_Comparison_Returns_Expected_Value(IntervalLimit<byte> left, IntervalLimit<byte> right, bool expectEquivalent)
    {
        Assert.Equal(expectEquivalent, left.GetHashCode() == right.GetHashCode());
    }

    #endregion

    public static IEnumerable<object[]> CrossProductOfLimitTypes 
    {
        get
        {
            const byte limit = 10;
            var limits = new[]
            {
                IntervalLimit.UnboundedStart<byte>(),
                IntervalLimit.UnboundedEnd<byte>(),
                IntervalLimit.OpenStart(limit),
                IntervalLimit.OpenEnd(limit),
                IntervalLimit.ClosedStart(limit),
                IntervalLimit.ClosedEnd(limit)
            };

            foreach (var l1 in limits)
            {
                foreach (var l2 in limits)
                {
                    yield return new[] { l1, l2, (object)(l1 == l2) };
                }
            }
        }
    }
}
