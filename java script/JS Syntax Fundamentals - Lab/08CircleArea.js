function solve(num) {

    let inputType = typeof(num);
    let result = 0;

    if (inputType === 'number') {
        result = Math.pow(num, 2) * Math.PI;
        console.log(result.toFixed(2))
    } else {
        console.log(`We can not calculate the circle area, because we receive a ${inputType}.`);
    }
}

solve('name');