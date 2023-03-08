public class Solution {
    public int[] DistributeCandies(int candies, int num_people) {
        var ret = new int[num_people];
        int k = 1;
        int sum = 0;
        while (sum <= candies)
            for (int i = 0; i < num_people && sum <= candies; i++)
            {
                if (sum + k >= candies)
                    ret[i] += candies - sum;
                else
                    ret[i] += k;
                sum += k;
                k++;
            }
        return ret;
    }
}
