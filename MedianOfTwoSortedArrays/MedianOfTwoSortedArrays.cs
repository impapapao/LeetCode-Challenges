public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        decimal medianSorted;
        int[] ans = nums1.Concat(nums2).OrderBy(x => x).ToArray();
        int n = ans.Length;

        if(n % 2 != 0)
        {
             medianSorted = ans[n / 2];
        }
        else
        {
            medianSorted = Decimal.Divide((ans[n / 2] + ans[(n -  1) / 2]), 2);
        }
        return Convert.ToDouble(medianSorted);
        
    }
}