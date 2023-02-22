public class Solution {
    public bool BuddyStrings(string s, string goal) {
        if (s.Length!=goal.Length)
            return false;
        if (s==goal)
        {
            var hash = new HashSet<char>();
            for (int m = 0; m < s.Length; m++)
                if (hash.Contains(s[m]))
                    return true;
                else
                    hash.Add(s[m]);
            return false;
        }
        int i = 0;
        for (; i < goal.Length; i++)
            if (s[i]!=goal[i])
                break;
        int j = i+1;
        for (; j < goal.Length; j++)
            if (s[j] != goal[j])
                break;
        if (j==goal.Length)
            return false;
        int n = j+1;
        for (; n < goal.Length; n++)
            if (s[n]!=goal[n])
                return false;
        if (s[i]==goal[j] && s[j]==goal[i])
            return true;
        return false;
    }
}
