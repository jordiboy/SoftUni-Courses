function solve(products, delivery) {
    
    const store = getProducts([...products, ...delivery]);

    for (const product in store) {
        console.log(`${product} -> ${store[product]}`)
    }

}

function getProducts(input) {

    const products = [];

    for (let i = 0; i < input.length; i += 2) {
        const product = input[i];
        const quantity = Number(input[i + 1]);

        if (!products[product]) {
            products[product] = 0;
        }

        products[product] += quantity;
    }

    return products;
}

solve([
    'Chips', '5', 'CocaCola', '9', 'Bananas',    
    '14', 'Pasta', '4', 'Beer', '2'    
    ],    
    [    
    'Flour', '44', 'Oil', '12', 'Pasta', '7',    
    'Tomatoes', '70', 'Bananas', '30'    
    ])