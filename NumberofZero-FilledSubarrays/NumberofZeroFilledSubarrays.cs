public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        long counter = 0, n = 0;
        for(int i = 0; i < nums.Length; i++) 
        {
            if(nums[i] == 0)
            {
                counter++;
            }
            else if(counter > 0)
            {
                n += (counter * (counter + 1 ) / 2);
                counter = 0;
            }
        }
        if(counter > 0) 
        {
            n += (counter * (counter + 1) / 2);
        }
        return n;
    }
}