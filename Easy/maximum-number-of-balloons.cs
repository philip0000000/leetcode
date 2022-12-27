// 1st
public class Solution {
    public int MaxNumberOfBalloons(string text) {
        var dict = new Dictionary<char, int>();
        dict.Add('b', 0);
        dict.Add('a', 0);
        dict.Add('l', 0);
        dict.Add('o', 0);
        dict.Add('n', 0);
        foreach (var c in text)
            if (c == 'b' || c == 'a' || c == 'l' || c == 'o' || c == 'n')
                dict[c]++;
        int l = dict['l'] / 2;
        int o = dict['o'] / 2;
        return Math.Min(dict['b'], Math.Min(dict['a'], Math.Min(dict['n'], Math.Min(l, o))));
    }
}

// 2nd
public class Solution {
    public int MaxNumberOfBalloons(string text) {
        int b = 0;
        int a = 0;
        int l = 0;
        int o = 0;
        int n = 0;
        foreach (var c in text)
            switch (c)
            {
                case 'b':
                    b++;
                    break;
                case 'a':
                    a++;
                    break;
                case 'l':
                    l++;
                    break;
                case 'o':
                    o++;
                    break;
                case 'n':
                    n++;
                    break;
                default:
                    break;
            }
        l /= 2;
        o /= 2;
        return Math.Min(b, Math.Min(a, Math.Min(n, Math.Min(l, o))));
    }
}
