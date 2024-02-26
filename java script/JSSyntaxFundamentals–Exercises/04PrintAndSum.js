function solve(num1, num2) {

    numbers = [];
    let sum = 0;

    for (let i = num1; i <= num2; i++) {
        sum += i;
        numbers.push(i);        
    }

    console.log(numbers.join(' '));
    console.log(`Sum: ${sum}`)
}

solve(5, 10)