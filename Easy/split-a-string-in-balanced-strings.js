// 1st
var balancedStringSplit = function(s) {
    let ret = 0;
    let L = 0, R = 0;
    for (let n = 0; n < s.length; n++) {
        if (s[n] == 'L')
            L++;
        else
            R++;
        if (L == R) {
            ret++;
            L = 0;
            R = 0;
        }
    }
    return ret;
};

// 2nd 50%~
var balancedStringSplit = function(s) {
    let ret = 0;
    let L = 0, R = 0;
    for (let n = 0; n < s.length; n++) {
        if (s[n] == 'L')
            L++;
        else
            R++;
        if (L == R) {
            ret++;
        }
    }
    return ret;
};
