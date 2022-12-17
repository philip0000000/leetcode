// 1st
HashSet<int> seen = new HashSet<int>();
foreach (int x in nums1)
{
    if (seen.Contains(x) == false)
        seen.Add(x);
}
HashSet<int> ret = new HashSet<int>();
foreach (int x in nums2)
{
    if (seen.Contains(x) == true)
        if (ret.Contains(x) == false)
            ret.Add(x);
}
return ret.ToArray();

// 2nd... 50%~
var d1 = new Dictionary<int, int>();
var ret = new List<int>();
foreach (int x in nums1)
{
    if (d1.ContainsKey(x))
        d1[x]++;
    else
        d1[x] = 1;
}
foreach (int x in nums2)
{
    if (d1.ContainsKey(x) && d1[x] > 0)
    {
        ret.Add(x);
        d1[x]--;
    }
}
return ret.ToArray();
