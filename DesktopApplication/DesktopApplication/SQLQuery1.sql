CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	profile_image VARCHAR(MAX) NULL,
	role VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_reg DATE NULL
)

SELECT * FROM users
TRUNCATE TABLE users

INSERT INTO users (username, password, profile_image, role, status, date_reg) VALUES('admin', 'admin123', '', 'Admin', 'Active', '2023-01-06')


DROP TABLE products;

CREATE TABLE products
(
    id INT PRIMARY KEY IDENTITY(1,1),
    prod_id VARCHAR(MAX) NULL,
    prod_name VARCHAR(MAX) NULL,
    prod_type VARCHAR(MAX) NULL,
    prod_stock INT NULL,
    prod_price FLOAT NULL,
    prod_status VARCHAR(MAX) NULL,
    prod_image VARCHAR(MAX) NULL,
    date_insert DATE NULL,
    date_update DATE NULL,
    date_delete DATE NULL
)

SELECT * FROM products
TRUNCATE TABLE products

SELECT * FROM products WHERE date_delete IS NULL

DELETE FROM products WHERE id = 2

SELECT * FROM orders
TRUNCATE TABLE orders

SELECT * FROM orders WHERE customer_id = 1

SELECT MAX(customer_id) FROM customers

SELECT * FROM customers
TRUNCATE TABLE customers

ALTER TABLE customers
ADD amount FLOAT NULL

ALTER TABLE customers
ADD change FLOAT NULL

ALTER TABLE customers
ADD users VARCHAR(MAX) NULL

SELECT MAX(customer_id) FROM orders

SELECT SUM(prod_price) FROM orders WHERE customer_id = 1

SELECT * FROM customers

SELECT * FROM users

SELECT SUM(total_price) FROM customers

SELECT SUM(total_price) FROM customers WHERE DATE = '2025-01-18'



