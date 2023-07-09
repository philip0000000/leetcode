public class Solution {
    static public int Find(string str, int k, char F)
    {
        int max = 0;
        int pL = 0, // pointer left
            pR = 0; // pointer right

        // Init
        while (pL < str.Length && str[pL] == F)
            pL++;
        if (pL >= str.Length) // bad, no F in str
            return str.Length;
        if (str[pL] == F) // bad, not found
            return 0;
        int t = k - 1;
        for (pR = pL; pR + 1 < str.Length && t > 0;)
        {
            pR++;
            if (str[pR] != F)
                t--;
        }
        if (pR > str.Length) // bad, only 1 F in str
            return 1 + Math.Min(str.Length - 1, k);

        // Run
        while (pR < str.Length)
        {
            int v = (pR - pL) + 1;
            for (int i = pR + 1; i < str.Length && str[i] == F; i++)
                v++;
            for (int i = pL - 1; i >= 0 && str[i] == F; i--)
                v++;
            max = Math.Max(v, max);
            // pRight ---> +1
            for (pR++; pR < str.Length && str[pR] == F; pR++);
            // pLeft ---> -1
            for (pL++; pL < str.Length && str[pL] == F; pL++);
        }
        return max;
    }
    public int MaxConsecutiveAnswers(string answerKey, int k) {
        if (k > answerKey.Length)
            k = answerKey.Length;

        return Math.Max(Find(answerKey, k, 'T'),
                        Find(answerKey, k, 'F'));
    }
}
