// 1st https://leetcode.com/problems/check-if-word-equals-summation-of-two-words/submissions/910448678/
public class Solution {
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
        int fw = 0, sw = 0, tw = 0;
        foreach (char c in firstWord)
            fw = fw * 10 + c - 'a';
        foreach (char c in secondWord)
            sw = sw * 10 + c - 'a';
        foreach (char c in targetWord)
            tw = tw * 10 + c - 'a';
        return fw + sw == tw ? true : false;
    }
}

// 2nd 50%~
public class Solution {
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
        int fw = 0, sw = 0, tw = 0;
        foreach (char c in firstWord)
            fw = fw * 10 + c - 'a';
        foreach (char c in secondWord)
            sw = sw * 10 + c - 'a';
        foreach (char c in targetWord)
            tw = tw * 10 + c - 'a';
        return fw + sw == tw;
    }
}
