// https://leetcode.com/problems/find-the-town-judge/submissions/900650300/
public class Solution {
    public int FindJudge(int n, int[][] trust) {
        var HowManyPeopleThisPersonTrust = new int[n+1];
        var HowManyTrustThisPerson = new int[n+1];
        for (int i = 0; i < trust.Length; i++)
        {
            HowManyPeopleThisPersonTrust[trust[i][0]]++;
            HowManyTrustThisPerson[trust[i][1]]++;
        }
        n--;
        int found = 0;
        int label = 0;
        for (int i = 1; i < HowManyPeopleThisPersonTrust.Length; i++)
            if (HowManyPeopleThisPersonTrust[i] == 0 && HowManyTrustThisPerson[i] == n)
            {
                if (found == 1)
                    return -1;
                found++;
                label = i;
            }
        if (found == 0)
            return -1;
        return label;
    }
}
