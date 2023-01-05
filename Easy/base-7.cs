public class Solution {
    public (int, int) Calc(int num)
    {
        int ret = 1;
        int temp = num;
        int n = 0;
        while (temp >= 7)
        {
            n++;
            temp /= 7;
        }
        if (temp < 8 && temp > 0)
            ret = temp;
        if (n > 0)
        {
            int del = 1;
            while (n > 0)
            {
                del *= 7;
                ret *= 10;
                n--;
            }
            num -= temp * del;
        }
        else
            ret = 0;
        return (num, ret);
    }
    public string ConvertToBase7(int num) {
        bool negativ = false;
        if (num < 0)
        {
            num = -num;
            negativ = true;
        }
        (int x, int s) = Calc(num);
        int ret = s;
        while (x >= 7)
        {
            (x, s) = Calc(x);
            ret += s;
        }
        ret += x;
        if (negativ)
            ret = -ret;
        return ret.ToString();
    }
}
