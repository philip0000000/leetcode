public class Solution {
    public bool CheckDistances(string s, int[] distance) {
        for (int i = 0; i < s.Length; i++)
        {
            int n = s[i]-'a';
            if (distance[n] != -1)
            {
                int d = distance[n];
                if (i+d+1 >= s.Length || s[i] != s[i+d+1])
                    return false;
                distance[n] = -1;
            }
        }
        return true;
    }
}
