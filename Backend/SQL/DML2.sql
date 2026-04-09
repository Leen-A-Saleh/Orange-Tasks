CREATE DATABASE CompanyDB;

USE CompanyDB;

CREATE TABLE Departments (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(20)
);

CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(20),
    Salary DECIMAL(10,2),
    DeptId INT,
    FOREIGN KEY (DeptId) REFERENCES Departments(Id),
);

CREATE TABLE Projects (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(20),
    Budget DECIMAL(10,2)
);

CREATE TABLE EmployeeProjects (
    Id INT PRIMARY KEY IDENTITY (1,1),
    EmployeeId INT,
    ProjectId INT
);


INSERT INTO Departments (Name)
VALUES
('IT'),
('HR'),
('Sales');


INSERT INTO Employees (Name, Salary, DeptId)
VALUES
('Ahmad', 1000, 1),
('Ali', 1500, 1),
('Sara', 1200, 2),
('Omar', 2000, 3),
('Lina', 1800, 3);


INSERT INTO Projects (Name, Budget)
VALUES
('Website', 5000),
('Mobile App', 8000),
('CRM System', 6000);


INSERT INTO EmployeeProjects (EmployeeId, ProjectId)
VALUES
(1, 1),
(2, 1),
(3, 2),
(4, 3),
(5, 2);

--Tasks-------

SELECT COUNT(*) AS CountEmp FROM Employees ;

SELECT SUM(Salary) AS TotalSalary FROM Employees ;

SELECT AVG(Salary) AS AVGSalary FROM Employees ;

SELECT MAX(Salary),MIN(Salary) AS MINMAXSalary FROM Employees ;

SELECT COUNT(*) AS Salary FROM Employees WHERE Salary >1500;

SELECT Name , COUNT(*) FROM Departments GROUP BY Name;

SELECT DeptId , SUM(Salary) FROM Employees GROUP BY DeptId;

SELECT DeptId , AVG(Salary) FROM Employees GROUP BY DeptId;

SELECT DeptId,COUNT(*) AS EMpCount FROM Employees GROUP BY DeptId HAVING COUNT(*) > 1;

SELECT DeptId FROM Employees GROUP BY DeptId HAVING SUM(Salary)>2500; 

SELECT e.Name,d.Name FROM Employees e JOIN 
Departments d ON e.Id = d.Id;

SELECT e.Name,p.Name FROM Employees e JOIN
EmployeeProjects ep ON e.Id = ep.EmployeeId JOIN
Projects p ON p.Id = ep.ProjectId;

SELECT p.Name,COUNT(*) FROM Projects p JOIN
EmployeeProjects ep ON p.Id = ep.ProjectId JOIN
Employees e ON e.Id = ep.EmployeeId
GROUP BY p.Name;

SELECT d.Name,SUM(Salary) AS 'TotalSalary' FROM  Departments d JOIN
Employees e ON d.Id = e.DeptId
GROUP BY d.Name;

SELECT e.Name,p.Name FROM Employees e JOIN
EmployeeProjects ep ON e.Id = ep.EmployeeId JOIN
Projects p ON p.Id = ep.ProjectId WHERE p.Name= 'Mobile App';

SELECT Name,Salary FROM Employees WHERE Salary > (SELECT AVG(Salary) FROM Employees);

SELECT TOP(2) Name,Salary FROM Employees ORDER BY Salary DESC;

SELECT e.Name FROM Employees e LEFT JOIN 
EmployeeProjects ep ON e.Id = ep.EmployeeId
WHERE ep.EmployeeId IS NULL; 

CREATE INDEX idx_empName ON Employees(Name);

CREATE INDEX idx_emp ON Employees (Name, Salary);

DROP INDEX idx_empName ON Employees;