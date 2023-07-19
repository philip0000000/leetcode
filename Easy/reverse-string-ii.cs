// 1st
public class Solution {
    public string ReverseStr(string s, int k) {
            var sb = new StringBuilder(s);
            for (int i = 0; i < s.Length;)
            {
                int sum = s.Length - i;
                if (sum < k)
                {
                    for (int j = s.Length - 1; i < j; i++, j--)
                        (sb[i], sb[j]) = (sb[j], sb[i]);
                    break;
                }
                else if (sum < k * 2 && sum >= k)
                {
                    for (int j = i + k - 1, l = i; l < j; l++, j--)
                        (sb[l], sb[j]) = (sb[j], sb[l]);
                    break;
                }
                else
                {
                    for (int j = i + k - 1, l = i; l < j; l++, j--)
                        (sb[l], sb[j]) = (sb[j], sb[l]);
                    i += k * 2;
                }
            }
            return sb.ToString();
    }
}

// 2nd bad
public class Solution {
    public string ReverseStr(string s, int k) {
            var sb = new StringBuilder(s);
            int i = 0;
            
            for (int a = s.Length - k; i <= a; i += k * 2)
                for (int j = i + k - 1, l = i; l < j; l++, j--)
                    (sb[l], sb[j]) = (sb[j], sb[l]);
            
            int sum = s.Length - i;
            if (sum < k)
                for (int j = s.Length - 1; i < j; i++, j--)
                    (sb[i], sb[j]) = (sb[j], sb[i]);
            else if (sum < k * 2 && sum >= k)
                for (int j = i + k - 1; i < j; i++, j--)
                    (sb[i], sb[j]) = (sb[j], sb[i]);

            return sb.ToString();
    }
}
