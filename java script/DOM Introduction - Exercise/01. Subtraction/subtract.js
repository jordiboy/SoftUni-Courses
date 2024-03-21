function subtract() {
    const num1Element = document.getElementById('firstNumber');
    const num2Element = document.getElementById('secondNumber');
    const resultElement = document.getElementById('result');

    const result = Number(num1Element.value - num2Element.value);
    resultElement.textContent = result;

    console.log(result);
}