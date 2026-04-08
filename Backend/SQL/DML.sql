CREATE DATABASE StoreDB;

USE StoreDB;

CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(20),
    Email VARCHAR(30),
);

CREATE TABLE Orders (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserId INT,
    ProductName VARCHAR(20),
    Price DECIMAL(10,2),
    FOREIGN KEY (UserId) REFERENCES Users(Id), 
);

--Insert Tasks

INSERT INTO Users (Name,Email) VALUES ('Leen','leen@gmail.com'),('Haneen','haneen@gmail.com'),('aya','aya@gmail.com');

INSERT INTO Orders ( UserId,ProductName,Price) VALUES (1,'Laptop',800),(2,'Phone',500),(1,'Mouse',20),(3,'Keyboard',50);

INSERT INTO Users (Name) VALUES ('Ahmad');

--Update Tasks

UPDATE Users SET Email='aya_new@gmail.com' WHERE Id = 3;

UPDATE Orders SET Price = Price + 10;

UPDATE Users SET Name = 'New Haneen' WHERE Id = 2;

--Delete Tasks

DELETE FROM Users WHERE Id = 4;

DELETE FROM Orders WHERE Price < 50;

DELETE FROM Orders WHERE UserId = 3;

--Select Tasks

SELECT * FROM Users;

SELECT Name,Email FROM Users;

SELECT * FROM Users WHERE Name LIKE 'A%';

SELECT * FROM Users WHERE Email IS NULL;

SELECT * FROM Orders WHERE Price BETWEEN 50 AND 800;

SELECT * FROM Orders WHERE ProductName = 'Phone';

SELECT * FROM Orders ORDER BY Price DESC;

SELECT * FROM Users ORDER BY Name;

SELECT * FROM Orders WHERE Price > 100 AND UserId = 1;

SELECT * FROM Users WHERE Name LIKE '%A%';