public class Solution {
    public int MaxPower(string s) {
        int max = 0;
        char CharPre = s[0];
        int currentNr = 0;
        foreach (var c in s)
            if (c != CharPre)
            {
                if (currentNr > max)
                    max = currentNr;
                currentNr = 1;
                CharPre = c;
            }
            else
                currentNr++;
        return Math.Max(currentNr, max);
    }
}
