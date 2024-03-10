function solve(number) {

    const row = (number) => new Array(number).fill(number).join(' ');

    for (let i = 0; i < number; i++) {
        console.log(row(number));        
    }
}

solve(7);