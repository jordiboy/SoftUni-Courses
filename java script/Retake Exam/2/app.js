window.addEventListener("load", solve);

function solve() {
  const adoptButton = document.getElementById("adopt-btn");
  const typeInputElement = document.getElementById("type");
  const ageInputElement = document.getElementById("age");
  const genderInputElement = document.getElementById("gender");
  const ulElement = document.getElementById("adoption-info");
  const adoptedElement = document.getElementById("adopted-list");

  adoptButton.addEventListener("click", (e) => {
    if (
      typeInputElement.value === "" ||
      ageInputElement.value === "" ||
      genderInputElement.value === ""
    ) {
      return;
    }
    createAnimal();
    clearInputs();
  });

  function createAnimal() {
    const pPetElement = document.createElement("p");
    pPetElement.textContent = `Pet:${typeInputElement.value}`;

    const pGenderElement = document.createElement("p");
    pGenderElement.textContent = `Gender:${genderInputElement.value}`;

    const pAgeElement = document.createElement("p");
    pAgeElement.textContent = `Age:${ageInputElement.value}`;

    const articleElement = document.createElement("article");
    articleElement.appendChild(pPetElement);
    articleElement.appendChild(pGenderElement);
    articleElement.appendChild(pAgeElement);

    const editButton = document.createElement("button");
    editButton.classList.add("edit-btn");
    editButton.textContent = "Edit";

    editButton.addEventListener("click", (e) => {
      typeInputElement.value = pPetElement.split(":").pop();
      ageInputElement.value = pGenderElement.split(":").pop();
      genderInputElement.value = pAgeElement.split(":").pop();

      liElement.remove();
    });

    const doneButton = document.createElement("button");
    doneButton.classList.add("done-btn");
    doneButton.textContent = "Done";

    doneButton.addEventListener("click", (e) => {
      divElement.remove();

      const clearButton = document.createElement("button");
      clearButton.classList.add("clear-btn");
      clearButton.textContent = "Clear";

      clearButton.addEventListener("click", (e) => {
        liElement.remove();
      });

      liElement.appendChild(clearButton);

      adoptedElement.appendChild(liElement);
    });

    const divElement = document.createElement("div");
    divElement.classList.add("buttons");
    divElement.appendChild(editButton);
    divElement.appendChild(doneButton);

    const liElement = document.createElement("li");
    liElement.appendChild(articleElement);
    liElement.appendChild(divElement);

    ulElement.appendChild(liElement);
  }

  function clearInputs() {
    typeInputElement.value = "";
    ageInputElement.value = "";
    genderInputElement.value = "";
  }
}
