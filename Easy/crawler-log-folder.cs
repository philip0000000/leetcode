// 1st
public class Solution {
    public int MinOperations(string[] logs) {
        var stack = new Stack<bool>();
        for (int n = 0; n < logs.Length; n++)
            switch (logs[n])
            {
                case "../":
                    if (stack.Count > 0)
                        stack.Pop();
                    break;
                case "./":
                    break;
                default:
                    stack.Push(true);
                    break;
            }
        return stack.Count;
    }
}

// 2nd
public class Solution {
    public int MinOperations(string[] logs) {
        int ret = 0;
        for (int n = 0; n < logs.Length; n++)
            switch (logs[n])
            {
                case "../":
                    if (ret > 0)
                        ret--;
                    break;
                case "./":
                    break;
                default:
                    ret++;
                    break;
            }
        return ret;
    }
}
