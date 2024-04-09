window.addEventListener("load", solve);

function solve() {
    const sureListElement = document.getElementById('sure-list');
    const addButton = document.getElementById('add-btn');
    const playerInputElement = document.getElementById('player');
    const scoreInputElement = document.getElementById('score');
    const roundInputElement = document.getElementById('round');
    const scoreBoardListElement = document.getElementById('scoreboard-list');
    const clearBtn = document.querySelector('.clear');

    let currPlayer;
    let currScore;
    let currRound;

    addButton.addEventListener('click', (e) => {

      if (playerInputElement.value === '' || scoreInputElement.value === '' || roundInputElement.value === '') {
        return;
      }

      const pPlayerElement = document.createElement('p');
      currPlayer = playerInputElement.value;
      pPlayerElement.textContent = currPlayer;

      const pScoreElement = document.createElement('p');
      currScore = scoreInputElement.value;
      pScoreElement.textContent = `Score: ${currScore}`;

      const pRoundElement = document.createElement('p');
      currRound = roundInputElement.value;
      pRoundElement.textContent = `Round: ${currRound}`;

      const articleElement = document.createElement('article');      

      articleElement.appendChild(pPlayerElement);
      articleElement.appendChild(pScoreElement);
      articleElement.appendChild(pRoundElement);

      const editBtn = document.createElement('button');
      editBtn.classList.add('btn');
      editBtn.classList.add('edit');
      editBtn.textContent = 'edit';

      editBtn.addEventListener('click', (e) => {
        playerInputElement.value = currPlayer;
        scoreInputElement.value = currScore;
        roundInputElement.value = currRound;

        sureListElement.removeChild(liElement);
        //sureListElement.innerHTML = '';
        addButton.disabled = false;
      })
      
      const okBtn = document.createElement('button');
      okBtn.classList.add('btn');
      okBtn.classList.add('ok');
      okBtn.textContent = 'ok';

      okBtn.addEventListener('click', (e) => {
        liElement.removeChild(okBtn);
        liElement.removeChild(editBtn);        

        scoreBoardListElement.append(liElement);
        sureListElement.innerHTML = '';
        addButton.disabled = false;
      })

      const liElement = document.createElement('li');
      liElement.classList.add('dart-item');

      liElement.appendChild(articleElement);
      liElement.appendChild(editBtn);
      liElement.appendChild(okBtn);

      sureListElement.appendChild(liElement);

      playerInputElement.value = '';
      scoreInputElement.value = '';
      roundInputElement.value = '';

      addButton.disabled = true;
    })
    
    clearBtn.addEventListener('click', (e) => {
      //scoreBoardListElement.innerHTML = '';
      location.reload();
    })
  }
  