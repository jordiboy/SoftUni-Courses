function solve(input) {

    const pattern = /#([A-Za-z]+)/g;

    const matches = input.matchAll(pattern);
    
    for (const match of matches) {
        console.log(match[1]);
    }
    
}

solve('Nowadays everyone uses # to tag a #special word in #socialMedia');