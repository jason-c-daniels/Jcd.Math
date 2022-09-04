using Jcd.Math.Intervals;

namespace Jcd.Math.Tests.Intervals;

public class ComparableExtensionsUnitTests
{
    [Theory]
    [InlineData(1,0,5,true)]
    [InlineData(1,2,10,false)]
    [InlineData(2,2,10,true)]
    [InlineData(10,2,10,true)]
    [InlineData(11,2,10,false)]
    public void InRange_Returns_Expected_Value_For_Range(int value, int start, int end, bool expected)
    {
        Assert.Equal(expected,value.InRange(start,end));
    }
    
    [Theory]
    [InlineData(1,0,5,0)]
    [InlineData(1,2,10,-1)]
    [InlineData(2,2,10,0)]
    [InlineData(10,2,10,0)]
    [InlineData(11,2,10,1)]
    public void CompareToRange_Returns_Expected_Value_For_Range(int value, int start, int end, int expected)
    {
        Assert.Equal(expected,value.CompareToRange(start,end));
    }
}