// Rolling hash // https://leetcode.com/problems/rotate-string/submissions/899124332/
public class Solution {
    public bool RotateString(string s, string goal) {
        if (s.Length == goal.Length)
        {
            if (s.Length > 1)
            {
                int str0 = s[0];
                int str1 = goal[0];
                if ((s[s.Length - 1] & 1) == 1)
                    str0 *= -1;
                if ((goal[goal.Length - 1] & 1) == 1)
                    str1 *= -1;
                for (int i = 1; i < s.Length; i++)
                {
                    int t;
                    t = s[i];
                    if ((s[i-1] & 1) == 1)
                        t *= -1;
                    str0 += t;
                    t = goal[i];
                    if ((goal[i - 1] & 1) == 1)
                        t *= -1;
                    str1 += t;
                }
                if (str0 == str1)
                    return true;
            }
            else if (s[0] == goal[0])
                return true;
        }
        return false;
    }
}
