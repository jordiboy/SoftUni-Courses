function solve(number) {

    const evens = x => x % 2 === 0;
    const odds = x => x % 2 !== 0;

    const evenSum = calculateSum(number, evens);
    const oddSum = calculateSum(number, odds);

    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
}

function calculateSum (number, filter) {
    const digits = number
    .toString()
    .split('')
    .map(Number)
    .filter(filter);

    const sum = digits.reduce((a, b) => a + b, 0);

    return sum;
}

solve(1000435);