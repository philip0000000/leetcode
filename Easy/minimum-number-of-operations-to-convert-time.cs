public class Solution {
    public int ConvertTime(string current, string correct) {
        int ret = 0;
        int corH = (correct[0]-'0')*10 + (correct[1]-'0');
        int corM = (correct[3]-'0')*10 + (correct[4]-'0');
        int curH = (current[0]-'0')*10 + (current[1]-'0');
        int curM = (current[3]-'0')*10 + (current[4]-'0');
        int time = ((corH*60)+corM) - ((curH*60)+curM);
        int del = 60;
        while (time > 0)
        {
            if (time-del>=0)
            {
                time-=del;
                ret++;
            }
            else
                switch (del)
                {
                    case 60:
                        del = 15;
                        break;
                    case 15:
                        del = 5;
                        break;
                    case 5:
                    default:
                        del = 1;
                        break;
                }
        }
        return ret;
    }
}
