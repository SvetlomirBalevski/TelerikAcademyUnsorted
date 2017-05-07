function solve(args) {
    var inputNumber = +args;
    var ouput = '';
    if (inputNumber % 5 === 0 && inputNumber % 7 === 0) {
        ouput = 'true';
    } else {
        ouput = 'false';
    }
    console.log(`${ouput} ${inputNumber}`);
}