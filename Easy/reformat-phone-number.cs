public class Solution {
    public string ReformatNumber(string number) {
        var sb = new StringBuilder();
        foreach (var c in number)
            if (c >= '0' && c <= '9')
                sb.Append(c);
        int l = sb.Length;
        int i = 0;
        while (l > 4)
        {
            i+=3;
            sb.Insert(i, '-');
            i++;
            l -= 3;
        }
        if (l == 4)
            sb.Insert(i + 2, '-');
        return sb.ToString();
    }
}
