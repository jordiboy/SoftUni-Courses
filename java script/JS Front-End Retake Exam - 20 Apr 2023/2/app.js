window.addEventListener("load", solve);

function solve() {
  const publishBtn = document.getElementById("publish-btn");
  const taskTitleElement = document.getElementById("task-title");
  const taskCategoryElement = document.getElementById("task-category");
  const taskContentElement = document.getElementById("task-content");
  const ulRevueListElement = document.getElementById("review-list");
  const ulPublishedElement = document.getElementById("published-list");

  publishBtn.addEventListener("click", (e) => {
    if (
      !taskTitleElement.value ||
      !taskCategoryElement.value ||
      !taskContentElement.value
    ) {
      return;
    }
    createPublication();
    clearFields();
  });

  function createPublication() {
    const h4Element = document.createElement("h4");
    h4Element.textContent = taskTitleElement.value;

    const pCategoryElement = document.createElement("p");
    pCategoryElement.textContent = `Category: ${taskCategoryElement.value}`;

    const pContentElement = document.createElement("p");
    pContentElement.textContent = `Content: ${taskContentElement.value}`;

    const articleElement = document.createElement("article");
    articleElement.appendChild(h4Element);
    articleElement.appendChild(pCategoryElement);
    articleElement.appendChild(pContentElement);

    const editBtn = document.createElement("button");
    editBtn.classList.add("action-btn");
    editBtn.classList.add("edit");
    editBtn.textContent = "Edit";

    editBtn.addEventListener("click", (e) => {
      taskTitleElement.value = h4Element.textContent;
      taskCategoryElement.value = pCategoryElement.textContent
        .split(": ")
        .pop();
      taskContentElement.value = pContentElement.textContent.split(": ").pop();
      ulRevueListElement.innerHTML = "";
    });

    const postBtn = document.createElement("button");
    postBtn.classList.add("action-btn");
    postBtn.classList.add("post");
    postBtn.textContent = "Post";

    postBtn.addEventListener("click", (e) => {
      liElement.removeChild(editBtn);
      liElement.removeChild(postBtn);
      ulPublishedElement.appendChild(liElement);
    });

    const liElement = document.createElement("li");
    liElement.classList.add("rpost");
    liElement.appendChild(articleElement);
    liElement.appendChild(editBtn);
    liElement.appendChild(postBtn);

    ulRevueListElement.appendChild(liElement);
  }

  function clearFields() {
    taskTitleElement.value = "";
    taskCategoryElement.value = "";
    taskContentElement.value = "";
  }
}
