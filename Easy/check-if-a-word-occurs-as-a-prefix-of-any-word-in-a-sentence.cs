public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        var StrArr = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < StrArr.Length; i++)
            if (StrArr[i].StartsWith(searchWord))
                return i+1;
        return -1;
    }
}
