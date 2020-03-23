--CREATE DATABASE EmployeeDb;
--use EmployeeDb;
--using CREATE DATABASE could be expensive b/c we are using azure, so instead create separate schema w/in same database

--USE Chinook;

--drop table EmployeeDbExercise.EmpDetails
--drop table EmployeeDbExercise.Employee
--drop table EmployeeDbExercise.Department
--DROP SCHEMA IF EXISTS EmployeeDbExercise

CREATE SCHEMA EmployeeDbExercise;
GO

CREATE TABLE EmployeeDbExercise.Department(
ID int primary key NOT NULL,
Name nvarchar(20),
Location varchar(20)
);
CREATE TABLE EmployeeDbExercise.Employee(
ID int primary key NOT NULL,
DeptID int foreign key references EmployeeDbExercise.Department(ID) NOT NULL, --need to alt to foreign key a/f creation to modify constraint
FirstName nvarchar(30),
LastName nvarchar(30),
SSN char(9) unique   --ssn no arithmetic req (char instead of int)
);
--EX: 
--ALTER TABLE Employee
--ADD CONSTRAINT DeptID FOREIGN KEY (column1, column2...) NOT NULL;
CREATE TABLE EmployeeDbExercise.EmpDetails(
ID int primary key NOT NULL,
EmployeeID int foreign key references EmployeeDbExercise.Employee(ID) NOT NULL,
Salary money, --2 digits of precision
Address1 varchar(80),
Address2 varchar(80),
City nvarchar(40),
State varchar(40),
Country nvarchar(40)
);

INSERT INTO EmployeeDbExercise.Department (ID, Name, Location)
VALUES
(1, 'Marketing', 'Dallas'),
(2, 'Shipping', 'Dallas'),
(3, 'Sales', 'Dallas')
INSERT INTO EmployeeDbExercise.Employee (ID, DeptID, FirstName, LastName, SSN)
VALUES
(1, 1, 'Tina', 'Smith', '111111111'),
(2, 1, 'Bob', 'Builder', '222222222'),
(3, 1, 'Rick', 'Roll', '333333333'),
(4, 1, 'Tom', 'Tuna', '444444444'),
(5, 1, 'Darren', 'Dolittle', '555555555')
INSERT INTO EmployeeDbExercise.EmpDetails
(ID, EmployeeID, Salary, Address1, Address2, City, State, Country)
VALUES 
(1, 1, 70000, '111 S Center St', null, 'Dallas', 'Texas', 'USA'),
(2, 2, 60000, '222 W Left St', null, 'Dallas', 'Texas', 'USA'),
(3, 3, 60000, '333 E Right St', null, 'Dallas', 'Texas', 'USA'),
(4, 4, 60000, '444 N Top Way', null, 'Dallas', 'Texas', 'USA'),
(5, 5, 60000, '555 Animal Dr', null, 'Dallas', 'Texas', 'USA')

--list employees in marketing
SELECT FirstName + ' ' + LastName
FROM EmployeeDbExercise.Employee
WHERE DeptID = 1;
--report total salary of marketing
SELECT SUM(Salary) AS 'SalarySum'
FROM EmployeeDbExercise.EmpDetails
JOIN EmployeeDbExercise.Employee ON EmployeeDbExercise.Employee.ID = EmployeeDbExercise.EmpDetails.EmployeeID
WHERE EmployeeDbExercise.Employee.DeptID = 1;
--report total employees by department
SELECT COUNT(Employee.ID) AS 'Number of Employees'
FROM EmployeeDbExercise.Employee
JOIN EmployeeDbExercise.Department ON EmployeeDbExercise.Department.ID = EmployeeDbExercise.Employee.DeptID
GROUP BY EmployeeDbExercise.Department.ID;
--increase salary of tina smith to $90000
UPDATE EmployeeDbExercise.EmpDetails
SET Salary = 90000
WHERE EmployeeID = 1;
--show new salary for tina
SELECT EmployeeDbExercise.Employee.FirstName, EmployeeDbExercise.EmpDetails.Salary
FROM EmployeeDbExercise.EmpDetails
JOIN EmployeeDbExercise.Employee ON EmployeeDbExercise.Employee.ID = EmployeeDbExercise.EmpDetails.EmployeeID
WHERE EmployeeID = 1;