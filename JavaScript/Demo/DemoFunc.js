'use strict';
// function hello() {
//     console.log('Hello');
// }

// let x = hello();
// console.log(x); // Vsqka funkcia vryshta neshto

// let hello2 = hello;
// hello2();

// let hello3 = function() {
//     console.log('Hello 3');
// };
// hello3();
// function doubleX(x) {
//     console.log(x * 2);
// }
// doubleX('5a');
// let counter = 0;
// function count() {
//     counter += 1;
//     return counter;
// }
// console.log(count());
// console.log(count());
// function sum() {
//     let sum = 0;
//     console.log(arguments[0]);
//     console.log(arguments.length);
//     for (let i = 0; i < arguments.length; i += 1) {
//         sum += arguments[i];
//     }
//     console.log(sum);
// }
// sum(1, 2, 3, 12, '', 232, 'a');

// function printTriangle(n) {

//     function printToN(n) {
//         let arr = [];
//         for (let i = 1; i <= n; i += 1) {
//             arr.push[i];
//         }
//         console.log(arr.join(' '));
//     }
//     for (let i = 1; i <= n; i += 1) {
//         printToN(n);
//     }
//     for (let i = n; i > 0; i += 1) {
//         printToN(n);
//     }
// }
// printTriangle(5);
// function doubleX(x) {
//     if (typeof x === 'number') {
//         return x * 2;
//     }
//     if (typeof x === 'string') { return x + x; }
//     if (Array.isArray(x)) { return x.concat(x) }
// }
// console.log(doubleX(5));
// console.log(doubleX('ass'));
// let x = function(a,b)
// {
//     return a+b;
// }
// x = (a,b)=> a+b;  // Ekvivalentno na gornoto