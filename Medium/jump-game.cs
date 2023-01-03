// DP https://leetcode.com/problems/jump-game/submissions/870127137/
int lastIndex = nums.Length - 1;
for (int n = nums.Length - 1; n >= 0; n--)
{
    if (nums[n] + n >= lastIndex)
        nums[n] = -1;
    else
    {
        int m = n + nums[n];
        for (; m > n; m--)
        {
            if (nums[m] == -1)
                break;
        }
        nums[n] = nums[m] == -1 ? -1 : -2;
    }
}
return nums[0] == -1 ? true : false;

// greedy https://leetcode.com/problems/jump-game/submissions/870151349/
int lastIndex = nums.Length - 1;
int biggest = 0;
for (int n = 0; n <= biggest; n++)
{
    if (nums[n] + n >= lastIndex)
        return true;
    if (nums[n] + n > biggest)
        biggest = nums[n] + n;
}
return false;
