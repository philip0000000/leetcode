public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var dictRN = new Dictionary<char, int>();
        foreach (char c in ransomNote)
            if (dictRN.ContainsKey(c))
                dictRN[c]++;
            else
                dictRN.Add(c, 1);

        var dictM = new Dictionary<char, int>();
        foreach (char c in magazine)
            if (dictM.ContainsKey(c))
                dictM[c]++;
            else
                dictM.Add(c, 1);

        foreach (var kvp in dictRN)
            if (dictM.ContainsKey((char)kvp.Key) == false ||
                dictM[kvp.Key] < dictRN[kvp.Key])
                return false;

        return true;
    }
}
