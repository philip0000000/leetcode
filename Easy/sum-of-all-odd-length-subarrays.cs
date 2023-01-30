// O(N^2)
public class Solution {
    public int SumOddLengthSubarrays(int[] arr)
    {
        int ret = 0;
        var mult = new int[arr.Length];
        var oddNums = new Dictionary<int, int>();
        for (int i = 3; i <= arr.Length; i += 2)
            oddNums.Add(i, 0);
        int down = arr.Length;
        int up = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            mult[i] = 1;
            foreach(var kvp in oddNums)
            {
                if (down >= kvp.Key && kvp.Value < kvp.Key)
                    oddNums[kvp.Key]++;
                if (up >= kvp.Key && down < kvp.Key)
                    oddNums[kvp.Key]--;
                mult[i] += oddNums[kvp.Key];
            }
            ret += arr[i] * mult[i];
            down--;
            up++;
        }
        return ret;
    }
}

// O(N^3)
public class Solution {
    public int SumOddLengthSubarrays(int[] arr)
    {
        int ret = 0;
        for (int i = 1; i <= arr.Length; i += 2)
        {
            for (int n = 0; n < arr.Length; n++)
            {
                if (n + i <= arr.Length)
                {
                    for (int m = 0; m < i; m++)
                        ret += arr[n + m];
                }
            }
        }
        return ret;
    }
}
