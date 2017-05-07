'use strict'
// if (false)
//     console.log('Hello');
// console.log('Bez skobi se izpalniava tova');

// // asdsa - NaN
// //'0' - 0 - tova e number, n;o !0  si e true

// let string = '1ds2';
// let number = +string;
// // if (!number) {
// //     console.log('This is False');
// // }

// // Po pravilno

// if (isNaN(number)) {
//     console.log('This is False');
// }

let number = 5,
    newnumber = 0;

if (number == newnumber) {
    console.log('Here');
}

let score = 3.5;

// switch (number) {
//     case 1:
//         console.log('1');
//         break;
//     case 2:
//         console.log('2');
//         break;
//     case 3:
//         console.log('3');
//         break;
//     case 4:
//         console.log('4');
//         break;
//     case 5:
//         console.log('5');
//         break;
//     default:
//         console.log('None of above');
//}

// var person = {
//     name: 'Pesho',
//     age: 10 //Definirame obekt
// };
// for (var key in person) {
//     console.log('variable');

// }

var array = [2, 4, 6];
for (var variable in array) {
    console.log(variable);
} // tova e forin - dava ni indexa

console.log('----------');

//debugger;; //Raboti v browser-a

for (var variable of array) {
    console.log(variable);
} // tova e foroff - dava ni stoinostite na poletata, samo na masivi stava



// var array = {
//     0: 1,
//     1: 2,
//     2: 3,
//     gosho: 'gosho'
// };

// for (var variable in array) {
//     console.log(variable);
// }