namespace problem_008_string_to_integer_atoi.tests;

public class SolutionTest
{
    [Fact]
    public void Leetcode_Case1()
    {
        // Arrange
        var inputString = "42";
        var expected = 42;

        // Act
        var solution = new Solution();
        var result = solution.MyAtoi(inputString);

        // Assert
        Assert.Equal(result, expected);
    }

    [Fact]
    public void Leetcode_Case2()
    {
        // Arrange
        var inputString = "   -42";
        var expected = -42;

        // Act
        var solution = new Solution();
        var result = solution.MyAtoi(inputString);

        // Assert
        Assert.Equal(result, expected);
    }

    [Fact]
    public void Leetcode_Case3()
    {
        // Arrange
        var inputString = "4193 with words";
        var expected = 4193;

        // Act
        var solution = new Solution();
        var result = solution.MyAtoi(inputString);

        // Assert
        Assert.Equal(result, expected);
    }

    [Fact]
    public void Leetcode_Case4()
    {
        // Arrange
        var inputString = "-91283472332";
        var expected = -2147483648;

        // Act
        var solution = new Solution();
        var result = solution.MyAtoi(inputString);

        // Assert
        Assert.Equal(result, expected);
    }
}
