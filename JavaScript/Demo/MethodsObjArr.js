'use strict';
const arr = [1, 2, 3, 34, 5.343, 232];

// function isOdd(x) {
//     return x % 2 == 1;
// }

// const result = arr.every(isOdd); // Not all are odd
// console.log(result);

// function areSmallerThan100(x) {
//     return x < 100;
// }

// arr.every = function(isOk) { //Pishem si nashe every za nashiq array
//     for (const x of this) {
//         if (!isOk(x)) {
//             return false;
//         }
//     }
//     return true;
// }
// Array.prototype.every = function(isOk) { //Pishem si nashe every za vsichki masivi(override)!
//     for (const x of this) {
//         if (!isOk(x)) {
//             return false;
//         }
//     }
//     return true;
// }
// console.log(arr.every(areSmallerThan100)); // Dali vsichki sa po-golemi ot 100

// console.log(arr.every(x => x < 1000));

// console.log(arr.some(areSmallerThan100)); // Dali nqkoe e po-goqlmo ot 100

// Array.prototype.some = function(isOk) {
//     console.log('Use our function');
//     for (const x of this) {
//         if (isOk(x)) {
//             return true;
//         }
//     }
//     return false;
// }

// console.log(arr.some(areSmallerThan100)); // Dali nqkoe e po-goqlmo ot 100, s nashata si funckija

// function isIncreasing(x,i,arr){
//     if(i===0){
//         return true;
//     }
//    return( arr[i-1]<x)
// }

// Array.prototype.filter = function(isOK) //isOK - condition
//     {
//         let filteredArray = [];
//         const len = this.length;
//         for (let i = 0; i < len; i += 1) {
//             if (isOK(i, this[i], this)) {
//                 filteredArray.push(this.i);
//             }
//         }
//         return filteredArray;

//     }

// const arr = [1, 2, 3, 34, 5343, 232];
// console.log(arr.filter(x => x % 2 === 1)); // Pravim si masiv  ot neshetni
// console.log(arr.map(x => x * 2)); // Pravi deistvieto za vsichki elementi na masiva
// console.log(arr.map((x, i) => x * i));

// function rotate(x, i, arr) {
//     if (i + 1 === arr.length) {
//         return arr[0];
//     }
//     return arr[i + 1];
// }
// const rotated = arr.map(rotate);
// console.log(rotated);

//                                  Foreach 

// arr.forEach(x => console.log(x));

// console.log(arr.map((_, i) => i + 1)); // _ ili x, nqma znachenie

// Array.prototype.forEach = function(func) {
//     const len = this.length;
//     for (let i = 0; i < len; i += 1) {
//         func(this, i);
//     }
// }

//                                 Searching

Array.prototype.find = function(isOk) {
    const len = this.length;
    for (let i = 0; i < len; i += 1) {
        if (isOk(this[i], this, i)) {
            return this[i];
        }
    }
}

console.log(arr.find(x => x < 10 && x > 1));

console.log(arr.findIndex(x => x < 100));