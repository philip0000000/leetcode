// 1st
public class Solution {
    public string IntToRoman(int num) {
        string ret = "";
        while (num >= 1000)
        {
            num -= 1000;
            ret += 'M';
        }
        if (num >= 900)
        {
            num -= 900;
            ret += "CM";
        }
        while (num >= 500)
        {
            num -= 500;
            ret += 'D';
        }
        if (num >= 400)
        {
            num -= 400;
            ret += "CD";
        }
        while (num >= 100)
        {
            num -= 100;
            ret += 'C';
        }
        if (num >= 90)
        {
            num -= 90;
            ret += "XC";
        }
        while (num >= 50)
        {
            num -= 50;
            ret += 'L';
        }
        if (num >= 40)
        {
            num -= 40;
            ret += "XL";
        }
        while (num >= 10)
        {
            num -= 10;
            ret += 'X';
        }
        if (num >= 9)
        {
            num -= 9;
            ret += "IX";
        }
        while (num >= 5)
        {
            num -= 5;
            ret += 'V';
        }
        if (num >= 4)
        {
            num -= 4;
            ret += "IV";
        }
        while (num >= 1)
        {
            num -= 1;
            ret += 'I';
        }
        return ret;
    }
}

// 2nd
public class Solution {
    static readonly Dictionary<int, string> RomanNrDict = new Dictionary<int, string>()
        {
            { 1000, "M"},
            { 900, "CM"},
            { 500, "D"},
            { 400, "CD"},
            { 100, "C"},
            { 90, "XC"},
            { 50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };
    public string IntToRoman(int num) {
        string ret = "";
        foreach(KeyValuePair<int, string> entry in RomanNrDict)
        {
            while (num >= entry.Key)
            {
                num -= entry.Key;
                ret += entry.Value;
            }
        }
        return ret;
    }
}
