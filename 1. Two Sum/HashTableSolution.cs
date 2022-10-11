public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> hashTable = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (hashTable.ContainsKey(target - nums[i]))
            {
                return new int[] { hashTable[target - nums[i]], i };
            }
            else
            {
                hashTable[nums[i]] = i;
            }
        }
        return null;
    }
}