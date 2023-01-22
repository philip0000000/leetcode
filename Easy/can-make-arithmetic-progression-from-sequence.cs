public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        int d = arr[1] - arr[0];
        int n = 1;
        while (n < arr.Length)
        {
            if (arr[n-1] != arr[n] - d)
                break;
            n++;
        }
        return n == arr.Length;
    }
}
