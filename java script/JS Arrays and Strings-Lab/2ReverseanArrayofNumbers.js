function solve(n, input) {
    reversedArray = [];

    for (let i = 0; i < n; i++) {
        reversedArray.push(input[i]);        
    }

    reversedArray.reverse();
    
    console.log(reversedArray.join(' '));
}

solve(3, [10, 20, 30, 40, 50])