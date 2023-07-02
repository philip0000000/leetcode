/**
 * @param {number} money
 * @param {number} children
 * @return {number}
 */
var distMoney = function(money, children) {
    if (children > money)
        return -1;
    var arr = [];
    for (var j = 0; j < children && money > 0; j++, money--)
        arr.push(1);
    var i = 0;
    for (; i < arr.length && money - 7 >= 0; i++, money -= 7)
        arr[i] += 7;
    if (i < arr.length)
    {
        arr[i] += money;
        if (arr[i] == 4 && i == arr.length - 1)
            i--;
    }
    else if (i == arr.length && money > 0)
        i--;
    if (i < 0)
        i = 0;
    return i;
};
