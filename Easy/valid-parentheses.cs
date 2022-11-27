public class Solution {
    public bool IsValid(string s) {
        Stack<char> PStack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
                PStack.Push(c);
            else
            {
                if (PStack.Count == 0) return false;
                switch (c)
                {
                    case ')':
                        if (PStack.Pop() != '(')
                            return false;
                        break;
                    case '}':
                        if (PStack.Pop() != '{')
                            return false;
                        break;
                    case ']':
                        if (PStack.Pop() != '[')
                            return false;
                        break;
                    default:
                        break;
                }
            }
        }
        if (PStack.Count != 0)
            return false;
        return true;
    }
}
