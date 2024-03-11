function solve(commands) {
    let cleanPercent = 0;

    for (const command of commands) {
        cleanPercent += getAction(command, cleanPercent);
    }

    console.log(`The car is ${cleanPercent.toFixed(2)}% clean.`);
}

function getAction(command, cleaningProgress) {
    
    switch (command) {
        case 'soap':
           return 10;
        case 'water':
           return cleaningProgress * 0.2;
        case 'vacuum cleaner':
           return cleaningProgress * 0.25;
        case 'mud':
           return cleaningProgress * -0.1;
            
    }    
}

solve(['soap', 'soap', 'vacuum cleaner', 'mud', 'soap', 'water']);
solve(["soap", "water", "mud", "mud", "water", "mud", "vacuum cleaner"]);