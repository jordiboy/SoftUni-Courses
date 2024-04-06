function solve(input) {
    let message = input.shift();
    let result = message;
    
    for (let i = 0; i < input.length; i++) {
        const command = input[i].split('?').shift();

        switch (command) {
            case 'TakeEven':
                result = getEven(result);          
                break;            
        }
        
        function getEven(message) {
            temp = '';              
                for (let i = 0; i < message.length; i += 2) {            
                    temp += message[i];
                }

            return temp;
        }
    }

    console.log(result)
    
}

solve(["z2tdsfndoctsB6z7tjc8ojzdngzhtjsyVjek!snfzsafhscs", 
"TakeEven",
"Reverse?!nzahc",
"ChangeAll?m?g",
"Reverse?adshk",
"ChangeAll?z?i",
"Buy"])