public class Solution {
    public int LongestSubarray(int[] nums) {
        var list = new List<int>();
        bool ZeroFound = false;
        int n = 0;
        int zero = 0;
        foreach (var i in nums)
            if (i == 1)
            {
                if (zero > 1)
                    list.Add(0);
                zero = 0;
                n++;
            }
            else if (i == 0)
            {
                if (n > 0)
                {
                    list.Add(n);
                    n = 0;
                }
                ZeroFound = true;
                zero++;
            }
        if (ZeroFound == false)
            return n-1;
        if (zero > 0)
            list.Add(0);
        if (n > 0)
        {
            list.Add(n);
            n = 0;
        }
        int max = 0;
        for (int j = 0; j < list.Count-1; j++)
            if (list[j] + list[j+1] > max)
                max = list[j] + list[j+1];
        return max;
    }
}
