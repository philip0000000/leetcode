/**
 * @param {string} word
 * @return {boolean}
 */
var detectCapitalUse = function(word) {
    if (word[word.length-1] >= 'a' && word[word.length-1] <= 'z')
    {
        for (var i = word.length - 1; i > 0; i--)
            if (word[i] >= 'A' && word[i] <= 'Z')
                return false;
    }
    else
    {
        for (var i = 0; i < word.length; i++)
            if (word[i] >= 'a' && word[i] <= 'z')
                return false;
    }
    return true;
};
