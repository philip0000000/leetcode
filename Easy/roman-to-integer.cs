public class Solution {
    static readonly Dictionary<char, int> RomanNrDict = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
    public int RomanToInt(string s) {
        int num = RomanNrDict[s[0]];
        int oldNumber = RomanNrDict[s[0]];
        for (int i = 1; i < s.Length; i++)
        {
            if (RomanNrDict[s[i-1]] < RomanNrDict[s[i]])
                num += RomanNrDict[s[i]] - (2 * RomanNrDict[s[i-1]]);
            else
                num += RomanNrDict[s[i]];
        }
        return num;
    }
}
