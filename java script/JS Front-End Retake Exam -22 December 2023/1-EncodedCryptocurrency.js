function solve(input) {
    let message = input.shift();
    let result = message;
    
    for (let i = 0; i < input.length; i++) {
        const tokens = input[i].split('?');
        const command = tokens.shift();
                
        switch (command) {
            case 'TakeEven':
                result = getEven(result);
                console.log(result);
                break;
            case 'ChangeAll':
                result = changeAll(result, tokens);
                console.log(result);
                break;
            case 'Reverse':
                if (result.includes(tokens[0])) {
                    result = reverse(result, tokens);
                console.log(result);
                } else {
                    console.log('error');
                }                
                break;
        }        
    }
    console.log(`The cryptocurrency is: ${result}`);

    function getEven(message) {
        temp = '';              
            for (let i = 0; i < message.length; i += 2) {            
                temp += message[i];
            }

        return temp;
    }

    function changeAll(result, tokens) {
        for (let i = 0; i < result.length; i++) {
            if (result[i] === tokens[0]) {
                result = result.replace(tokens[0], tokens[1]);
            }            
        }
        return result;
    }

    function reverse(result, tokens) {
        const startIndex = result.indexOf(tokens);
        
        let reversed = '';

        for (let i = tokens[0].length - 1; i > -1; i--) {
            reversed += tokens[0][i];            
        }

        result = result.replace(tokens[0], reversed);
        return result;
    }
}

solve(["z2tdsfndoctsB6z7tjc8ojzdngzhtjsyVjek!snfzsafhscs", 
"TakeEven",
"Reverse?!nzahc",
"ChangeAll?m?g",
"Reverse?adshk",
"ChangeAll?z?i",
"Buy"]);

solve(["PZDfA2PkAsakhnefZ7aZ", 
"TakeEven",
"TakeEven",
"TakeEven",
"ChangeAll?Z?X",
"ChangeAll?A?R",
"Reverse?PRX",
"Buy"]);
