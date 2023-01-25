public int Maximum69Number (int num) {
    StringBuilder sb = new StringBuilder();
    sb.Append(num);
    for (int n = 0; n < sb.Length; n++)
        if (sb[n] == '6')
        {
            sb[n] = '9';
            break;
        }
    return int.Parse(sb.ToString());
}
