// 1st
public class Solution {
    public int GetSum(int a, int b) {
        bool carry = false;
        int ret = 0;

        for (int l = 0; l < 32; l++)
        {
            if ( (a & (1 << l)) != 0 && (b & (1 << l)) != 0 && carry == true) // 3 bits are 1
            {
                ret |= 1 << l;
            }
            else if (   ((a & (1 << l)) != 0 && (b & (1 << l)) != 0 ) || // 2 bits are 1
                        ( (a & (1 << l)) != 0 && carry == true ) ||
                        ( carry == true && (b & (1 << l)) != 0 ) )
            {
                carry = true;
            }
            else if (carry == true || (a & (1 << l)) != 0 || (b & (1 << l)) != 0) // 1 bit is 1
            {
                carry = false;
                ret |= 1 << l;
            }
        }

        return ret;
    }
}

// 2nd
public class Solution {
    public int GetSum(int a, int b) {
        int and = (a & b) << 1,
            xor = a ^ b,
            temp = 0;

        while (and != 0)
        {
            temp = xor ^ and;
            and = (xor & and) << 1;
            xor = temp;
        }

        return xor;
    }
}
