// https://leetcode.com/problems/min-cost-climbing-stairs/submissions/870111027/
public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        for (int n = cost.Length - 3; n >= 0; n--)
            cost[n] += cost[n+1] < cost[n+2] ? cost[n+1] : cost[n+2];
        return cost[0] < cost[1] ? cost[0] : cost[1];
    }
}
