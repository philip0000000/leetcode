public class Solution {
    public string ReorderSpaces(string text) {
        int spaces = 0;
        foreach (var c in text)
            if (c == ' ')
                spaces++;
        var StrArr = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var sb = new StringBuilder();
        if (StrArr.Length > 1)
        {
            int between = spaces / (StrArr.Length-1);
            foreach (string str in StrArr)
            {
                sb.Append(str);
                if (between > 0)
                {
                    sb.Append(new string(' ', between));
                    spaces -= between;
                }
            }
            sb.Length -= between;
        }
        else
            sb.Append(StrArr[0]);
        while (sb.Length < text.Length)
            sb.Append(' ');
        return sb.ToString();
    }
}
