function solve(input) {
    let start = input[0].split(' ');
    let maxRol = +start[0];
    let maxCol = +start[1];
    let startRow = Math.floor(maxRol / 2);
    let startCol = Math.floor(maxCol / 2);
    let i = startRow;
    let j = startCol;
    let arr = new Array(maxRol - 1);
    for (let k = 0; k < maxRol - 1; k += 1) {
        arr[k] = new Array(maxCol);
        arr[k] = input[k + 1].split(' ');
    }
    let catched = false;
    while (i < maxRol && j < maxCol) {
        // while (j < maxCol) {
        //console.log(+arr[i][j]);
        if ((+arr[i][j] != 0) && (+arr[i][j] & 1 == 1)) { //up 
            arr[i][j] = 0;
            i -= 1;
        } else if ((+arr[i][j] != 0) && (+arr[i][j] & (1 << 1) > 0)) { // right
            arr[i][j] = 0;
            j += 1;
        } else if ((+arr[i][j] != 0) && (+arr[i][j] & (1 << 2) > 0)) { // down
            arr[i][j] = 0;
            i += 1;
        } else if ((+arr[i][j] != 0) && (+arr[i][j] & (1 << 3) > 0)) { // down
            arr[i][j] = 0;
            j -= 1;
        } else {
            //console.log('No JavaScript, only rakiya ' + i + ' ' + j);
            let res = 'No JavaScript, only rakiya ' + i + ' ' + j;
            return res;
        }
    }
    let result = 'No rakiya, only JavaScript ' + i + ' ' + j;
    //  console.log('No rakiya, only JavaScript ' + i + ' ' + j);
    return result;
}
let test = [
    '5 7',
    '9 5 3 11 9 5 3',
    '10 11 10 12 4 3 10',
    '10 10 12 7 13 6 10',
    '12 4 3 9 5 5 2',
    '13 5 4 6 13 5 6'
];
console.log(solve(test));