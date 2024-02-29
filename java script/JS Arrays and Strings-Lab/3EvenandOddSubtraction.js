function solve(input) {

    let sumOdd = 0;
    let sumEven = 0;

    for (let i = 0; i < input.length; i++) {
        
        if (input[i] % 2 === 0) {
            sumEven += input[i];
        } else {
            sumOdd += input[i];
        }                
    }

    const result = sumEven - sumOdd;

    console.log(result);
}

solve([1,2,3,4,5,6])
solve([3,5,7,9])