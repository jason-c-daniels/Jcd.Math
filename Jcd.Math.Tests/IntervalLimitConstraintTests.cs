using Jcd.Math.Intervals;

namespace Jcd.Math.Tests;

public class IntervalLimitConstraintTests
{
    [Fact]
    public void Open_Is_Defined_As_Having_A_Limit_And_IsOpen_True()
    {
        Assert.True(IntervalLimitConstraint.Open.IsOpen);
        Assert.True(IntervalLimitConstraint.Open.HasLimitValue);
        Assert.False(IntervalLimitConstraint.Open.IsClosed);
    }
    
    [Fact]
    public void Closed_Is_Defined_As_Having_A_Limit_And_IsClosed_True()
    {
        Assert.False(IntervalLimitConstraint.Closed.IsOpen);
        Assert.True(IntervalLimitConstraint.Closed.HasLimitValue);
        Assert.True(IntervalLimitConstraint.Closed.IsClosed);
    }
    
    [Fact]
    public void Unbounded_Is_Defined_As_Having_No_Limit_And_IsOpen_True()
    {
        Assert.True(IntervalLimitConstraint.Unbounded.IsOpen);
        Assert.False(IntervalLimitConstraint.Unbounded.HasLimitValue);
        Assert.False(IntervalLimitConstraint.Unbounded.IsClosed);
    }
    
    [Theory]
    [MemberData(nameof(EquivalenceData))]    
    public void Equals_Returns_Expected_Value(IntervalLimitConstraint left, IntervalLimitConstraint right, bool expectedValue)
    {
        Assert.Equal(expectedValue, left == right);
        Assert.Equal(expectedValue, left.Equals(right));
        Assert.Equal(expectedValue, left.Equals((object)right));
    }

    [Theory]
    [MemberData(nameof(EquivalenceData))]    
    public void Not_Equals_Returns_Expected_Value(IntervalLimitConstraint left, IntervalLimitConstraint right, bool negatedExpectedValue)
    {
        Assert.Equal(!negatedExpectedValue, left != right);
    }

    
    [Theory]
    [MemberData(nameof(EquivalenceData))]    
    public void GetHashCode_Comparisons_Return_Expected_Value(IntervalLimitConstraint left, IntervalLimitConstraint right, bool expectedValue)
    {
        Assert.Equal(expectedValue, left.GetHashCode() == right.GetHashCode());
    }
    
    [Fact]
    public void Default_Is_Unbounded()
    {
        IntervalLimitConstraint @default=default;
        Assert.Equal(IntervalLimitConstraint.Unbounded, @default);
    }
    
    public static IEnumerable<object[]> EquivalenceData =>
        new List<object[]>
        {
            new object[] { IntervalLimitConstraint.Open, IntervalLimitConstraint.Open, true },
            new object[] { IntervalLimitConstraint.Closed, IntervalLimitConstraint.Closed, true },
            new object[] { IntervalLimitConstraint.Unbounded, IntervalLimitConstraint.Unbounded, true },
            new object[] { IntervalLimitConstraint.Open, IntervalLimitConstraint.Closed, false },
            new object[] { IntervalLimitConstraint.Open, IntervalLimitConstraint.Unbounded, false },
            new object[] { IntervalLimitConstraint.Closed, IntervalLimitConstraint.Open, false },
            new object[] { IntervalLimitConstraint.Closed, IntervalLimitConstraint.Unbounded, false },
            new object[] { IntervalLimitConstraint.Unbounded, IntervalLimitConstraint.Closed, false },
            new object[] { IntervalLimitConstraint.Unbounded, IntervalLimitConstraint.Open, false }
        };
    
}