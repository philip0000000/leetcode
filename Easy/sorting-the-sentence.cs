// https://leetcode.com/problems/sorting-the-sentence/submissions/908383130/
public class Solution {
    public string SortSentence(string s) {
        var sb = new StringBuilder();
        string[] tokens = s.Split(' ');
        for (int i = 1; i <= tokens.Length; i++)
        {
            for (int j = 0; j < tokens.Length; j++)
            {
                if (tokens[j][tokens[j].Length-1]-'0' == i)
                {
                    sb.Append(tokens[j].Substring(0, tokens[j].Length-1));
                    sb.Append(' ');
                    break;
                }
            }
        }
        sb.Length--;
        return sb.ToString();
    }
}

// 50%~
public class Solution {
    public string SortSentence(string s) {
        var sb = new StringBuilder();
        string[] tokens = s.Split(' ');
        var dict = new Dictionary<int, string>();
        foreach (var str in tokens)
            dict.Add(str[str.Length-1]-'0', str.Substring(0, str.Length-1));
        for (int i = 1; i <= tokens.Length; i++)
        {
            sb.Append(dict[i]);
            sb.Append(' ');
        }
        sb.Length--;
        return sb.ToString();
    }
}
