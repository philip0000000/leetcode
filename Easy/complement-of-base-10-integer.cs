public class Solution {
    public int BitwiseComplement(int n) {
        if (n==0)
            return 1;
        int ret = 0;
        int b = 0;
        while (n > 0)
        {
            if ((n & 1) == 0)
                ret |= 1<<b;
            b++;
            n >>= 1;
        }
        return ret;
    }
}
