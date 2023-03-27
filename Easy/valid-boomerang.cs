public class Solution {
    public bool IsBoomerang(int[][] points) {
        if ((points[0][0] == points[1][0] && points[0][1] == points[1][1]) ||
            (points[1][0] == points[2][0] && points[1][1] == points[2][1]) ||
            (points[0][0] == points[2][0] && points[0][1] == points[2][1]))
            return false;
        double x1, y1;
        x1 = points[1][0] - points[0][0];
        y1 = points[1][1] - points[0][1];
        double x2, y2;
        x2 = points[2][0] - points[1][0];
        y2 = points[2][1] - points[1][1];
        double a1 = x1 / y1;
        double a2 = x2 / y2;
        if (a1 == double.NegativeInfinity && a2 == double.PositiveInfinity)
            return false;
        return a1 == a2 ? false : true;
    }
}
