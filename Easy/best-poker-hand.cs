// https://leetcode.com/problems/best-poker-hand/submissions/906793062/
public class Solution {
    public string BestHand(int[] ranks, char[] suits) {
        if (suits[0] == suits[1] &&
            suits[0] == suits[2] &&
            suits[0] == suits[3] &&
            suits[0] == suits[4])
            return "Flush";
        var dict = new Dictionary<int, int>();
        foreach (int n in ranks)
            if (dict.ContainsKey(n))
                dict[n]++;
            else
                dict.Add(n, 1);
        bool FoundPair = false;
        foreach (var kvp in dict)
            if (kvp.Value>=3)
                return "Three of a Kind";
            else if (kvp.Value==2)
                FoundPair = true;
        return FoundPair ? "Pair" : "High Card";
    }
}
