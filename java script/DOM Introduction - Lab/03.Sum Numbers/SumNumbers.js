function calc() {
    
    const num1Element = document.getElementById('num1');
    const num2Element = document.getElementById('num2');
    const sumElement = document.getElementById('sum');

    const number1 = Number(num1Element.value);
    const number2 = Number(num2Element.value);
    
    sumElement.value = number1 + number2;;
}
