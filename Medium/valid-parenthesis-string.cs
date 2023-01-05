// 1st brute force, bad https://leetcode.com/problems/valid-parenthesis-string/submissions/870989035/
public class Solution {
    public bool CheckValidString(string s) {
        var str = new StringBuilder(s);
        int lp = 0;
        while (lp < str.Length) // remove )
        {
            if (lp >= 0)
            {
                if (str[lp] == ')')
                {
                    int rp = lp - 1;
                    while (rp >= 0 && str[rp] != '(')
                        rp--;
                    if (rp >= 0)
                    {
                        str.Remove(lp, 1);
                        str.Remove(rp, 1);
                        lp -= 2;
                    }
                    else
                        lp++;
                }
                else
                    lp++;
            }
            else
                lp++;
        }
        if (str.Length > 0) // remove leftover ( or )
        {
            lp = 0;
            while (lp < str.Length)
            {
                if (lp >= 0)
                {
                    if (str[lp] == '(')
                    {
                        int rp = lp + 1;
                        while (rp < str.Length && str[rp] != '*')
                            rp++;
                        if (rp < str.Length)
                        {
                            str.Remove(rp, 1);
                            str.Remove(lp, 1);
                        }
                        else
                            lp++;
                    }
                    else if (str[lp] == ')')
                    {
                        int rp = lp - 1;
                        while (rp >= 0 && str[rp] != '*')
                            rp--;
                        if (rp >= 0)
                        {
                            str.Remove(lp, 1);
                            str.Remove(rp, 1);
                            lp -= 2;
                        }
                        else
                            lp++;
                    }
                    else
                        lp++;
                }
                else
                    lp++;
            }
        }
        if (str.Length > 0) // remove *
        {
            lp = 0;
            while (lp < str.Length)
            {
                if (str[lp] == '*')
                    str.Remove(lp, 1);
                else
                    lp++;
            }
        }
        return str.Length > 0 ? false : true;
    }
}

// 2nd stack https://leetcode.com/problems/valid-parenthesis-string/submissions/871463564/
public class Solution {
    public bool CheckValidString(string s) {
        var StarStack = new Stack<int>();
        var LeftStack = new Stack<int>();
        var RightStack = new Stack<int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                LeftStack.Push(i);
            else if (s[i] == ')')
            {
                if (LeftStack.Count > 0)
                    LeftStack.Pop();
                else if (StarStack.Count > 0 && StarStack.Peek() < i)
                    StarStack.Pop();
                else
                    RightStack.Push(i);
            }
            else
                StarStack.Push(i);
        }
        while (LeftStack.Count > 0)
        {
            if (StarStack.Count == 0)
                break;
            if (StarStack.Peek() < LeftStack.Peek())
                break;
            StarStack.Pop();
            LeftStack.Pop();
        }
        while (RightStack.Count > 0)
        {
            if (StarStack.Count == 0)
                break;
            if (StarStack.Peek() > RightStack.Peek())
                break;
            StarStack.Pop();
            RightStack.Pop();
        }
        return LeftStack.Count == 0 && RightStack.Count == 0 ? true : false;
    }
}

// 3rd 50%~
public class Solution {
    public bool CheckValidString(string s) {
        int ho = 0;
        int lo = 0;
        foreach (var c in s)
        {
            if (c == '(')
            {
                ho++;
                lo++;
            }
            else if (c == ')')
            {
                ho--;
                lo--;
            }
            else // c == *
            {
                ho++;
                lo--;
            }
            if (ho < 0)
                break;
            if (lo < 0)
                lo = 0;
        }
        return lo == 0;
    }
}
