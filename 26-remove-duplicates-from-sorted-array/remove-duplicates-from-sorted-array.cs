using System.Collections.Generic;
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int uniqueCount = 1;
        for(int i=1, j=0; i<=nums.Length-1; i++)
        {
            if(nums[j] != nums[i])
            {
                j=j+1;
                nums[j] = nums[i];
                uniqueCount = uniqueCount+1;
            }
        }
        return uniqueCount;
    }
}