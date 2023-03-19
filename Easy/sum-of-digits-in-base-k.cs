public class Solution {
    public int SumBase(int n, int k) {
        var stack = new Stack<int>();
        int temp = 1;
        while (temp <= n)
        {
            stack.Push(temp);
            temp *= k;
        }
        int ret = 0;
        while (n > 0)
        {
            temp = n / stack.Peek();
            ret += temp;
            n -= temp * stack.Pop();
        }
        return ret;
    }
}
