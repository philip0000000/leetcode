/**
 * @param {string[]} words
 * @param {string} pattern
 * @return {string[]}
 */
var GetStrFormated = function (str) {
    let dict = {};
    let count = 'a';
    let retStr = '';
    for (let m = 0; m < str.length; m++) {
        if (dict.hasOwnProperty(str[m]) == false) {
            dict[str[m]] = count;
            count = String.fromCharCode(count.charCodeAt(0) + 1);
        }
        retStr += dict[str[m]];
    }
    return retStr;
}
var findAndReplacePattern = function(words, pattern) {
    let ret = [];
    let p = GetStrFormated(pattern);
    for (let n = 0; n < words.length; n++) {
        if (words[n].length != pattern.length)
            continue;
        if (p == GetStrFormated(words[n]))
            ret.push(words[n])
    }
    return ret;
};
