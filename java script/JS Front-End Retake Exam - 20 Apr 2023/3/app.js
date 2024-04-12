const baseUrl = "http://localhost:3030/jsonstore/tasks";
const loadButton = document.getElementById("load-course");
const addButton = document.getElementById("add-course");
const editCourseButton = document.getElementById("edit-course");
const courseNameElement = document.getElementById("course-name");
const courseTypeElement = document.getElementById("course-type");
const descriptionElement = document.getElementById("description");
const teacherNameElement = document.getElementById("teacher-name");
const divListElement = document.getElementById("list");

loadButton.addEventListener("click", (e) => {
  loadElements(baseUrl);
});

addButton.addEventListener("click", (e) => {
  fetch(baseUrl, {
    method: "post",
    headers: { "Content-type": "application/json" },
    body: JSON.stringify({
      title: courseNameElement.value,
      type: courseTypeElement.value,
      description: descriptionElement.value,
      teacher: teacherNameElement.value,
    }),
  });

  courseNameElement.value = "";
  courseTypeElement.value = "";
  descriptionElement.value = "";
  teacherNameElement.value = "";

  loadElements(baseUrl);
});

let currId = "";

editCourseButton.addEventListener("click", (e) => {
  fetch(`${baseUrl}/${currId}`, {
    method: "put",
    headers: { "Content-type": "application/json" },
    body: JSON.stringify({
      title: courseNameElement.value,
      type: courseTypeElement.value,
      description: descriptionElement.value,
      teacher: teacherNameElement.value,
    }),
  });

  courseNameElement.value = "";
  courseTypeElement.value = "";
  descriptionElement.value = "";
  teacherNameElement.value = "";

  editCourseButton.disabled = true;
  addButton.disabled = false;

  loadElements(baseUrl);
});

function createElement(courses) {
  divListElement.innerHTML = "";
  for (const item in courses) {
    const h2CourseElement = document.createElement("h2");
    h2CourseElement.textContent = courses[item].title;

    const h3NameElement = document.createElement("h3");
    h3NameElement.textContent = courses[item].teacher;

    const h3CourseTypeElement = document.createElement("h3");
    h3CourseTypeElement.textContent = courses[item].type;

    const h4DescriptionElement = document.createElement("h4");
    h4DescriptionElement.textContent = courses[item].description;

    const editButton = document.createElement("button");
    editButton.classList.add("edit-btn");
    editButton.textContent = "Edit Course";

    editButton.addEventListener("click", (e) => {
      courseNameElement.value = courses[item].title;
      courseTypeElement.value = courses[item].type;
      descriptionElement.value = courses[item].description;
      teacherNameElement.value = courses[item].teacher;

      currId = divContainerElement.getAttribute("data-id");

      divContainerElement.remove();

      editCourseButton.disabled = false;
      addButton.disabled = true;
    });

    const finishButton = document.createElement("button");
    finishButton.classList.add("finish-btn");
    finishButton.textContent = "Finish Course";

    finishButton.addEventListener("click", (e) => {
      fetch(`${baseUrl}/${divContainerElement.getAttribute("data-id")}`, {
        method: "delete",
      });
      divContainerElement.remove();
    });

    const divContainerElement = document.createElement("div");
    divContainerElement.classList.add("container");
    divContainerElement.setAttribute("data-id", courses[item]._id);
    divContainerElement.appendChild(h2CourseElement);
    divContainerElement.appendChild(h3NameElement);
    divContainerElement.appendChild(h3CourseTypeElement);
    divContainerElement.appendChild(h4DescriptionElement);
    divContainerElement.appendChild(editButton);
    divContainerElement.appendChild(finishButton);

    divListElement.appendChild(divContainerElement);
  }
}

function loadElements(baseUrl) {
  fetch(baseUrl)
    .then((response) => response.json())
    .then((courses) => createElement(courses))
    .catch((error) => console.error(error));
}
