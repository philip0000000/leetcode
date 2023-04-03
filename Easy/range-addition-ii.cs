// 1st
public class Solution {
    public int MaxCount(int m, int n, int[][] ops) {
        foreach (var arr in ops)
        {
            if (arr[0] < m)
                m = arr[0];
            if (arr[1] < n)
                n = arr[1];
        }
        return m*n;
    }
}

// 2nd
public class Solution {
    public int MaxCount(int m, int n, int[][] ops) {
        foreach (var arr in ops)
        {
            m = Math.Min(arr[0], m);
            n = Math.Min(arr[1], n);
        }
        return m*n;
    }
}
