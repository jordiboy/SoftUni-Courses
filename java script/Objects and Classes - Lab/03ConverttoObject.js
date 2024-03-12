function solve(data) {
    const person = JSON.parse(data);

    Object.keys(person).forEach(key => console.log(`${key}: ${person[key]}`))
}

solve('{"name": "George", "age": 40, "town": "Sofia"}')