/**
 * @param {number[][]} image
 * @param {number} sr
 * @param {number} sc
 * @param {number} color
 * @return {number[][]}
 */
var floodFill = function(image, sr, sc, color) {
    if (image[sr][sc] == color)
        return image;
    var f = image[sr][sc];
    var s = [[sr, sc]];
    var set = new Set();
    while (s.length > 0) {
        var e = s.shift();
        if (set.has(e))
            continue;
        set.add(e);
        if (e === undefined)
            continue;
        if (image[e[0]][e[1]] == f)
            image[e[0]][e[1]] = color;
        if (e[0]+1 < image.length && image[e[0]+1][e[1]] == f) {
            image[e[0]+1][e[1]] = color;
            s.push([e[0]+1, e[1]]);
        }
        if (e[0]-1 >= 0 && image[e[0]-1][e[1]] == f) {
            image[e[0]-1][e[1]] = color;
            s.push([e[0]-1, e[1]]);
        }
        if (e[1]+1 < image[0].length && image[e[0]][e[1]+1] == f) {
            image[e[0]][e[1]+1] = color;
            s.push([e[0], e[1]+1]);
        }
        if (e[1]-1 >= 0 && image[e[0]][e[1]-1] == f) {
            image[e[0]][e[1]-1] = color;
            s.push([e[0], e[1]-1]);
        }
    }
    return image;
};
