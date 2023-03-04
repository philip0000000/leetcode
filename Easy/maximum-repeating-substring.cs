public class Solution {
    public int MaxRepeating(string sequence, string word) {
        int ret = 0;
        int[] Found = new int[sequence.Length];
        var hs = new HashSet<string> { word };
        int l = sequence.Length - word.Length;
        for (int p0 = 0; p0 <= l; p0++)
            if (hs.Contains(sequence.Substring(p0, word.Length)))
                Found[p0] = 1;
        int i = 0;
        for (; i < l; i++)
            if (Found[i]!=0)
            {
                if (Found[i]>ret)
                    ret = Found[i];
                if (Found[i + word.Length] != 0)
                    Found[i + word.Length] = Found[i]+1;
            }
        if (Found[i] != 0 && Found[i] > ret)
            ret = Found[i];
        return ret;
    }
}
