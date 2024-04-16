const baseUrl = "http://localhost:3030/jsonstore/games/";
const gameListElement = document.getElementById("games-list");
const loadGamesButton = document.getElementById("load-games");
const addGameButton = document.getElementById("add-game");
const editButton = document.getElementById("edit-game");
const nameInputElement = document.getElementById("g-name");
const typeInputElement = document.getElementById("type");
const playersInputElement = document.getElementById("players");

loadGamesButton.addEventListener("click", (e) => {
  getElements(baseUrl);
});

addGameButton.addEventListener("click", (e) => {
  fetch(baseUrl, {
    method: "post",
    headers: { "Content-type": "application/json" },
    body: JSON.stringify({
      name: nameInputElement.value,
      type: typeInputElement.value,
      players: playersInputElement.value,
    }),
  }).then((res) => {
    if (!res.ok) {
      return;
    }
    clearInputs();
    getElements(baseUrl);
  });
  //clearInputs();
  //getElements(baseUrl);
});

let currId = "";

editButton.addEventListener("click", (e) => {
  fetch(`${baseUrl}/${currId}`, {
    method: "put",
    headers: { "Content-type": "application/json" },
    body: JSON.stringify({
      name: nameInputElement.value,
      type: typeInputElement.value,
      players: playersInputElement.value,
    }),
  }).then((res) => {
    if (!res.ok) {
      return;
    }
    clearInputs();
    getElements(baseUrl);
  });
  editButton.disabled = true;
  addGameButton.disabled = false;
});
function createElements(games) {
  gameListElement.innerHTML = "";
  for (const item in games) {
    const pNameElement = document.createElement("p");
    pNameElement.textContent = games[item].name;

    const pTypeElement = document.createElement("p");
    pTypeElement.textContent = games[item].type;

    const pPlayersElement = document.createElement("p");
    pPlayersElement.textContent = games[item].players;

    const divContentElement = document.createElement("div");
    divContentElement.classList.add("content");
    divContentElement.appendChild(pNameElement);
    divContentElement.appendChild(pTypeElement);
    divContentElement.appendChild(pPlayersElement);

    const changeBtn = document.createElement("button");
    changeBtn.classList.add("change-btn");
    changeBtn.textContent = "Change";

    changeBtn.addEventListener("click", (e) => {
      nameInputElement.value = games[item].name;
      typeInputElement.value = games[item].type;
      playersInputElement.value = games[item].players;

      currId = games[item]._id;

      boardGameElement.remove();

      editButton.disabled = false;
      addGameButton.disabled = true;
    });

    const deleteBtn = document.createElement("button");
    deleteBtn.classList.add("delete-btn");
    deleteBtn.textContent = "Delete";

    deleteBtn.addEventListener("click", (e) => {
      fetch(`${baseUrl}/${boardGameElement.getAttribute("data-id")}`, {
        method: "delete",
      }).then((res) => {
        if (!res.ok) {
          return;
        }
        clearInputs();
        getElements(baseUrl);
      });

      //boardGameElement.remove();
      //getElements(baseUrl);
    });

    const divButtonsElement = document.createElement("div");
    divButtonsElement.classList.add("buttons-container");
    divButtonsElement.appendChild(changeBtn);
    divButtonsElement.appendChild(deleteBtn);

    const boardGameElement = document.createElement("div");
    boardGameElement.classList.add("board-game");
    boardGameElement.setAttribute("data-id", games[item]._id);
    boardGameElement.appendChild(divContentElement);
    boardGameElement.appendChild(divButtonsElement);

    gameListElement.appendChild(boardGameElement);
  }
}

function clearInputs() {
  nameInputElement.value = "";
  typeInputElement.value = "";
  playersInputElement.value = "";
}
function getElements(baseUrl) {
  fetch(baseUrl)
    .then((response) => response.json())
    .then((games) => createElements(games))
    .catch((error) => console.error(error));
}
