//No of total sub arrays in an array whose sum equals K.
using System.Collections.Generic;

public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        map[0] = 1; // prefixSum(-1) = 0

        int sum = 0;
        int count = 0;

        foreach (int num in nums)
        {
            sum += num;

            if (map.ContainsKey(sum - k))
            {
                count += map[sum - k];
            }

            if (!map.ContainsKey(sum))
            {
                map[sum] = 0;
            }

            map[sum]++;
        }

        return count;
    }
}
