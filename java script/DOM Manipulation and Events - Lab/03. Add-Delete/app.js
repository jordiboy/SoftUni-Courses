function addItem() {
    const itemsElement = document.getElementById('items');
    const newItemTextElement = document.getElementById('newItemText').value;

    const newElement = document.createElement('li');
    newElement.textContent = newItemTextElement;
    
    const removeElement = document.createElement('a');
    removeElement.textContent = '[Delete]';    
    removeElement.href = '#';
    

    removeElement.addEventListener('click', () => {
        newElement.remove();
    })

    newElement.appendChild(removeElement);
    itemsElement.appendChild(newElement);
}