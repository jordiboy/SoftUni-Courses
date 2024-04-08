const inputPresent = document.getElementById('gift');
const inputFor = document.getElementById('for');
const inputPrice = document.getElementById('price');
const loadPresents = document.getElementById('load-presents');
const giftListElement = document.getElementById('gift-list');
const addPresentBtn = document.getElementById('add-present');
const editBtn = document.getElementById('edit-present');

const baseUrl = 'http://localhost:3030/jsonstore/gifts/';
let elementId = ''

loadPresents.addEventListener('click', (e) => {
    
    loadingPresents(baseUrl);
})

addPresentBtn.addEventListener('click', (e) => {
    fetch(baseUrl, {
        method: 'post',
        headers: { 'Content-type': 'application/json' },
        body: JSON.stringify({
            gift: inputPresent.value,
            for: inputFor.value,
            price: inputPrice.value,
        }),
    })
    loadingPresents(baseUrl);

    inputPresent.value = '';
    inputFor.value = '';
    inputPrice.value = '';
})

editBtn.addEventListener('click', (e) => {
    
    fetch(`${baseUrl}/${elementId}`, {
        method: 'put',
        headers: { 'Content-type': 'application/json' },
        body: JSON.stringify({
            gift: inputPresent.value,
            for: inputFor.value,
            price: inputPrice.value,
        }),
    })
    loadingPresents(baseUrl);
    console.log(elementId);
    inputPresent.value = '';
    inputFor.value = '';
    inputPrice.value = '';

    editBtn.disabled = true;
    addPresentBtn.disabled = false;
})

function createPresent(presents) {
    
    for (const item in presents) {
        const divSockElement = document.createElement('div');
        divSockElement.classList.add('gift-sock');
        divSockElement.setAttribute('id', presents[item]._id);        

        const divContent = document.createElement('div');
        divContent.classList.add('content');

        const pPresentElement = document.createElement('p');
        pPresentElement.textContent = presents[item].gift;

        const pForElement = document.createElement('p');
        pForElement.textContent = presents[item].for;

        const pPriceElement = document.createElement('p');
        pPriceElement.textContent = presents[item].price;

        divContent.appendChild(pPresentElement);
        divContent.appendChild(pForElement);
        divContent.appendChild(pPriceElement);

        const divButtons = document.createElement('div');
        divButtons.classList.add('buttons-container');

        const changeBtn = document.createElement('button');
        changeBtn.classList.add('change-btn');
        changeBtn.textContent = 'Change';

        changeBtn.addEventListener('click', (e)=> {
            inputPresent.value = presents[item].gift;
            inputFor.value = presents[item].for;
            inputPrice.value = presents[item].price;
            elementId = divSockElement.getAttribute('id');

            divSockElement.remove();

            editBtn.disabled = false;
            addPresentBtn.disabled = true;
        })

        const deleteBtn = document.createElement('button');
        deleteBtn.classList.add('delete-btn');
        deleteBtn.textContent = 'Delete';

        deleteBtn.addEventListener('click', (e) => {
            elementId = divSockElement.getAttribute('id');
            console.log(elementId);
            fetch(`${baseUrl}/${elementId}`, {
                method: 'delete',
                })

            loadingPresents(baseUrl);
        })

        divButtons.appendChild(changeBtn);
        divButtons.appendChild(deleteBtn);

        divSockElement.appendChild(divContent);
        divSockElement.appendChild(divButtons);
        giftListElement.appendChild(divSockElement);
    }    
}

function loadingPresents(baseUrl) {
    const removeElements = giftListElement.querySelectorAll('div');
    for (const element of removeElements) {
        element.remove();
    }
    fetch(baseUrl)
        .then((response) => response.json())
        .then((presents) => createPresent(presents))
        .catch((error) => console.error(error))
}
