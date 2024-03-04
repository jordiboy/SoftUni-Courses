function solve(word, sentence) {
    let textArray = sentence.split(' ');
    let words = word.split(', ');

    for (let i = 0; i < textArray.length; i++) {
        
        if (textArray[i].includes('*')) {

            let length = textArray[i].length;
            let replaceWord = words.find(w => w.length === length)
            textArray.splice(i, 1, replaceWord);
        }
    }

    console.log(textArray.join(' '));
}

solve('great', 'softuni is ***** place for learning new programming languages')
solve('great, learning', 'softuni is ***** place for ******** new programming languages')