public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++)
        {
            if(!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = 1;
            }
            else
            {
                map[nums[i]]++;
            }

        }
        var sortedList = map.ToList();
        sortedList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
        //Let's say the values of pairs are equal, then we want to sort by keys in ascending order. Then, we would do this,
        // sortedList.Sort((pair1, pair2) => 
        // {
        //     // First, compare by Value (Descending)
        //     int result = pair2.Value.CompareTo(pair1.Value);
            
        //     // If Values are the same (result is 0), compare by Key (Ascending)
        //     if (result == 0)
        //     {
        //         return pair1.Key.CompareTo(pair2.Key);
        //     }
            
        //     return result;
        // });
        
        return sortedList.GetRange(0, k).Select(pair => pair.Key).ToArray();
    }
}
