using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public static bool IsLetter(char c)
    {
        return ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
    }
    public static bool IsDigit(char c)
    {
        return (c >= '0' && c <= '9');
    }

    public int solution(string S) {
        // write your code in C# 6.0 with .NET 4.7 (Mono 6.12)
        int ret = -1; // default value is -1
        int NumLetters = 0;
        int NumDigits = 0;
        bool InvalidPassword = false;

        foreach (char c in S)
        {
            if (c == ' ') // new password
            {
                // 1st calculat if it is bigger
                if (InvalidPassword == false && // contain only alphanumerical characters
                    NumLetters % 2 == 0 &&      // even number of letters
                    NumDigits % 2 != 0)        // odd number of digits
                    if ((NumLetters + NumDigits) > ret)
                        ret = (NumLetters + NumDigits);

                // 2nd reset values
                NumLetters = 0;
                NumDigits = 0;
                InvalidPassword = false;
            }
            else
            {
                if (InvalidPassword == false)
                {
                    if (IsLetter(c) == true)
                        NumLetters++;
                    else if (IsDigit(c) == true)
                        NumDigits++;
                    else // invalid character
                        InvalidPassword = true;
                }
            }
        }

        // check again
        if (InvalidPassword == false && // contain only alphanumerical characters
            NumLetters % 2 == 0 &&      // even number of letters
            NumDigits % 2 != 0)        // odd number of digits
            if ((NumLetters + NumDigits) > ret)
                ret = (NumLetters + NumDigits);

        return ret;
    }
}
