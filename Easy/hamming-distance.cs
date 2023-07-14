public class Solution {
    public int HammingDistance(int x, int y) {
        int ret = 0;
        while (x > 0 || y > 0)
        {
          int xb = x == 0 ? 0 : x & 1;
          int yb = y == 0 ? 0 : y & 1;
          if ((xb ^ yb) == 1)
            ret++;
          x >>= 1;
          y >>= 1;
        }
        return ret;
    }
}
