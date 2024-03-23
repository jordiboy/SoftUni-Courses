function solve() {

    let textElement = document.getElementById('text').value;
    const conventionElement = document.getElementById('naming-convention').value;
    const resultElement = document.getElementById('result');

    textElement = textElement.toLowerCase().split(' ');    

    switch (conventionElement) {
        case 'Camel Case':
            resultElement.textContent = convertToCamelCase(textElement);
            break;
        case 'Pascal Case':
            resultElement.textContent = convertToPascalCase(textElement);
            break;    
        default:
            resultElement.textContent = 'Error!'
            break;
    }

    function convertToCamelCase(textElement) {
        for (let i = 1; i < textElement.length; i++) {
            textElement[i] = textElement[i].charAt(0).toUpperCase()+ textElement[i].slice(1);            
        }

        return textElement.join('');
    }

    function convertToPascalCase(textElement) {
        for (let i = 0; i < textElement.length; i++) {
            textElement[i] = textElement[i].charAt(0).toUpperCase()+ textElement[i].slice(1);            
        }

        return textElement.join('');
    }
}