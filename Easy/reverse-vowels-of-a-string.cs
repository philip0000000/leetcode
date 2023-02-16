// 1st stack // https://leetcode.com/problems/reverse-vowels-of-a-string/submissions/899134669/
public class Solution {
    public string ReverseVowels(string s) {
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
            if (s[i] == 'a' ||
                s[i] == 'A' ||
                s[i] == 'e' ||
                s[i] == 'E' ||
                s[i] == 'i' ||
                s[i] == 'I' ||
                s[i] == 'o' ||
                s[i] == 'O' ||
                s[i] == 'u' ||
                s[i] == 'U')
                stack.Push(s[i]);
        var sb = new StringBuilder(s);
        for (int i = 0; i < s.Length; i++)
            if (s[i] == 'a' ||
                s[i] == 'A' ||
                s[i] == 'e' ||
                s[i] == 'E' ||
                s[i] == 'i' ||
                s[i] == 'I' ||
                s[i] == 'o' ||
                s[i] == 'O' ||
                s[i] == 'u' ||
                s[i] == 'U')
                sb[i] = stack.Pop();
        return sb.ToString();
    }
}

// 2nd two pointers // https://leetcode.com/problems/reverse-vowels-of-a-string/submissions/899142722/
public class Solution {
    public string ReverseVowels(string s) {
        var sb = new StringBuilder(s);
        int p0 = 0, p1 = s.Length-1;
        for (; p0 < p1; p0++)
            if (s[p0] == 'a' || s[p0] == 'A' ||
                s[p0] == 'e' || s[p0] == 'E' ||
                s[p0] == 'i' || s[p0] == 'I' ||
                s[p0] == 'o' || s[p0] == 'O' ||
                s[p0] == 'u' || s[p0] == 'U')
            {
                while (p1 >= 0 &&
                      (s[p1] != 'a' && s[p1] != 'A' &&
                       s[p1] != 'e' && s[p1] != 'E' &&
                       s[p1] != 'i' && s[p1] != 'I' &&
                       s[p1] != 'o' && s[p1] != 'O' &&
                       s[p1] != 'u' && s[p1] != 'U'))
                    p1--;
                if (p1 >= 0 &&
                   (s[p1] == 'a' || s[p1] == 'A' ||
                    s[p1] == 'e' || s[p1] == 'E' ||
                    s[p1] == 'i' || s[p1] == 'I' ||
                    s[p1] == 'o' || s[p1] == 'O' ||
                    s[p1] == 'u' || s[p1] == 'U'))
                {
                    sb[p0] = s[p1];
                    sb[p1] = s[p0];
                    p1--;
                }
            }
        return sb.ToString();
    }
}
