using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public static int NumberOfBitZeros(int n) {
      int res = 0;
      for (int i = 0; i < 30; i++)
      {
        if ((n & 1) == 1);
        else res++;
        n >>= 1;
      }
      return res;
    }

    public static int NumberOfConfigurations(int n) {  
        return 1 << NumberOfBitZeros(n);
    }

    public int solution(int A, int B, int C) {
        // write your code in C# 6.0 with .NET 4.7 (Mono 6.12)
        
        int PositiveCommon = NumberOfConfigurations(A | B) + NumberOfConfigurations(A | C) + NumberOfConfigurations(B | C);
        int NegativeCommon = NumberOfConfigurations(A | B | C) + NumberOfConfigurations(A) + NumberOfConfigurations(B) + NumberOfConfigurations(C);
        return NegativeCommon - PositiveCommon;
    }
}
