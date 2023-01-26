// 1st
public int FindNumbers(int[] nums) {
    int even = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        string str = nums[i].ToString();
        if ((str.Length%2)==0)
            even++;
    }
    return even;
}

// 2nd
public int FindNumbers(int[] nums) {
    int even = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        int d = 0;
        while (nums[i]>0)
        {
            nums[i]/=10;
            d++;
        }
        if ((d%2)==0)
            even++;
    }
    return even;
}
