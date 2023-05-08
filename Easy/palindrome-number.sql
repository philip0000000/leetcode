// 1st
/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function(x) {
  var list = x.toString();
  list = list.split('');
  while (list.length > 1) {
    if (list[0] != list[list.length-1])
      return false;
    list.shift();
    list.pop();
  }
  return true;
};

// 2nd 50%~
/**
 * @param {number} x
 * @return {boolean}
 */
function reverseNumber(x) {
  let num = 0;
  while (x > 0) {
    num *= 10;
    num += x % 10;
    x = Math.floor(x / 10);
  }
  return num;
}
var isPalindrome = function(x) {
    if (x<0)
        return false;
    num = reverseNumber(x);
    return num == x;
};
