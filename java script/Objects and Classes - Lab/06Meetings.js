function solve(input) {

    let meetengs = {};

    for (const line of input) {
        const [weekday, name] = line.split(' ');

        if (meetengs[weekday]) {
            console.log(`Conflict on ${weekday}!`)
        } else {
            meetengs[weekday] = name;
            console.log(`Scheduled for ${weekday}`)
        }
    }

    for (const weekday in meetengs) {
        console.log(`${weekday} -> ${meetengs[weekday]}`)
    }
}

solve(['Friday Bob',
'Saturday Ted',
'Monday Bill',
'Monday John',
'Wednesday George']);