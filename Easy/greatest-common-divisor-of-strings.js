// 50%~
/**
 * @param {string} str1
 * @param {string} str2
 * @return {string}
 */
function gcd(a, b)
{
    if (b == 0)
        return a;
    else
        return gcd(b, a % b);
}
function match(a, b)
{
    var n = 0, k = 0;
    while (n < a.length && a[n] == b[k])
    {
        k = k + 1 == b.length ? 0 : k + 1;
        n++;
    }
    if (n == a.length && k == 0)
        return true;
    return false;
}
var gcdOfStrings = function(str1, str2) {
    if (str2.length > str1.length)
    {
        var temp = str1;
        str1 = str2;
        str2 = temp;
    }
    var str = str2.substr(0, gcd(str1.length, str2.length));
    if (match(str1, str) == false || match(str2, str) == false)
        return '';
    return str;
};
