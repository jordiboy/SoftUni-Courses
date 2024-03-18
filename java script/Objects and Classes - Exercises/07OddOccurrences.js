function solve(input) {

    countWords = {};
    const words = input.split(' ');

    for (const word of words) {
        if (!countWords.hasOwnProperty(word.toLowerCase())) {
            countWords[word.toLowerCase()] = 0;
        }

        countWords[word.toLowerCase()]++;
    }

    const result = [];

    for (const word in countWords) {
        if (countWords[word] % 2 !== 0) {
            result.push(word);            
        }
    }

    console.log(result.join(' '));
}

solve('Java C# Php PHP Java PhP 3 C# 3 1 5 C#')