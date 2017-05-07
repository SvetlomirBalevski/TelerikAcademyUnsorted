'use strict';

// let x = [1, 2, 3, [3, 4, 5]];
// console.log(x[3].length);

// console.log(x[5]);

// let x = [];
// for (let i = 1; i <= 20; i += 1) {
//     //x[i - 1] = i;
//     //x[x.length] = i; // syshtoto kato gornoto
//     x.push(i); // syshtoto kato gornoto
// }
// console.log(x);
// // for (var i in x) {
// //     console.log(i);
// // }
// x.reverse();
// console.log(x);

let array = [1, 2, 17, 39, 6];
let spliced = array.splice(2, 2, 3, 4, 5);
console.log(array);
console.log(spliced);

function ourSplice(array, startIndex, count) {
    let leftArray = array.slice(0, startIndex);
    let middle = array.slice(startIndex, startIndex + count);
    let rightArray = array.slice(startIndex + count);
    while (array.length > startIndex) {
        array.pop();
    }

    for (let i = 3; i < arguments.length; i += 1) {
        array.push(arguments[i]);
    }
    [].push.apply(array, rightArray);
    return middle;
}