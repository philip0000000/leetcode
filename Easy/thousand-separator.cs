// 1st
public class Solution {
    public string ThousandSeparator(int n) {
        var sb = new StringBuilder();
        int k = 3;
        do {
            int m = n % 10;
            sb.Insert(0, m);
            k--;
            n /= 10;
            if (k == 0 && n > 0)
            {
                sb.Insert(0, '.');
                k = 3;
            }
        } while (n > 0);
        return sb.ToString();
    }
}

// 2nd
public class Solution {
    public string ThousandSeparator(int n) {
        var sb = new StringBuilder(n.ToString());
        for (int i = sb.Length-1, k = 3; i >= 0; i--)
        {
            k--;
            if (k == 0)
            {
                sb.Insert(i, '.');
                k = 3;
            }
        }
        if (sb[0] == '.')
            sb.Remove(0, 1);
        return sb.ToString();
    }
}
