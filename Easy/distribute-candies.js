// 1st
/**
 * @param {number[]} candyType
 * @return {number}
 */
var distributeCandies = function(candyType) {
    const set = new Set();
    candyType.forEach((e) => set.add(e));
    return set.size > (candyType.length / 2) ? candyType.length / 2 : set.size;
};

// 2nd 50%~
/**
 * @param {number[]} candyType
 * @return {number}
 */
var distributeCandies = function(candyType) {
    const set = new Set(candyType);
    return set.size > (candyType.length / 2) ? candyType.length / 2 : set.size;
};
