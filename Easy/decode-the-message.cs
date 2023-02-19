public class Solution {
    public string DecodeMessage(string key, string message) {
        var TranslateKey = new Dictionary<char, char>();
        var hash = new HashSet<char>();
        char l = 'a';
        for (int i = 0; i < key.Length && hash.Count <= 26; i++)
            if (key[i]!=' ')
            {
                if (hash.Contains(key[i])==false)
                {
                    hash.Add(key[i]);
                    TranslateKey.Add(key[i], l);
                    l++;
                }
            }
        TranslateKey.Add(' ', ' ');
        var sb = new StringBuilder();
        for (int i = 0; i < message.Length; i++)
            sb.Append(TranslateKey[message[i]]);
        return sb.ToString();
    }
}
