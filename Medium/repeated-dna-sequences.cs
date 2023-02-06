// https://leetcode.com/problems/repeated-dna-sequences/submissions/892880368/
public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        var dict = new Dictionary<string, int>();
        int p0 = 9;
        int p1 = 0;
        while (p0 < s.Length)
        {
            string temp = s.Substring(p1, 10);
            if (dict.ContainsKey(temp))
                dict[temp]++;
            else
                dict.Add(temp, 1);
            p0++;
            p1++;
        }
        var list = new List<string>();
        foreach (var kvp in dict)
        {
            if (kvp.Value > 1)
                list.Add(kvp.Key);
        }
        return list.ToArray();
    }
}
