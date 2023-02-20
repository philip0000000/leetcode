public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        for (int i = num.Length-1; i >= 0; i--)
        {
            k += num[i];
            num[i] = k % 10;
            k /= 10;
            if (k==0)
                break;
        }
        var ret = new List<int>(num);
        while (k > 0)
        {
            ret.Insert(0, k%10);
            k/=10;
        }
        return ret;
    }
}
