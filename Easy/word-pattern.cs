public class Solution {
    public bool WordPattern(string pattern, string s) {
        var words = s.Split(' ').ToList();
        if (pattern.Length != words.Count)
            return false;
        var dict = new Dictionary<char, string>();
        for (int i = 0; i < pattern.Length; i++)
        {
            if (dict.ContainsKey(pattern[i]))
            {
                if (dict[pattern[i]] != words[i])
                    return false;
            }
            else
            {
                if (dict.ContainsValue(words[i]))
                    return false;
                dict.Add(pattern[i], words[i]);
            }
        }
        return true;
    }
}
