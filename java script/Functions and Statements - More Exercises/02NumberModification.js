function solve(number) {

    let digits = number.toString().split('').map(Number);

    while (getAverageValue(digits) <= 5) {
        digits.push(9);
    }

    console.log(digits.join(''));
}

function getAverageValue(digits) {
    let tempArray = digits;    

    const sum = tempArray.reduce((a, b) => a + b, 0);
    const average = sum / digits.length;
    
    return average;
}

solve(101);
solve(5835)
