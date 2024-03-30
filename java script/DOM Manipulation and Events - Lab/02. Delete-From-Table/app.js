function deleteByEmail() {
    const trElements = document.querySelectorAll('#customers tbody tr');
    let eMailElement = document.querySelector('input').value;
    let resultElement = document.getElementById('result');

    const row = Array
        .from(trElements)
        .find(tr => tr.children[1].textContent.includes(eMailElement));

        if (row) {
            row.remove();
            resultElement.textContent = 'Delete.';
        } else {
            resultElement.textContent = 'Not found.';
        }

    eMailElement = '';
}