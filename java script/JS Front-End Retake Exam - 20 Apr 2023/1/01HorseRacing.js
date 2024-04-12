function solve(input) {
  let horses = input.shift().split("|");

  while (true) {
    const [command, horse1, horse2] = input.shift().split(" ");
    if (command === "Finish") {
      console.log(horses.join("->"));
      console.log(`The winner is: ${horses[horses.length - 1]}`);
      return;
    }
    if (command === "Retake") {
      if (horses.indexOf(horse1) < horses.indexOf(horse2)) {
        let h2Index = horses.indexOf(horse2);
        let temp = horses[horses.indexOf(horse1)];
        horses[horses.indexOf(horse1)] = horse2;
        horses[h2Index] = temp;
        console.log(`${horse1} retakes ${horse2}.`);
      }
    } else if (command === "Trouble") {
      if (horses.indexOf(horse1) > 0) {
        const horse1Index = horses.indexOf(horse1);
        let temp = horses[horses.indexOf(horse1) - 1];
        horses[horses.indexOf(horse1) - 1] = horses[horse1Index];
        horses[horse1Index] = temp;
        console.log(`Trouble for ${horse1} - drops one position.`);
      }
    } else if (command === "Rage") {
      if (horses.indexOf(horse1) === horses.length - 2) {
        const h1 = horses.pop();
        const h2 = horses.pop();
        horses.push(h1);
        horses.push(h2);
      } else if (horses.indexOf(horse1) < horses.length - 2) {
        const horse1Index = horses.indexOf(horse1);
        horses.splice(horse1Index, 1);
        horses.splice(horse1Index + 2, 0, horse1);
      }
      console.log(`${horse1} rages 2 positions ahead.`);
    } else if (command === "Miracle") {
      let temp = horses.shift();
      horses.push(temp);
      console.log(
        `What a miracle - ${horses[horses.length - 1]} becomes first.`
      );
    }
  }
}
solve([
  "Onyx|Domino|Sugar|Fiona",
  "Trouble Onyx",
  "Retake Onyx Sugar",
  "Rage Domino",
  "Miracle",
  "Finish",
]);

solve([
  "Bella|Alexia|Sugar",
  "Retake Alexia Sugar",
  "Rage Bella",
  "Trouble Bella",
  "Finish",
]);
