function solve(text) {

    const pattern = /([A-Z][a-z]+)/g;
    const matches = text.matchAll(pattern);

    for (const match of matches) {
        console.log(match.join(', '));
    }
}

solve('SplitMeIfYouCanHaHaYouCantOrYouCan');