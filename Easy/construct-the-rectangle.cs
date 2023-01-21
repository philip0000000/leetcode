// https://leetcode.com/problems/construct-the-rectangle/submissions/882158227/
public class Solution {
    public int[] ConstructRectangle(int area) {
        int l = (int)Math.Sqrt(area);
        while ((area % l) != 0)
            l--;
        return new int[] { area/l, l };
    }
}
