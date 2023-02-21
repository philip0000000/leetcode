public class Solution {
    public int Calculate(string s) {
        var nums = new Queue<int>();
        var operators = new Queue<char>();
        var sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
            switch (s[i])
            {
                case '+':
                case '-':
                case '*':
                case '/':
                    nums.Enqueue(int.Parse(sb.ToString()));
                    sb.Clear();
                    operators.Enqueue(s[i]);
                    break;
                case ' ':
                    break;
                default:
                    sb.Append(s[i]);
                    break;
            }
        if (sb.Length>0)
            nums.Enqueue(int.Parse(sb.ToString()));
        var stack = new Stack<int>();
        char op;
        int ret = 0;
        int n=nums.Dequeue();
        while (operators.TryDequeue(out op))
        {
            switch (op)
            {
                case '+':
                    ret+=n;
                    n=nums.Dequeue();
                    break;
                case '-':
                    ret+=n;
                    n=nums.Dequeue();
                    n=-n;
                    break;
                case '*':
                    n *= nums.Dequeue();
                    break;
                case '/':
                    n /= nums.Dequeue();
                    break;
            }
        }
        ret+=n;
        return ret;
    }
}
