function getInfo() {
    const inputElement = document.getElementById('stopId');

    const baseUrl = 'http://localhost:3030/jsonstore/bus/businfo';

    console.log(inputElement.value);

    fetch(`${baseUrl}/${inputElement.value}`)
        .then((response) => response.json())
        .then((data) => console.log(data))
        .catch((error) => console.log('Error'))    
}