// 1st
public class Solution {
    public int PercentageLetter(string s, char letter) {
        int c = 0;
        for (int i = 0; i < s.Length; i++)
            if (s[i] == letter)
                c++;
        decimal b = (decimal)c / (decimal)s.Length;
        b *= 100;
        return (int)(b);
    }
}

// 2nd 50%~ https://leetcode.com/problems/percentage-of-letter-in-string/submissions/893883482/
public class Solution {
    public int PercentageLetter(string s, char letter) {
        int c = 0;
        for (int i = 0; i < s.Length; i++)
            if (s[i] == letter)
                c++;
        float b = (float)c*100 / (float)s.Length;
        return (int)(b);
    }
}
