// 1st
var dict = new Dictionary<int, int>();
for (int i = 0; i < nums.Length; i++)
{
    if (dict.ContainsKey(nums[i]))
        dict[nums[i]]++;
    else
        dict.Add(nums[i], 1);
}
var ret = new int[k];
for (int i = 0; i < ret.Length; i++)
{
    int keyMavValue = 0;
    int Max = int.MinValue;
    foreach (var kvp in dict)
        if (kvp.Value > Max)
        {
            Max = kvp.Value;
            keyMavValue = kvp.Key;
        }
    ret[i] = keyMavValue;
    dict.Remove(keyMavValue);
}
return ret;

// 2nd 50%~
Dictionary<int, int> dict = new Dictionary<int, int>();
for (int i = 0; i < nums.Length; i++)
    if (dict.ContainsKey(nums[i]))
        dict[nums[i]]++;
    else
        dict.Add(nums[i], 1);
var list = dict.ToList();
list.Sort((a, b) => b.Value.CompareTo(a.Value));
var result = new int[k];
for (int i = 0; i < k; i++)
    result[i] = list[i].Key;
return result;
