function extractText() {
    
    const itemsElement = document.getElementById('items');
    const resultElement = document.getElementById('result');

    resultElement.value = itemsElement.textContent;
}