function solve(input) {
  const countAstronauts = input.shift();

  const astronauts = [];

  for (let i = 0; i < countAstronauts; i++) {
    const [name, oxigen, energy] = input[i].split(" ");
    //input.shift();
    const astronautsObj = {
      name,
      oxygen: Number(oxigen),
      energy: Number(energy),
    };
    astronauts.push(astronautsObj);
  }

  let row = input.shift();
  let [command, astronaut, amount] = row.split(" - ");

  while (command !== "End") {
    amount = Number(amount);
    const currentAstronaut = astronauts.find((a) => a.name === astronaut);

    switch (command) {
      case "Explore":
        if (
          currentAstronaut.name === astronaut &&
          currentAstronaut.energy >= amount
        ) {
          currentAstronaut.energy -= amount;
          console.log(
            `${astronaut} has successfully explored a new area and now has ${currentAstronaut.energy} energy!`
          );
        }
        break;
      case "Refuel":
        if (
          currentAstronaut.name === astronaut &&
          currentAstronaut.energy + amount < 200
        ) {
          currentAstronaut.energy += amount;
          console.log(`${astronaut} refueled their energy by ${amount}!`);
        } else {
          console.log(
            `${astronaut} refueled their energy by ${
              200 - currentAstronaut.energy
            }!`
          );
          currentAstronaut.energy = 200;
        }
        break;
      case "Breathe":
        if (
          currentAstronaut.name === astronaut &&
          currentAstronaut.oxygen + amount < 100
        ) {
          currentAstronaut.oxygen += amount;
          console.log(
            `${astronaut} took a breath and recovered ${amount} oxygen!`
          );
        } else {
          console.log(
            `${astronaut} took a breath and recovered ${Math.abs(
              100 - currentAstronaut.oxygen
            )} oxygen!`
          );
          currentAstronaut.oxygen = 100;
        }
        break;
    }
    row = input.shift();
    [command, astronaut, amount] = row.split(" - ");
  }

  for (const astronaut of astronauts) {
    console.log(
      `Astronaut: ${astronaut.name}, Oxygen: ${astronaut.oxygen}, Energy: ${astronaut.energy}`
    );
  }
}

solve([
  "4",
  "Alice 60 100",
  "Bob 40 80",
  "Charlie 70 150",
  "Dave 80 180",
  "Explore - Bob - 60",
  "Refuel - Alice - 30",
  "Breathe - Charlie - 50",
  "Refuel - Dave - 40",
  "Explore - Bob - 40",
  "Breathe - Charlie - 30",
  "Explore - Alice - 40",
  "End",
]);
