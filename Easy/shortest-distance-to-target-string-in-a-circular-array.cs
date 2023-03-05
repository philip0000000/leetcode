// 1st bad
public class Solution {
    public int ClosetTarget(string[] words, string target, int startIndex) {
        int i = 0;
        while (i < words.Length && words[i] != target)
            i++;
        if (i != words.Length)
        {
            int up = 0;
            int j = startIndex;
            while (j < words.Length && words[j] != target)
                j++;
            up = j - startIndex;
            if (j == words.Length)
            {
                int k = 0;
                while (k < words.Length && words[k] != target)
                    k++;
                up += k;
            }
            int down = 0;
            j = startIndex;
            while (j >= 0 && words[j] != target)
                j--;
            if (j == -1)
                down = startIndex;
            else
                down = startIndex - j;
            if (j < 0)
            {
                int k = words.Length - 1;
                while (k >= 0 && words[k] != target)
                    k--;
                down += words.Length - k;
            }
            return Math.Min(up, down);
        }
        return -1;
    }
}

// 2nd 50%~
public class Solution {
    public int ClosetTarget(string[] words, string target, int startIndex) {
        int l = 0, r = 0;
        int lIndex = startIndex, rIndex = startIndex;
        while (l+r <= words.Length)
        {
            if (words[lIndex] == target)
                return l;
            if (words[rIndex] == target)
                return r;
            l++;
            lIndex--;
            if (lIndex == -1)
                lIndex = words.Length-1;
            r++;
            rIndex++;
            if (rIndex == words.Length)
                rIndex = 0;
        }
        return -1;
    }
}
