function getInfo() {
    const inputElement = document.getElementById('stopId');
    const stopNameElement = document.getElementById('stopName');
    const busesUlElement = document.getElementById('buses');

    const baseUrl = 'http://localhost:3030/jsonstore/bus/businfo';

    console.log(inputElement.value);

    fetch(`${baseUrl}/${inputElement.value}`)
        .then((response) => response.json())
        .then(data => {
            const pNameElement = document.createElement('p');
            pNameElement.textContent = data.name;
            stopNameElement.appendChild(pNameElement);

            for (const bus in data.buses) {
                const liElement = document.createElement('li');
                liElement.textContent = `Bus ${bus} arrives in ${data.buses[bus]} minutes`;
                busesUlElement.appendChild(liElement);
            }
        })
        .catch(error => {
            const pNameElement = document.createElement('p');
            pNameElement.textContent = 'Error';
            stopNameElement.appendChild(pNameElement);
        })    
}