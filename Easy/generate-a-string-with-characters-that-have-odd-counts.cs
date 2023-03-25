// 1st
public class Solution {
    public string GenerateTheString(int n) {
        var sb = new StringBuilder();
        for (int i = 0; i < n; i++)
            sb.Append('p');
        if (n % 2 == 0)
        {
            sb.Length--;
            sb.Append('z');
        }
        return sb.ToString();
    }
}

// 2nd 90%~
public class Solution {
    public string GenerateTheString(int n) {
        var sb = new StringBuilder();
        if (n % 2 == 0)
        {
            sb.Append('a', n-1);
            sb.Append('b');
        }
        else
            sb.Append('a', n);
        return sb.ToString();
    }
}
