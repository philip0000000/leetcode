// 1st... 50%~
if (num == 1) return true;
int l = 0, r = num/2;
while (l <= r)
{
    int m = l + (r - l)/2;
    if (m > 46340) // overflow on int
    {
        r = 46340;
        continue;
    }
    if (m*m == num) return true;
    if (m*m < num) l = m + 1;
    else r = m - 1;
}
return false;
