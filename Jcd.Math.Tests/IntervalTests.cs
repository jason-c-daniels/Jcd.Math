using Jcd.Math.Intervals;

namespace Jcd.Math.Tests;

public class IntervalTests
{
    #region Factory method tests

    [Fact]
    public void Default_Instance_Is_Invalid()
    {
        Interval<byte> interval = default;
        Assert.False(interval.IsValid);
    }
    
    [Theory]
    [InlineData(1,1,false,true)]
    [InlineData(0,5,false,false)]
    public void Closed_Creates_A_Closed_Interval_With_The_Correct_Limits(byte start, byte end, bool isEmpty, bool isSingle)
    {
        var interval = Interval.Closed(start, end);
        Assert.True(interval.IsValid);
        Assert.Equal(isSingle,interval.IsSingleValue);
        Assert.Equal(isEmpty,interval.IsEmpty);
        Assert.Equal(start,(byte)interval.Start);
        Assert.Equal(end,(byte)interval.End);
        Assert.True(interval.Start.IsClosed);
        Assert.True(interval.Start.HasLimitValue);
        Assert.True(interval.End.IsClosed);
        Assert.True(interval.End.HasLimitValue);
    }
    
    [Theory]
    [InlineData(1,1,true,false)]
    [InlineData(0,5,false,false)]
    public void Open_Creates_An_Open_Interval_With_The_Correct_Limits(byte start, byte end, bool isEmpty, bool isSingle)
    {
        var interval = Interval.Open(start, end);
        Assert.True(interval.IsValid);
        Assert.Equal(isSingle,interval.IsSingleValue);
        Assert.Equal(isEmpty,interval.IsEmpty);
        Assert.Equal(start,(byte)interval.Start);
        Assert.Equal(end,(byte)interval.End);
        Assert.True(interval.Start.IsOpen);
        Assert.True(interval.Start.HasLimitValue);
        Assert.True(interval.End.IsOpen);
        Assert.True(interval.End.HasLimitValue);
    }

    [Theory]
    [InlineData(1,1,false,false)]
    [InlineData(0,5,false,false)]
    public void OpenClosed_Creates_An_OpenClosed_Interval_With_The_Correct_Limits(byte start, byte end, bool isEmpty, bool isSingle)
    {
        var interval = Interval.OpenClosed(start, end);
        Assert.True(interval.IsValid);
        Assert.Equal(isSingle,interval.IsSingleValue);
        Assert.Equal(isEmpty,interval.IsEmpty);
        Assert.Equal(start,(byte)interval.Start);
        Assert.Equal(end,(byte)interval.End);
        Assert.True(interval.Start.IsOpen);
        Assert.True(interval.Start.HasLimitValue);
        Assert.True(interval.End.IsClosed);
        Assert.True(interval.End.HasLimitValue);
    }
    
    [Theory]
    [InlineData(1,1,false,false)]
    [InlineData(0,5,false,false)]
    public void ClosedOpen_Creates_A_ClosedOpen_Interval_With_The_Correct_Limits(byte start, byte end, bool isEmpty, bool isSingle)
    {
        var interval = Interval.ClosedOpen(start, end);
        Assert.True(interval.IsValid);
        Assert.Equal(isSingle,interval.IsSingleValue);
        Assert.Equal(isEmpty,interval.IsEmpty);
        Assert.Equal(start,(byte)interval.Start);
        Assert.Equal(end,(byte)interval.End);
        Assert.True(interval.Start.IsClosed);
        Assert.True(interval.Start.HasLimitValue);
        Assert.True(interval.End.IsOpen);
        Assert.True(interval.End.HasLimitValue);
    }
    
    [Theory]
    [InlineData(1,false,false)]
    [InlineData(10,false,false)]
    public void UnboundedOpen_Creates_A_UnboundedOpen_Interval_With_The_Correct_Limits(byte limit,  bool isEmpty, bool isSingle)
    {
        var interval = Interval.UnboundedOpen(limit);
        Assert.True(interval.IsValid);
        Assert.Equal(isSingle,interval.IsSingleValue);
        Assert.Equal(isEmpty,interval.IsEmpty);
        Assert.Equal(limit,(byte)interval.End);
        Assert.True(interval.Start.IsOpen);
        Assert.True(interval.Start.IsUnbounded);
        Assert.True(interval.End.IsOpen);
        Assert.True(interval.End.HasLimitValue);
    }
    
    [Theory]
    [InlineData(1,false,false)]
    [InlineData(10,false,false)]
    public void UnboundedClosed_Creates_A_UnboundedClosed_Interval_With_The_Correct_Limits(byte limit,  bool isEmpty, bool isSingle)
    {
        var interval = Interval.UnboundedClosed(limit);
        Assert.True(interval.IsValid);
        Assert.Equal(isSingle,interval.IsSingleValue);
        Assert.Equal(isEmpty,interval.IsEmpty);
        Assert.Equal(limit,(byte)interval.End);
        Assert.True(interval.Start.IsOpen);
        Assert.True(interval.Start.IsUnbounded);
        Assert.True(interval.End.IsClosed);
        Assert.True(interval.End.HasLimitValue);
    }
    
    [Theory]
    [InlineData(1,false,false)]
    [InlineData(10,false,false)]
    public void OpenUnbounded_Creates_An_OpenUnbounded_Interval_With_The_Correct_Limits(byte limit,  bool isEmpty, bool isSingle)
    {
        var interval = Interval.OpenUnbounded(limit);
        Assert.True(interval.IsValid);
        Assert.Equal(isSingle,interval.IsSingleValue);
        Assert.Equal(isEmpty,interval.IsEmpty);
        Assert.Equal(limit,(byte)interval.Start);
        Assert.True(interval.Start.IsOpen);
        Assert.True(interval.Start.HasLimitValue);
        Assert.True(interval.End.IsOpen);
        Assert.True(interval.End.IsUnbounded);
    }
    
    [Theory]
    [InlineData(1,false,false)]
    [InlineData(10,false,false)]
    public void ClosedUnbounded_Creates_A_ClosedUnbounded_Interval_With_The_Correct_Limits(byte limit,  bool isEmpty, bool isSingle)
    {
        var interval = Interval.ClosedUnbounded(limit);
        Assert.True(interval.IsValid);
        Assert.Equal(isSingle,interval.IsSingleValue);
        Assert.Equal(isEmpty,interval.IsEmpty);
        Assert.Equal(limit,(byte)interval.Start);
        Assert.True(interval.Start.IsClosed);
        Assert.True(interval.Start.HasLimitValue);
        Assert.True(interval.End.IsOpen);
        Assert.True(interval.End.IsUnbounded);
    }
    
    [Fact]
    public void Unbounded_Creates_An_Unbounded_Interval_With_The_Correct_Limits()
    {
        var interval = Interval.Unbounded<byte>();
        Assert.True(interval.IsValid);
        Assert.False(interval.IsSingleValue);
        Assert.False(interval.IsEmpty);
        Assert.True(interval.Start.IsOpen);
        Assert.True(interval.Start.IsUnbounded);
        Assert.True(interval.End.IsOpen);
        Assert.True(interval.End.IsUnbounded);
    }
 
    #endregion
    
    #region Contains and Equality tests

    [Theory]
    [MemberData(nameof(CrossProductOfIntervals))]
    public void Equals_Returns_Expected_Value(Interval<byte> i1, Interval<byte> i2, bool expectedResult)
    {
        Assert.Equal(expectedResult,i1.Equals(i2));
        Assert.Equal(expectedResult,i1.GetHashCode() == i2.GetHashCode());
        Assert.Equal(expectedResult,i1.Equals(i2 as IInterval<byte>));
        Assert.Equal(expectedResult,i1.Equals((object)i2));
        Assert.Equal(expectedResult,i1 == i2);
        Assert.NotEqual(expectedResult,i1 != i2);
    }


    [Fact]
    public void Contains_Interval_Throws_An_Exception_When_Either_Interval_Is_Invalid()
    {
        Interval<byte> invalid = default;
        var valid = Interval.Closed<byte>(10, 20);
        Assert.ThrowsAny<Exception>(() => invalid.Contains(valid));
        Assert.ThrowsAny<Exception>(() => valid.Contains(invalid));
        Assert.ThrowsAny<Exception>(() => invalid.Contains(valid as IInterval<byte>));
        Assert.ThrowsAny<Exception>(() => valid.Contains(invalid as IInterval<byte>));
    }
    
    [Theory]
    [InlineData(1,1,1,true)]
    [InlineData(5,10,4,false)]
    [InlineData(5,10,5,true)]
    [InlineData(5,10,8,true)]
    [InlineData(5,10,10,true)]
    [InlineData(5,10,11,false)]
    public void Contains_Value_Returns_Expected_Value_For_Closed_Interval(byte start, byte end, byte value, bool expectedResult)
    {
        var interval = Interval.Closed(start, end);
        Assert.Equal(expectedResult,interval.Contains(value));
    }

    [Theory]
    [InlineData(1,1,1,false)]
    [InlineData(5,10,4,false)]
    [InlineData(5,10,5,false)]
    [InlineData(5,10,8,true)]
    [InlineData(5,10,10,false)]
    [InlineData(5,10,11,false)]
    public void Contains_Value_Returns_Expected_Value_For_Open_Interval(byte start, byte end, byte value, bool expectedResult)
    {
        var interval = Interval.Open(start, end);
        Assert.Equal(expectedResult,interval.Contains(value));
    }

    [Theory]
    [InlineData(1,10,0,4,false)]
    [InlineData(1,10,2,4,true)]
    [InlineData(1,10,1,10,true)]
    [InlineData(1,10,2,11,false)]
    public void Firsts_Interval_Contains_Other_Interval_Returns_Expected_Result_For_Closed_Intervals(
        byte s1, byte e1, byte s2, byte e2, bool expected)
    {
        var i1 = Interval.Closed(s1, e1);
        var i2 = Interval.Closed(s2, e2);
        Assert.Equal(expected,i1.Contains(i2));
        Assert.Equal(expected,i1.Contains(i2 as IInterval<byte>));
    }

    
    [Theory]
    [InlineData(1,10,0,4,false)]
    [InlineData(1,10,2,4,true)]
    [InlineData(1,10,1,10,true)]
    [InlineData(1,10,2,11,false)]
    public void Firsts_Interval_Contains_Other_Interval_Returns_Expected_Result_For_Open_Intervals(
        byte s1, byte e1, byte s2, byte e2, bool expected)
    {
        var i1 = Interval.Closed(s1, e1);
        var i2 = Interval.Closed(s2, e2);
        Assert.Equal(expected,i1.Contains(i2));
        Assert.Equal(expected,i1.Contains(i2 as IInterval<byte>));
    }
    
    #endregion
    
    public static IEnumerable<object[]> CrossProductOfIntervals 
    {
        get
        {
            const byte start = 10;
            const byte end = 20;
            var intervals = new[]
            {
                Interval.Unbounded<byte>(),
                Interval.ClosedUnbounded(start),
                Interval.OpenUnbounded(start),
                Interval.UnboundedOpen(end),
                Interval.UnboundedClosed(end),
                Interval.Closed(start,end),
                Interval.Open(start,end),
                Interval.OpenClosed(start,end),
                Interval.ClosedOpen(start,end)
            };

            foreach (var i1 in intervals)
            {
                foreach (var i2 in intervals)
                {
                    yield return new[] { i1, i2, (object)(
                           i1.Start.Constraint == i2.Start.Constraint 
                        && i1.Start.LimitType == i2.Start.LimitType 
                        && i1.End.Constraint == i2.End.Constraint 
                        && i1.End.LimitType == i2.End.LimitType 
                        ) };
                }
            }
        }
    }

}