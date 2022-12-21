// 1st O(nk)
var Found = new Dictionary<int, List<int>>();
for (int i = 0; i < nums.Length; i++)
{
    if (Found.ContainsKey(nums[i]))
    {
        foreach (var j in Found[nums[i]])
            if (Math.Abs(i - j) <= k)
                return true;
        Found[nums[i]].Add(i);
    }
    else
    {
        var list = new List<int>();
        list.Add(i);
        Found.Add(nums[i], list);
    }
}
return false;

// 2nd O(n) (sliding window approach) 50%~
var set = new HashSet<int>();
for (int i = 0; i < nums.Length; i++)
{
    if (i > k)
        set.Remove(nums[i - k - 1]);
    if (!set.Add(nums[i]))
        return true;
}
return false;
