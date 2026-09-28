public class Solution {
     public List<List<int>> ThreeSum(int[] nums)
  {
      int target = 0;
      List<List<int>> resultLists = new List<List<int>>();

      Array.Sort(nums);
      for (int i = 0; i < nums.Length; i++)
      {
          if (i > 0 && nums[i] == nums[i - 1])
          {
              continue;
          }

          int startPointer = i + 1;
          int endPointer = nums.Length - 1;

          while (startPointer < endPointer)
          {
              int currentVal = nums[startPointer] + nums[endPointer] + nums[i];

              if (currentVal == target)
              {
                  List<int> foundArray = new List<int> { nums[i], nums[startPointer], nums[endPointer]};
                  resultLists.Add(foundArray);
                  startPointer++;
                  endPointer--;
                  // Skip duplicate second values
                  while (startPointer < endPointer &&
                         nums[startPointer] == nums[startPointer - 1])
                  {
                      startPointer++;
                  }

                  // Skip duplicate third values
                  while (startPointer < endPointer &&
                         nums[endPointer] == nums[endPointer + 1])
                  {
                      endPointer--;
                  }
              }
              else if (currentVal < target)
              {
                  startPointer++;
              }
              else
              {
                  endPointer--;
              }
          }
      }

      return resultLists;
  }
}
