public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int a = 0;
        int b = 0;
        for (a = 0; a < nums.Length; a++)
        {
            for (b = a + 1; b < nums.Length; b++)
            {
                if (nums[a] + nums[b] == target)
                {
                    return new int[] { a, b };
                }
            }
        }
        return null;
    }
}