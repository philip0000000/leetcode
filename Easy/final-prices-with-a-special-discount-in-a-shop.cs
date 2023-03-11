public class Solution {
    public int[] FinalPrices(int[] prices) {
        var ret = new int[prices.Length];
        var stack = new Stack<int>();
        for (int i = prices.Length-1; i >= 0; i--)
        {
            while (stack.Count > 0 && stack.Peek() > prices[i])
                stack.Pop();
            if (stack.Count == 0)
            {
                stack.Push(prices[i]);
                ret[i] = prices[i];
            }
            else
            {
                ret[i] = prices[i] - stack.Peek();
                stack.Push(prices[i]);
            }
        }
        return ret;
    }
}
