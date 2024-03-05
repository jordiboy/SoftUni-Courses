function solve(word, text) {
    const sentence = text.split(' ');

    for (const item of sentence) {
        
        if (item.toLowerCase() === word.toLowerCase()) {
            return word;
        }
    }
    return `${word} not found!`
}

console.log(solve('javascript', 'JavaScript is the best programming language'));