public class Solution {
    public int SubtractProductAndSum(int n) {
        int product = 1;
        int sum = 0;
        while (n > 0)
        {
            int t = n % 10;
            product *= t;
            sum += t;
            n /= 10;
        }
        return product - sum;
    }
}
