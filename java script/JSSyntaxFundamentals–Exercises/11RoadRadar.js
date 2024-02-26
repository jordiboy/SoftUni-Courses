function solve(kmPerHour, zone) {

    speedLimit = 0;

    switch (zone) {
        case 'motorway': speedLimit = 130; break;
        case 'interstate': speedLimit = 90; break;
        case 'city': speedLimit = 50; break;
        case 'residential': speedLimit = 20; break;        
    }

    if (kmPerHour <= speedLimit) {

        console.log(`Driving ${kmPerHour} km/h in a ${speedLimit} zone`);

    } else {

        let differece = kmPerHour - speedLimit;
        let status = '';

        if (differece <= 20) {
            status = 'speeding';
        } else if (differece <= 40) {
            status = 'excessive speeding';
        } else {
            status = 'reckless driving';
        }

        console.log(`The speed is ${differece} km/h faster than the allowed speed of ${speedLimit} - ${status}`)
    }
}

solve(21, 'residential')