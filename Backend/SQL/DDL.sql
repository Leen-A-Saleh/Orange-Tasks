CREATE DATABASE Store;
use Store;

CREATE TABLE users(
Id INT PRIMARY KEY Identity(1,1),
Name VARCHAR(50),
Email VARCHAR(50) UNIQUE NOT NULL,
);

CREATE TABLE products (
Id INT PRIMARY KEY Identity(1,1),
Name VARCHAR(50),
Price DECIMAL (8,2) NOT NULL,
);

CREATE TABLE orders (
Id INT PRIMARY KEY Identity(1,1),
user_Id INT,
order_date DATETIME  DEFAULT GETDATE(),
FOREIGN KEY(user_Id) REFERENCES users(Id),
);

CREATE TABLE order_product(
order_Id INT,
product_Id INT,
PRIMARY KEY (order_Id,product_Id),
FOREIGN KEY (order_Id) REFERENCES orders(Id), 
FOREIGN KEY (product_Id) REFERENCES products(Id),
); 

CREATE TABLE categories(
Id INT PRIMARY KEY Identity(1,1),
Name VARCHAR(50),
);

ALTER TABLE products ADD category_id INT;
ALTER TABLE products ADD FOREIGN KEY (category_id) REFERENCES categories(id);

CREATE TABLE employee(
Id INT PRIMARY KEY Identity(1,1),
Name VARCHAR(50),
Manager_id INT,
FOREIGN KEY (Manager_id) REFERENCES employee(Id),
);

ALTER TABLE users ADD Phone VARCHAR(10);
ALTER TABLE users DROP COLUMN phone;

ALTER TABLE users ALTER COLUMN Name VARCHAR(100);

CREATE TABLE customers (
Id INT PRIMARY KEY Identity(1,1),
Name VARCHAR(50) NOT NULL,
Phone varchar(10),
);

CREATE TABLE payments (
Id INT PRIMARY KEY Identity(1,1),
Amount DECIMAL(8,2),
order_id INT,
FOREIGN KEY (order_id) REFERENCES orders(Id),
);

CREATE TABLE students (
Id INT PRIMARY KEY Identity(1,1),
Name VARCHAR(20),
);

CREATE TABLE courses (
Id INT PRIMARY KEY Identity(1,1),
Title VARCHAR(20)
);

CREATE TABLE std_courses(
std_id INT,
course_id INt,
PRIMARY KEY (std_id , course_id),
FOREIGN KEY (std_id) REFERENCES students(id),
FOREIGN KEY (course_id) REFERENCES courses(id),
);

CREATE TABLE logs (
Id INT PRIMARY KEY Identity(1,1),
msg TEXT,
create_at DATETIME DEFAULT GETDATE(),
);

TRUNCATE TABLE logs;

DROP TABLE logs;

CREATE TABLE example_table (
req VARCHAR(20) NOT NULL,
op VARCHAR(20)
);

CREATE TABLE books(
Id INT PRIMARY KEY Identity(1,1),
title VARCHAR(20),
price DECIMAL(8,2),
);

CREATE TABLE authers(
Id INT PRIMARY KEY Identity(1,1),
Name VARCHAR(20),
);

ALTER TABLE books ADD auther_id INt;
ALTER TABLE books ADD FOREIGN KEY (auther_id) REFERENCES authers(Id);

CREATE TABLE ids(
Id INT PRIMARY KEY Identity(1,1),
);

CREATE TABLE mixed_types (
Id INT PRIMARY KEY Identity(1,1),
num INT,
txt VARCHAR(10),
ddate DATE,
);

CREATE TABLE unique_email (
Id INT PRIMARY KEY Identity(1,1),
Email VARCHAR(10),
);

ALTER TABLE unique_email ADD CONSTRAINT email UNIQUE(email);

--Optional Tasks 
CREATE DATABASE test;

DROP DATABASE test;

CREATE TABLE products(
Id INT PRIMARY KEY Identity(1,1),
name VARCHAR(100),
price DECIMAL(10,2) NOT NULL,
);

ALTER TABLE products ADD description VARCHAR(100);

DELETE TABLE products;

CREATE TABLE single(
Id INT PRIMARY KEY Identity(1,1),
);

DROP TABLE single;

CREATE TABLE users (
Id INT PRIMARY KEY Identity(1,1),
Email VARCHAR(10) UNIQUE NOT NULL
);

TRUNCATE TABLE users;

CREATE TABLE last (
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(10) NOT NULL,
email VARCHAR(10) UNIQUE
);
