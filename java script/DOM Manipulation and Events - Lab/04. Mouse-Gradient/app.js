function attachGradientEvents() {
    const gradientElement = document.getElementById('gradient');
    let resultElement = document.getElementById('result');

    gradientElement.addEventListener('mousemove', (e) => {
        let move = Math.floor((e.offsetX / e.target.clientWidth) * 100);
        resultElement.textContent = `${move}%`;        
    });

    gradientElement.addEventListener('mouseout', () => {
        resultElement.textContent = '';
    });
}