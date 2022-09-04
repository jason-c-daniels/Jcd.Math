using Jcd.Math.Intervals;

// ReSharper disable EqualExpressionComparison

namespace Jcd.Math.Tests.Intervals;

public class IntervalLimitTypeTests
{
    [Fact]
    public void Cast_0_As_Byte_To_IntervalLimitType_Returns_Start()
    {
        const byte value = 0;
        var type = (IntervalLimitType)value;
        Assert.Equal(value.ToString(),type.ToString());
        Assert.Equal(value,(byte)type);
    }
    
    [Fact]
    public void Cast_1_As_Byte_To_IntervalLimitType_Returns_End()
    {
        const byte value = 1;
        var type = (IntervalLimitType)value;
        Assert.Equal(value.ToString(),type.ToString());
        Assert.Equal(value,(byte)type);
    }
    
    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(127)]
    [InlineData(128)]
    [InlineData(255)]
    public void Cast_2_Or_Greater_As_Byte_To_IntervalLimitType_Throws_An_Exception(byte value)
    {
        Assert.ThrowsAny<Exception>(()=>(IntervalLimitType)value);
    }

    [Fact]
    public void Start_LessThan_End_Is_True()
    {
        Assert.True(IntervalLimitType.Start < IntervalLimitType.End);
    }
    
    [Fact]
    public void Start_LessThan_Or_Equals_End_Is_True()
    {
        Assert.True(IntervalLimitType.Start <= IntervalLimitType.End);
    }
    
    [Fact]
    public void Start_GreaterThan_Or_Equals_End_Is_False()
    {
        Assert.False(IntervalLimitType.Start >= IntervalLimitType.End);
    }
    
    [Fact]
    public void Start_GreaterThan_End_Is_False()
    {
        Assert.False(IntervalLimitType.Start > IntervalLimitType.End);
    }
    
    [Fact]
    public void Start_Equals_Start_Is_True()
    {
        var s1 = IntervalLimitType.Start;
        var s2 = IntervalLimitType.Start;
        Assert.True(s1 == s2);
    }

    [Fact]
    public void Start_Not_Equals_Start_Is_False()
    {
        var s1 = IntervalLimitType.Start;
        var s2 = IntervalLimitType.Start;
        Assert.False(s1 != s2);
    }

    [Fact]
    public void Start_Equals_End_Is_False()
    {
        Assert.False(IntervalLimitType.Start == IntervalLimitType.End);
    }
    
    [Fact]
    public void Start_Not_Equals_End_Is_True()
    {
        Assert.True(IntervalLimitType.Start != IntervalLimitType.End);
    }

    [Theory]
    [InlineData(0,0,0)]
    [InlineData(0,1,-1)]
    [InlineData(1,1,0)]
    [InlineData(1,0,1)]
    public void CompareTo_Returns_Expected_Value(byte v1, byte v2, int expectedValue)
    {
        Assert.Equal(expectedValue,((IntervalLimitType)v1).CompareTo((IntervalLimitType)v2));
        Assert.Equal(expectedValue,((IntervalLimitType)v1).CompareTo((object)(IntervalLimitType)v2));
    }
    
    [Theory]
    [InlineData(0,0,true)]
    [InlineData(0,1,false)]
    [InlineData(1,1,true)]
    [InlineData(1,0,false)]
    public void Equals_Returns_Expected_Value(byte left, byte right, bool expectedValue)
    {
        var x = (IntervalLimitType)left;
        var y1 = (IntervalLimitType)right;
        object y2 = (IntervalLimitType)right;
        
        Assert.Equal(expectedValue,x.Equals(y1));
        Assert.Equal(expectedValue,x.Equals(y2));
    }

    [Fact]
    public void Equals_Object_Returns_False_When_Wrong_Data_Type_Or_Null()
    {
        var x = IntervalLimitType.Start;
        object y = new ();
        Assert.False(x.Equals(y));
        Assert.False(x.Equals(null));
    }

    [Fact]
    public void CompareTo_Object_Returns_NonZero_When_Null()
    {
        var x = IntervalLimitType.Start;
        Assert.NotEqual(0,x.CompareTo(null));
    }

    [Fact]
    public void CompareTo_Object_Throws_When_Wrong_Data_Type()
    {
        var x = IntervalLimitType.Start;
        object y = new ();
        Assert.ThrowsAny<Exception>(()=>x.CompareTo(y));
    }
    
    [Fact]
    public void GetHashCode_Returns_Unique_HashCode()
    {
        Assert.NotEqual(IntervalLimitType.Start.GetHashCode(), IntervalLimitType.End.GetHashCode());
    }
}