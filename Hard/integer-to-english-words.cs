// 1st
public class Solution {
    static readonly Dictionary<int, string> Digits = new Dictionary<int, string>()
    {
        {0, "Zero"},
        {1, "One"},
        {2, "Two"},
        {3, "Three"},
        {4, "Four"},
        {5, "Five"},
        {6, "Six"},
        {7, "Seven"},
        {8, "Eight"},
        {9, "Nine"}
    };
    static readonly Dictionary<int, string> TyNrs = new Dictionary<int, string>()
    {
        {1, "Ten"},
        {2, "Twenty"},
        {3, "Thirty"},
        {4, "Forty"},
        {5, "Fifty"},
        {6, "Sixty"},
        {7, "Seventy"},
        {8, "Eighty"},
        {9, "Ninety"}
    };
    static readonly Dictionary<int, string> TeenNrs = new Dictionary<int, string>()
    {
        {10, "Ten"},
        {11, "Eleven"},
        {12, "Twelve"},
        {13, "Thirteen"},
        {14, "Fourteen"},
        {15, "Fifteen"},
        {16, "Sixteen"},
        {17, "Seventeen"},
        {18, "Eighteen"},
        {19, "Nineteen"}
    };
    public string NumberToWords(int num) {
        if (num == 0)
            return "Zero";
        string ret = "";
        int n = num / 1000000000;
        if (n > 0)
        {
            ret = Digits[n] + " Billion";
            num -= n * 1000000000;
        }
        if (num >= 1000000)
        {
            n = num / 1000000;
            num -= n * 1000000;
            int d = n / 100;
            
            if (d > 0)
            {
                if (ret.Length != 0) ret += ' ';
                ret += Digits[d] + " Hundred";
                n -= d * 100;
            }
            
            if (n >= 10)
            {
                if (ret.Length != 0) ret += ' ';
                if (n < 20)
                {
                    ret += TeenNrs[n];
                    n = -1;
                }
                else
                {
                    ret += TyNrs[n/10];
                    n -= (n / 10) * 10;
                }
            }
            if (n > 0)
            {
                if (ret.Length != 0) ret += ' ';
                ret += Digits[n];
            }
            ret += " Million";
        }
        if (num >= 1000)
        {
            n = num / 1000;
            num -= n * 1000;
            int d = n / 100;
            if (d > 0)
            {
                if (ret.Length != 0) ret += ' ';
                ret += Digits[d] + " Hundred";
                n -= d * 100;
            }
            d = n / 10;
            if (n >= 10)
            {
                if (ret.Length != 0) ret += ' ';
                if (n >= 20)
                {
                    ret += TyNrs[d];
                    n -= d * 10;
                }
                else
                {
                    ret += TeenNrs[n];
                    n = -1;
                }
            }
            if (n > 0)
            {
                if (ret.Length != 0) ret += ' ';
                ret += Digits[n];
            }
            ret += " Thousand";
        }
        if (num >= 100)
        {
            n = num / 100;
            num -= n * 100;
            if (ret.Length != 0) ret += ' ';
            ret += Digits[n] + " Hundred";
        }
        if (num >= 20)
        {
            n = num / 10;
            if (ret.Length != 0) ret += ' ';
            ret += TyNrs[n];
            num -= n * 10;
        }
        else if (num >= 10)
        {
            if (ret.Length != 0) ret += ' ';
            ret += TeenNrs[num];
            num = -1;
        }
        if (num > 0)
        {
            if (ret.Length != 0) ret += ' ';
            ret += Digits[num];
        }
        return ret;
    }
}

// 2nd
public class Solution {
    static readonly Dictionary<int, string> Digits = new Dictionary<int, string>()
    {
        {1, "One"},
        {2, "Two"},
        {3, "Three"},
        {4, "Four"},
        {5, "Five"},
        {6, "Six"},
        {7, "Seven"},
        {8, "Eight"},
        {9, "Nine"}
    };
    static readonly Dictionary<int, string> TyNrs = new Dictionary<int, string>()
    {
        {1, "Ten"},
        {2, "Twenty"},
        {3, "Thirty"},
        {4, "Forty"},
        {5, "Fifty"},
        {6, "Sixty"},
        {7, "Seventy"},
        {8, "Eighty"},
        {9, "Ninety"}
    };
    static readonly Dictionary<int, string> TeenNrs = new Dictionary<int, string>()
    {
        {10, "Ten"},
        {11, "Eleven"},
        {12, "Twelve"},
        {13, "Thirteen"},
        {14, "Fourteen"},
        {15, "Fifteen"},
        {16, "Sixteen"},
        {17, "Seventeen"},
        {18, "Eighteen"},
        {19, "Nineteen"}
    };
    public string NumberToWords(int num) {
        if (num == 0)
            return "Zero";
        string ret = "";
        int n = num / 1000000000;
        if (n > 0)
        {
            ret = NumberToWords(n) + " Billion";
            num -= n * 1000000000;
        }
        n = num / 1000000;
        if (n > 0)
        {
            if (ret.Length > 0)
                ret += ' ';
            ret += NumberToWords(n) + " Million";
            num -= n * 1000000;
        }
        n = num / 1000;
        if (n > 0)
        {
            if (ret.Length > 0)
                ret += " ";
            ret += NumberToWords(n) + " Thousand";
            num -= n * 1000;
        }
        if (num >= 100)
        {
            n = num / 100;
            num -= n * 100;
            if (ret.Length != 0)
                ret += ' ';
            ret += Digits[n] + " Hundred";
        }
        if (num >= 20)
        {
            n = num / 10;
            if (ret.Length != 0) ret += ' ';
            ret += TyNrs[n];
            num -= n * 10;
        }
        else if (num >= 10)
        {
            if (ret.Length != 0) ret += ' ';
            ret += TeenNrs[num];
            num = -1;
        }
        if (num > 0)
        {
            if (ret.Length != 0) ret += ' ';
            ret += Digits[num];
        }
        return ret;
    }
}
