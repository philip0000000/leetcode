public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var ret = new int[temperatures.Length];
        for (int i = temperatures.Length-2; i >= 0; i--)
        {
            int sum = 1;
            while (temperatures[i+sum] <= temperatures[i] && ret[i+sum] > 0)
                sum += ret[i+sum];
            ret[i] = temperatures[i+sum] > temperatures[i] ? sum : 0;
        }
        return ret;
    }
}
