public class Solution {
    public bool HasAlternatingBits(int n) {
        int prev = n & 1;
        n >>= 1;
        while (n > 0)
        {
            int t = n & 1;
            if (prev == t)
                return false;
            prev = t;
            n >>= 1;
        }
        return true;
    }
}
