function solve(text, word) {

    let censore = '*';    
    let index = text.indexOf(word);

    while (index >= 0) {
        text = text.replace(word, censore.repeat(word.length));
        index = text.indexOf(word);
    }

    console.log(text);
}

solve('A small sentence with some words', 'small');
solve('Find the hidden word', 'hidden')