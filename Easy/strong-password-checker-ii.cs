//https://leetcode.com/problems/strong-password-checker-ii/submissions/890733138/
public class Solution {
    public bool StrongPasswordCheckerII(string password) {
        if (password.Length >= 8)
        {
            bool lower = false;
            bool upper = false;
            bool digit = false;
            bool spec = false;
            for (int i = 0; i < password.Length &&
                           (lower == false || upper == false || digit == false || spec == false); i++)
            {
                if (password[i] >= 'a' && password[i] <= 'z')
                {
                    lower = true;
                    continue;
                }
                if (password[i] >= 'A' && password[i] <= 'Z')
                {
                    upper = true;
                    continue;
                }
                if (password[i] >= '0' && password[i] <= '9')
                {
                    digit = true;
                    continue;
                }
                switch (password[i])
                {
                    case '!':
                    case '@':
                    case '#':
                    case '$':
                    case '%':
                    case '^':
                    case '&':
                    case '*':
                    case '(':
                    case ')':
                    case '-':
                    case '+':
                        spec = true;
                        break;
                    default:
                        return false;
                }
            }
            if (lower == true && upper == true && digit == true && spec == true)
            {
                for (int i = 1; i < password.Length; i++)
                    if (password[i-1] == password[i])
                        return false;
                return true;
            }
        }
        return false;
    }
}
