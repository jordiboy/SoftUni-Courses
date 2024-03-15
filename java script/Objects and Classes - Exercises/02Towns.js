function solve(input) {

    const towns = [];

    for (const row of input) {

        const [town, latitude, longitude] = row.split(' | ');
        const townInfo = {
            town: town,
            latitude: Number(latitude).toFixed(2),
            longitude: Number(longitude).toFixed(2)
        }

        towns.push(townInfo);
    }

    towns.forEach(town => console.log(town));
}

solve(['Sofia | 42.696552 | 23.32601', 'Beijing | 39.913818 | 116.363625']);