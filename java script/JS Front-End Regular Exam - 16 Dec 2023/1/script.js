function solve(input) {
  const count = input.shift();

  const baristas = {};

  for (let i = 0; i < count; i++) {
    const [name, shift, coffetypes] = input[i].split(" ");
    baristas[name] = {
      shift,
      coffetypes: coffetypes.split(","),
    };
  }

  let row = input.shift();

  while (row !== "Closed") {
    const [command, name, ...args] = row.split(" / ");
    const barista = baristas[name];

    if (command === "Prepare") {
      const shift = args[0];
      const coffeeType = args[1];
      if (barista.shift === shift && barista.coffetypes.includes(coffeeType)) {
        console.log(`${name} has prepared a ${coffeeType} for you!`);
      } else {
        console.log(`${name} is not available to prepare a ${coffeeType}.`);
      }
    } else if (command === "Change Shift") {
      const shift = args[0];
      barista.shift = shift;
      console.log(`${name} has updated his shift to: ${shift}`);
    } else if (command === "Learn") {
      const coffeeType = args[0];
      if (barista.coffetypes.includes(coffeeType)) {
        console.log(`${name} knows how to make ${coffeeType}.`);
      } else {
        barista.coffetypes.push(coffeeType);
        console.log(`${name} has learned a new coffee type: ${coffeeType}.`);
      }
    }
    row = input.shift();
  }

  for (const barista in baristas) {
    console.log(
      `Barista: ${barista}, Shift: ${
        baristas[barista].shift
      }, Drinks: ${baristas[barista].coffetypes.join(", ")}`
    );
  }
}

solve([
  "3",
  "Alice day Espresso,Cappuccino",
  "Bob night Latte,Mocha",
  "Carol day Americano,Mocha",
  "Prepare / Alice / day / Espresso",
  "Change Shift / Bob / night",
  "Learn / Carol / Latte",
  "Learn / Bob / Latte",
  "Prepare / Bob / night / Latte",
  "Closed",
]);
