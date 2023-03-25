public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach (var str in words)
        {
            int p0 = 0, p1 = str.Length-1;
            while (p0 < p1 && str[p0] == str[p1])
            {
                p0++;
                p1--;
            }
            if (p0 >= p1)
                return str;
        }
        return "";
    }
}
