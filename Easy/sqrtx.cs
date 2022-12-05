public class Solution {
    public long BinarySearch(long l, long r, int target)
    {
        if (l > r) return -1;
        long m = l + (r - l) / 2;
        if (m > 46341) return BinarySearch(l, 46341, target); // anything bigger than this, will cause overflow
        long num = m * m;
        if (num == target) return m;
        if (num < target && (m + 1) * (m + 1) > target) return m;
        if (num > target) return BinarySearch(l, m - 1, target);
        return BinarySearch(m + 1, r, target); //if (num < target)
    }
    public int MySqrt(int x) {
        if (x == 0) return 0;
        if (x < 4) return 1;
        return (int)BinarySearch(1, x/2, x);
    }
}
