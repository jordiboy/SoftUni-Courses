function validate() {
    const emailElement = document.getElementById('email');
    const pattern = /^[a-z]+@[a-z]+\.[a-z]+/

    emailElement.addEventListener('change', (e) => {
        if (!pattern.test(e.target.value)) {
            e.target.classList.add('error');
        } else {
            e.target.classList.remove('error');
        }
    })
}