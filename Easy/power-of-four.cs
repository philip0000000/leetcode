public class Solution {
    public bool IsPowerOfFour(int n) {
        int zeros = 0;
        while (n > 0)
        {
            if ((n & 1) == 1)
                break;
            zeros++;
            n >>= 1;
        }
        if (n == 1)
        {
            if ((zeros % 4) == 0 || (zeros % 4) == 2)
                return true;
        }
        return false;
    }
}
