window.addEventListener("load", solve);

function solve() {
    const placeInputElement = document.getElementById('place');
    const actionInputElement = document.getElementById('action');
    const personInputElement = document.getElementById('person');
    const addButton = document.getElementById('add-btn');
    const ulTaskList = document.getElementById('task-list');

    addButton.addEventListener('click', (e) => {
        const place = placeInputElement.value;
        const action = actionInputElement.value;
        const person = personInputElement.value;

        const liElement = document.createElement('li');
        liElement.classList.add('clean-task');

        const articleElement = document.createElement('article');

        const pElementPlace = document.createElement('p');
        pElementPlace.textContent = `Place:${place}`;

        const pElementAction = document.createElement('p');
        pElementAction.textContent = `Action:${action}`;

        const pElementPerson = document.createElement('p');
        pElementPerson.textContent = `Person:${person}`;

        const editBtn = document.createElement('button');
        editBtn.textContent = 'Edit';
        editBtn.classList.add('edit');

        editBtn.addEventListener('click', (e) => {
            const placeTask = document.querySelector('.clean-task article p:nth-child(1)');
            const actionTask = document.querySelector('.clean-task article p:nth-child(2)');
            const personTask = document.querySelector('.clean-task article p:nth-child(3)');

            placeInputElement.value = placeTask.textContent.split(':').pop();
            actionInputElement.value = actionTask.textContent.split(':').pop();
            personInputElement.value = personTask.textContent.split(':').pop();

            liElement.remove();
        })

        const doneBtn = document.createElement('button');
        doneBtn.textContent = 'Done';
        doneBtn.classList.add('done');

        doneBtn.addEventListener('click', (e) => {
            const doneElement = document.getElementById('done-list');
            
            divElement.removeChild(doneBtn);
            divElement.removeChild(editBtn);

            deleteBtn = document.createElement('button');
            deleteBtn.textContent = 'Delete';
            deleteBtn.classList.add('delete');

            deleteBtn.addEventListener('click', (e) => {
                liElement.remove();
            })

            liElement.appendChild(deleteBtn);
            doneElement.appendChild(liElement);
        })

        const divElement = document.createElement('div');
        divElement.classList.add('buttons');
        divElement.appendChild(editBtn);
        divElement.appendChild(doneBtn);

        articleElement.appendChild(pElementPlace);
        articleElement.appendChild(pElementAction);
        articleElement.appendChild(pElementPerson);

        liElement.appendChild(articleElement);
        liElement.appendChild(divElement);
        ulTaskList.appendChild(liElement);

        placeInputElement.value = '';
        actionInputElement.value = '';
        personInputElement.value = '';
    })

}