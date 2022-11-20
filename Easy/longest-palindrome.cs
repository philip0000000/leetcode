public class Solution {
    public int LongestPalindrome(string s) {
        var Dic = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (Dic.ContainsKey(c))
                Dic[c]++;
            else
                Dic.Add(c, 1);
        }

        int num = 0;
        bool AddOneOdd = false;
        foreach(var item in Dic)
        {
            if ((item.Value % 2) == 0) // if even
                num += item.Value;
            else if (AddOneOdd == false)
            {
                num += item.Value;
                AddOneOdd = true;
            }
            else
                num += item.Value - 1;
        }

        return num;
    }
}
