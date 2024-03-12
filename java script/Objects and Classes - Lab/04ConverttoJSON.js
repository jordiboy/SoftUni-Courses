function solve(name, lastName, hairColor) {
    let Person = {
        name,
        lastName,
        hairColor
    }

    console.log(JSON.stringify(Person));
}

solve('George', 'Jones', 'Brown');