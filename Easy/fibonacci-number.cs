public class Solution {
    public int Fib(int n) {
        if (n == 0)
            return 0;

        int var0 = 1;
        int var1 = 0;
        for (int i = 1; i < n; i++)
        {
            if (var1 > var0)
                var0 += var1;
            else
                var1 += var0;
        }

        return var0 > var1 ? var0 : var1;
    }
}
