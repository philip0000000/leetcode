public class Solution {
    public int LengthOfLastWord(string s) {
        int ret = 0;
        int i = s.Length - 1;
        while (i >= 0 && s[i] == ' ') // remove space
            i--;
        while (i >= 0 && s[i] != ' ')
        {
            i--;
            ret++;
        }
        return ret;
    }
}
