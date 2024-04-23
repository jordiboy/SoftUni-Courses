function solve(input) {
  let word = input.shift();
  let result = word;

  let row = input.shift();

  while (row !== "End") {
    let [command, ...args] = row.split("!");

    switch (command) {
      case "RemoveEven":
        result = getEven(result);
        console.log(result);
        break;
      case "TakePart":
        result = result.substring(args[0], args[1]);
        console.log(result);
        break;
      case "Reverse":
        if (result.includes(args[0])) {
          result = reverse(result, args[0]);
          console.log(result);
        } else {
          console.log("Error");
        }
        break;
    }
    row = input.shift();
  }

  console.log(`The concealed spell is: ${result}`);

  function getEven(result) {
    temp = "";
    for (let i = 0; i < result.length; i++) {
      if (i % 2 === 0) {
        temp += result[i];
      }
    }
    return temp;
  }

  function reverse(result, args) {
    const startIndex = result.indexOf(args);

    let reversed = "";

    for (let i = args.length - 1; i > -1; i--) {
      reversed += args[i];
    }

    result = result.replace(args, reversed);
    return result;
  }
}

solve([
  "asAsl2adkda2mdaczsa",
  "RemoveEven",
  "TakePart!1!9",
  "Reverse!maz",
  "End",
]);

solve([
  "hZwemtroiui5tfone1haGnanbvcaploL2u2a2n2i2m",
  "TakePart!31!42",
  "RemoveEven",
  "Reverse!anim",
  "Reverse!sad",
  "End",
]);
