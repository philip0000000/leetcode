// https://leetcode.com/problems/reverse-prefix-of-word/submissions/901658122/
public class Solution {
    public string ReversePrefix(string word, char ch) {
        int n = 0;
        while (n < word.Length && word[n]!=ch)
            n++;
        if (n == word.Length)
            return word;
        var sb = new StringBuilder();
        int m = n+1;
        do {
            sb.Append(word[n]);
            n--;
        }
        while (n>=0);
        if (m<word.Length)
            sb.Append(word.Substring(m));
        return sb.ToString();
    }
}
