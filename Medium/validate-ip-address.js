// https://leetcode.com/problems/validate-ip-address/submissions/985750059/
/**
 * @param {string} queryIP
 * @return {string}
 */
 function IsDigit(c)
 {
     return (c <= '9' && c >= '0') ?
         true :
         false;
 }
 function IsValidPartIPv4(p)
 {
     if (p.length == 0 || p.length > 3)
         return false;
     var num = 0;
     for (var i = 0; i < p.length; i++)
         if (IsDigit(p[i]) == false)
             return false;
         else
             num = num * 10 + parseInt(p[i]);
     if (num > 255 || num < 0)
         return false;
     if (p[0] == '0' && p.length > 1)
         return false;
     return true;
 }
function IsValidPartIPv6(p)
{
    if (p.length == 0 || p.length > 4)
        return false;
    for (var i = 0; i < p.length; i++)
        if (IsDigit(p[i]) == true)
            continue;
        else if ((p[i] == 'a' || p[i] == 'A' ||
                  p[i] == 'b' || p[i] == 'B' ||
                  p[i] == 'c' || p[i] == 'C' ||
                  p[i] == 'd' || p[i] == 'D' ||
                  p[i] == 'e' || p[i] == 'E' ||
                  p[i] == 'f' || p[i] == 'F') == false)
            return false;
     return true;
 }
 var validIPAddress = function(queryIP) {
     var isIpv4 = false;
     var arr = queryIP.split('.')
     if (arr.length == 4)
     {
         isIpv4 = true;
         for (var i = 0; i < arr.length; i++)
             if (IsValidPartIPv4(arr[i]) == false)
             {
                 isIpv4 = false;
                 break;
             }
     }
 
     var isIpv6 = false;
     var arr = queryIP.split(':');
     if (arr.length == 8) // must be divided by 7 ':'
     {
         isIpv6 = true;
         for (var i = 0; i < arr.length; i++)
             if (IsValidPartIPv6(arr[i]) == false)
             {
                 isIpv6 = false;
                 break;
             }
     }
 
     if (isIpv4)
         return "IPv4";
     if (isIpv6)
         return "IPv6";
     return "Neither";
 };
