/**
 * @param {number[]} arr
 * @param {number} k
 * @param {number} threshold
 * @return {number}
 */
var numOfSubarrays = function(arr, k, threshold) {
    var ret = 0;
    var i = 0;
    var sum = 0;
    for (; i < k; i++)
        sum += arr[i];
    if (sum / k >= threshold)
        ret++;
    for (var j = 0; i < arr.length; i++, j++) {
        sum -= arr[j];
        sum += arr[i];
        if (sum / k >= threshold)
            ret++;
    }
    return ret;
};
