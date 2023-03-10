public class Solution {
    public int MinBitFlips(int start, int goal) {
        int ret = 0;
        while (start > 0 || goal > 0)
        {
            if ((start & 1) != (goal & 1))
                ret++;
            start >>= 1;
            goal >>= 1;
        }
        return ret;
    }
}
