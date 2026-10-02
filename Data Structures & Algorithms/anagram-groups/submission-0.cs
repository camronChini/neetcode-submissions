public class Solution {
      public List<List<string>> GroupAnagrams(string[] strs)
   {
       Dictionary<String, List<String>> results = new Dictionary<String, List<String>>();
       foreach(string  str in strs)
       {
           int[] count = new int[26];
           foreach(char c in str)
           {
               count[c - 'a']++;
           }

           string key = string.Join(",", count);
           if (!results.ContainsKey(key))
           {
               results[key] = new List<String>();
           }
           results[key].Add(str);
       }

       return results.Values.ToList();

   }
}
