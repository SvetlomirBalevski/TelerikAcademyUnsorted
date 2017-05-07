function solve(args) {
    let x = args[0];
    let y = args[1];
    let distance = Math.sqrt(x * x + y * y);
    let isInside = (distance <= 2);
    if (isInside === false) {
        return 'no ' + distance.toFixed(2);
    } else {
        return 'yes ' + distance.toFixed(2);
    }
}