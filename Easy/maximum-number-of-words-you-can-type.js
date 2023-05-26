/**
 * @param {string} text
 * @param {string} brokenLetters
 * @return {number}
 */
var canBeTypedWords = function(text, brokenLetters) {
    var arr = text.split(' ')
    var hashSet = brokenLetters.split('')
    var NrFullyType = 0
    for (var i = 0; i < arr.length; i++) {
        if (hashSet.some(c => arr[i].includes(c)) == false) {
            NrFullyType++
        }
    }
    return NrFullyType
};
