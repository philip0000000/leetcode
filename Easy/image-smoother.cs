public class Solution {
    public static int row = 0;
    public static int column = 0;
    public static int GetImgSmootherValue(int[][] arr, int y, int x)
    {
        int sum = arr[y][x];
        int num = 1;
        if (x + 1 < row)
        {
            sum += arr[y][x + 1];
            num++;
            if (y + 1 < column)
            {
                sum += arr[y + 1][x + 1];
                num++;
            }
            if (y - 1 >= 0)
            {
                sum += arr[y - 1][x + 1];
                num++;
            }
        }
        if (x - 1 >= 0)
        {
            sum += arr[y][x - 1];
            num++;
            if (y + 1 < column)
            {
                sum += arr[y + 1][x - 1];
                num++;
            }
            if (y - 1 >= 0)
            {
                sum += arr[y - 1][x - 1];
                num++;
            }
        }
        if (y + 1 < column)
        {
            sum += arr[y + 1][x];
            num++;
        }
        if (y - 1 >= 0)
        {
            sum += arr[y - 1][x];
            num++;
        }
        return sum / num;
    }
    public int[][] ImageSmoother(int[][] img) {
        var RetArr = new int[img.Length][];
        for (int i = 0; i < img.Length; i++)
            RetArr[i] = new int[img[0].Length];
        column = img.Length;
        row = img[0].Length;
        for (int i = 0; i < img.Length; i++)
            for (int j = 0; j < img[0].Length; j++)
                RetArr[i][j] = GetImgSmootherValue(img, i, j);
        return RetArr;
    }
}
