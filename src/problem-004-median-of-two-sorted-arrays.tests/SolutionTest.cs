namespace problem_004_median_of_two_sorted_arrays.tests;

public class SolutionTest
{
    [Fact]
    public void Leetcode_Case1()
    {
        // Arrange
        var nums1 = new int[] { 1, 3 };
        var nums2 = new int[] { 2 };
        var expected = 2;

        // Act
        var solution = new Solution();
        var result = solution.FindMedianSortedArrays(nums1, nums2);

        // Assert
        Assert.Equal(result, expected);
    }

    [Fact]
    public void Leetcode_Case2()
    {
        // Arrange
        var nums1 = new int[] { 1, 2 };
        var nums2 = new int[] { 3, 4 };
        var expected = 2.5d;

        // Act
        var solution = new Solution();
        var result = solution.FindMedianSortedArrays(nums1, nums2);

        // Assert
        Assert.Equal(result, expected);
    }

    [Fact]
    public void Leetcode_Case3()
    {
        // Arrange
        var nums1 = new int[] { };
        var nums2 = new int[] { 2, 3 };
        var expected = 2.5d;

        // Act
        var solution = new Solution();
        var result = solution.FindMedianSortedArrays(nums1, nums2);

        // Assert
        Assert.Equal(result, expected);
    }
}
