// https://leetcode.com/problems/lemonade-change/submissions/901485383/
public class Solution {
    public bool LemonadeChange(int[] bills) {
        int s5  = 0;
        int s10 = 0;
        for (int i = 0; i < bills.Length; i++)
            switch (bills[i])
            {
                case 5:
                    s5++;
                    break;
                case 10:
                    if (s5==0)
                        return false;
                    s5--;
                    s10++;
                    break;
                case 20:
                    if (s10>0 && s5>0)
                    {
                        s10--;
                        s5--;
                    }
                    else if (s5>=3)
                        s5-=3;
                    else
                        return false;
                    break;
                default:
                    return false;
            }
        return true;
    }
}
