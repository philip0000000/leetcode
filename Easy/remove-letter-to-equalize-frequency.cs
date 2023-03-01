// 1st
public class Solution {
    public bool EqualFrequency(string word) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < word.Length; i++)
            if (dict.ContainsKey(word[i]))
                dict[word[i]]++;
            else
                dict.Add(word[i], 1);
        var dict2 = new Dictionary<int, int>();
        foreach (var j in dict)
            if (dict2.ContainsKey(j.Value))
                dict2[j.Value]++;
            else
                dict2.Add(j.Value, 1);
        if (dict2.Count > 2)
            return false;
        int a = 0, b = 0;
        int aNum = 0, bNum = 0;
        foreach (var j in dict2)
            if (a==0)
            {
                a = j.Key;
                aNum = j.Value;
            }
            else
            {
                b = j.Key;
                bNum = j.Value;
            }
        if (bNum == 0 && (aNum==1 || a==1))
            return true;
        else
        {
            if (aNum==1 && (a-1 == b || a-1 == 0))
                return true;
            if (bNum==1 && (b-1 == a || b-1 == 0))
                return true;
        }
        return false;
    }
}

// 2nd https://leetcode.com/problems/remove-letter-to-equalize-frequency/submissions/907416886/ 50%~
public class Solution {
    public bool EqualFrequency(string word) {
        int a = 0, b = 0;
        int aNum = 0, bNum = 0;
        var fre = new int[26];
        foreach (var c in word)
            fre[c-'a']++;
        for (int i = 0; i < 26; i++)
            if (fre[i]!=0)
            {
                if (fre[i] == a)
                    aNum++;
                else if (fre[i] == b)
                    bNum++;
                else
                {
                    if (a == 0)
                    {
                        a = fre[i];
                        aNum = 1;
                    }
                    else if (b == 0)
                    {
                        b = fre[i];
                        bNum = 1;
                    }
                    else
                        return false;
                }
            }
        if (bNum == 0 && (aNum == 1 || a == 1))
            return true;
        if (aNum == 1 && (a - 1 == b || a - 1 == 0))
            return true;
        if (bNum == 1 && (b - 1 == a || b - 1 == 0))
            return true;
        return false;
    }
}
