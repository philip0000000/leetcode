public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var sb = new StringBuilder();
        int i = 0;
        while (i < word1.Length && i < word2.Length)
        {
            sb.Append(word1[i]);
            sb.Append(word2[i]);
            i++;
        }
        if (word1.Length > i)
            sb.Append(word1.Substring(i));
        else if (word2.Length > i)
            sb.Append(word2.Substring(i));
        return sb.ToString();
    }
}
