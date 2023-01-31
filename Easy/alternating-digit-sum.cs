public class Solution {
    public int AlternateDigitSum(int n) {
        int ret = 0;
        string str = n.ToString();
        bool add=true;
        for (int i=0; i<str.Length;i++)
            if (add)
            {
                ret+=str[i]-'0';
                add=false;
            }
            else
            {
                ret-=str[i]-'0';
                add=true;
            }
        return ret;
    }
}
