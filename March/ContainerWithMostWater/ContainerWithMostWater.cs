public class Solution {
    public int MaxArea(int[] height) {
        
        int i = 0, r = height.Length - 1, CurrentMax = 0, max = 0;

        while (i < r)
        {
            CurrentMax = (r - i) * Math.Min(height[i], height[r]);
            if(CurrentMax > max)
            {
                max = CurrentMax;
            }
            if(height[i] <= height[r])
            {
                i++;
            }
            else
            {
                r--;
            }
        }
        return max;
        
    }
}