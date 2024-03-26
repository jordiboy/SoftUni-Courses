function deleteByEmail() {
    const trElements = document.querySelectorAll('#customers tbody tr');
    let eMailElement = document.querySelector('input').value;
    let resultElement = document.getElementById('result');

    const rows = Array
        .from(trElements)
        .find(element => element.children[1].textContent.includes(eMailElement));

        if (rows) {
            rows.remove();
            resultElement.textContent = 'Delete.';
        } else {
            resultElement.textContent = 'Not found.';
        }

    eMailElement = '';
}