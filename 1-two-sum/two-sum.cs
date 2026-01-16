using System.Collections.Generic;
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
     List<int> list = new List<int>();
     bool shouldexit = false;
     for(int i = 0; i<=nums.Length-1; i++)
     {
        for(int j=i+1;j<=nums.Length-1;j++)
        {
            if(nums[i]+nums[j] == target)
            {
                 shouldexit = true;
                 list.Add(i);
                 list.Add(j);
            }   
        }
        if(shouldexit)
        {
            break;
        }
     }
     int[] result = list.ToArray();
     return result;
    }
}