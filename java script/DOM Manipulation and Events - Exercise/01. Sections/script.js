function create(words) {
   let contentElement = document.getElementById('content');

   words.forEach((word) => {
      const newWrapper = document.createElement('div');
      const newWord = document.createElement('p');      
      newWord.textContent = word;
      newWord.style.display = 'none';

      newWrapper.addEventListener('click', () => {
         newWord.style.display = 'block';
      }); 

      newWrapper.appendChild(newWord);
      contentElement.appendChild(newWrapper);
   });
}