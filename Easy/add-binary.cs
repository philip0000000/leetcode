public class Solution {
    public string AddBinary(string a, string b) {
        string ret = "";
        bool carry = false;
        if (b.Length > a.Length)
        {
            string t = a;
            a = b;
            b = t;
        }
        int n = a.Length - 1;
        int i = b.Length - 1;
        for (; n >= 0 && i >= 0; i--, n--)
        {
            if (carry == true)
            {
                if (a[n] == '1' && b[i] == '1')
                    ret = '1' + ret;
                else if (a[n] == '1' || b[i] == '1')
                    ret = '0' + ret;
                else
                {
                    ret = '1' + ret;
                    carry = false;
                }
            }
            else
            {
                if (a[n] == '1' && b[i] == '1')
                {
                    carry = true;
                    ret = '0' + ret;
                }
                else if (a[n] == '1' || b[i] == '1')
                    ret = '1' + ret;
                else
                    ret = '0' + ret;
            }
        }
        for (; n >= 0; n--)
        {
            if (carry == true)
            {
                if (a[n] == '0')
                {
                    carry = false;
                    ret = '1' + ret;
                }
                else if (a[n] == '1')
                {
                    ret = '0' + ret;
                }
            }
            else
                ret = a[n] + ret;
        }
        if (carry == true)
            ret = '1' + ret;
        return ret;
    }
}
