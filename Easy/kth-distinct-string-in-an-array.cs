public class Solution {
    public string KthDistinct(string[] arr, int k) {
        var hash = new HashSet<string>();
        var hashNotDistinct = new HashSet<string>();
        foreach (var c in arr)
            if (hash.Contains(c))
                hashNotDistinct.Add(c);
            else
                hash.Add(c);
        int n = 0;
        foreach (var c in arr)
            if (!hashNotDistinct.Contains(c))
            {
                n++;
                if (n==k)
                    return c;
                else if (n>k)
                    break;
            }
        return "";
    }
}
