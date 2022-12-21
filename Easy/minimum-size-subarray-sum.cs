// 1st
int ret = Int32.MaxValue;
int m = 0;
int temp = 0;
// get first "target"
for (m = 0; m < nums.Length && temp < target; m++)
    temp += nums[m];
if (temp >= target)
    ret = m;
for (int n = 1; n < nums.Length; n++)
{
    temp -= nums[n - 1];
    m--;
    if (temp < target) // --->
    {
        while (n + m < nums.Length && temp < target)
        {
            temp += nums[n + m];
            m++;
        }
    }
    else if (temp >= target && m < ret)
        ret = m;
}
return ret == Int32.MaxValue ? 0 : ret;

// 2nd
if (nums == null || nums.Length == 0)
    return 0;
else if (nums.Length == 1 && nums[0] > target)
    return 1;
else if (nums.Length == 1 && nums[0] < target)
    return 0;

int start = 0;
int end = 0;
int sum = nums[start];
int minLength = int.MaxValue;
while (end < nums.Length)
{
    if (sum >= target)
    {
        minLength = Math.Min(minLength, end - start + 1);
        sum -= nums[start];
        start++;
    }
    else
    {
        end++;
        if (end < nums.Length)
            sum += nums[end];
    }
}
return minLength == int.MaxValue ? 0 : minLength;
