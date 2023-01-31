public class Solution {
    public bool IsAnagram(string s, string t) {
        var dictS = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
            if (dictS.ContainsKey(s[i]))
                dictS[s[i]]++;
            else
                dictS.Add(s[i], 1);
        var dictT = new Dictionary<char, int>();
        for (int i = 0; i < t.Length; i++)
            if (dictT.ContainsKey(t[i]))
                dictT[t[i]]++;
            else
                dictT.Add(t[i], 1);
        if (dictS.Count != dictT.Count)
            return false;
        foreach (KeyValuePair<char, int> kvp in dictS)
            if (dictT.ContainsKey(kvp.Key)==false ||
                dictT[kvp.Key]!=kvp.Value)
                return false;
        return true;
    }
}
