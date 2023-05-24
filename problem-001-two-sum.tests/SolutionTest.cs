namespace problem_001_two_sum.tests;

public class SolutionTest
{
    [Fact]
    public void Leetcode_Case1()
    {
        // Arrange
        var nums = new int[] { 2, 7, 11, 15 };
        var target = 9;
        var expected = new int[] { 0, 1 };

        // Act
        var solution = new Solution();
        var result = solution.TwoSum(nums, target);
        Array.Sort(result);

        // Assert
        Assert.Equal(result, expected);
    }

    [Fact]
    public void Leetcode_Case2()
    {
        // Arrange
        var nums = new int[] { 3, 2, 4 };
        var target = 6;
        var expected = new int[] { 1, 2 };

        // Act
        var solution = new Solution();
        var result = solution.TwoSum(nums, target);
        Array.Sort(result);

        // Assert
        Assert.Equal(result, expected);
    }

    [Fact]
    public void Leetcode_Case3()
    {
        // Arrange
        var nums = new int[] { 3, 3 };
        var target = 6;
        var expected = new int[] { 0, 1 };

        // Act
        var solution = new Solution();
        var result = solution.TwoSum(nums, target);
        Array.Sort(result);

        // Assert
        Assert.Equal(result, expected);
    }
}
