public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int n = 1;
        for (int i = 0; k > 0 && i < arr.Length; n++)
            if (arr[i] == n)
                i++;
            else
                k--;
        if (k > 0)
            n += k;
        return n-1;
    }
}
