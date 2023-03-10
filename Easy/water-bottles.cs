// bad
public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int ret = numBottles;
        int add = 0;
        do {
            while (numBottles >= numExchange)
            {
                numBottles -= numExchange;
                add++;
            }
            ret += add;
            numBottles += add;
            add = 0;
        } while (numBottles >= numExchange);
        return ret;
    }
}
