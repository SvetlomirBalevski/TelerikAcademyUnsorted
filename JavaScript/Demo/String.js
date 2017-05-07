'use strict'

// var test = 'Teststring';

// console.log(test.length);
// console.log(test.charAt(2));

// let strings = [
//     'str1',
//     'str2',
//     'str3',
//     'str4',
//     'str5',
// ];
// let result = ''.concat(...strings);

// console.log(result);

// let string = 'Hello, someString ';
// console.log(string.replace('someString', 'Pesho'));
// console.log(string);

// console.log(string.search('l')); // Raboti s regex
// console.log(string.substr(1, 4));
// console.log(string.substring(1, 4));

// function replicate(str, count) {
//     let arr = new Array(count);
//     arr.fill(str);
//     return arr.join('');
// }

// console.log(replicate('@', 10000));

String.prototype.trimChars = function(chars) {
    let startindex = 0;
    while (startindex < this.length) {
        if (chars.indexOf(this[startindex]) < 0) {
            break;
        }
        startindex += 1;
    }
    let endIndex = this.length - 1;
    while (startindex < endIndex) {
        if (chars.indexOf(this[endIndex] < 0)) {
            break;
        }
        endIndex -= 1;
    }
    return this.substring(startindex, endIndex + 1);
};
console.log((', . ; , .. Hi Pesho ., , , . ').trimChars(' ,.;'));