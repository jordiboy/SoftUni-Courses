function solve(input) {

    countWords = {};
    const searchWords = input.shift().split(' ').forEach(element => countWords[element] = 0);    

    for (const word of input) {
        if (countWords.hasOwnProperty(word)) {
            countWords[word] += 1;
        }
    }

    Object.entries(countWords)
        .sort((a, b) => b[1] - a[1])
        .forEach(([word, counts]) => console.log(`${word} - ${counts}`))
}

solve([
    'this sentence',    
    'In', 'this', 'sentence', 'you', 'have',    
    'to', 'count', 'the', 'occurrences', 'of',    
    'the', 'words', 'this', 'and', 'sentence',    
    'because', 'this', 'is', 'your', 'task'    
    ])