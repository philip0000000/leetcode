public class Solution {
    public bool IsHappy(int n) {
        var seen = new HashSet<int>();
        seen.Add(n);
        while (n > 1)
        {
            int sum = 0, t = 0;
            while (n > 0)
            {
                t = n % 10;
                sum += t * t;
                n /= 10;
            }
            n = sum;
            if (seen.Contains(n))
                return false;
            seen.Add(n);
        }
        return true;
    }
}
