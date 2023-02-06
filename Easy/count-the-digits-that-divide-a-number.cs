// 1st https://leetcode.com/problems/count-the-digits-that-divide-a-number/submissions/892664636/
public class Solution {
    public int CountDigits(int num) {
        var stack = new Stack<int>();
        int t = num;
        while (t > 0)
        {
            int n = t % 10;
            stack.Push(n);
            t /= 10;
        }
        int ret = 0;
        while (stack.Count > 0)
        {
            if ((num % stack.Pop()) == 0)
                ret++;
        }
        return ret;
    }
}

// 2nd https://leetcode.com/problems/count-the-digits-that-divide-a-number/submissions/892672713/
public class Solution {
    public int CountDigits(int num) {
        int[] dict = new int[10];
        int t = num;
        while (t > 0)
        {
            dict[t % 10]++;
            t /= 10;
        }
        int ret = dict[1];
        for (int i = 2; i < 11; i++)
        {
            if ((num % i) == 0)
                ret += dict[i];
        }
        return ret;
    }
}
