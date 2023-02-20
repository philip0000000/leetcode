public class Solution {
    public int LargestAltitude(int[] gain) {
        int h = 0;
        int c = 0;
        for (int i = 0; i < gain.Length; i++)
        {
            c += gain[i];
            if (c > h)
                h = c;
        }
        return h;
    }
}
