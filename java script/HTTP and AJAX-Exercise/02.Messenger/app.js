function attachEvents() {}
const baseUrl = "http://localhost:3030/jsonstore/messenger";
const authorElement = document.querySelector("input[name=author]");
const contentElement = document.querySelector("input[name=content]");
const submitBtn = document.getElementById("submit");
const refreshBtn = document.getElementById("refresh");
const textAreaElement = document.getElementById("messages");

textAreaElement.value = "";

submitBtn.addEventListener("click", (e) => {
  fetch(baseUrl, {
    method: "post",
    headers: { "Content-type": "application/json" },
    body: JSON.stringify({
      author: authorElement.value,
      content: contentElement.value,
    }),
  });
  getMessages(baseUrl);
});

refreshBtn.addEventListener("click", (e) => {
  getMessages(baseUrl);
  authorElement.value = "";
  contentElement.value = "";
});

function getMessages(baseUrl) {
  fetch(baseUrl)
    .then((response) => response.json())
    .then((messages) => {
      let text = "";
      for (const message in messages) {
        text += `${messages[message].author}: ${messages[message].content}\n`;

        textAreaElement.value = text;
      }
    });
}
attachEvents();
