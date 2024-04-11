import calculate from './externalModule.js';
console.log(calculate(2, 3));

const usersUrl = 'http://localhost:3030/users';
const catchUrl = 'http://localhost:3030/data/catches';

const registerView = document.getElementById('register-view');
const loginView = document.getElementById('login-view');
const homeView = document.getElementById('home-view');
const sections = document.getElementById('views');
const mainElement = document.querySelector('body > main');
const catchSection = document.getElementById('catches')

const userButtons = document.getElementById('user');
const guestButtons = document.getElementById('guest');

const homeLink = document.getElementById('home');
const logoutLink = document.getElementById('logout');
const loginLink = document.getElementById('login');
const registerLink = document.getElementById('register');

const loginButton = loginView.querySelector('button');
const emailElement = loginView.querySelector('input[name=email]');
const passwordElement = loginView.querySelector('input[name=password]');

const userSpanElement = document.querySelector('nav p.email');
const loadButton = document.querySelector('button.load');

sections.style.display = 'none';
mainElement.appendChild(homeView);

updateNavigationData();

loginLink.addEventListener('click', () => {
    hideSections();
    mainElement.appendChild(loginView);
});

registerLink.addEventListener('click', () => {
    hideSections();
    mainElement.appendChild(registerView);
})

homeLink.addEventListener('click', () => {
    hideSections();
    mainElement.appendChild(homeView);
});

loginButton.addEventListener('click', async (e) => {
    e.preventDefault();

    try {
        const response = await fetch(`${usersUrl}/login`, {
            method: 'POST',
            headers: {
                'content-type': 'application/json',
            },
            body: JSON.stringify({
                email: emailElement.value,
                password: passwordElement.value,
            })
        });

        if (!response.ok) {
            throw new Error(response.statusText);
        }

        const userData = await response.json();
        setUserData(userData)

        hideSections();
        mainElement.appendChild(homeView);

        updateNavigationData();
    } catch (err) {
        document.querySelector('.notification').textContent = 'Invalid username or password';
    }
});

logoutLink.addEventListener('click', async (e) => {
    // Skip server logout
    removeUserData();
    updateNavigationData();
});

loadButton.addEventListener('click', async (e) => {
    const response = await fetch(catchUrl);
    const catches = await response.json();

    // Not secure dont do this at home!
    catchSection.innerHTML = catches.map(item => catchTemplate(item, updateCalback)).join('\n');
});


function hideSections() {
    sections.appendChild(mainElement.children[0]);
}

function setUserData(userData) {
    localStorage.setItem('accessToken', userData.accessToken);
    localStorage.setItem('email', userData.email);
    localStorage.setItem('username', userData.username);
    localStorage.setItem('_id', userData._id);
}

function removeUserData() {
    localStorage.removeItem('accessToken');
    localStorage.removeItem('email');
    localStorage.removeItem('username');
    localStorage.removeItem('_id');
}

function updateNavigationData() {
    const username = localStorage.getItem('username');
    if (username) {
        guestButtons.style.display = 'none';
        userButtons.style.display = 'inline';
        userSpanElement.textContent = username;
    } else {
        guestButtons.style.display = 'inline';
        userButtons.style.display = 'none';
        userSpanElement.textContent = 'guest';
    }
}

function catchTemplate(data, updateCalback) {
    return `
    <div class="catch">
        <label>Angler</label>
        <input type="text" class="angler" value="${data.angler}">
        <label>Weight</label>
        <input type="text" class="weight" value="${data.weight}">
        <label>Species</label>
        <input type="text" class="species" value="${data.species}">
        <label>Location</label>
        <input type="text" class="location" value="${data.location}">
        <label>Bait</label>
        <input type="text" class="bait" value="${data.bait}">
        <label>Capture Time</label>
        <input type="number" class="captureTime" value="${data.captureTime}">

        <button class="update" data-id="07f260f4-466c-4607-9a33-f7273b24f1b4">Update</button>
        <button class="delete" data-id="07f260f4-466c-4607-9a33-f7273b24f1b4">Delete</button>
    </div>
`;
} 
