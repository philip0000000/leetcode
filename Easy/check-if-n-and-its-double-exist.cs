// 1st
for (int i = 0; i < arr.Length; i++)
    for (int j = 0; j < arr.Length; j++)
        if (i != j && arr[i] == arr[j]*2)
            return true;

return false;

// 2nd
var num = new List<int>();

for (int i = 0; i < arr.Length; i++)
    num.Add(arr[i] * 2);
for (int i = 0; i < arr.Length; i++)
    if (num.Contains(arr[i]))
        if (i != num.IndexOf(arr[i]))
            return true;

return false;

// 3rd...
HashSet<int> seen = new HashSet<int>();
foreach (int x in arr)
{
    if (seen.Contains(x * 2) || (x % 2 == 0 && seen.Contains(x / 2)))
    {
        return true;
    }
    seen.Add(x);
}
return false;
