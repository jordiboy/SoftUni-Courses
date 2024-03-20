function sumTable() {

    const numbersElements = document.querySelectorAll('td:nth-child(even):not(#sum)');
    const resultElement = document.getElementById('sum');

    let sum = 0;

    for (const element of numbersElements) {
        sum += Number(element.textContent);
    }
    
    resultElement.textContent = sum;
}