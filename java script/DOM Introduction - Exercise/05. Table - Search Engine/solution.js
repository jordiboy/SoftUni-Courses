function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      const trElement = document.querySelectorAll('tbody tr');
      const searchFieldElement = document.getElementById('searchField');

      for (const tr of trElement) {
         const tdElements = tr.querySelectorAll('td');
         tr.classList.remove('select');
         let isSelected = false;

         for (const td of tdElements) {
            if (td.textContent.toLowerCase().includes(searchFieldElement.value.toLowerCase())) {
               isSelected = true;
            }
         }

         if (isSelected) {
            tr.classList.add('select');
         }
         
      }

      searchFieldElement.value = '';

   }
}