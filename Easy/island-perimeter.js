/**
 * @param {number[][]} grid
 * @return {number}
 */
var islandPerimeter = function(grid) {
    var ret = 0;
    grid.unshift(new Array(grid[0].length).fill(0));
    grid.push(new Array(grid[0].length).fill(0));
    for (var i = 1; i < grid.length; i++)
        for (var j = 0; j < grid[0].length; j++) {
            if (grid[i][j] == 1 && j - 1 < 0)
                ret++;
            if (grid[i][j] == 1 && j + 1 >= grid[0].length)
                ret++;
            if (j - 1 >= 0 && grid[i][j - 1] != grid[i][j])
                ret++;
            if (grid[i - 1][j] != grid[i][j])
                ret++;
        }
    return ret;
};
