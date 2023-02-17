public class Solution {
    public char RepeatedCharacter(string s) {
        var hash = new HashSet<char>();
        for (int i = 0; i < s.Length; i++)
            if (hash.Contains(s[i]))
                return s[i];
            else
                hash.Add(s[i]);
        return s[0];
    }
}
