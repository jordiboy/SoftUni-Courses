function solve(input) {
  const playersNumber = input.shift();

  const players = [];

  for (let i = 0; i < playersNumber; i++) {
    const [name, hp, bullets] = input[i].split(" ");
    playersObj = {
      name,
      hp: Number(hp),
      bullets: Number(bullets),
    };
    players.push(playersObj);
  }

  let row = input.shift();
  let [command, name, arg1, arg2] = row.split(" - ");

  while (command !== "Ride Off Into Sunset") {
    const currenPlayer = players.find((a) => a.name === name);

    if (command === "FireShot") {
      if (currenPlayer.bullets > 0) {
        currenPlayer.bullets -= 1;
        console.log(
          `${name} has successfully hit ${arg1} and now has ${currenPlayer.bullets} bullets!`
        );
      } else {
        console.log(`${name} doesn't have enough bullets to shoot at ${arg1}!`);
      }
    } else if (command === "TakeHit") {
      currenPlayer.hp -= Number(arg1);
      if (currenPlayer.hp > 0) {
        console.log(
          `${name} took a hit for ${arg1} HP from ${arg2} and now has ${currenPlayer.hp} HP!`
        );
      } else {
        const playerIndex = players.indexOf(currenPlayer);
        players.splice(playerIndex, 1);
        console.log(`${name} was gunned down by ${arg2}!`);
      }
    } else if (command === "Reload") {
      if (currenPlayer.bullets < 6) {
        console.log(`${name} reloaded ${6 - currenPlayer.bullets} bullets!`);
        currenPlayer.bullets = 6;
      } else {
        console.log(`${name}'s pistol is fully loaded!`);
      }
    } else if (command === "PatchUp") {
      if (currenPlayer.hp + Number(arg1) > 100) {
        console.log(`${name} is in full health!`);
      } else {
        currenPlayer.hp += Number(arg1);
        console.log(`${name} patched up and recovered ${arg1} HP!`);
      }
    }
    row = input.shift();
    [command, name, arg1, arg2] = row.split(" - ");
  }

  for (const player of players) {
    console.log(player.name);
    console.log(` HP: ${player.hp}`);
    console.log(` Bullets: ${player.bullets}`);
  }
}
solve([
  "2",
  "Gus 100 0",
  "Walt 100 6",
  "TakeHit - Gus - 80 - Bandit",
  "PatchUp - Gus - 20",
  "Ride Off Into Sunset",
]);
