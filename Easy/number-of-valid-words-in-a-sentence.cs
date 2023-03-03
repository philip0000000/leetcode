public class Solution {
    public int CountValidWords(string sentence) {
        int ret = 0;
        string[] tokens = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string token in tokens)
        {
            int i = 0;
            bool FoundHyphen = false;
            for (; i < token.Length; i++)
            {
                if ('0' <= token[i] && token[i] <= '9')
                    break;
                if (token[i] == '-')
                {
                    if (i-1 < 0 || i+1 == token.Length ||
                        FoundHyphen ||
                        token[i-1] < 'a' || token[i-1] > 'z' ||
                        token[i+1] < 'a' || token[i+1] > 'z')
                        break;
                    FoundHyphen = true;
                }
                if ((token[i] == '.' || token[i] == ',' || token[i] == '!') &&
                    i+1 != token.Length)
                    break;
            }
            if (i == token.Length)
                ret++;
        }
        return ret;
    }
}
