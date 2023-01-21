// 1st
public class Solution {
    public int CountEven(int num) {
        int ret = 0;
        var EvenDigitSum = new HashSet<int>();
        var NotEvenDigitSum = new HashSet<int>();
        for (int n = 1; n <= num; n++)
        {
            int sum = 0;
            int t = n;
            while (t > 0)
            {
                sum += t % 10;
                t /= 10;
            }
            if (EvenDigitSum.Contains(sum))
                ret++;
            else if (NotEvenDigitSum.Contains(sum) == false)
            {
                if ((sum % 2) == 0)
                {
                    EvenDigitSum.Add(sum);
                    ret++;
                }
                else
                {
                    NotEvenDigitSum.Add(sum);
                }
            }
        }
        return ret;
    }
}

// 2nd 50%~
public class Solution {
    public int CountEven(int num) {
        int ret = 0;
        var EvenDigitSum = new HashSet<int>();
        var NotEvenDigitSum = new HashSet<int>();
        for (int n = 1; n <= num; n++)
        {
            int sum = 0;
            string str = Convert.ToString(n);
            for (int m = 0; m < str.Length; m++)
                sum += str[m] - '0';
            if (EvenDigitSum.Contains(sum))
                ret++;
            else if (NotEvenDigitSum.Contains(sum) == false)
            {
                if ((sum % 2) == 0)
                {
                    EvenDigitSum.Add(sum);
                    ret++;
                }
                else
                    NotEvenDigitSum.Add(sum);
            }
        }
        return ret;
    }
}

// 3rd 50%~
// https://leetcode.com/problems/count-integers-with-even-digit-sum/submissions/882261721/
public class Solution {
    public int CountEven(int num) {
        int ret = 0;
        for (int n = 1; n <= num; n++)
        {
            int sum = 0;
            string str = Convert.ToString(n);
            for (int m = 0; m < str.Length; m++)
                sum += str[m] - '0';
            if ((sum % 2) == 0)
                ret++;
        }
        return ret;
    }
}
