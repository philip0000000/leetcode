// https://leetcode.com/problems/odd-string-difference/submissions/907135346/
public class Solution {
    public bool CmpList(List<int> l0, List<int> l1)
    {
        for (int i = 0; i < l0.Count; i++)
            if (l0[i]!=l1[i])
                return false;
        return true;
    }
    public string OddString(string[] words) {
        var diff0 = new List<int>();
        var diff1 = new List<int>();
        var diff2 = new List<int>();
        for (int i = 1, old = words[0][0]-'0'; i < words[0].Length; old = words[0][i]-'0', i++)
            diff0.Add((words[0][i]-'0')-old);
        for (int i = 1, old = words[1][0]-'0'; i < words[1].Length; old = words[1][i]-'0', i++)
            diff1.Add((words[1][i]-'0')-old);
        for (int i = 1, old = words[2][0]-'0'; i < words[2].Length; old = words[2][i]-'0', i++)
            diff2.Add((words[2][i]-'0')-old);
        if (CmpList(diff0, diff1) && CmpList(diff0, diff2))
        {
            for (int j = 3; j < words.Length; j++)
            {
                diff1.Clear();
                for (int i = 1, old = words[j][0]-'0'; i < words[j].Length; old = words[j][i]-'0', i++)
                    diff1.Add((words[j][i]-'0')-old);
                if (!CmpList(diff0, diff1))
                    return words[j];
            }
        }
        if (CmpList(diff0, diff1))
            return words[2];
        if (CmpList(diff0, diff2))
            return words[1];
        return words[0];
    }
}
