function solve(args) {
    var mask = 1 << 2;
    console.log((args & mask) >> 3);
}