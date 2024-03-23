function search() {
   const townsListElement = document.getElementById('towns');
   const searchTextElement = document.getElementById('searchText');
   const resultElement = document.getElementById('result');

   const towns = Array.from(townsListElement.children);
   let countMatches = 0;

   for (const town of towns) {
      if (town.textContent.toLowerCase().includes(searchTextElement.value.toLowerCase())) {
         town.style.textDecoration = 'underline';
         town.style.fontWeight = 'bold';
         countMatches++;
      } else {
         town.style.textDecoration = 'none';
         town.style.fontWeight = 'normal';
      }
   }

   resultElement.textContent = `${countMatches} matches found`;
}
