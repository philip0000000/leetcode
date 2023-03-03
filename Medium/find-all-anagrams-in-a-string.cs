// https://leetcode.com/problems/find-all-anagrams-in-a-string/submissions/908429964/
public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        var ret = new List<int>();
        if (s.Length < p.Length)
            return ret;
        var dict = new Dictionary<char, int>();
        for (int i = 0; i < p.Length; i++)
            if (dict.ContainsKey(p[i]))
                dict[p[i]]++;
            else
                dict.Add(p[i], 1);
        int NoneValidChars = 0;
        var dictCmp = new Dictionary<char, int>();
        foreach (var kvp in dict)
            dictCmp.Add(kvp.Key, 0);
        int p0 = 0, p1 = 0;
        for (; p1 < p.Length; p1++)
            if (dictCmp.ContainsKey(s[p1]))
                dictCmp[s[p1]]++;
            else
                NoneValidChars++;
        if (NoneValidChars == 0)
        {
            bool AllFound = true;
            foreach (var kvp in dictCmp)
                if (kvp.Value != dict[kvp.Key])
                {
                    AllFound = false;
                    break;
                }
            if (AllFound)
                ret.Add(0);
        }
        for (; p1 < s.Length; p0++, p1++)
        {
            if (dictCmp.ContainsKey(s[p0]))
                dictCmp[s[p0]]--;
            else
                NoneValidChars--;
            if (dictCmp.ContainsKey(s[p1]))
                dictCmp[s[p1]]++;
            else
                NoneValidChars++;
            if (NoneValidChars == 0)
            {
                bool AllFound = true;
                foreach (var kvp in dictCmp)
                    if (kvp.Value != dict[kvp.Key])
                    {
                        AllFound = false;
                        break;
                    }
                if (AllFound)
                    ret.Add(p0+1);
            }
        }
        return ret;
    }
}
