public class Solution {
    public string ShortestCompletingWord(string licensePlate, string[] words) {
        var dict = new Dictionary<char, int>();
        foreach (var i in licensePlate)
        {
            char t = i;
            if (i >= 'A' && i <= 'Z')
                t = (char)(t + 32);
            if (t >= 'a' && t <= 'z')
            {
                if (dict.ContainsKey(t))
                    dict[t]++;
                else
                    dict.Add(t, 1);
            }
        }
        int min = Int32.MaxValue;
        string retStr = "";
        foreach (var str in words)
        {
            var dict2 = new Dictionary<char, int>();
            foreach (var i in str)
                if (dict.ContainsKey(i))
                {
                    if (dict2.ContainsKey(i))
                        dict2[i]++;
                    else
                        dict2.Add(i, 1);
                }
            if (dict.Count == dict2.Count)
            {
                bool Found = true;
                foreach (var kvp in dict)
                    if (dict2[kvp.Key] - kvp.Value < 0)
                    {
                        Found = false;
                        break;
                    }
                if (Found && str.Length < min)
                {
                    min = str.Length;
                    retStr = str;
                }
            }
        }
        return retStr;
    }
}
