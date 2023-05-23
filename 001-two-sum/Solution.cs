namespace Solutions;

public class Solution
{
#pragma warning disable CA1822 // Пометьте члены как статические
    public int[] TwoSum(int[] nums, int target)
#pragma warning restore CA1822 // Пометьте члены как статические
    {
#if DEBUG
        ValidateParams(nums, target);
#endif

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                    continue;

                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }
        }

        return Array.Empty<int>();
    }

    private static void ValidateParams(int[] nums, int target)
    {
        if (nums.Length < 2 || nums.Length > 10000)
            throw new ArgumentException(null, nameof(nums));

        if (target < Math.Pow(-10, 9) || target > Math.Pow(10, 9))
            throw new ArgumentException(null, nameof(target));
    }
}
