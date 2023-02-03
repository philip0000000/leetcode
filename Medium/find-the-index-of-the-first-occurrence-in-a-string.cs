public class Solution {
    public int StrStr(string haystack, string needle) {
        int p1 = 0;
        int p2 = needle.Length-1;
        while (p2 < haystack.Length)
        {
            if (needle[0] == haystack[p1] && needle[needle.Length-1] == haystack[p2])
            {
                if (needle.Length == 1)
                    return p1;
                int i = 1;
                while (i < needle.Length-1 && needle[i] == haystack[p1+i])
                    i++;
                if (i == needle.Length-1)
                    return p1;
            }
            p1++;
            p2++;
        }
        return -1;
    }
}
