function addItem() {
    const itemElements = document.getElementById('items');
    const inputElement = document.getElementById('newItemText');
    
    const newElement = document.createElement('li');
    newElement.textContent = inputElement.value;
    itemElements.appendChild(newElement);
}