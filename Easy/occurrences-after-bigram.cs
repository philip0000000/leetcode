public class Solution {
    public string[] FindOcurrences(string text, string first, string second) {
        string[] s = text.Split(' ');
        var list = new List<string>();
        for (int i = s.Length-3; i >= 0; i--)
            if (s[i] == first && s[i+1] == second)
                list.Add(s[i+2]);
        return list.ToArray();
    }
}
