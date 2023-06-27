/**
 * @param {number} n
 * @return {boolean}
 */
var isFascinating = function(n) {
    var str = n.toString() + (n * 2).toString() + (n * 3).toString();
    var hashSet = {};
    for (var i = 0; i < str.length; i++)
        if (str[i] in hashSet == true || str[i] == '0')
            return false;
        else
            hashSet[str[i]] = true;
    return true;
};
