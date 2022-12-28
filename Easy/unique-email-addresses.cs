public class Solution {
    public int NumUniqueEmails(string[] emails) {
        var AllEmails = new HashSet<string>();
        foreach (var temp in emails)
        {
            string[] ArrStr = new string[2];
            ArrStr = temp.Split("@");
            ArrStr[0] = ArrStr[0].Replace(".", "");
            int n = ArrStr[0].IndexOf("+");
            if (n > 0)
                ArrStr[0] = ArrStr[0].Substring(0, n);
            AllEmails.Add(ArrStr[0]+"@"+ArrStr[1]);
        }
        return AllEmails.Count;
    }
}
