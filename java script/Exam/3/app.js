const baseUrl = "http://localhost:3030/jsonstore/games/";
const gameListElement = document.getElementById("games-list");
const loadGamesButton = document.getElementById("load-games");
const addGameButton = document.getElementById("add-game");
const editButton = document.getElementById("edit-game");
const nameInputElement = document.getElementById("g-name");
const typeInputElement = document.getElementById("type");
const playersInputElement = document.getElementById("players");

let currId = null;

loadGamesButton.addEventListener("click", () => {
  getElements(baseUrl);
});

addGameButton.addEventListener("click", async () => {
  await fetch(baseUrl, {
    method: "POST",
    headers: { "Content-type": "application/json" },
    body: JSON.stringify({
      name: nameInputElement.value,
      type: typeInputElement.value,
      players: playersInputElement.value,
    }),
  });
  clearInputs();
  getElements(baseUrl);
});

editButton.addEventListener("click", async () => {
  await fetch(`${baseUrl}/${currId}`, {
    method: "PUT",
    headers: { "Content-type": "application/json" },
    body: JSON.stringify({
      name: nameInputElement.value,
      type: typeInputElement.value,
      players: playersInputElement.value,
      _id: currId,
    }),
  });

  clearInputs();

  editButton.disabled = true;
  addGameButton.disabled = false;

  getElements(baseUrl);
});

async function getElements(baseUrl) {
  const response = await fetch(baseUrl);
  const games = await response.json();

  gameListElement.innerHTML = "";

  for (const game of Object.values(games)) {
    const pNameElement = document.createElement("p");
    pNameElement.textContent = game.name;

    const pTypeElement = document.createElement("p");
    pTypeElement.textContent = game.type;

    const pPlayersElement = document.createElement("p");
    pPlayersElement.textContent = game.players;

    const divContentElement = document.createElement("div");
    divContentElement.classList.add("content");
    divContentElement.appendChild(pNameElement);
    divContentElement.appendChild(pTypeElement);
    divContentElement.appendChild(pPlayersElement);

    const changeButton = document.createElement("button");
    changeButton.classList.add("change-btn");
    changeButton.textContent = "Change";

    changeButton.addEventListener("click", () => {
      nameInputElement.value = game.name;
      typeInputElement.value = game.type;
      playersInputElement.value = game.players;
      currId = game._id;

      divBoardGameElement.remove();

      editButton.disabled = false;
      addGameButton.disabled = true;
    });

    const deleteButton = document.createElement("button");
    deleteButton.classList.add("delete-btn");
    deleteButton.textContent = "Delete";

    deleteButton.addEventListener("click", async () => {
      await fetch(`${baseUrl}/${game._id}`, {
        method: "DELETE",
      });
      getElements(baseUrl);
    });

    const divButtonsElement = document.createElement("div");
    divButtonsElement.classList.add("buttons-container");
    divButtonsElement.appendChild(changeButton);
    divButtonsElement.appendChild(deleteButton);

    const divBoardGameElement = document.createElement("div");
    divBoardGameElement.classList.add("board-game");
    divBoardGameElement.appendChild(divContentElement);
    divBoardGameElement.appendChild(divButtonsElement);

    gameListElement.appendChild(divBoardGameElement);
  }
}

function clearInputs() {
  nameInputElement.value = "";
  typeInputElement.value = "";
  playersInputElement.value = "";
}
