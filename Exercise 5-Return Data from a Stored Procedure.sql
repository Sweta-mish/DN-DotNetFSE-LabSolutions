
-- Create Stored Procedure --

CREATE PROCEDURE sp_GetEmployeeCountByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT
        @DepartmentID AS DepartmentID,
        COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO


-- Execute Stored Procedure --

EXEC sp_GetEmployeeCountByDepartment 101;
GO

EXEC sp_GetEmployeeCountByDepartment 102;
GO

