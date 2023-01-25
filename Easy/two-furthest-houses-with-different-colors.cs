// 1st
public int MaxDistance(int[] colors) {
    int ret = 0;
    for (int n = 0; n < colors.Length - 1; n++)
    {
        int m = colors.Length - 1;
        while (colors[n] == colors[m])
            m--;
        int u = Math.Abs(n - m);
        if (u > ret)
            ret = u;
    }
    return ret;
}

// 2nd 50%~
public int MaxDistance(int[] colors) {
    int n = colors.Length - 1;
    while (colors[0] == colors[n])
        n--;
    int m = 0;
    while (colors[m] == colors[colors.Length-1])
        m++;
    return Math.Max(n, Math.Abs(colors.Length-1-m));
}
