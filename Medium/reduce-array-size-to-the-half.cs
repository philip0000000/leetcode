// https://leetcode.com/problems/reduce-array-size-to-the-half/submissions/902227048/
public class Solution {
    public int MinSetSize(int[] arr) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
            if (dict.ContainsKey(arr[i]))
                dict[arr[i]]++;
            else
                dict[arr[i]]=1;
        var list = new List<int>();
        foreach (var kvp in dict)
            list.Add(kvp.Value);
        int sum = arr.Length / 2;
        if ((arr.Length%2)!=0)
            sum++;
        list.Sort();
        int m = 0;
        int n = list.Count-1;
        for (; n >= 0 && m < sum; n--)
            m += list[n];
        return list.Count-n-1;
    }
}
