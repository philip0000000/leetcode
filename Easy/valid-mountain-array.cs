public class Solution {
    public bool ValidMountainArray(int[] arr) {
        if (arr.Length < 3 || arr[0] > arr[1] || arr[arr.Length-2] < arr[arr.Length-1])
            return false;
        int i = 1;
        while (i < arr.Length && arr[i-1] < arr[i])
            i++;
        while (i < arr.Length && arr[i-1] > arr[i])
            i++;
        return i == arr.Length ? true : false;
    }
}
