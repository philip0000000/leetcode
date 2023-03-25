public class Solution {
    public double Average(int[] salary) {
        double val = 0;
        Array.Sort(salary);
        for (int i = 1; i < salary.Length-1; i++)
            val += salary[i];
        return val / (salary.Length-2);
    }
}
