function solve(number) {

    let num = number.toString();
    let sum = 0;
    let isEqual = true;

    for (let i = 0; i < num.length; i++) {
        
        if (num[i] !== num[0]) {
            isEqual = false;
        }
        sum += parseInt(num[i]);

    }    
    
    if (isEqual) {
        console.log('true');
    } else {
        console.log('false');        
    }

    console.log(sum);
}

solve(2222222);