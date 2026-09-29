public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int,int> numbersSeen = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length ; i++)
        {
            int difference  = target - nums[i];
            if (numbersSeen.ContainsKey(difference))
            {
                int[] returnArray = [numbersSeen[difference],i];
                return returnArray;
            }
            else
            {
                numbersSeen.Add(nums[i],i);
            }

        }

        return [-1, -1];
    }
}
