public class Solution {
    public int SplitNum(int num) {
        var list = new List<int>();
        while (num > 0)
        {
            list.Add(num%10);
            num /= 10;
        }
        list.Sort();
        int num0 = 0;
        int num1 = 0;
        bool even = true;
        for (int i = 0; i < list.Count; i++)
            if (even)
            {
                num0 *= 10;
                num0 += list[i];
                even = false;
            }
            else
            {
                num1 *= 10;
                num1 += list[i];
                even = true;
            }
        return num0+num1;
    }
}
