public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);
        for (int i = 0; i < spells.Length; i++)
        {
            double succ = (double)success / (double)spells[i];
            int l = 0, r = potions.Length - 1;
            while (true)
            {
                int m = (l + r) / 2;
                if (m == 0 && r <= 0)
                {
                    if (succ <= potions[0])
                        spells[i] = potions.Length;
                    else
                        spells[i] = potions.Length - 1;
                    break;
                }
                if (m == potions.Length - 1)
                {
                    if (succ > potions[potions.Length-1])
                        spells[i] = 0;
                    else
                        spells[i] = 1;
                    break;
                }
                if ((succ == potions[m] && succ == potions[m+1]) ||
                    (succ == potions[m] && succ < potions[m + 1]))
                    r = m;
                else if (((double)potions[m] < succ && succ < (double)potions[m + 1]) ||
                        (potions[m] < succ && succ == potions[m + 1]))
                {
                    spells[i] = potions.Length - m - 1;
                    break;
                }
                else if (succ < (double)potions[m])
                    r = m - 1;
                else //if (succ > (double)potions[m+1])
                    l = m + 1;
            }
        }
        return spells;
    }
}
