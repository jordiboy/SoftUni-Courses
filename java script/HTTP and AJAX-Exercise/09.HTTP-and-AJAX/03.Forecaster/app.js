function attachEvents() {
    const baseUrl = 'http://localhost:3030/jsonstore/forecaster';

    const locationElement = document.getElementById('location');
    const submitButton = document.getElementById('submit');
    const forecastElement = document.getElementById('forecast');
    const currentElement = document.getElementById('current');

    const weatherSymbol = {
        'Sunny': '☀',
        'Partly sunny': '⛅',
        'Overcast': '☁',
        'Rain': '☂',
        'Degrees': '°',
    }

    submitButton.addEventListener('click', async () => {
        const locationResponse = await fetch(`${baseUrl}/locations`);
        const locationData = await locationResponse.json

        const { code } = locationData.find(location => location.name === locationElement.value)

        const todayResponse = await fetch(`${baseUrl}/today/${code}`);
        const today = await todayResponse.json();

        const upcomingResponse = await fetch(`${baseUrl}/upcoming/${code}`);
        const upcoming = await upcomingResponse.json();

        forecastElement.style.display = 'block';

        const symbolSpanElement = document.createElement('span');
        symbolSpanElement.classList.add('condition');
        symbolSpanElement.classList.add('symbol');
        symbolSpanElement.textContent = weatherSymbol[today.forecast.condition];

        // Don't do this at home
        const anotherSpan = document.createElement('span');
        anotherSpan.innerHTML = `
            <span class="condition">
                <span class="forecast-data">${today.name}</span>
                <span class="forecast-data">${today.forecast.low}/${today.forecast.high}</span>
                <span class="forecast-data">${today.forecast.condition}</span>
            </span>
        `;

        const forecastsElement = document.createElement('div');
        forecastsElement.classList.add('forecasts');
        forecastsElement.appendChild(symbolSpanElement);
        forecastsElement.appendChild(anotherSpan);

        currentElement.appendChild(forecastsElement);
    });
}

attachEvents();
