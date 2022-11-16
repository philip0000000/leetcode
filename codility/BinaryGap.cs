using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        // write your code in C# 6.0 with .NET 4.7 (Mono 6.12)
        string bin = Convert.ToString(N, 2);
        int returnValue = 0; // default binary gap is 0
        int temp = 0;

        // find binary gap size
        bool FoundZero = false;
        foreach (char bit in bin)
        {
            if (bit == '0')
            {
                if (FoundZero == true)
                    temp++;
                else // if (FoundZero == false)
                {
                    FoundZero = true;
                    temp = 1;
                }
            }
            else // if (bit == '1')
            {
                if (FoundZero == true)
                {
                    if (temp > returnValue)
                        returnValue = temp;

                    FoundZero = false;
                    temp = 0;
                }
            }
        }

        return returnValue;
    }
}
