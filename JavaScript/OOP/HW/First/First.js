function solve() {
    return function(numbers) {
        if (numbers === undefined) {
            throw "Exeption";
        } else if (numbers.length === null) {
            return null;
        }


        return numbers.reduce((x, y) => x + y, 0);
    }
}