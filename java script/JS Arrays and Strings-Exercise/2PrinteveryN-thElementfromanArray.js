function solve(array, number) {
    
    resultArray = [];    

    for (let i = 0; i < array.length; i += number) {
                
        resultArray.push(array[i]);           
    }   
    
    return resultArray;
}

solve(['5', '20', '31', '4', '20'], 2);
solve(['1', '2', '3', '4', '5'], 6);