// https://leetcode.com/problems/reverse-integer/submissions/868179040/
public class Solution {
    public int Reverse(int x) {
        bool min;
        if (x < 0)
        {
            if (x == -2147483648)
                return 0;
            x = -x;
            min = true;
        }
        else
            min = false;
        int ret = 0;
        while (x > 0)
        {
            if (ret > 214748364)
                return 0;
            ret *= 10; // move to the left
            ret += (x % 10); // add first digit of x
            x /= 10; // remove first digit
        }
        return min == true ? ret * -1 : ret;
    }
}
