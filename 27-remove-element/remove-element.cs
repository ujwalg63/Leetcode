public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k=0;
        int j = nums.Length - 1;
        for(int i=0; i<=nums.Length -1; i++)
        {
            while(i<=j && nums[j] == val)
            {
                j = j-1;
            }           
            if(i>j)
            {
                break;
            }
            if(nums[i]==val)
            {
                (nums[i],nums[j]) = (nums[j], nums[i]);
                j=j-1;
                k=k+1;
            }
               
        }
        return j+1;
    }
} 