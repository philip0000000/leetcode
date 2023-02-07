public class Solution {
    public int[] SeparateDigits(int[] nums) {
        var list = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            string str = nums[i].ToString();
            for (int j = 0; j < str.Length; j++)
                list.Add(str[j] - '0');
        }
        return list.ToArray();
    }
}
