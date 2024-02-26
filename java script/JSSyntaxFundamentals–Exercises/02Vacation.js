function solve(count, group, dayOfWeek) {

    let price = 0;
    
    if (group === 'Students') {

        switch (dayOfWeek) {
            case 'Friday': price = 8.45; break;
            case 'Saturday': price = 9.8; break;
            case 'Sunday': price = 10.46; break;
                        
        }
        
        if (count >= 30) {
            price -= price * 0.15;   
        }

    } else if (group === 'Business') {

        switch (dayOfWeek) {
            case 'Friday': price = 10.9; break;
            case 'Saturday': price = 15.6; break;
            case 'Sunday': price = 16; break;            
        }

        if (count >= 100) {
            count -= 10;
        }

    } else if (group === 'Regular') {

        switch (dayOfWeek) {
            case 'Friday': price = 15; break;
            case 'Saturday': price = 20; break;
            case 'Sunday': price = 22.5; break;            
        }

        if (count >= 10 && count <= 20) {
            price -= price * 0.05;
        }

    }
        
    let result = price * count;    

    console.log(`Total price: ${result.toFixed(2)}`);
}

solve(30, "Students", "Sunday");