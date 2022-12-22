// 1st NOTE: Not sure how good this is. Get 90% on runtime
public class Solution {
    public string LongestNiceSubstring(string s) {
        var ValidStrs = new Stack<string>();
        ValidStrs.Push(s);
        var retStr = "";
        int maxLength = retStr.Length;
        while (ValidStrs.Count > 0)
        {
            var TestStr = ValidStrs.Pop();
            if (TestStr.Length == 1) continue;
            var ValidChar = new HashSet<char>(); // get all tokens in str
            foreach (var c in TestStr)
                ValidChar.Add(c);
            // split string in 2, if invalid token is found(not in both upper and lower case)
            int n = 0;
            while (n < TestStr.Length &&
                   ValidChar.Contains(Char.ToUpper(TestStr[n])) &&
                   ValidChar.Contains(Char.ToLower(TestStr[n])))
                n++;
            if (n == TestStr.Length) // string has no invalid tokens
            {
                if (n > maxLength)
                {
                    maxLength = n;
                    retStr = TestStr;
                }
            }
            else if (n > 0) // string has invalid tokens, split string in to 2 parts
            {
                ValidStrs.Push(TestStr.Substring(n + 1)); // +1 to remove the bad token
                ValidStrs.Push(TestStr.Substring(0, n));
            }
            else if (TestStr.Length > 0) // remove 1st token if string is not empty
                ValidStrs.Push(TestStr.Remove(0, 1));
        }
        return retStr;
    }
}
