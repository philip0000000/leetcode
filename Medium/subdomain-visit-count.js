/**
 * @param {string[]} cpdomains
 * @return {string[]}
 */
var subdomainVisits = function(cpdomains) {
    var dict = {};
    for (let n = 0; n < cpdomains.length; n++) {
      let spaceIndex = cpdomains[n].indexOf(' ');
      let number = parseInt(cpdomains[n].substring(0, spaceIndex), 10);
      let StrTemp = cpdomains[n].substring(spaceIndex + 1);
      if (StrTemp in dict)
        dict[StrTemp] += number;
      else
        dict[StrTemp] = number;
      let d1 = StrTemp.indexOf('.');
      if (d1 != -1) {
        StrTemp = StrTemp.substring(d1 + 1);
        if (StrTemp in dict)
          dict[StrTemp] += number;
        else
          dict[StrTemp] = number;
      }
      d1 = StrTemp.indexOf('.');
      if (d1 != -1) {
        StrTemp = StrTemp.substring(d1 + 1);
        if (StrTemp in dict)
          dict[StrTemp] += number;
        else
          dict[StrTemp] = number;
      }
      d1 = StrTemp.indexOf('.');
      if (d1 != -1) {
        StrTemp = StrTemp.substring(d1 + 1);
        if (StrTemp in dict)
          dict[StrTemp] += number;
        else
          dict[StrTemp] = number;
      }
    }
    let ret = [];
    for (let key in dict) {
      if (dict.hasOwnProperty(key)) {
        let value = dict[key];
        ret.push(value.toString() + ' ' + key);
      }
    }
    return ret;
};
