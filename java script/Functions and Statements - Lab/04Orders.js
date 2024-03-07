function order(product, count) {

    const result = cost(product, count);
    console.log(result.toFixed(2));

    function cost(product, count) {
    
        switch (product) {
            case 'coffee':            
                return 1.5 * count;
            case 'water':            
                return 1 * count;
            case 'coke':            
                return 1.4 * count;
            case 'snacks':            
                return 2 * count;        
        }
    }
}

order("water", 5);