public class Solution {
    public int MinimumSum(int num) {
        int[] arr = new int[4];
        arr[0] = num%10;
        num/=10;
        arr[1] = num%10;
        num/=10;
        arr[2] = num%10;
        num/=10;
        arr[3] = num%10;
        Array.Sort(arr);
        return ((arr[0]+arr[1])*10)+arr[2]+arr[3];
    }
}
