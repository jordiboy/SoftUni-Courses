function solve(input) {
    const employees = {};

    for (let i = 0; i < input.length; i++) {        
        const personalNumber = input[i].length;
        employees[input[i]] = personalNumber;
        console.log(`Name: ${input[i]} -- Personal Number: ${personalNumber}`)      
    }    
}

function solve2(input) {
    const employees = {};

    input.forEach(element => {
        employees[element] = element.length;
        console.log(`Name: ${element} -- Personal Number: ${element.length}`)
    });
}

solve([
    'Silas Butler',    
    'Adnaan Buckley',    
    'Juan Peterson',    
    'Brendan Villarreal'    
    ]);

solve2([
    'Silas Butler',    
    'Adnaan Buckley',    
    'Juan Peterson',    
    'Brendan Villarreal'    
    ])