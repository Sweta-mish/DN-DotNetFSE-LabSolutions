
-- Exercise 1: Ranking and Window Functions --


USE OnlineRetailStore;
GO

-- Create Products table only if it doesn't exist
IF OBJECT_ID('Products', 'U') IS NULL
BEGIN
    CREATE TABLE Products
    (
        ProductID INT PRIMARY KEY,
        ProductName VARCHAR(100),
        Category VARCHAR(50),
        Price DECIMAL(10,2)
    );
END
GO

-- Insert sample data only if the table is empty
IF NOT EXISTS (SELECT 1 FROM Products)
BEGIN
    INSERT INTO Products VALUES
    (101,'Laptop','Electronics',85000),
    (102,'Mobile','Electronics',65000),
    (103,'Smart Watch','Electronics',25000),
    (104,'Headphones','Electronics',12000),
    (105,'Tablet','Electronics',45000),

    (201,'Shirt','Fashion',2000),
    (202,'Jeans','Fashion',3500),
    (203,'Jacket','Fashion',6000),
    (204,'Shoes','Fashion',5000),
    (205,'Cap','Fashion',1000),

    (301,'Chair','Furniture',7000),
    (302,'Table','Furniture',15000),
    (303,'Sofa','Furniture',40000),
    (304,'Bed','Furniture',35000),
    (305,'Cupboard','Furniture',30000);
END
GO


-- Display all products --


SELECT * FROM Products;
GO


-- ROW_NUMBER() --
-- Assign a unique rank within each category


SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RowNumber
FROM Products;
GO


-- Top 3 most expensive products in each category --


SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RowNumber
    FROM Products
) RankedProducts
WHERE RowNumber <= 3;
GO


-- RANK() --


SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS ProductRank
FROM Products;
GO


-- DENSE_RANK() --


SELECT
    ProductID,
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS DenseRank
FROM Products;
GO


-- Compare ROW_NUMBER, RANK and DENSE_RANK --

SELECT
    ProductID,
    ProductName,
    Category,
    Price,

    ROW_NUMBER() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RowNumber,

    RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RankNumber,

    DENSE_RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS DenseRank

FROM Products;
GO