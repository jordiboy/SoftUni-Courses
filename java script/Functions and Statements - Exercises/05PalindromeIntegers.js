function solve(numbers) {

    numbers.forEach(number => console.log(isPalindrom(number)));        
    
}

function isPalindrom(number) {

    const normalNumber = number.toString();
    const reversedNumber = normalNumber.split('').reverse().join('');

    return normalNumber === reversedNumber;
}

solve([123,323,421,121]);