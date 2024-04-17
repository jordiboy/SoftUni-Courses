window.addEventListener("load", solve);

function solve() {
  const addButon = document.getElementById("add-btn");
  const previewListElement = document.getElementById("preview-list");
  const deleteButton = document.querySelector(".delete");
  const typeInputElement = document.getElementById("expense");
  const amountInputElement = document.getElementById("amount");
  const dateInputElement = document.getElementById("date");
  const expensesListElement = document.getElementById("expenses-list");

  addButon.addEventListener("click", () => {
    if (
      typeInputElement.value === "" ||
      amountInputElement.value === "" ||
      dateInputElement.value === ""
    ) {
      return;
    }
    createElement();
    clearInputs();

    addButon.disabled = true;
  });

  deleteButton.addEventListener("click", () => {
    //location.reload();
    expensesListElement.innerHTML = "";
  });

  function createElement() {
    const editButton = document.createElement("button");
    editButton.classList.add("btn");
    editButton.classList.add("edit");
    editButton.textContent = "Edit";

    editButton.addEventListener("click", () => {
      typeInputElement.value = pTypeElement.textContent.split(": ").pop();
      amountInputElement.value = pAmountElement.textContent.match(/[0-9]+/g);
      dateInputElement.value = pDateElement.textContent.split(": ").pop();

      liElement.remove();
      addButon.disabled = false;
    });

    const okButton = document.createElement("button");
    okButton.classList.add("btn");
    okButton.classList.add("ok");
    okButton.textContent = "Ok";

    okButton.addEventListener("click", () => {
      divButtonsElement.remove();
      expensesListElement.appendChild(liElement);
      addButon.disabled = false;
    });

    const divButtonsElement = document.createElement("div");
    divButtonsElement.classList.add("buttons");
    divButtonsElement.appendChild(editButton);
    divButtonsElement.appendChild(okButton);

    pTypeElement = document.createElement("p");
    pTypeElement.textContent = `Type: ${typeInputElement.value}`;

    pAmountElement = document.createElement("p");
    pAmountElement.textContent = `Amount: ${amountInputElement.value}$`;

    pDateElement = document.createElement("p");
    pDateElement.textContent = `Date: ${dateInputElement.value}`;

    const articleElement = document.createElement("article");
    articleElement.appendChild(pTypeElement);
    articleElement.appendChild(pAmountElement);
    articleElement.appendChild(pDateElement);

    const liElement = document.createElement("li");
    liElement.classList.add("expense-item");
    liElement.appendChild(articleElement);
    liElement.appendChild(divButtonsElement);

    previewListElement.appendChild(liElement);
  }

  function clearInputs() {
    typeInputElement.value = "";
    amountInputElement.value = "";
    dateInputElement.value = "";
  }
}
