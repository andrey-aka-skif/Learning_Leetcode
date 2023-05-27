namespace problem_004_median_of_two_sorted_arrays;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] newArray = new int[nums1.Length + nums2.Length];
        Array.Copy(nums1, newArray, nums1.Length);
        Array.Copy(nums2, 0, newArray, nums1.Length, nums2.Length);

        Array.Sort(newArray);

        bool isEven = newArray.Length % 2 == 0;

        double median;

        if (isEven)
        {
            int middleIndex1 = (newArray.Length / 2) - 1;
            int middleIndex2 = middleIndex1 + 1;
            median = (double)(newArray[middleIndex1] + newArray[middleIndex2]) / 2;
        }
        else
        {
            int middleIndex = newArray.Length / 2;
            median = newArray[middleIndex];
        }

        return median;
    }
}
