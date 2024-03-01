function solve(array, number) {

    for (let i = 0; i < number; i++) {
        let temp = array.shift();
        array.push(temp);
    }

    console.log(array.join(' '))
}

solve([51, 47, 32, 61, 21], 2)