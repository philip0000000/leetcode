public class Solution {
    public string GreatestLetter(string s) {
        char ret = ' ';
        var hashLower = new HashSet<char>();
        var hashUpper = new HashSet<char>();
        foreach (var c in s)
            if (c >= 'a' && c <= 'z')
            {
                hashLower.Add(c);
                if (hashUpper.Contains((char)(c - 32)) && c - 32 > ret)
                    ret = (char)(c - 32);
            }
            else
            {
                hashUpper.Add(c);
                if (hashLower.Contains((char)(c + 32)) && c > ret)
                    ret = c;
            }
        return ret == ' ' ? "" : ret.ToString();
    }
}
