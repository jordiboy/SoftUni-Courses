function solve(text, word) {

    let words = text.split(' ');
    let counter = 0;

    for (let i = 0; i < words.length; i++) {
        
        if (words[i] === word) {
            counter ++;
        }        
    }

    console.log(counter);
}

solve('This is a word and it also is a sentence', 'is');