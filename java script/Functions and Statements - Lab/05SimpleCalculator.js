function calculator(num1, num2, operator) {

    const calculation = getCalculation(operator);
    const result = calculation(num1, num2);
    
    console.log(result);

    function getCalculation(operator) {
    
        switch (operator) {
            case 'multiply':            
                return (num1, num2) => num1 * num2;
            case 'divide':            
                return (num1, num2) => num1 / num2;
            case 'add':            
                return (num1, num2) => num1 + num2;
            case 'subtract':            
                return (num1, num2) => num1 - num2;        
        }
    }
}

calculator(5, 5, 'multiply');