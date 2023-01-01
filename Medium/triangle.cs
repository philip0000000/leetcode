// https://leetcode.com/problems/triangle/submissions/868828317/
public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int r = triangle.Count - 2;
        int sum = 0;
        while (r >= 0)
        {
            for (int n = 0; n < triangle[r].Count; n++)
            {
                if (triangle[r][n] + triangle[r+1][n] < triangle[r][n] + triangle[r+1][n+1])
                    triangle[r][n] += triangle[r+1][n];
                else
                    triangle[r][n] += triangle[r+1][n+1];
            }
            r--;
        }
        return triangle[0][0];
    }
}
