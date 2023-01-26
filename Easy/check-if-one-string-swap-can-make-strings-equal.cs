// 1st
public bool AreAlmostEqual(string s1, string s2) {
    var diffChar0 = new List<char>();
    var diffChar1 = new List<char>();
    int diff = 0;
    for (int n = 0; n < s1.Length; n++)
        if (s1[n] != s2[n])
        {
            diff++;
            if (diff >= 3)
                break;
            diffChar0.Add(s1[n]);
            diffChar1.Add(s2[n]);
        }
    if (diff == 0)
        return true;
    if (diff == 2)
    {
        if (diffChar0[0] == diffChar1[1] && diffChar0[1] == diffChar1[0])
            return true;
    }
    return false;
}

// 2nd
public bool AreAlmostEqual(string s1, string s2) {
    var diffChar0 = new char[2];
    var diffChar1 = new char[2];
    int diff = 0;
    for (int n = 0; n < s1.Length; n++)
        if (s1[n] != s2[n])
        {
            if (diff < 2)
            {
                diffChar0[diff] = s1[n];
                diffChar1[diff] = s2[n];
            }
            diff++;
            if (diff >= 3)
                break;
        }
    if (diff == 0)
        return true;
    if (diff == 2)
    {
        if (diffChar0[0] == diffChar1[1] && diffChar0[1] == diffChar1[0])
            return true;
    }
    return false;
}
