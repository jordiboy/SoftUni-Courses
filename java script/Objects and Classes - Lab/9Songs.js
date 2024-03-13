class Song {
    constructor(type, name, time) {
        this.type = type;
        this.name = name;
        this.time = time;
    }
}

function solve(input) {

    const songs = [];
    const songsCount = input.shift();
    const songType = input.pop();
        
    for (let i = 0; i < songsCount; i++) {
        const [type, name, time] = input[i].split('_');        
        songs.push(new Song(type, name, time));        
    }

    if (songType === 'all') {
        songs.forEach(song => console.log(song.name));
    } else {
        const filtered = songs.filter(song => song.type === songType);
        filtered.forEach(song => console.log(song.name));
    }
}

solve([3, 'favourite_DownTown_3:14', 'favourite_Kiss_4:16', 'favourite_Smooth Criminal_4:01', 'favourite']);