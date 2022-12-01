public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var dict = new Dictionary<char, char>();
        for (int n = 0; n < s.Length; n++)
        {
            if (dict.ContainsKey(s[n]) == true)
            {
                if (dict[s[n]] != t[n])
                    return false;
            }
            else if (dict.ContainsValue(t[n]) == true) // Add...
                return false;
            else
                dict.Add(s[n], t[n]);
        }
        return true;
    }
}
