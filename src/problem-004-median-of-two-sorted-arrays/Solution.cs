namespace problem_004_median_of_two_sorted_arrays;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] newArray = new int[nums1.Length + nums2.Length];

        int i1 = 0;
        int i2 = 0;

        for (int i = 0; i < newArray.Length; i++)
        {
            if (i1 >= nums1.Length)
            {
                newArray[i] = nums2[i2];
                i2++;
                continue;
            }

            if (i2 >= nums2.Length)
            {
                newArray[i] = nums1[i1];
                i1++;
                continue;
            }

            if (nums1[i1] < nums2[i2])
            {
                newArray[i] = nums1[i1];
                i1++;
                continue;
            }

            if (nums1[i1] >= nums2[i2])
            {
                newArray[i] = nums2[i2];
                i2++;
                continue;
            }
        }

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
