public class Solution {
    public string Interpret(string command) {
        var sb = new StringBuilder();
        for (int i = 0; i < command.Length; i++)
            if (command[i] == '(')
            {
                i++;
                if (command[i] != ')')
                {
                    i+=2;
                    sb.Append("al");
                }
                else
                    sb.Append('o');
            }
            else
                sb.Append('G');
        return sb.ToString();
    }
}
