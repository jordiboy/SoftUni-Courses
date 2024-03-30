function solve() {
   const buttons = document.querySelectorAll('.add-product');
   const textAreaElement = document.querySelector('textarea');
   let products = new Set();
   let total = 0;

   for (const button of buttons) {
      const product = button.parentElement.parentElement;      
      
      button.addEventListener('click', () => {
         const name = document.querySelector('.product-title').textContent;
         const price = Number(document.querySelector('.product-line-price').textContent);

         products.add(name);
         total += price;
         textAreaElement.value += `Added ${name} for ${price.toFixed(2)} to the cart.\n`;
         
      })
   }   
}