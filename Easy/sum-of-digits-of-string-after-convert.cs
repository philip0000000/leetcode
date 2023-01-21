// https://leetcode.com/problems/sum-of-digits-of-string-after-convert/submissions/882132881/
public class Solution {
    public int GetLucky(string s, int k) {
        var nums = new List<int>();
        foreach (var c in s)
        {
            int t = c - '`';
            if (t > 9)
                {
                    nums.Add(t / 10);
                    nums.Add(t % 10);
                }
                else
                    nums.Add(t);
        }
        nums.Add(0);
        for (;k > 0; k--)
        {
            int temp = 0;
            int x = 0;
            for (; x < nums.Count && nums[x] != -1; x++)
            {
                temp += nums[x];
                nums[x] = 0;
            }
            string str = temp.ToString();
            int y = 0;
            for (; y < str.Length; y++)
                nums[y] = str[y] - '0';
            nums[y] = -1;
        }
        int ret = 0;
        for (int v = 0; v < nums.Count && nums[v] != -1; v++)
        {
            ret *= 10;
            ret += nums[v];
        }
        return ret;
    }
}
