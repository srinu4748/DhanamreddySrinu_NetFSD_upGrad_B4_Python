CREATE DATABASE StoreDB;

USE StoreDB;

CREATE TABLE customers (
	customer_id INT PRIMARY KEY,
	first_name VARCHAR(50),
	last_name VARCHAR(50)
);

CREATE TABLE orders (
	order_id INT PRIMARY KEY,
	customer_id INT,
	order_date DATE,
	order_status INT,
	FOREIGN KEY (customer_id)
	REFERENCES customers(customer_id)
);

INSERT INTO customers VALUES
(1,'Ram','Kumar'),
(2,'Ravi','Sharma'),
(3,'Sita','Reddy'),
(4,'Anil','Verma');

INSERT INTO orders VALUES
(101,1,'2024-01-10',1),
(102,2,'2024-01-12',4),
(103,3,'2024-01-15',2),
(104,1,'2024-01-18',4),
(105,4,'2024-01-20',1);


SELECT * FROM customers;

SELECT * FROM orders;

SELECT c.first_name, c.last_name, o.order_id, o.order_date, o.order_status FROM customers c
INNER JOIN orders o ON c.customer_id = o.customer_id WHERE o.order_status = 1 OR o.order_status = 4
ORDER BY o.order_date DESC;