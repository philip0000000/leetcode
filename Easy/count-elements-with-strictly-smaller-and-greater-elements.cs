// 1st
int biggest = -2147483648;
int smallest = 2147483647;
foreach(var x in nums)
{
    if (x > biggest)
        biggest = x;
    if (x < smallest)
        smallest = x;
}
int count = 0;
foreach(var x in nums)
{
    if (x != biggest && x != smallest)
        count++;
}
return count;

// 2nd
int max = nums.Max();
int min = nums.Min();
int count = 0;
foreach(var x in nums)
{
    if (x != max && x != min)
        count++;
}
return count;

// 3rd (not good)
int biggest = -2147483648;
int countBig = 0;
int smallest = 2147483647;
int countSmall = 0;
foreach(var x in nums)
{
    if (x > biggest)
    {
        biggest = x;
        countBig = 1;
    }
    else if (x == biggest)
        countBig++;

    if (x < smallest)
    {
        smallest = x;
        countSmall = 1;
    }
    else if (x == smallest)
        countSmall++;
}
int sum = (nums.Length - countBig) - countSmall;
if (sum > 0)
    return sum;
return 0;
