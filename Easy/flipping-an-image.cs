public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        for (int y = 0; y < image.Length; y++)
            for (int x0 = 0, x1 = image[y].Length-1; x0 <= x1; x0++, x1--)
            {
                int t = image[y][x0];
                image[y][x0] = image[y][x1]==0?1:0;
                image[y][x1] = t==0?1:0;
            }
        return image;
    }
}
