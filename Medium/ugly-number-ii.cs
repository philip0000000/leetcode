public class Solution {
    public int NthUglyNumber(int n) {
        var UglyNums = new List<int> { 1, 2, 3, 4, 5 };
        int highest = 5;
        int two = 1;
        int twoValue = 0;
        int three = 1;
        int threeValue = 0;
        int five = 1;
        int fiveValue = 0;
        while (UglyNums.Count < n)
        {
            if (twoValue <= highest)
                for (; two < UglyNums.Count && twoValue <= highest; two++)
                    twoValue = UglyNums[two] * 2;
            if (threeValue <= highest)
                for (; three < UglyNums.Count && threeValue <= highest; three++)
                    threeValue = UglyNumugly-nums[three] * 3;
            if (fiveValue <= highest)
                for (; five < UglyNums.Count && fiveValue <= highest; five++)
                    fiveValue = UglyNums[five] * 5;
            highest = Math.Min(twoValue, Math.Min(threeValue, fiveValue));
            UglyNums.Add(highest);
        }
        return UglyNums[n-1];
    }
}
