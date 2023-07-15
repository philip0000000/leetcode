public class Solution {
    public bool JudgeCircle(string moves) {
        var pos = (0, 0);
        foreach (char c in moves)
            switch (c)
            {
                case 'R':
                    pos.Item2++;
                    break;
                case 'L':
                    pos.Item2--;
                    break;
                case 'U':
                    pos.Item1++;
                    break;
                case 'D':
                    pos.Item1--;
                    break;
                default:
                    break;
            }
        return pos == (0, 0) ? true : false;
    }
}
