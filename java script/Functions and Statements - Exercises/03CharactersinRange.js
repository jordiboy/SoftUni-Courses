function solve(...chars) {
    
    const sortedChars = chars.sort();
    
    result = [];
    
    for (let i = chars[0].charCodeAt(0) + 1; i < chars[1].charCodeAt(0); i++) {
        result.push(String.fromCharCode(i));        
    }

    console.log(result.join(' '));
}

//solve('a', 'd');
solve('C', '#');