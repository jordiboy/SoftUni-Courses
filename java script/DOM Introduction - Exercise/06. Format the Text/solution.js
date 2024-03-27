function solve() {
    const inputElement = document.getElementById('input').value;
    const outputElement = document.getElementById('output');

    const textArray = inputElement.split('.');
    let result = '';
    console.log(textArray);
    let counter = 0;
    if (textArray.length > 0) {
        for (let i = 0; i < textArray.length; i++) {
        
            if (counter === 0) {
                result += '<p>'
            }
            if (counter < 3) {
                result += `${textArray[i]}.`;
                counter++;
            } else {
                result += '</p>'
                counter = 0;
                i--;               
            }
        }
    }
    outputElement.innerHTML = result.slice(0, result.length - 1).trim();
}