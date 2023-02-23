// 1st https://leetcode.com/problems/third-maximum-number/submissions/903731700/
public class Solution {
    public int ThirdMax(int[] nums) {
        int max1st = Int32.MinValue;
        int max2nd = Int32.MinValue;
        int max3rd = Int32.MinValue;
        bool min = false;
        foreach (int n in nums)
            if (n > max3rd && n!=max1st && n != max2nd && n != max3rd)
            {
                max3rd = n;
                if (max3rd>max2nd)
                {
                    int t = max2nd;
                    max2nd = max3rd;
                    max3rd = t;
                }
                if (max2nd>max1st)
                {
                    int t = max1st;
                    max1st = max2nd;
                    max2nd = t;
                }
            }
            else if (n == Int32.MinValue)
                min = true;
        if (min == true && max1st>Int32.MinValue && max2nd>Int32.MinValue)
            return Int32.MinValue;
        return max3rd==Int32.MinValue?max1st:max3rd;
    }
}

// 2nd
public class Solution {
    public int ThirdMax(int[] nums) {
        long max1st = Int64.MinValue;
        long max2nd = Int64.MinValue;
        long max3rd = Int64.MinValue;
        foreach (long n in nums)
            if (n > max3rd && n!=max1st && n != max2nd && n != max3rd)
            {
                max3rd = n;
                if (max3rd>max2nd)
                {
                    long t = max2nd;
                    max2nd = max3rd;
                    max3rd = t;
                }
                if (max2nd>max1st)
                {
                    long t = max1st;
                    max1st = max2nd;
                    max2nd = t;
                }
            }
        return max3rd==Int64.MinValue?(int)max1st:(int)max3rd;
    }
}

// 3rd https://leetcode.com/problems/third-maximum-number/submissions/903742351/
public class Solution {
    public int ThirdMax(int[] nums) {
        var hash = new HashSet<int>();
        var pq = new PriorityQueue<int, long>();
        foreach (int n in nums)
            if (!hash.Contains(n))
            {
                hash.Add(n);
                long m = -(long)n;
                pq.Enqueue(n, m);
            }
        if (pq.Count==1 || pq.Count==2)
            return pq.Dequeue();
        pq.Dequeue();
        pq.Dequeue();
        return pq.Dequeue();
    }
}

// 4th https://leetcode.com/problems/third-maximum-number/submissions/903744318/
public class Solution {
    public int ThirdMax(int[] nums) {
        Array.Sort(nums);
        var hash = new HashSet<int>();
        for (int i = nums.Length-1; i >= 0; i--)
            if (!hash.Contains(nums[i]))
            {
                if (hash.Count == 2)
                    return nums[i];
                else
                    hash.Add(nums[i]);
            }
        return nums[nums.Length-1];
    }
}
