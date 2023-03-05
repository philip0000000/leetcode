public class Solution {
    public int CountGoodTriplets(int[] arr, int a, int b, int c) {
        int ret = 0;
        for (int k = 2; k < arr.Length; k++)
            for (int i = 0; i < k-1; i++)
                for (int j = i+1; j < k; j++)
                    if (Math.Abs(arr[i] - arr[j]) <= a &&
                        Math.Abs(arr[j] - arr[k]) <= b &&
                        Math.Abs(arr[i] - arr[k]) <= c)
                        ret++;
        return ret;
    }
}
