function solve(input) {
    const countAstronauts = input.shift();

    const astronauts = [];

    for (let i = 0; i < countAstronauts; i++) {
        const [name, oxigen, energy] = input[i].split(' ');
        input.shift();        
        const astronautsObj = {name, oxigen, energy};
        astronauts.push(astronautsObj);
    }
    
    let command = input.shift();

    while (command !== 'End') {

        
        let command = input.shift();
    }
}

solve([  '3',
'John 50 120',
'Kate 80 180',
'Rob 70 150',
'Explore - John - 50',
'Refuel - Kate - 30',
'Breathe - Rob - 20',
'End']);