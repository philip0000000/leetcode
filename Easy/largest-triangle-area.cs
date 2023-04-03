public class Solution {
    public static double CalculateDistance(int[] p1, int[] p2, int[] p3) {
        double area = 0.5 * Math.Abs((p1[0]*p2[1] + p2[0]*p3[1] + p3[0]*p1[1]) - (p1[1]*p2[0] + p2[1]*p3[0] + p3[1]*p1[0]));
        return area;
    }
    public double LargestTriangleArea(int[][] points) {
        double ret = 0;
        for (int i = 0; i < points.Length-2; i++)
            for (int j = i + 1; j < points.Length-1; j++)
                for (int n = j+1; n < points.Length; n++)
                {
                    double t = CalculateDistance(points[i], points[j], points[n]);
                    if (t > ret)
                        ret = t;
                }
        return ret;
    }
}
