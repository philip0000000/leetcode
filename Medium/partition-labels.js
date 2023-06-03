/**
 * @param {string} s
 * @return {number[]}
 */
var partitionLabels = function(s) {
    let ret = [];
    while (s.length > 0) {
        let i = s.length - 1;
        while (s[0] != s[i])
            i--;
        let HashSet = {};
        for (let n = 0; n < i; n++) {
            if (HashSet[s[n]] != true)
                HashSet[s[n]] = true;
        }
        for (let l = i + 1; l < s.length; l++)
            if (HashSet[s[l]] == true) {
                while (i < l) {
                    HashSet[s[i]] = true;
                    i++;
                }
            }
        i++;
        ret.push(i);
        s = s.substring(i);
    }
    return ret;
};
