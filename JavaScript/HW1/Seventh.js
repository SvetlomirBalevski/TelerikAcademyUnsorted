function solve(args) {
    var number = +args;
    var isPrime = true;
    if (number > 1) {
        for (var i = 3; i < 10; i++) {
            if (number % i == 0) {
                isPrime = false;
                break;
            }
        }
    } else { isPrime = false }
    return isPrime;
}