public class Solution {
    public int HammingWeight(uint n) {
        int num = 0;
        while (n > 0)
        {
            if ((n & 1) == 1)
                num++;
            n >>= 1;
        }

        return num;
    }
}
