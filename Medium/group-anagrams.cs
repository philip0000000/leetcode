// 1st
public class Solution {
    public bool SimilarDict(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
    {
        if (dict1.Count != dict2.Count)
            return false;
        foreach (KeyValuePair<char, int> kvp in dict1)
        {
            if (dict2.ContainsKey(kvp.Key))
            {
                if (dict2[kvp.Key] != kvp.Value)
                    return false;
            }
            else
                return false;
        }
        return true;
    }
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var ret = new List<IList<string>>();
        var StrsHashList = new List<Dictionary<char, int>>();
        for (int i = 0; i < strs.Length; i++)
        {
            var AnagramDict = new Dictionary<char, int>();
            string s = strs[i];
            foreach (var c in s)
                if (AnagramDict.ContainsKey(c))
                    AnagramDict[c]++;
                else
                    AnagramDict[c] = 1;
            StrsHashList.Add(AnagramDict);
        }
        int NumberOfEmptyStr = 0;
        for (int i = 0; i < strs.Length; i++)
            if (strs[i] == "")
                NumberOfEmptyStr++;
        if (NumberOfEmptyStr > 0)
        {
            var l = new List<string>();
            while (NumberOfEmptyStr > 0)
            {
                l.Add("");
                NumberOfEmptyStr--;
            }
            ret.Add(l);
        }
        for (int i = 0; i < strs.Length; i++)
        {
            if (strs[i] != "")
            {
                var AddToRet = new List<string>();
                AddToRet.Add(strs[i]);
                for (int n = i + 1; n < strs.Length; n++)
                {
                    if (strs[n] != "" && SimilarDict(StrsHashList[i], StrsHashList[n]))
                    {
                        AddToRet.Add(strs[n]);
                        strs[n] = "";
                    }
                }
                ret.Add(AddToRet);
            }
        }
        return ret;
    }
}

// 2nd
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var StrsHashList = new Dictionary<string, IList<string>>();
        foreach (var str in strs)
        {
            char[] chars = str.ToArray();
            Array.Sort(chars);
            string temp = new String(chars);
            if (!StrsHashList.ContainsKey(temp))
                StrsHashList.Add(temp, new List<string>());
            StrsHashList[temp].Add(str);
        }
        return StrsHashList.Values.ToList();
    }
}
