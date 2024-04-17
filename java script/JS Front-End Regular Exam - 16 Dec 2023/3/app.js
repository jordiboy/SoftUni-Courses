const baseUrl = "http://localhost:3030/jsonstore/tasks";
const loadMealsButton = document.getElementById("load-meals");
const addMealButton = document.getElementById("add-meal");
const editMealButton = document.getElementById("edit-meal");
const foodInputElement = document.getElementById("food");
const caloriesInputElement = document.getElementById("calories");
const timeInputElement = document.getElementById("time");
const listElement = document.getElementById("list");
let currId = null;
loadMealsButton.addEventListener("click", () => {
  getElements(baseUrl);
});

addMealButton.addEventListener("click", async () => {
  await fetch(baseUrl, {
    method: "POST",
    headers: { "Content-type": "application/json" },
    body: JSON.stringify({
      food: foodInputElement.value,
      calories: caloriesInputElement.value,
      time: timeInputElement.value,
    }),
  });
  clearInputs();
  getElements(baseUrl);
});

editMealButton.addEventListener("click", async () => {
  fetch(`${baseUrl}/${currId}`, {
    method: "PUT",
    headers: { "Content-type": "application/json" },
    body: JSON.stringify({
      food: foodInputElement.value,
      calories: caloriesInputElement.value,
      time: timeInputElement.value,
      _id: currId,
    }),
  });

  clearInputs();

  editMealButton.disabled = true;
  addMealButton.disabled = false;

  getElements(baseUrl);
});

async function getElements(baseUrl) {
  const response = await fetch(baseUrl);
  const meals = await response.json();

  listElement.innerHTML = "";

  for (const meal of Object.values(meals)) {
    const changeButton = document.createElement("button");
    changeButton.classList.add("change-meal");
    changeButton.textContent = "Change";

    changeButton.addEventListener("click", () => {
      foodInputElement.value = meal.food;
      caloriesInputElement.value = meal.calories;
      timeInputElement.value = meal.time;
      currId = meal._id;

      divMealElement.remove();

      editMealButton.disabled = false;
      addMealButton.disabled = true;
    });

    const deleteButton = document.createElement("button");
    deleteButton.classList.add("delete-meal");
    deleteButton.textContent = "delete";

    deleteButton.addEventListener("click", async () => {
      await fetch(`${baseUrl}/${meal._id}`, {
        method: "DELETE",
      });
      getElements(baseUrl);
    });

    const divButtonsElement = document.createElement("div");
    divButtonsElement.classList.add("meal-buttons");
    divButtonsElement.appendChild(changeButton);
    divButtonsElement.appendChild(deleteButton);

    const h2FoodElement = document.createElement("h2");
    h2FoodElement.textContent = meal.food;

    const h3CaloriesElement = document.createElement("h3");
    h3CaloriesElement.textContent = meal.calories;

    const h3TimeElement = document.createElement("h3");
    h3TimeElement.textContent = meal.time;

    const divMealElement = document.createElement("div");
    divMealElement.classList.add("meal");

    divMealElement.appendChild(h2FoodElement);
    divMealElement.appendChild(h3CaloriesElement);
    divMealElement.appendChild(h3TimeElement);
    divMealElement.appendChild(divButtonsElement);

    listElement.appendChild(divMealElement);
  }
}

function clearInputs() {
  foodInputElement.value = "";
  caloriesInputElement.value = "";
  timeInputElement.value = "";
}
