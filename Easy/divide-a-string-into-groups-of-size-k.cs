public class Solution {
    public string[] DivideString(string s, int k, char fill) {
        var list = new List<string>();
        var sb = new StringBuilder();
        for (int i = 0, j = k; i < s.Length; i++)
        {
            j--;
            sb.Append(s[i]);
            if (j == 0)
            {
                list.Add(sb.ToString());
                sb.Clear();
                j = k;
            }
        }
        if (sb.Length != 0)
        {
            while (sb.Length < k)
                sb.Append(fill);
            list.Add(sb.ToString());
        }
        return list.ToArray();
    }
}
