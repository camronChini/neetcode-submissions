public class Solution {
  public int[] TopKFrequent(int[] nums, int k)
  {
      Dictionary<int,int> numberOccurences = new Dictionary<int,int>();
      List<int>[] freq = new List<int>[nums.Length + 1];
      for (int i = 0; i < freq.Length; i++)
      {
          freq[i] = new List<int>();
      }



      foreach (int i in nums)
      {
          if (numberOccurences.ContainsKey(i))
          {
              numberOccurences[i]++;
          }
          else
          {
              numberOccurences.Add(i,1);
          }
      }

      foreach(int val in numberOccurences.Keys)
      {
          freq[numberOccurences[val]].Add(val);
      }

      int[] returnArray = new int [k];
      int index = 0;
      
      for (int i = freq.Length - 1; i > 0; i--)
      {
          foreach(int num in freq[i])
          {
              returnArray[index] = num;
              index++;
              if (index == k)
              {
                  return returnArray;
              }
          }
      }

      return returnArray;
  }
}
