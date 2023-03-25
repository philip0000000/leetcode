public class Solution {
    public int[] EvenOddBit(int n) {
        var ret = new int[2];
        bool even = true;
        while (n > 0)
        {
            if (n % 2 == 1)
            {
                if (even)
                    ret[0]++;
                else
                    ret[1]++;
            }
            even = !even;
            n >>= 1;
        }
        return ret;
    }
}
