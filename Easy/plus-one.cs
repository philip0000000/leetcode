public class Solution {
    public int[] PlusOne(int[] digits) {
        var list = new List<int>(digits);
        int i = digits.Length-1;
        list[i]++;
        while (i >= 0 && list[i] == 10)
        {
            list[i] = 0;
            i--;
            if (i == -1)
                list.Insert(0, 1);
            else
                list[i]++;
        }
        return list.ToArray();
    }
}
