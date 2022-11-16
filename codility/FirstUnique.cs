/**************/
/*** O(n^2) ***/
/**************/
using System;
class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.7 (Mono 6.12)
        bool FoundSame = false;
        var Found = new System.Collections.Generic.List<int>();

        for (int n = 0; n < A.Length; n++, FoundSame = false)
        {
            if (Found.Contains(A[n]))
                continue;
            Found.Add(A[n]);
            for (int m = n+1; m < A.Length; m++)
            {
                if (A[n] == A[m])
                {
                    FoundSame = true;
                    break;
                }
            }
            if (FoundSame == false)
                return A[n];
        }

        return -1;
    }
}

/****************/
/*** O(nlogn) ***/
/****************/
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        var NumDic = new System.Collections.Generic.Dictionary<int, int>();

        foreach(int n in A)
        {
            if (NumDic.ContainsKey(n))
                NumDic[n]++;
            else
                NumDic.Add(n, 1);
        }

        foreach(var item in NumDic)
        {
            if (item.Value == 1)
                return item.Key;
        }

        return -1;
    }
}
