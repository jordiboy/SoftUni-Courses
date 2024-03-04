function solve(array) {

    const sortedArray = array.sort((a, b) => a - b);
    let resultArray = [];

    while (sortedArray.length > 0) {

        let smaller = sortedArray.shift();
        let bigger = sortedArray.pop();
        resultArray.push(smaller, bigger);
    }

    return resultArray;
}

console.log(solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));
