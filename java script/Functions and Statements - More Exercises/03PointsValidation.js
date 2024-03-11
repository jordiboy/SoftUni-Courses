function solve(coords) {

    const firstPointToZeroDistance = getDistance([coords[0], coords[1], 0, 0]);
    const secondPointToZeroDistance = getDistance([coords[2], coords[3], 0, 0]);
    const firstToSecondPointDistance = getDistance(coords);

    printValidations(coords, firstPointToZeroDistance, secondPointToZeroDistance, firstToSecondPointDistance);
}

function getDistance(coords) {

    const [x1, y1, x2, y2] = [coords[0], coords[1], coords[2], coords[3]];
    const distance = Math.sqrt(Math.pow((x2 - x1), 2) + Math.pow((y2 - y1), 2));

    return distance;
}

function printValidations(coords, firstPointToZeroDistance, secondPointToZeroDistance, firstToSecondPointDistance) {

    if (Number.isInteger(firstPointToZeroDistance)) {
        console.log(`{${coords[0]}, ${coords[1]}} to {0, 0} is valid`)
    } else {
        console.log(`{${coords[0]}, ${coords[1]}} to {0, 0} is invalid`)
    }
    if (Number.isInteger(secondPointToZeroDistance)) {
        console.log(`{${coords[2]}, ${coords[3]}} to {0, 0} is valid`)
    } else {
        console.log(`{${coords[2]}, ${coords[3]}} to {0, 0} is invalid`)
    }
    if (Number.isInteger(firstToSecondPointDistance)) {
        console.log(`{${coords[0]}, ${coords[1]}} to {${coords[2]}, ${coords[3]}} is valid`)
    } else {
        console.log(`{${coords[0]}, ${coords[1]}} to {${coords[2]}, ${coords[3]}} is invalid`)
    }
}

solve([3, 0, 0, 4]);
solve([2, 1, 1, 1]);