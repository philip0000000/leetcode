// 1st
var removeDuplicates = function(s) {
    let removeCharAtIndex = (str, indexToRemove) => str.substring(0, indexToRemove) + str.substring(indexToRemove + 1);
    for (let i = 1; i < s.length; i++) {
        while (i < s.length && s[i-1] == s[i]) {
            s = removeCharAtIndex(s, i);
            s = removeCharAtIndex(s, i-1);
            i -= 1;
        }
    }
    return s;
};

// 2nd 50%~
var removeDuplicates = function(s) {
    let stack = [];
    for (let i = 0; i < s.length; i++) {
        if (stack.length > 0) {
            if (stack[stack.length-1] == s[i])
                stack.pop();
            else
                stack.push(s[i]);
        }
        else
            stack.push(s[i]);
    }
    return stack.join('');
};

// 3rd
var removeDuplicates = function(s) {
    let stack = [];
    for (let i = 0; i < s.length; i++)
        if (stack.length > 0 && stack[stack.length-1] == s[i])
            stack.pop();
        else
            stack.push(s[i]);
    return stack.join('');
};
