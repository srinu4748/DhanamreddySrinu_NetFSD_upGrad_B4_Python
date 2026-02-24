export const calculateTotal = (products) => {
    return products
        .map(product => product.price * product.quantity)
        .reduce((total, value) => total + value, 0);
};