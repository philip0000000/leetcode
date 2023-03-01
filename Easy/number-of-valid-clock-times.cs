// https://leetcode.com/problems/number-of-valid-clock-times/submissions/907117005/
public class Solution {
    public int CountTime(string time) {
        int ret=1;
        if (time[1]=='?')
            switch (time[0])
            {
                case '2':
                    ret=4;
                    break;
                case '1':
                case '0':
                    ret=10;
                    break;
                default:
                    ret=24;
                    break;
            }
        else if (time[0]=='?')
        {
            ret=2;
            if (time[1]!='?' && time[1]-'0'<4)
                ret++;
        }
        if (time[3]=='?')
            ret*=6;
        if (time[4]=='?')
            ret*=10;
        return ret;
    }
}
