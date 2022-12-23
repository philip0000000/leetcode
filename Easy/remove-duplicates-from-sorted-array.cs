// 1st
int n = 0;
for (int i = 0; i < nums.Length; n++)
{
    nums[n] = nums[i];
    while (i < nums.Length && nums[n] == nums[i])
        i++;
}
return n;

// 2nd
int n = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[n] != nums[i])
    {
        n++;
        nums[n] = nums[i];
    }
}
return n+1;
