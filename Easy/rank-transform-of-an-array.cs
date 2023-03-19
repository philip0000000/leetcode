public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        var TempArr = new int[arr.Length];
        Array.Copy(arr, TempArr, arr.Length);
        Array.Sort(TempArr);
        var dict = new Dictionary<int, int>();
        int n = 1;
        for (int i = 0; i < TempArr.Length; i++)
            if (!dict.ContainsKey(TempArr[i]))
            {
                dict.Add(TempArr[i], n);
                n++;
            }
        for (int i = 0; i < arr.Length; i++)
            arr[i] = dict[arr[i]];
        return arr;
    }
}
