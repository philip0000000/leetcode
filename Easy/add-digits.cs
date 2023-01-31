// 1st
public class Solution {
    public int AddDigits(int num) {
        while (num > 9)
        {
            int n = 0;
            while (num > 0)
            {
                n += num%10;
                num/=10;
            }
            num = n;
        }
        return num;
    }
}

// 2nd O(1) 50%~...Modulo Operator (%)
public class Solution {
    public int AddDigits(int num) {
        int ret = 0;
        while (num > 0)
        {
            ret += num%10;
            num/=10;
            if (ret > 9)
                ret -= 9;
        }
        return ret;
    }
}
