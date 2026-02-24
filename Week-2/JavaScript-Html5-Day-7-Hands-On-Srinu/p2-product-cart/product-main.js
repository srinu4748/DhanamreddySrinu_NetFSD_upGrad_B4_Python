import { calculateTotal } from './product-cart.js';

// Product array
const products = [
    { name: "Laptop", price: 50000, quantity: 1 },
    { name: "Mouse", price: 500, quantity: 2 },
    { name: "Keyboard", price: 1500, quantity: 1 }
];

// Generate bill details
const generateInvoice = (items) => {

    const productDetails = items.map(item => {
        const itemTotal = item.price * item.quantity;

        return `
Product: ${item.name}
Price: ${item.price}
Quantity: ${item.quantity}
Item Total: ${itemTotal}
--------------------------`;
    }).join("");

    const totalAmount = calculateTotal(items);

    return `
========= Bill Details =========
${productDetails}

Total Cart Value: ₹${totalAmount}
===========================
`;
};

console.log(generateInvoice(products));