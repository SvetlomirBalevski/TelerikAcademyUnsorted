function solve(args) {
    var inputNumber = +args;
    var ouput = '';
    if (inputNumber % 2 === 0) {
        ouput = 'even';
    } else {
        ouput = 'odd';
    }
    console.log(`${ouput} ${inputNumber}`);
}