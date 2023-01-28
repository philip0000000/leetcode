// bad https://leetcode.com/problems/check-if-it-is-a-straight-line/submissions/886600932/
public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        if (coordinates.Length >= 2)
        {
            if (coordinates[0][0] == coordinates[1][0])
            {
                for (int i = 2; i < coordinates.Length; i++)
                    if (coordinates[0][0] != coordinates[i][0])
                        return false;
            }
            else if (coordinates[0][1] == coordinates[1][1])
            {
                for (int i = 2; i < coordinates.Length; i++)
                    if (coordinates[0][1] != coordinates[i][1])
                        return false;
            }
            else
            {
                int a = 0;
                if ((coordinates[0][0] > 0 && coordinates[1][0] > 0) ||
                   (coordinates[0][0] < 0 && coordinates[1][0] < 0))
                    a = Math.Abs(Math.Min(coordinates[0][0], coordinates[1][0]) -
                                 Math.Max(coordinates[0][0], coordinates[1][0]));
                else
                    a = Math.Abs(coordinates[0][0]) + Math.Abs(coordinates[1][0]);
                int b = 0;
                if ((coordinates[0][1] > 0 && coordinates[1][1] > 0) ||
                   (coordinates[0][1] < 0 && coordinates[1][1] < 0))
                    b = Math.Abs(Math.Min(coordinates[0][1], coordinates[1][1]) -
                                 Math.Max(coordinates[0][1], coordinates[1][1]));
                else
                    b = Math.Abs(coordinates[0][1]) + Math.Abs(coordinates[1][1]);
                if (a == 0 || b == 0)
                    return false;
                float ratio = (float)a / (float)b;
                for (int i = 2; i < coordinates.Length; i++)
                {
                    if ((coordinates[i-1][0] > 0 && coordinates[i][0] > 0) ||
                    (coordinates[i-1][0] < 0 && coordinates[i][0] < 0))
                        a = Math.Abs(Math.Min(coordinates[i-1][0], coordinates[i][0]) -
                                    Math.Max(coordinates[i-1][0], coordinates[i][0]));
                    else
                        a = Math.Abs(coordinates[i-1][0]) + Math.Abs(coordinates[i][0]);
                    if ((coordinates[i-1][1] > 0 && coordinates[i][1] > 0) ||
                    (coordinates[i-1][1] < 0 && coordinates[i][1] < 0))
                        b = Math.Abs(Math.Min(coordinates[i-1][1], coordinates[i][1]) -
                                    Math.Max(coordinates[i-1][1], coordinates[i][1]));
                    else
                        b = Math.Abs(coordinates[i-1][1]) + Math.Abs(coordinates[i][1]);
                    if (a == 0 || b == 0)
                        return false;
                    if (ratio != (float)a / (float)b)
                        return false;

                    // 1st point
                    if ((coordinates[0][0] > 0 && coordinates[i][0] > 0) ||
                    (coordinates[0][0] < 0 && coordinates[i][0] < 0))
                        a = Math.Abs(Math.Min(coordinates[0][0], coordinates[i][0]) -
                                    Math.Max(coordinates[0][0], coordinates[i][0]));
                    else
                        a = Math.Abs(coordinates[0][0]) + Math.Abs(coordinates[i][0]);
                    if ((coordinates[0][1] > 0 && coordinates[i][1] > 0) ||
                    (coordinates[0][1] < 0 && coordinates[i][1] < 0))
                        b = Math.Abs(Math.Min(coordinates[0][1], coordinates[i][1]) -
                                    Math.Max(coordinates[0][1], coordinates[i][1]));
                    else
                        b = Math.Abs(coordinates[0][1]) + Math.Abs(coordinates[i][1]);
                    if (a == 0 || b == 0)
                        return false;
                    if (ratio != (float)a / (float)b)
                        return false;
                }
            }
        }
        return true;
    }
}
