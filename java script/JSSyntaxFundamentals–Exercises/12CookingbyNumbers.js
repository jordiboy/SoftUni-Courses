function solve(el0, el1, el2, el3, el4, el5) {

    number = parseInt(el0);
    manipulations = [el1, el2, el3, el4, el5];

    for (let i = 0; i < manipulations.length; i++) {
        
        if (manipulations[i] === 'chop') {
            number /= 2; 
        } else if (manipulations[i] === 'dice'){
            number = Math.sqrt(number);
        } else if (manipulations[i] === 'spice') {
            number += 1;
        } else if (manipulations[i] === 'bake') {
            number *= 3;
        } else if (manipulations[i] === 'fillet') {
            number -= number * 0.2;
        }
        
        console.log(number);
    }
}

solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet')