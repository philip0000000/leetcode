public class Solution {
    public int VowelStrings(string[] words, int left, int right) {
        int ret = 0;
        right++;
        for (int i = left; i < right && i < words.Length; i++)
            switch (words[i][0])
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    switch (words[i][words[i].Length-1])
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            ret++;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        return ret;
    }
}
