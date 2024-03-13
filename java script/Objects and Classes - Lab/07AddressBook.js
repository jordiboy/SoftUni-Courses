function solve(input) {

    let addressBook = {};

    for (const line of input) {
        
        const [name, address] = line.split(':');
        addressBook[name] = address;
    }

    const sortedAddressBook = Object
        .entries(addressBook)
        .sort((a, b) => a[0].localeCompare(b[0]))
        .forEach(key => console.log(`${key[0]} -> ${key[1]}`));    
}

solve(['Bob:Huxley Rd',
'John:Milwaukee Crossing',
'Peter:Fordem Ave',
'Bob:Redwing Ave',
'George:Mesta Crossing',
'Ted:Gateway Way',
'Bill:Gateway Way',
'John:Grover Rd',
'Peter:Huxley Rd',
'Jeff:Gateway Way',
'Jeff:Huxley Rd'])