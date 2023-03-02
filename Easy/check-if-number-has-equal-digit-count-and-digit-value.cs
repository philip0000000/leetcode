public class Solution {
    public bool DigitCount(string num) {
        int[] dict = new int[10];
        for (int i = 0; i < num.Length; i++)
            dict[num[i]-'0']++;
        for (int i = 0; i < num.Length; i++)
            if (dict[i]!=num[i]-'0')
                return false;
        return true;
    }
}
