window.addEventListener("load", solve);

function solve() {
  const nameInputElement = document.getElementById("name");
  const phoneInputElement = document.getElementById("phone");
  const categoryInputElement = document.getElementById("category");
  const ulCheckListElement = document.getElementById("check-list");
  const contactListElement = document.getElementById("contact-list");
  const addButton = document.getElementById("add-btn");

  addButton.addEventListener("click", (e) => {
    if (
      nameInputElement.value === "" ||
      phoneInputElement.value === "" ||
      categoryInputElement.value === ""
    ) {
      return;
    }
    createElement();
    clearInputs();
  });

  function createElement() {
    const pNameElement = document.createElement("p");
    pNameElement.textContent = `name:${nameInputElement.value}`;

    const pPhoneElement = document.createElement("p");
    pPhoneElement.textContent = `phone:${phoneInputElement.value}`;

    const pCategoryElement = document.createElement("p");
    pCategoryElement.textContent = `category:${categoryInputElement.value}`;

    const articleElement = document.createElement("article");
    articleElement.appendChild(pNameElement);
    articleElement.appendChild(pPhoneElement);
    articleElement.appendChild(pCategoryElement);

    const editButton = document.createElement("button");
    editButton.classList.add("edit-btn");

    editButton.addEventListener("click", (e) => {
      const name = pNameElement.textContent.split(":");
      nameInputElement.value = name[1];

      const phone = pPhoneElement.textContent.split(":");
      phoneInputElement.value = phone[1];

      const category = pCategoryElement.textContent.split(":");
      categoryInputElement.value = category[1];

      liElement.remove();
    });

    const saveButton = document.createElement("button");
    saveButton.classList.add("save-btn");

    saveButton.addEventListener("click", (e) => {
      liElement.removeChild(divElement);

      const deleteButton = document.createElement("button");
      deleteButton.classList.add("del-btn");

      deleteButton.addEventListener("click", (e) => {
        liElement.remove();
      });

      liElement.appendChild(deleteButton);

      contactListElement.appendChild(liElement);
    });

    const divElement = document.createElement("div");
    divElement.classList.add("buttons");
    divElement.appendChild(editButton);
    divElement.appendChild(saveButton);

    const liElement = document.createElement("li");
    liElement.appendChild(articleElement);
    liElement.appendChild(divElement);

    ulCheckListElement.appendChild(liElement);
  }

  function clearInputs() {
    nameInputElement.value = "";
    phoneInputElement.value = "";
    categoryInputElement.value = "";
  }
}
