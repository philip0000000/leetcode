// note: bad, use Array.Sort
// https://leetcode.com/problems/minimum-amount-of-time-to-fill-cups/submissions/884301457/
// https://leetcode.com/problems/minimum-amount-of-time-to-fill-cups/submissions/884300109/
public class Solution {
    public int FillCups(int[] amount) {
        int ret = 0;
        while (amount[0] > 0 || amount[1] > 0 || amount[2] > 0)
        {
            ret++;
            int Biggest = 0;
            if (amount[1] > amount[0])
                Biggest = 1;
            if (amount[2] > amount[Biggest])
                Biggest = 2;
            int Bigger = 0;
            switch (Biggest)
            {
                default:
                case 0:
                    Bigger = amount[1] > amount[2] ? 1 : 2;
                    break;
                case 1:
                    Bigger = amount[0] > amount[2] ? 0 : 2;
                    break;
                case 2:
                    Bigger = amount[0] > amount[1] ? 0 : 1;
                    break;
            }
            amount[Biggest]--;
            if (amount[Bigger] > 0)
                amount[Bigger]--;
        }
        return ret;
    }
}
