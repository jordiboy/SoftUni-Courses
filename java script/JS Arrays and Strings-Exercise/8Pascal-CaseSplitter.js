function solve(text) {
    
    const matches = text.matchAll(/[A-Z][a-z]*/g);
    const words = Array.from(matches);
    console.log(words.join(', '));   
}

solve('SplitMeIfYouCanHaHaYouCantOrYouCan');