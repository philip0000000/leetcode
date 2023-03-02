public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        var ret = new List<int>();
        for (; left <= right; left++)
        {
            string str = left.ToString();
            int i = 0;
            for (; i < str.Length; i++)
                if (str[i]=='0' || (str[i]!='1' && left%(str[i]-'0')!=0))
                    break;
            if (i==str.Length)
                ret.Add(left);
        }
        return ret;
    }
}
