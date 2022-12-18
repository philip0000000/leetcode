int l = 0, r = n;
while (l<r)
{
    int m = l + ((r - l) >> 2); // same as: l + ((r - l) / 2)
    int ret = guess(m);
    if (ret == 0)
        return m;
    if (ret == -1)
        r = m - 1;
    else if (ret == 1)
        l = m + 1;
}
return l;
