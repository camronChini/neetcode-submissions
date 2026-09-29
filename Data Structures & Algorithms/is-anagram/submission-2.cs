public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char,int> stringData = new Dictionary<char,int>();

        for (int i = 0; i < s.Length; i++) {
            if (stringData.ContainsKey(s[i]))
            {
                stringData[s[i]]++;
            }
            else
            {
                stringData.Add(s[i], 1);
            }
        }

        for(int i = 0;i < t.Length; i++)
        {
            if (stringData.ContainsKey(t[i]))
            {
                stringData[t[i]]--;
                if (stringData[t[i]] == 0)
                {
                    stringData.Remove(t[i]);
                } 
            }
            else
            {
                return false;
            }
        }
        if (stringData.Keys.Count > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
