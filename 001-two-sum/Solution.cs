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

        var hash = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (hash.ContainsKey(complement))
            {
                return new int[] { i, hash[complement] };
            }

            if (hash.ContainsKey(nums[i]))
            {
                hash[nums[i]] = i;
            }
            else
            {
                hash.Add(nums[i], i);
            }
        }

        return null!;
    }

    private static void ValidateParams(int[] nums, int target)
    {
        if (nums.Length < 2 || nums.Length > 10000)
            throw new ArgumentException(null, nameof(nums));

        if (target < Math.Pow(-10, 9) || target > Math.Pow(10, 9))
            throw new ArgumentException(null, nameof(target));
    }
}
