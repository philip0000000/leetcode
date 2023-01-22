// https://leetcode.com/problems/keyboard-row/submissions/882850487/
public class Solution {
    public static HashSet<char> FirstRow = new HashSet<char>() { 'q','w','e','r','t','y','u','i','o','p' };
    public static HashSet<char> SecondRow = new HashSet<char>() { 'a','s','d','f','g','h','j','k','l' };
    public static HashSet<char> ThirdRow = new HashSet<char>() { 'z','x','c','v','b','n','m' };
    public string[] FindWords(string[] words) {
        var GoodWords = new List<string>();
        for (int m = 0; m < words.Length; m++)
        {
            bool f = true, s = true, t = true;
            for (int n = 0; n < words[m].Length && (f || s || t); n++)
            {
                char c = words[m][n];
                if (c < 'a')
                    c += (char)32;
                if (f && FirstRow.Contains(c) == false)
                    f = false;
                if (s && SecondRow.Contains(c) == false)
                    s = false;
                if (t && ThirdRow.Contains(c) == false)
                    t = false;
            }
            if (f || s || t)
                GoodWords.Add(words[m]);
        }
        return GoodWords.ToArray();
    }
}
