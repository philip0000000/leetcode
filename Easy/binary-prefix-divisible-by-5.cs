// 50%~
public class Solution {
    public IList<bool> PrefixesDivBy5(int[] nums) {
        var list = new List<bool>();
        int j = 0;
        foreach (int i in nums)
        {
            j += i;
            if ((j%5)==0)
                list.Add(true);
            else
                list.Add(false);
            j <<= 1;
            if (j > 255)
                j = j % 255;
        }
        return list;
    }
}
