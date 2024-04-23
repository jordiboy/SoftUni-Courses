const baseUrl = "http://localhost:3030/jsonstore/records";
const loadButton = document.getElementById("load-records");
const listElement = document.getElementById("list");
const addButton = document.getElementById("add-record");
const nameInputElement = document.getElementById("p-name");
const stepsInputElement = document.getElementById("steps");
const caloriesInputElement = document.getElementById("calories");
const editButton = document.getElementById("edit-record");

let currId = null;

loadButton.addEventListener("click", () => {
  getElements(baseUrl);
});

addButton.addEventListener("click", async () => {
  await fetch(baseUrl, {
    method: "POST",
    headers: { "Content-type": "application/json" },
    body: JSON.stringify({
      name: nameInputElement.value,
      steps: stepsInputElement.value,
      calories: caloriesInputElement.value,
    }),
  });

  clearInputs();
  getElements(baseUrl);
});

editButton.addEventListener("click", async () => {
  fetch(`${baseUrl}/${currId}`, {
    method: "PUT",
    headers: { "Content-type": "application/json" },
    body: JSON.stringify({
      name: nameInputElement.value,
      steps: stepsInputElement.value,
      calories: caloriesInputElement.value,
      _id: currId,
    }),
  });

  clearInputs();

  editButton.disabled = true;
  addButton.disabled = false;

  getElements(baseUrl);
});

async function getElements(baseUrl) {
  const response = await fetch(baseUrl);
  const records = await response.json();

  listElement.innerHTML = "";

  for (const record of Object.values(records)) {
    const pNameElement = document.createElement("p");
    pNameElement.textContent = record.name;

    const pStepsElement = document.createElement("p");
    pStepsElement.textContent = record.steps;

    const pCaloriesElement = document.createElement("p");
    pCaloriesElement.textContent = record.calories;

    const divInfoElement = document.createElement("div");
    divInfoElement.classList.add("info");
    divInfoElement.appendChild(pNameElement);
    divInfoElement.appendChild(pStepsElement);
    divInfoElement.appendChild(pCaloriesElement);

    const changeButton = document.createElement("button");
    changeButton.classList.add("change-btn");
    changeButton.textContent = "Change";

    changeButton.addEventListener("click", () => {
      nameInputElement.value = record.name;
      stepsInputElement.value = record.steps;
      caloriesInputElement.value = record.calories;
      currId = record._id;

      liRecordElement.remove();

      editButton.disabled = false;
      addButton.disabled = true;
    });

    const deleteButton = document.createElement("button");
    deleteButton.classList.add("delete-btn");
    deleteButton.textContent = "Delete";

    deleteButton.addEventListener("click", async () => {
      await fetch(`${baseUrl}/${record._id}`, {
        method: "DELETE",
      });
      getElements(baseUrl);
    });

    const divButtonsElement = document.createElement("div");
    divButtonsElement.classList.add("btn-wrapper");
    divButtonsElement.appendChild(changeButton);
    divButtonsElement.appendChild(deleteButton);

    const liRecordElement = document.createElement("li");
    liRecordElement.classList.add("record");
    liRecordElement.appendChild(divInfoElement);
    liRecordElement.appendChild(divButtonsElement);

    listElement.appendChild(liRecordElement);
  }
}

function clearInputs() {
  nameInputElement.value = "";
  stepsInputElement.value = "";
  caloriesInputElement.value = "";
}
