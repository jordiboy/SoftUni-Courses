function lockedProfile() {
    const profileElements = document.querySelectorAll('.profile');

    for (const profileElement of profileElements) {
        const showButtonElement = profileElement.querySelector('button');
        const lockRadioElement = profileElement.querySelector('input[type=radio][value=lock]');

        showButtonElement.addEventListener('click', (e) => {
            if (lockRadioElement.checked) {
                return;
            }
            
            const moreInfo = showButtonElement.previousElementSibling;

            if (showButtonElement.textContent === 'Show more') {
                moreInfo.style.display = 'block';
                showButtonElement.textContent = 'Hide it';
            } else {
                moreInfo.style.display = 'none';
                showButtonElement.textContent = 'Show more';
            }            
        })
    }
}