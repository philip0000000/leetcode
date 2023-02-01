public class Solution {
    public int MinimumBuckets(string hamsters) {
        var sbHam = new StringBuilder(hamsters);
        int food = 0;
        if (sbHam[0] == 'H')
        {
            if (sbHam.Length > 1 && sbHam[1] == '.')
            {
                sbHam[1] = 'f';
                food++;
            }
            else
                return -1;
        }
        for (int i = 1; i < sbHam.Length; i++)
            if (sbHam[i] == 'H' && sbHam[i-1] != 'f')
            {
                if (i != sbHam.Length-1 && sbHam[i+1] == '.')
                {
                    sbHam[i+1] = 'f';
                    food++;
                }
                else if (i > 0 && sbHam[i-1] == '.')
                    food++;
                else
                    return -1;
            }
        return food;
    }
}
