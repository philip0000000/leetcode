public class Solution {
    public uint reverseBits(uint n) {
        uint ret = 0;
        for (int l = 0; l < 31; l++)
        {
            ret += n & 1;
            ret <<= 1;
            n >>= 1;
        }
        ret += n & 1;

        return ret;
    }
}
