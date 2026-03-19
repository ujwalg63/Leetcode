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
        return sortedList.GetRange(0, k).Select(pair => pair.Key).ToArray();
    }
}
