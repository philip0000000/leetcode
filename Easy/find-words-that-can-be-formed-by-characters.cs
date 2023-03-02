public class Solution {
    public int CountCharacters(string[] words, string chars) {
        int ret = 0;
        int[] dict = new int[26];
        foreach (char c in chars)
            dict[c-'a']++;
        for (int i = 0; i < words.Length; i++)
        {
            int[] cmpDict = new int[26];
            Array.Copy(dict, cmpDict, 26);
            int j = 0;
            for (; j < words[i].Length; j++)
            {
                if (cmpDict[words[i][j]-'a']<1)
                    break;
                else
                    cmpDict[words[i][j]-'a']--;
            }
            if (j == words[i].Length)
                ret += words[i].Length;
        }
        return ret;
    }
}
