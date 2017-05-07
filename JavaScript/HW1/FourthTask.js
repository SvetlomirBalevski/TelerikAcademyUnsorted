function solve(args) {
    var number = +args[0];
    var digit = parseInt(number / 100) % 10;
    if (digit === 7) {
        console.log("true");
    } else {
        console.log("false " + digit);
    }
}