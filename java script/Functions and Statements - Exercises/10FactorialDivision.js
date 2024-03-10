function solve(num1, num2) {

    const result = getFactorial(num1) / getFactorial(num2);

    console.log(`${result.toFixed(2)}`);    
}

function getFactorial(number) {

    let result = 1;

    for (let i = 1; i <= number; i++) {
        result *= i;        
    }

    return result;
}

solve(5, 2);