function solve(a, b, c) {
    const multiply = (a, b) => a * b;

    const result = multiply(multiply(a, b), c );

    if (result > 0) {
        console.log('Positive');
    } else {
        console.log('Negative');
    }
}

solve(5, 12, -15);