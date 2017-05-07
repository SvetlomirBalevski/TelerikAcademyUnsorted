// function solve(input) {
//     let len = +input[0];
//     let sum = +input[1];
//     let i = 1;
//     if (!!(+input[i] % 2)) {
//         i = 2;
//     }
//     while (i < len) {
//         if (!!(+input[i] % 2)) {
//             sum = sum * +input[i];
//             if (sum > 1024) {
//                 sum = sum % 1024;
//             }
//             i += 1;
//         } else {
//             sum += +input[i];
//             if (sum > 1024) {
//                 sum = sum % 1024;
//             }
//             i += 2;
//         }
//     }
//     console.log(sum);
// }

function solve(input) {
    let arr = new Array(input[0]);

    for (let i = 0; i < input.length - 1; i += 1) {
        arr[i] = +input[i + 1];
        console.log(arr[i]);
    }
}

let test = [
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9'
];
console.log(solve(test));