USE OnlineRetailStore;
GO


-- Create Employees Table (Only if it doesn't exist) --

IF OBJECT_ID('Employees', 'U') IS NULL
BEGIN
    CREATE TABLE Employees
    (
        EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
        FirstName VARCHAR(50),
        LastName VARCHAR(50),
        DepartmentID INT,
        Salary DECIMAL(10,2),
        JoinDate DATE
    );
END
GO


-- Clear Existing Data (Prevents Duplicate Records) --

DELETE FROM Employees;
GO

DBCC CHECKIDENT ('Employees', RESEED, 0);
GO


-- Drop Stored Procedure if it already exists --

IF OBJECT_ID('sp_InsertEmployee', 'P') IS NOT NULL
    DROP PROCEDURE sp_InsertEmployee;
GO


-- Create Stored Procedure to Insert Employee --

CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees
    (
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    (
        @FirstName,
        @LastName,
        @DepartmentID,
        @Salary,
        @JoinDate
    );
END;
GO


-- Insert Sample Employees --

EXEC sp_InsertEmployee
'John',
'Smith',
101,
55000,
'2024-01-10';

EXEC sp_InsertEmployee
'Alice',
'Johnson',
102,
62000,
'2023-06-15';

EXEC sp_InsertEmployee
'Rahul',
'Sharma',
101,
70000,
'2022-09-01';
GO


-- Display All Employees --

SELECT * FROM Employees;
GO


-- Drop Retrieval Procedure if it already exists --

IF OBJECT_ID('sp_GetEmployeesByDepartment', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetEmployeesByDepartment;
GO


-- Create Procedure to Retrieve Employees
-- by DepartmentID

CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO


-- Execute Retrieval Procedure --

EXEC sp_GetEmployeesByDepartment 101;
GO