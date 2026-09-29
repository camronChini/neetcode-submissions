public class Solution {
     public bool hasDuplicate(int[] nums)
  {
      HashSet<int> contents = new HashSet<int>();

      for (int i = 0; i <  nums.Length; i++)
      {
          if (contents.Contains(nums[i]))
          {
              return true;
          }
          contents.Add(nums[i]);
      }
      return false;
  }
}