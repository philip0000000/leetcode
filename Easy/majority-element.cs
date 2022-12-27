// 1st
public class Solution {
    public int MajorityElement(int[] nums) {
        if (nums.Length == 1 || nums.Length == 2)
            return nums[0];
        int findNr = nums.Length / 2;
        if ((nums.Length & 1) == 1)
            findNr++;
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]]++;
                if (dict[nums[i]] == findNr)
                    return nums[i];
            }
            else
                dict.Add(nums[i], 1);
        return -1;
    }
}
