CREATE DATABASE Product_Price_List;

use Product_Price_List;

CREATE TABLE brands (
    brand_id INT PRIMARY KEY,
    brand_name VARCHAR(50)
);

CREATE TABLE categories (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(50)
);

CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100),
    brand_id INT,
    category_id INT,
    model_year INT,
    list_price DECIMAL(10,2),
    FOREIGN KEY (brand_id) REFERENCES brands(brand_id),
    FOREIGN KEY (category_id) REFERENCES categories(category_id)
);

INSERT INTO brands VALUES
(1,'Samsung'),
(2,'Apple'),
(3,'Sony');

INSERT INTO categories VALUES
(1,'Mobile'),
(2,'Laptop'),
(3,'Accessories');

INSERT INTO products VALUES
(101,'Galaxy S21',1,1,2022,750),
(102,'iPhone 13',2,1,2023,900),
(103,'Sony Headphones',3,3,2021,300),
(104,'MacBook Air',2,2,2023,1200),
(105,'Samsung Buds',1,3,2022,150);

SELECT * FROM brands;

SELECT * FROM categories;

SELECT * FROM products;

SELECT 
    p.product_name,
    b.brand_name,
    c.category_name,
    p.model_year,
    p.list_price
FROM products p
INNER JOIN brands b
    ON p.brand_id = b.brand_id
INNER JOIN categories c
    ON p.category_id = c.category_id
WHERE p.list_price > 500
ORDER BY p.list_price ASC;
