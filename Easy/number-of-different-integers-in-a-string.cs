public class Solution {
    public int NumDifferentIntegers(string word) {
        var hs = new HashSet<string>();
        bool num = false;
        var sb = new StringBuilder();
        for (int i = 0; i < word.Length; i++)
            if (num)
            {
                if (word[i] < '0' || word[i] > '9')
                {
                    while (sb.Length > 1 && sb[0] == '0')
                        sb.Remove(0, 1);
                    hs.Add(sb.ToString());
                    sb.Clear();
                    num = false;
                }
                else
                    sb.Append(word[i]);
            }
            else if (word[i] >= '0' && word[i] <= '9')
            {
                sb.Append(word[i]);
                num = true;
            }
        if (num)
        {
            while (sb.Length > 1 && sb[0] == '0')
                sb.Remove(0, 1);
            hs.Add(sb.ToString());
        }
        return hs.Count;
    }
}
