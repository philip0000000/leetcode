// https://leetcode.com/problems/baseball-game/submissions/882926708/
public class Solution {
    public int CalPoints(string[] operations) {
        var score = new Stack<int>();
        for (int n = 0; n < operations.Length; n++)
            switch (operations[n][0])
            {
                case '+':
                    if (score.Count >= 2)
                    {
                        int temp0 = score.Pop();
                        int temp1 = score.Peek();
                        score.Push(temp0);
                        score.Push(temp0+temp1);
                    }
                    break;
                case 'D':
                    score.Push(score.Peek()*2);
                    break;
                case 'C':
                    score.Pop();
                    break;
                default:
                    score.Push(Int32.Parse(operations[n]));
                    break;
            }
        int ret = 0;
        while (score.Count > 0)
            ret += score.Pop();
        return ret;
    }
}
