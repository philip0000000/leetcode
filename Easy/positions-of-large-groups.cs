public class Solution {
    public IList<IList<int>> LargeGroupPositions(string s) {
        var list = new List<IList<int>>();
        int p0 = 0;
        while (p0 < s.Length)
        {
            int p1 = p0 + 1;
            while (p1 < s.Length && s[p0] == s[p1])
                p1++;
            if (p1 - p0 >= 3)
                list.Add(new List<int>{ p0, p1-1 });
            p0 = p1;
        }
        return list;
    }
}
