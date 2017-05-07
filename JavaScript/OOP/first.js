// //function func(x, y) {
// //return x + y;
// //}

// //console.log(func.length); // Vryshta broya na argumentite,
// //console.log(func.name);

// // const modifiers = [

// //     function(x) { return x + 7; },
// //     function(x) { return x + 2; }

// // ];

// // function applyFuncOver11(f) {
// //     return f(11);
// // }
// //  modifiers.map(f => f(11))
// //     .forEach(x => console.log(x));

// // modifiers.map(applyFuncOver11)
// //     .forEach(x => console.log(x));

// // const msg = 'test';
// // var printMsg = function() { console.log(msg); }
// // printMsg();

// // const someFunc = new Function('x', 'y', 'console.log(x+y);');
// // someFunc(4, 5);
// // //                Same as
// // const someFunc = function(x, y) {
// //     console.log(x + y);
// // }

// // console.log(someFunc(4, 5));


// const modifiers = [

//     function(x) { return x + 7; },
//     function(x) { return x + 2; }

// ];

// modifiers.someFunc = function() {
//     console.log(this[0].toString());
// };

// console.log(modifiers.someFunc()); // modifiers = this

// Array.prototype.someOtheFunc = function(x) {
//     console.log(x);
//     console.log(this[0].toString());
// };
// console.log(modifiers.someOtheFunc.call([5, 4, 7], 3)); // Smenqme modifiers s [5,4,7], zaradi call

// console.log(modifiers.someOtheFunc.apply([5, 4, 7], [3])); // Pochti sashtoto kato gornoto 
// // Apply kogato pylnim dinamichno, t.e. ne znaem kolko parametri imame v masiva.

// function maxElement() {
//     let args = [];
//     for (let i = 0; i < arguments.length; i += 1) {
//         args.push(arguments[i]);
//     }
//     //!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//     // same as const args = [].slice.call(arguments);  - Vryshta Direktno masiva args!!!!!!
//     //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

//     return args.reduce((x, y) => Math.max(x, y));
// }

// console.log(maxElement(2, 3, 4, 5));

//          Recursion

function factorial(n) {
    if (n === 0) {
        return 1;
    } else {
        return factorial(n - 1) * n;
    }
}

console.log(factorial(114));

function fibo(n) {
    if (n < 0) {
        throw "Test exception";
    }
    if (n === 0 || n === 1) {
        return 1;
    }
    return fibo(n - 1) + fibo(n - 2);
}
console.log(fibo(1));

// function rotateElement(elem) {
//     elem.style.display = 'block';
//     elem.style.transform = 'rotate(73deg)';
// }

// function rotateRecursive(elem) {
//     rotateElement(elem);
//     [].slice.call(elem.children)
//         .forEach(rotateRecursive);
// }

// rotateRecursive(document.body);