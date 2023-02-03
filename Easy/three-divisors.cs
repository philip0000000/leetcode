public class Solution {
    public bool IsThree(int n) {
        int divi = 0, m = (n/2)+1;
        for (int i = 2; i < m; i++)
            if ((n % i)==0)
                divi++;
        return divi == 1;
    }
}
