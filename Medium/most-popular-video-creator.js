function charToNumber(char) {
    return char.charCodeAt(0) - 96;
}
function lexicographically(str)
{
    var ret = 0;
    for (var i = 0; i < str.length; i++)
        ret += (i + 1) * 26 + charToNumber(str[i]);
    return ret;
}
/**
 * @param {string[]} creators
 * @param {string[]} ids
 * @param {number[]} views
 * @return {string[][]}
 */
 var mostPopularCreator = function(creators, ids, views) {
    var dict = {};
    for (var i = 0; i < creators.length; i++)
        if (creators[i] in dict)
        {
            dict[creators[i]].viewAll += views[i];
            if (views[i] > dict[creators[i]].mostViewVideo)
            {
                dict[creators[i]].mostViewVideo = views[i];
                dict[creators[i]].mostViewVideoID = ids[i];
            }
            else if (views[i] == dict[creators[i]].mostViewVideo &&
                    lexicographically(ids[i]) < lexicographically(dict[creators[i]].mostViewVideoID))
                dict[creators[i]].mostViewVideoID = ids[i];
        }
        else
            dict[creators[i]] =  { viewAll: views[i],
                                   mostViewVideo: views[i], mostViewVideoID: ids[i] };

    var answer = [];
    var max = 0;
    for (var key in dict)
        if (dict[key].viewAll > max ||
            answer.length == 0)
        {
            answer.length = 0;
            max = dict[key].viewAll;
            answer.push([key, dict[key].mostViewVideoID]);
        }
        else if (max == dict[key].viewAll)
            answer.push([key, dict[key].mostViewVideoID]);

    return answer;
};
