function focused() {
    const inputElements = document.querySelectorAll('input');

    Array.from(inputElements).forEach(inputElement => inputElement.addEventListener('focus', (e) => {
        e.target.parentElement.classList.add('focused');
    }));

    Array.from(inputElements).forEach(inputElement => inputElement.addEventListener('blur', (e) => {
        e.target.parentElement.classList.remove('focused');
    }));
}