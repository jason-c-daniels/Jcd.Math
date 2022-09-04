using Jcd.Math.Intervals; 

namespace Jcd.Math.Tests.Intervals;

public class RangeUnitTests
{
    [Theory]
    [InlineData(1,1,1,true)]
    [InlineData(5,10,4,false)]
    [InlineData(5,10,5,true)]
    [InlineData(5,10,8,true)]
    [InlineData(5,10,10,true)]
    [InlineData(5,10,11,false)]
    public void Contains_Value_Returns_Expected_Value_For_Range(byte start, byte end, byte value, bool expectedResult)
    {
        var interval = new Range<byte>(start, end);
        Assert.Equal(expectedResult,interval.Contains(value));
    }
    
    [Theory]
    [InlineData(1,10,0,4,false)]
    [InlineData(1,10,2,4,true)]
    [InlineData(1,10,1,10,true)]
    [InlineData(1,10,2,11,false)]
    public void Firsts_Range_Contains_Other_Range_Returns_Expected_Result(
        byte s1, byte e1, byte s2, byte e2, bool expected)
    {
        var i1 = new Range<byte>(s1, e1);
        var i2 = new Range<byte>(s2, e2);
        Assert.Equal(expected,i1.Contains(i2));
        Assert.Equal(expected,i1.Contains(i2 as IInterval<byte>));
    }

    [Fact]
    public void Default_Is_Invalid()
    {
        Range<byte> @default = default;
        Assert.False(@default.IsValid);
    }

    [Fact]
    public void Constructor_Sets_Expected_Properties()
    {
        var r1 = new Range<byte>(1, 10);
        Assert.True(r1.IsValid);
        Assert.False(r1.IsEmpty);
        Assert.False(r1.IsSingleValue);
        Assert.Equal(1,(byte)r1.Start);
        Assert.Equal(10,(byte)r1.End);

        var r2 = new Range<byte>(11, 11);
        Assert.True(r2.IsValid);
        Assert.False(r2.IsEmpty);
        Assert.True(r2.IsSingleValue);
        Assert.Equal(11,(byte)r2.Start);
        Assert.Equal(11,(byte)r2.End);
    }
}