// 1st
public class Solution {
    Dictionary<char, string> morse = new Dictionary<char, string>()
    {
        {'a', ".-"},
        {'b', "-..."},
        {'c', "-.-."},
        {'d', "-.."},
        {'e', "."},
        {'f', "..-."},
        {'g', "--."},
        {'h', "...."},
        {'i', ".."},
        {'j', ".---"},
        {'k', "-.-"},
        {'l', ".-.."},
        {'m', "--"},
        {'n', "-."},
        {'o', "---"},
        {'p', ".--."},
        {'q', "--.-"},
        {'r', ".-."},
        {'s', "..."},
        {'t', "-"},
        {'u', "..-"},
        {'v', "...-"},
        {'w', ".--"},
        {'x', "-..-"},
        {'y', "-.--"},
        {'z', "--.."}
    };
    public int UniqueMorseRepresentations(string[] words) {
        var hash = new HashSet<string>();
        for (int i = 0; i < words.Length; i++)
        {
            var sb = new StringBuilder();
            for (int j = 0; j < words[i].Length; j++)
                sb.Append(morse[words[i][j]]);
            hash.Add(sb.ToString());
        }
        return hash.Count;
    }
}

// 2nd https://leetcode.com/problems/unique-morse-code-words/submissions/900929566/
public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        var hash = new HashSet<int>();
        for (int i = 0; i < words.Length; i++)
        {
            int h = 0;
            for (int j = 0; j < words[i].Length; j++)
                switch (words[i][j])
                {
                    case 'a':
                        h = (h * 31) + '.';
                        h = (h * 31) + '-';
                        break;
                    case 'b':
                        h = (h * 31) + '-';
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        break;
                    case 'c':
                        h = (h * 31) + '-';
                        h = (h * 31) + '.';
                        h = (h * 31) + '-';
                        h = (h * 31) + '.';
                        break;
                    case 'd':
                        h = (h * 31) + '-';
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        break;
                    case 'e':
                        h = (h * 31) + '.';
                        break;
                    case 'f':
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        h = (h * 31) + '-';
                        h = (h * 31) + '.';
                        break;
                    case 'g':
                        h = (h * 31) + '-';
                        h = (h * 31) + '-';
                        h = (h * 31) + '.';
                        break;
                    case 'h':
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        break;
                    case 'i':
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        break;
                    case 'j':
                        h = (h * 31) + '.';
                        h = (h * 31) + '-';
                        h = (h * 31) + '-';
                        h = (h * 31) + '-';
                        break;
                    case 'k':
                        h = (h * 31) + '-';
                        h = (h * 31) + '.';
                        h = (h * 31) + '-';
                        break;
                    case 'l':
                        h = (h * 31) + '.';
                        h = (h * 31) + '-';
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        break;
                    case 'm':
                        h = (h * 31) + '-';
                        h = (h * 31) + '-';
                        break;
                    case 'n':
                        h = (h * 31) + '-';
                        h = (h * 31) + '.';
                        break;
                    case 'o':
                        h = (h * 31) + '-';
                        h = (h * 31) + '-';
                        h = (h * 31) + '-';
                        break;
                    case 'p':
                        h = (h * 31) + '.';
                        h = (h * 31) + '-';
                        h = (h * 31) + '-';
                        h = (h * 31) + '.';
                        break;
                    case 'q':
                        h = (h * 31) + '-';
                        h = (h * 31) + '-';
                        h = (h * 31) + '.';
                        h = (h * 31) + '-';
                        break;
                    case 'r':
                        h = (h * 31) + '.';
                        h = (h * 31) + '-';
                        h = (h * 31) + '.';
                        break;
                    case 's':
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        break;
                    case 't':
                        h = (h * 31) + '-';
                        break;
                    case 'u':
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        h = (h * 31) + '-';
                        break;
                    case 'v':
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        h = (h * 31) + '-';
                        break;
                    case 'w':
                        h = (h * 31) + '.';
                        h = (h * 31) + '-';
                        h = (h * 31) + '-';
                        break;
                    case 'x':
                        h = (h * 31) + '-';
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        h = (h * 31) + '-';
                        break;
                    case 'y':
                        h = (h * 31) + '-';
                        h = (h * 31) + '.';
                        h = (h * 31) + '-';
                        h = (h * 31) + '-';
                        break;
                    case 'z':
                        h = (h * 31) + '-';
                        h = (h * 31) + '-';
                        h = (h * 31) + '.';
                        h = (h * 31) + '.';
                        break;
                    default:
                        break;
                }
            hash.Add(h);
        }
        return hash.Count;
    }
}
