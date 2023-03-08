public class Solution {
    public Dictionary<string, string> dict = new Dictionary<string, string>
    {
            { "Jan", "01" },
            { "Feb", "02" },
            { "Mar", "03" },
            { "Apr", "04" },
            { "May", "05" },
            { "Jun", "06" },
            { "Jul", "07" },
            { "Aug", "08" },
            { "Sep", "09" },
            { "Oct", "10" },
            { "Nov", "11" },
            { "Dec", "12" }
    };
    public string ReformatDate(string date) {
        var sb = new StringBuilder(date.Substring(date.Length-4));
        sb.Append('-');
        sb.Append(dict[date.Substring(date.Length-8, 3)]);
        sb.Append('-');
        if (date.Length == 13)
            sb.Append(date.Substring(0, 2));
        else
            sb.Append('0' + date.Substring(0, 1));
        return sb.ToString();
    }
}
