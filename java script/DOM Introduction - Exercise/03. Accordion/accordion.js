function toggle() {
    const buttonElement = document.getElementsByClassName('button')[0];
    const moreTextElement = document.getElementById('extra');
    
    if (buttonElement.textContent === 'More') {
        moreTextElement.style.display = 'block';
        buttonElement.textContent = 'Less';
    } else {
        moreTextElement.style.display = 'none';
        buttonElement.textContent = 'More';
    }
}