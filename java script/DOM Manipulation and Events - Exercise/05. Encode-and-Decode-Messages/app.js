function encodeAndDecodeMessages() {
    let encodeTextareaElement = document.querySelector('div:nth-child(1) textarea');
    const encodeButton = document.querySelector('div:nth-child(1) button');
    let decodeTextareaElement = document.querySelector('div:nth-child(2) textarea');
    const decodeButton = document.querySelector('div:nth-child(2) button');    

    encodeButton.addEventListener('click', (e) => {
        const inputText = encodeTextareaElement.value;
        let encodedText = ''; 

        for (let i = 0; i < inputText.length; i++) {
            encodedText += String.fromCharCode(inputText[i].charCodeAt(0) + 1);            
        }
        
        decodeTextareaElement.value = encodedText;
        encodeTextareaElement.value = '';
    })

    decodeButton.addEventListener('click', (e) => {

        const textToDecode = decodeTextareaElement.value;
        let decodedText = '';

        for (let i = 0; i < textToDecode.length; i++) {
            decodedText += String.fromCharCode(textToDecode[i].charCodeAt(0) - 1);            
        }

        decodeTextareaElement.value = decodedText;
    })
}