namespace problem_002_add_two_numbers.tests;

public class SolutionTest
{
    [Fact]
    public void Leetcode_Case1()
    {
        // Arrange
        var l1 = ListNodeFactory.CreateFromArray(new int[] { 2, 4, 3 });
        var l2 = ListNodeFactory.CreateFromArray(new int[] { 5, 6, 4 });
        var expected = new int[] { 7, 0, 8 };

        // Act
        var solution = new Solution();
        var result = solution.AddTwoNumbers(l1, l2).ToArray().Reverse();

        // Assert
        Assert.Equal(result, expected);
    }

    [Fact]
    public void Leetcode_Case2()
    {
        // Arrange
        var l1 = ListNodeFactory.CreateFromArray(new int[] { 0 });
        var l2 = ListNodeFactory.CreateFromArray(new int[] { 0 });
        var expected = new int[] { 0 };

        // Act
        var solution = new Solution();
        var result = solution.AddTwoNumbers(l1, l2).ToArray().Reverse();

        // Assert
        Assert.Equal(result, expected);
    }

    [Fact]
    public void Leetcode_Case3()
    {
        // Arrange
        var l1 = ListNodeFactory.CreateFromArray(new int[] { 9, 9, 9, 9, 9, 9, 9 });
        var l2 = ListNodeFactory.CreateFromArray(new int[] { 9, 9, 9, 9 });
        var expected = new int[] { 8, 9, 9, 9, 0, 0, 0, 1 };

        // Act
        var solution = new Solution();
        var result = solution.AddTwoNumbers(l1, l2).ToArray().Reverse();

        // Assert
        Assert.Equal(result, expected);
    }

    [Fact]
    public void Leetcode_Case4()
    {
        // Arrange
        var l1 = ListNodeFactory.CreateFromArray(new int[] { 9 });
        var l2 = ListNodeFactory.CreateFromArray(new int[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 });
        var expected = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };

        // Act
        var solution = new Solution();
        var result = solution.AddTwoNumbers(l1, l2).ToArray().Reverse();

        // Assert
        Assert.Equal(result, expected);
    }

    [Fact]
    public void Leetcode_Case5()
    {
        // Arrange
        var l1 = ListNodeFactory.CreateFromArray(new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 });
        var l2 = ListNodeFactory.CreateFromArray(new int[] { 5, 6, 4 });
        var expected = new int[] { 6, 6, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };

        // Act
        var solution = new Solution();
        var result = solution.AddTwoNumbers(l1, l2).ToArray().Reverse();

        // Assert
        Assert.Equal(result, expected);
    }
}
