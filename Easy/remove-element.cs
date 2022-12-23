int l = 0;
int n = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] == val)
        n++;
}
l = nums.Length - n;
if (n > 0)
{
    for (int m = 0, b = nums.Length - 1; m < nums.Length; m++)
        if (nums[m] == val)
        {
            while (b > 0 && nums[b] == val)
                b--;
            if (b < 0)
                break;
            nums[m] = nums[b];
            b--;
            if (b < 0)
                break;
            n--;
            if (n == 0)
                break;
        }
    if (n > 0)
    {
        for (int k = 0; k < nums.Length; k++)
        {
            if (nums[k] == val)
            {
                // find 1st none val value
                int m = k;
                while (m < nums.Length && nums[m] == val)
                    m++;
                if (m == nums.Length)
                    break;
                nums[k] = nums[m];
            }
        }
    }
}
return l;
