public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        var list = new List<string>(banned);
        var dict = new Dictionary<string, int>();
        var sb = new StringBuilder();
        for (int i = 0; i < paragraph.Length; i++)
        {
            if (paragraph[i] == '!' || paragraph[i] == '?' || paragraph[i] == '\'' ||
                paragraph[i] == ',' || paragraph[i] == ';' || paragraph[i] == '.' ||
                paragraph[i] == ' ')
            {
                if (sb.Length == 0)
                    continue;
                if (dict.ContainsKey(sb.ToString()))
                    dict[sb.ToString()]++;
                else
                    dict.Add(sb.ToString(), 1);
                sb.Clear();
            }
            else
                sb.Append(Char.ToLower(paragraph[i]));
        }
        if (sb.Length > 0)
        {
            if (dict.ContainsKey(sb.ToString()))
                dict[sb.ToString()]++;
            else
                dict.Add(sb.ToString(), 1);
        }
        int max = 0;
        string str = "";
        foreach (var kvp in dict)
            if (kvp.Value > max && list.Contains(kvp.Key) == false)
            {
                max = kvp.Value;
                str = kvp.Key;
            }
        return str;
    }
}
