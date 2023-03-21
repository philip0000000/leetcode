public class Solution {
    public string ToGoatLatin(string sentence) {
        string[] words = sentence.Split(' ', StringSplitOptions.TrimEntries);
        var sb = new StringBuilder();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i][0] == 'a' || words[i][0] == 'A' ||
                words[i][0] == 'e' || words[i][0] == 'E' ||
                words[i][0] == 'i' || words[i][0] == 'I' ||
                words[i][0] == 'o' || words[i][0] == 'O' ||
                words[i][0] == 'u' || words[i][0] == 'U')
                sb.Append(words[i]);
            else
            {
                sb.Append(words[i].Substring(1));
                sb.Append(words[i][0]);
            }
            sb.Append("ma");
            sb.Append('a', i+1);
            sb.Append(' ');
        }
        sb.Length--;
        return sb.ToString();
    }
}
