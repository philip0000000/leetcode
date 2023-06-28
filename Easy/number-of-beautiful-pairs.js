/**
 * @param {number[]} nums
 * @return {number}
 */
function findGCD(a, b) {
    var max = Math.max(a, b);
    var min = Math.min(a, b);
    var res = max % min;
    if (res == 0)
        return min;
    else
        return findGCD(min, res);
}
var countBeautifulPairs = function(nums) {
    var ret = 0;
    for (var i = 0; i < nums.length - 1; i++)
        for (var j = i + 1; j < nums.length; j++)
            if (i != j)
            {
                var x = nums[i];
                while (x >= 10)
                    x = Math.floor(x / 10);
                var y = nums[j] % 10;
                if (findGCD(x, y) == 1)
                    ret++;
            }
    return ret;
};
