// 1st
public class Solution {
    public int DominantIndex(int[] nums) {
        int[] copy = new int[nums.Length];
        Array.Copy(nums, copy, nums.Length);
        Array.Sort(copy);
        int n = copy[copy.Length-1] / 2;
        for (int i = 0; i < copy.Length-1; i++)
            if (copy[i] > n)
                return -1;
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] == copy[copy.Length-1])
                return i;
        return -1;
    }
}

// 2nd 50%~
public class Solution {
    public int DominantIndex(int[] nums) {
        int biggest = 0;
        int biggestIndex = 0;
        var hash = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i]>biggest)
            {
                biggest = nums[i];
                biggestIndex = i;
            }
            hash.Add(nums[i]);
        }
        hash.Remove(biggest);
        biggest /= 2;
        foreach (var i in hash)
            if (i > biggest)
                return -1;
        return biggestIndex;
    }
}
