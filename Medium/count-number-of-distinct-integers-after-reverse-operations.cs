// 1st
public class Solution {
    public int CountDistinctIntegers(int[] nums) {
        var hsIterate = new HashSet<int>(nums);
        var hs = new HashSet<int>(nums);
        foreach (int m in hsIterate) {
            int n = m, i = 0;
            while (n > 0)
            {
                i = (i * 10) + (n % 10);
                n /= 10;
            }
            hs.Add(i);
        }
        return hs.Count;
    }
}

// 2nd 50%~
public class Solution {
    public int CountDistinctIntegers(int[] nums) {
        var hsIterate = new HashSet<int>(nums);
        var hs = new HashSet<int>(nums);
        foreach (int n in hsIterate) {
            var i = 0;
            var str = n.ToString();
            for (int a = str.Length - 1; a >= 0; a--)
                if (str[a] != '0')
                    i = i * 10 + (str[a] - '0');
                else if (str[a] == '0' && i > 0)
                    i *= 10;
            hs.Add(i);
        }
        return hs.Count;
    }
}
