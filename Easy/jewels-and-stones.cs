public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        var hash = new HashSet<int>();
        foreach (var i in jewels)
            hash.Add(i);
        int ret = 0;
        foreach (var i in stones)
            if (hash.Contains(i))
                ret++;
        return ret;
    }
}
