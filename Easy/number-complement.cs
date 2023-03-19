// 90%~
public class Solution {
    public int FindComplement(int num) {
        uint mask = uint.MaxValue;
        while ((num & mask) != 0) {
            mask <<= 1;
        }
        return ~(int)mask & ~num;
    }
}
