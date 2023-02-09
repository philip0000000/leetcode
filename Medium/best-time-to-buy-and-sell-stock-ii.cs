public class Solution {
    public int MaxProfit(int[] prices) {
        int ret = 0;
        int h = 0;
        for (int i = prices.Length-1; i >= 0; i--)
        {
            if (prices[i] < h)
                ret += h - prices[i];
            h = prices[i];
        }
        return ret;
    }
}

// 2nd
public class Solution {
    public int MaxProfit(int[] prices) {
        int ret = 0;
        for (int i = prices.Length-1; i > 0; i--)
            if (prices[i-1] < prices[i])
                ret += prices[i] - prices[i-1];
        return ret;
    }
}
