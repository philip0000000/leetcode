public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int BiggestNr = -1;
        for (int i = arr.Length-1; i >= 0; i--)
        {
            int temp = arr[i];
            arr[i] = BiggestNr;
            if (temp > BiggestNr)
                BiggestNr = temp;
        }
        return arr;
    }
}
