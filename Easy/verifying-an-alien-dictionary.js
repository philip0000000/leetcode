// 1st
/**
 * @param {string[]} words
 * @param {string} order
 * @return {boolean}
 */
var isAlienSorted = function(words, order) {
    for (var i = 0; i < words.length - 1; i++) {
        var j = 0;
        for (; j < words[i].length && j < words[i + 1].length &&
            words[i][j] == words[i+1][j]; j++);
        if (((j == words[i].length || j == words[i + 1].length) && words[i].length > words[i + 1].length) ||
            (order.indexOf(words[i + 1][j]) < order.indexOf(words[i][j])))
                return false;
    }
    return true;
};

// 2nd 50%~
/**
 * @param {string[]} words
 * @param {string} order
 * @return {boolean}
 */
var isAlienSorted = function(words, order) {
    var map = new Map();
    for (var n = 0; n < order.length; n++)
        map.set(order[n], n);
    for (var i = 0; i < words.length - 1; i++) {
        var j = 0;
        for (; j < words[i].length && j < words[i + 1].length &&
            words[i][j] == words[i+1][j]; j++);
        if (((j == words[i].length || j == words[i + 1].length) && words[i].length > words[i + 1].length) ||
            (map.get(words[i + 1][j]) < map.get(words[i][j])))
                return false;
    }
    return true;
};
