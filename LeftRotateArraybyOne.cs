public class Solution
{
    public void rotateArrayByOne(List<int> nums)
    {
        int firstElement = nums[0];
        int n=nums.Count;
        for(int i=1; i<n;i++)
        {
            nums[i-1] = nums[i];
        }
        nums[n-1] = firstElement;
    }
}
//store the first element and then shift the elements starting from the second element to left by one.
