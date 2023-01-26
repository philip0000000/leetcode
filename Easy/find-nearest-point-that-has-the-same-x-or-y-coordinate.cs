// 1st
public int NearestValidPoint(int x, int y, int[][] points) {
    var valid = new List<(int, int, int)>();
    for (int i = 0; i < points.Length; i++)
        if (points[i][0] == x || points[i][1] == y)
            valid.Add((i, points[i][0], points[i][1]));
    if (valid.Count == 0)
        return -1;
    else if (valid.Count == 1)
        return valid[0].Item1;
    int index = valid.Count-1;
    int calc = Math.Abs(x - valid[index].Item2) + Math.Abs(y - valid[index].Item3);
    for (int i = valid.Count-2; i >= 0; i--)
    {
        int temp = Math.Abs(x - valid[i].Item2) + Math.Abs(y - valid[i].Item3);
        if (temp <= calc)
        {
            calc = temp;
            index = i;
        }
    }
    return valid[index].Item1;
}
    
// 2nd https://leetcode.com/problems/find-nearest-point-that-has-the-same-x-or-y-coordinate/submissions/885503539/
public int NearestValidPoint(int x, int y, int[][] points) {
    int i = points.Length-1;
    int index = -1;
    int calc = Int32.MaxValue;
    while (i >= 0)
    {
        if (points[i][0] == x || points[i][1] == y)
        {
            int temp = Math.Abs(x - points[i][0]) + Math.Abs(y - points[i][1]);
            if (temp <= calc)
            {
                calc = temp;
                index = i;
            }
        }
        i--;
    }
    return index;
}
