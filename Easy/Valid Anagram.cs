public class Solution {
    public bool IsAnagram(string s, string t) {
        var DicS = new System.Collections.Generic.Dictionary<char, int>();
        var DicT = new System.Collections.Generic.Dictionary<char, int>();
        // 1st count s
        foreach(char c in s)
        {
            if (DicS.ContainsKey(c))
                DicS[c]++;
            else
                DicS.Add(c, 1);
        }

        // 2nd count t
        foreach(char c in t)
        {
            if (DicT.ContainsKey(c))
                DicT[c]++;
            else
                DicT.Add(c, 1);
        }

        // 3rd compare the two dic for same number of value in key
        if (DicS.Count != DicT.Count) // must be same size
            return false;

        foreach (var entry in DicS)
        {
            if (DicT.ContainsKey(entry.Key) == true)
            {
                if (DicT[entry.Key] != entry.Value)
                    return false;
            }
            else
                return false;
        }

        return true;
    }
}
