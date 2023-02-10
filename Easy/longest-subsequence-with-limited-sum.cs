// 1st https://leetcode.com/problems/longest-subsequence-with-limited-sum/submissions/895370234/
public class Solution {
    public int[] AnswerQueries(int[] nums, int[] queries) {
        var answer = new int[queries.Length];
        Array.Sort(nums);
        for (int i = 0; i < queries.Length; i++)
        {
            int sum = 0;
            int j = 0;
            for (; j < nums.Length && sum < queries[i]; j++)
                sum += nums[j];
            if (sum > queries[i])
                j--;
            answer[i] = j;
        }
        return answer;
    }
}

// 2nd 50%~
public class Solution {
    public int[] AnswerQueries(int[] nums, int[] queries) {
        var answer = new int[queries.Length];
        Array.Sort(nums);
        var SumArr = new int [nums.Length];
        int sum = 0;
        for (int m = 0; m < nums.Length; m++)
        {
            sum += nums[m];
            SumArr[m] = sum;
        }
        for (int i = 0; i < queries.Length; i++)
        {
            int j = 0;
            for (; j < nums.Length && SumArr[j] <= queries[i]; j++)
                ;
            answer[i] = j;
        }
        return answer;
    }
}
