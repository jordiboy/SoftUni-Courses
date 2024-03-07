function smallestNumber(num1, num2, num3) {

    const numbers = Array.of(num1, num2, num3);
    const sortedNumbers = numbers.sort((a, b) => a - b);

    console.log(sortedNumbers[0]);
}

smallestNumber(2, 5, 3);
smallestNumber(600, 342, 123);