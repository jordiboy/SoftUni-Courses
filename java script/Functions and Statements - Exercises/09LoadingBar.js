function solve(progress) {

    const progressBar = progress => `[${'%'.repeat(progress / 10)}${'.'.repeat(10 - progress / 10)}]`;

    console.log(`${progress}% ${progressBar(progress)}`);

    if (progress === 100) {
        console.log('Complete!');
    } else {
        console.log('Still loading...')
    }
}

solve(30)
solve(100);