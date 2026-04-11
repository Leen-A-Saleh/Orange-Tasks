CREATE DATABASE MiniProj1;
USE MiniProj1;

CREATE SCHEMA Users;
CREATE SCHEMA Products;
CREATE SCHEMA Orders;

CREATE TABLE Users.Users(
Id INT PRIMARY KEY IDENTITY(1,1),
FirstName VARCHAR(10) NOT NULL,
LastName VARCHAR(10) NOT NULL,
Email VARCHAR(20) UNIQUE NOT NULL,
Password VARCHAR(10) NOT NULL,
IsDeleted BIT DEFAULT 0,
CreatedAt DATETIME DEFAULT GETDATE(),
UpdateAt DATETIME,
); 

ALTER TABLE Users.Users ALTER COLUMN Email VARCHAR(50);

CREATE TABLE Users.UserPhone(
Id INT PRIMARY KEY IDENTITY(1,1),
UserId INT FOREIGN KEY REFERENCES Users.Users(Id),
Phone VARCHAR(14),
);

CREATE TABLE Products.Categories(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(20) UNIQUE NOT NULL,
IsDeleted BIT DEFAULT 0,
CreatedAt DATETIME DEFAULT GETDATE(),
UpdateAt DATETIME,
);

CREATE TABLE Products.Products(
Id INT PRIMARY KEY IDENTITY(1,1),
CategoryId INT FOREIGN KEY REFERENCES Products.Categories(Id),
Name VARCHAR(20) NOT NULL,
Description VARCHAR(100) NOT NULL,
Price DECIMAL(8,2) NOT NULL,
Stock INT NOT NULL,
IsDeleted BIT DEFAULT 0,
CreatedAt DATETIME DEFAULT GETDATE(),
UpdateAt DATETIME,
);

CREATE TABLE Users.WishList(
Id INT PRIMARY KEY IDENTITY(1,1),
UserID INT FOREIGN KEY REFERENCES Users.Users(Id),
);

CREATE TABLE Users.WishListItem(
WishListId INT FOREIGN KEY REFERENCES Users.WishList(Id),
ProductId INT FOREIGN KEY REFERENCES Products.Products(Id),
PRIMARY KEY (WishListId,ProductId),
);

CREATE TABLE Users.Cart(
Id INT PRIMARY KEY IDENTITY(1,1),
UserID INT FOREIGN KEY REFERENCES Users.Users(Id),
IsDeleted BIT DEFAULT 0,
CreatedAt DATETIME DEFAULT GETDATE(),
UpdateAt DATETIME,
);

CREATE TABLE Users.CartItem(
CartId INT FOREIGN KEY REFERENCES Users.Cart(Id),
ProductId INT FOREIGN KEY REFERENCES Products.Products(Id),
Quantity INT NOT NULL,
PRIMARY KEY (CartId,ProductId),
);

CREATE TABLE Orders.Orders(
Id INT PRIMARY KEY IDENTITY(1,1),
UserId INT FOREIGN KEY REFERENCES Users.Users(Id),
OrderDate DATETIME NOT NULL,
Status VARCHAR(10) NOT NULL,
Amount INT NOT NULL,
IsDeleted BIT DEFAULT 0,
CreatedAt DATETIME DEFAULT GETDATE(),
UpdateAt DATETIME,
);

ALTER TABLE ORders.Orders
ADD CONSTRAINT Status CHECK (Status IN ('Pending','Paid','Shipped','Cancelled'));

CREATE TABLE Orders.OrderItem(
Id INT PRIMARY KEY IDENTITY(1,1),
OrderId INT FOREIGN KEY REFERENCES Orders.Orders(Id),
ProductId INT FOREIGN KEY REFERENCES Products.Products(Id),
Quantity INT NOT NULL,
);

CREATE TABLE Orders.Payment(
Id INT PRIMARY KEY IDENTITY(1,1),
OrderId INT FOREIGN KEY REFERENCES Orders.Orders(Id),
Method VARCHAR(10) NOT NULL,
PaymentDate DATETIME NOT NULL,
Amount INT NOT NULL,
Status VARCHAR(10) NOT NULL,
);

ALTER TABLE Orders.Payment ALTER COLUMN Amount DECIMAL(8,2);

CREATE TABLE Orders.Review(
Id INT PRIMARY KEY IDENTITY(1,1),
UserId INT FOREIGN KEY REFERENCES Users.Users(Id),
ProductId INT FOREIGN KEY REFERENCES Products.Products(Id),
Rating INT,
Comment VARCHAR(50),
);

ALTER TABLE Orders.Review
ADD CONSTRAINT Review_Rating
CHECK (Rating BETWEEN 1 AND 5);


--Insert data---------------------------------
INSERT INTO Users.Users (FirstName, LastName, Email, Password)
VALUES
('Leen', 'Anas', 'leen@gmail.com', '123456'),
('Ahmad', 'Aytoon', 'ahmad@gmail.com', '123456'),
('Abdallah', 'Allahham', 'abdallah@gmail.com', '123456');

INSERT INTO Users.UserPhone (UserId, Phone)
VALUES
(1, '0791111111'),
(2, '0792222222'),
(3, '0793333333');

INSERT INTO Products.Categories(Name)
VALUES
('Electronics'),
('Clothing'),
('Books');

INSERT INTO Products.Products (CategoryId, Name, Description, Price, Stock)
VALUES
(1, 'Headphones', 'Wireless headphones', 50.00, 10),
(1, 'Keyboard', 'Mechanical keyboard', 80.00, 5),
(2, 'T-Shirt', 'Cotton T-shirt', 20.00, 30),
(3, 'Novel', 'Fiction book', 15.00, 20);

INSERT INTO Users.WishList (UserID)
VALUES
(1),
(2);

INSERT INTO Users.WishListItem (WishListId, ProductId)
VALUES
(1, 1),
(1, 3),
(2, 2);

INSERT INTO Users.Cart (UserID)
VALUES
(1),
(2);

INSERT INTO Users.CartItem (CartId, ProductId, Quantity)
VALUES
(1, 1, 2),
(1, 2, 1),
(2, 3, 3);

INSERT INTO Orders.Orders (UserId, OrderDate, Status, Amount)
VALUES
(1, GETDATE(), 'Pending', 180.00),
(2, GETDATE(), 'Paid', 60.00),
(1, '2024-01-01', 'Paid', 100),
(2, '2024-02-01', 'Paid', 200),
(3, '2024-03-01', 'Shipped', 150),
(3, '2024-04-01', 'Pending', 300),
(2, '2024-05-01', 'Paid', 250),
(1, '2024-06-01', 'Paid', 180),
(2, '2024-07-01', 'Cancelled', 90),
(3, '2024-08-01', 'Paid', 400),
(2, '2024-09-01', 'Shipped', 220),
(2, '2024-10-01', 'Paid', 310);

INSERT INTO Orders.OrderItem (OrderId, ProductId, Quantity)
VALUES
(1, 1, 2),
(1, 2, 1),
(2, 3, 3);

INSERT INTO Orders.Payment (OrderId, Method, PaymentDate, Amount, Status)
VALUES
(2, 'CreditCard', GETDATE(), 60.00, 'Completed');

INSERT INTO Orders.Review (UserId, ProductId, Rating, Comment)
VALUES
(1, 1, 5, 'Excellent product'),
(2, 2, 4, 'Very good'),
(3, 3, 3, 'Good');

--Update-----------------------------------

UPDATE Users.Users SET 
FirstName = 'Rahma',LastName='Obeidat',
Email='rahma@gmail.com',UpdateAt=GETDATE() WHERE Id=3;

UPDATE Orders.Orders SET 
Status = 'Shipped',UpdateAt=GETDATE() WHERE Id=1;

UPDATE Orders.Payment SET
Status = 'Completed',PaymentDate=GETDATE() WHERE Id=1;

--soft delete-------------------------------------

UPDATE Users.Users SET 
IsDeleted = 1,UpdateAt=GETDATE() WHERE ID = 3;

UPDATE Users.Cart SET
IsDeleted = 1,UpdateAt=GETDATE() WHERE Id=1;

UPDATE Orders.Orders SET
IsDeleted = 1,UpdateAt=GETDATE() WHERE Id=1;

--Select--------------------------------------------
--Scenario 1-----------------------
SELECT u.Id,u.FirstName+' '+u.LastName Name,u.Email,
p.phone , o.OrderDate,o.Status,o.Amount
FROM Users.Users u JOIN Users.UserPhone p ON u.Id = p.UserId
JOIN Orders.Orders o ON u.Id = o.UserId
WHERE u.IsDeleted=0 AND o.IsDeleted=0;

--Scenario 2-----------------------
SELECT Name,Price FROM Products.Products ORDER BY Price;

--Scenario 3-----------------------
SELECT p.Name,AVG(Rating) Rating FROM Products.Products p 
JOIN Orders.Review r ON p.Id = r.ProductId
GROUP BY p.Name;

--Scenario 4-----------------------
SELECT u.Id,p.Name FROM Users.WishList w JOIN 
Users.Users u ON u.Id = w.UserID JOIN
Users.WishListItem wi ON w.Id = wi.WishListId JOIN 
Products.Products p ON p.Id = wi.ProductId
WHERE w.UserID = 1 AND p.IsDeleted = 0;

--Scenario 5-----------------------
SELECT u.Id,u.FirstName+' '+u.LastName Name,SUM(p.Amount) TotalSales 
FROM Users.Users u JOIN 
Orders.Orders o ON u.Id = o.UserId JOIN
Orders.Payment p ON o.Id = p.OrderId WHERE o.IsDeleted = 0 
GROUP BY u.Id,u.FirstName+' '+u.LastName;

--Scenario 6-----------------------
SELECT Name,Price FROM Products.Products WHERE
Price BETWEEN 50 AND 100 AND IsDeleted = 0;

--Scenario 7-----------------------
--TOP5
SELECT TOP 5 u.Id UserId,u.FirstName+' '+u.LastName Name ,
o.Id OrderId, o.OrderDate 
FROM Orders.Orders o JOIN 
Users.Users u ON u.Id = o.UserId WHERE
o.IsDeleted = 0 ORDER BY o.OrderDate DESC;

--Bouns-----------------------
--Index (Every table have Clustered Index which is PK(Id))
CREATE INDEX idx_user_email ON Users.Users(Email);
CREATE INDEX idx_product_cat ON Products.Products(CategoryId);
CREATE INDEX idx_product_price ON Products.Products(Price);
CREATE INDEX idx_wishList_userId ON Users.WishList(UserId);
CREATE INDEX idx_wishlistitem_product ON Users.WishListItem(ProductId);
CREATE INDEX idx_cart_userId ON Users.Cart(UserId);
CREATE INDEX idx_cartitem_product ON Users.CartItem(ProductId);
CREATE INDEX idx_orders_userId ON Orders.Orders(UserId);
CREATE INDEX idx_orders_date ON Orders.Orders(OrderDate);
CREATE INDEX idx_orders_isdeleted ON Orders.Orders(IsDeleted);
CREATE INDEX idx_payment_orderId ON Orders.Payment(OrderId);
CREATE INDEX idx_review_product ON Orders.Review(ProductId);
CREATE INDEX idx_review_user ON Orders.Review(UserId);

--Referential actions(on delete cascade/set null)

/*SELECT name FROM sys.foreign_keys 
WHERE parent_object_id = OBJECT_ID('Products.Products');*/
ALTER TABLE Users.UserPhone DROP CONSTRAINT FK__UserPhone__UserI__59FA5E80;

ALTER TABLE Users.UserPhone ADD CONSTRAINT FK__UserPhone__UserI__59FA5E80 
FOREIGN KEY(UserId) REFERENCES Users.Users(Id) 
ON DELETE CASCADE;

ALTER TABLE Products.Products
ALTER COLUMN CategoryId INT NULL;

ALTER TABLE Products.Products
DROP CONSTRAINT FK__Products__Catego__619B8048;

ALTER TABLE Products.Products
ADD CONSTRAINT FK__Products__Catego__619B8048
FOREIGN KEY (CategoryId)
REFERENCES Products.Categories(Id)
ON DELETE SET NULL;

--Stored procedures
--Triggers
CREATE TRIGGER insertUser ON Users.Users AFTER INSERT
AS SELECT 'Added Succesfully';

CREATE TABLE Users.UserLog(
Id INT PRIMARY KEY IDENTITY(1,1),
UserId INT,
Action VARCHAR(20),
ActionDate DATETIME DEFAULT GETDATE()
);
CREATE TRIGGER insertUser ON Users.Users AFTER INSERT AS
BEGIN
INSERT INTO Users.UserLog(UserId,Action)
SELECT Id,'INSERT' FROM INSERTED;
END;

--OFFSET 5-5
SELECT u.Id UserId,u.FirstName+' '+u.LastName Name ,
o.Id OrderId, o.OrderDate 
FROM Orders.Orders o JOIN 
Users.Users u ON u.Id = o.UserId WHERE
o.IsDeleted = 0 ORDER BY o.OrderDate DESC
OFFSET 5 ROWS FETCH NEXT 5 ROWS ONLY;


