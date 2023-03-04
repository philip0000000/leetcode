public class Solution {
    public bool IsPrefixString(string s, string[] words) {
        var sb = new StringBuilder();
        foreach (var str in words)
            sb.Append(str);
        if (sb.ToString().StartsWith(s))
        {
            int i = 0;
            for (int j = 0; j < words.Length; j++)
            {
                i += words[j].Length;
                if (i == s.Length)
                    return true;
                else if (i > s.Length)
                    break;
            }
        }
        return false;
    }
}
