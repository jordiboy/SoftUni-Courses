function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick () {
      const inputsElement = JSON.parse(document.querySelector('textarea').value);
      let bestRestaurantOutput = document.querySelector('#bestRestaurant p');
      let workersOutput = document.querySelector('#workers p');
      let restaurants = [];

      inputsElement.forEach(restaurant => createRestaurant(restaurant.split(' - ')));

      compareRestaurants(restaurants);      

      function createRestaurant(restaurant) {

         const restaurantName = restaurant.shift();
         let employeesArray = restaurant.pop().split(', ');         
         let employees = [];

         if (restaurants.some(r => r.restaurantName === restaurantName)) {
            const index = restaurants.findIndex(r => r.restaurantName === restaurantName);
            employees = restaurants[index].employees;            
         }
         
         for (const element of employeesArray) {            
            const [name, salary] =  element.split(' ');
            const employeeObj = {name, salary: Number(salary)};
            employees.push(employeeObj);
         }
         
         employees.sort((a, b) => b.salary - a.salary);

            restaurantObj = {
                restaurantName,
                employees,

            getAverageSalary() {
                let avg = 0;
                this.employees.forEach(e => avg += e.salary);
                return avg / this.employees.length;
            }
         }

         restaurants.push(restaurantObj);
      }                  

      function compareRestaurants(restaurants) {
         let bestRestaurant = restaurants[0];

         restaurants.forEach(r => {
            if (r.getAverageSalary() > bestRestaurant.getAverageSalary()) {
               bestRestaurant = r;
            }
         });
                  
         bestRestaurantOutput.textContent = `Name: ${bestRestaurant.restaurantName} Average Salary: ${bestRestaurant.getAverageSalary().toFixed(2)} Best Salary: ${bestRestaurant.employees[0].salary.toFixed(2)}`;
         bestRestaurant.employees.forEach(e => workersOutput.textContent += `Name: ${e.name} With Salary: ${e.salary} `);
      }
   }
}