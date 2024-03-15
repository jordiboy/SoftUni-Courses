function solve(input) {
    const heroes = [];

    for (const row of input) {
        const [hero, level, items] = row.split(' / ');

        const heroInfo = {};
        heroInfo.heroName = hero;
        heroInfo.level = Number(level);
        heroInfo.items = items;
        
        heroes.push(heroInfo);
    }

    heroes.sort((a, b) => a.level - b.level);

    for (const hero of heroes) {
        console.log(`Hero: ${hero.heroName}`);
        console.log(`level => ${hero.level}`);
        console.log(`items => ${hero.items}`);
    }
}

solve([
    'Isacc / 25 / Apple, GravityGun',    
    'Derek / 12 / BarrelVest, DestructionSword',    
    'Hes / 1 / Desolator, Sentinel, Antara'    
    ] )