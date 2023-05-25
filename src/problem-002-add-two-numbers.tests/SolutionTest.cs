namespace problem_002_add_two_numbers.tests;

public class SolutionTest
{
    [Fact]
    public void Leetcode_Case1()
    {
        // Arrange
        var l1 = ListNodeFactory.CreateFromArray(new int[] { 2, 4, 3 });
        var l2 = ListNodeFactory.CreateFromArray(new int[] { 5, 6, 4 });
        var expected = ListNodeFactory.CreateFromArray(new int[] { 7, 0, 8 });

        // Act
        var solution = new Solution();
        var result = solution.AddTwoNumbers(l1, l2);

        // Assert
        Assert.Equal(result, expected);
    }

    [Fact]
    public void Leetcode_Case2()
    {
        // Arrange
        var l1 = ListNodeFactory.CreateFromArray(new int[] { 0 });
        var l2 = ListNodeFactory.CreateFromArray(new int[] { 0 });
        var expected = ListNodeFactory.CreateFromArray(new int[] { 0 });

        // Act
        var solution = new Solution();
        var result = solution.AddTwoNumbers(l1, l2);

        // Assert
        Assert.Equal(result, expected);
    }

    [Fact]
    public void Leetcode_Case3()
    {
        // Arrange
        var l1 = ListNodeFactory.CreateFromArray(new int[] { 9, 9, 9, 9, 9, 9, 9 });
        var l2 = ListNodeFactory.CreateFromArray(new int[] { 9, 9, 9, 9 });
        var expected = ListNodeFactory.CreateFromArray(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 });

        // Act
        var solution = new Solution();
        var result = solution.AddTwoNumbers(l1, l2);

        // Assert
        Assert.Equal(result, expected);
    }
}
