function solve(number) {
    
    const sum = numbers => numbers.reduce((a , b) => a + b, 0);
    const isPerfectNumber = sum(devisors(number)) === number;

    if (isPerfectNumber) {
        console.log("We have a perfect number!");
    } else {
        console.log("It's not so perfect.");
    }

    function devisors(number) {
        let divisors = [];
    
        for (let i = 0; i < number; i++) {
            if (number % i === 0) {
                divisors.push(i);
            }        
        }
        return divisors;
    }
}

solve(6);