
-- Problem 1

SELECT FirstName,
       LastName
  FROM Employees
 WHERE FirstName LIKE 'Sa%'

-- Problem 2

SELECT FirstName,
       LastName
  FROM Employees
 WHERE LastName LIKE '%ei%'

 -- Problem 3

SELECT FirstName       
  FROM Employees
 WHERE DepartmentID IN (3, 10) AND (DATEPART(year, HireDate) BETWEEN (1995) AND (2005))

-- Problem 4

SELECT FirstName,
       LastName
  FROM Employees
 WHERE CHARINDEX('engineer', JobTitle) = 0

 -- Problem 5

  SELECT [Name]
    FROM Towns
   WHERE LEN([Name]) = 5 OR LEN([Name]) = 6
ORDER BY [Name]

-- Problem 6

  SELECT TownID,
         [Name]
    FROM Towns
   WHERE  LEFT([Name], 1) IN ('M', 'K', 'B', 'E')
ORDER BY [Name]

-- Problem 7

SELECT TownID,
         [Name]
    FROM Towns
   WHERE  LEFT([Name], 1) NOT IN ('R', 'B', 'D')
ORDER BY [Name]

-- Problem 8

CREATE VIEW V_EmployeesHiredAfter2000 AS
     SELECT FirstName,
	        LastName
       FROM Employees
	  WHERE DATEPART(year, HireDate) > 2000 
	
-- Problem 9

SELECT FirstName,
       LastName
FROM Employees
WHERE LEN(LastName) = 5

-- Problem 10

SELECT EmployeeID,
       FirstName,
	   LastName,
	   Salary,
	   DENSE_RANK ( ) OVER ( PARTITION BY Salary ORDER BY EmployeeID ) AS [Rank]
FROM Employees
WHERE Salary BETWEEN 10000 AND 50000
ORDER BY Salary DESC

-- Problem 11

SELECT *
FROM 
		(
			SELECT EmployeeID,
				   FirstName,
				   LastName,
				   Salary,
				   DENSE_RANK ( ) OVER ( PARTITION BY Salary ORDER BY EmployeeID ) AS [Rank]
			FROM Employees
			WHERE Salary BETWEEN 10000 AND 50000			
		) 
	  AS e
   WHERE [Rank] = 2
ORDER BY Salary DESC

GO

-- PART 2

USE [Geography]

GO

-- Problem 12

SELECT [CountryName] AS [Country Name],
	[IsoCode] AS [ISO Code]
FROM [Countries]
WHERE (LEN(CountryName) - LEN(REPLACE(UPPER(CountryName), 'A', ''))) >= 3
ORDER BY [IsoCode]

-- Problem 13

SELECT p.PeakName,
	   r.RiverName,
	   LOWER(CONCAT(p.PeakName, STUFF(r.RiverName, 1, 1, ''))) AS Mix
FROM Peaks AS p,
	Rivers AS r
WHERE RIGHT(p.PeakName, 1) = LEFT(r.RiverName, 1)
ORDER BY [Mix]

-- Part 3
USE Diablo

GO

-- Problem 14

SELECT TOP(50) [Name],
	   FORMAT([Start], 'yyyy-MM-dd') AS [Start]
FROM Games
WHERE DATEPART(year, [Start]) IN (2011, 2012)
ORDER BY [Start], [Name]

-- Problem 15

SELECT [UserName],
	STUFF([Email], 1, CHARINDEX('@', [Email]), '') AS [Email Provider]
FROM Users
ORDER BY [Email Provider], [Username]

-- Problem 16

SELECT [Username],
		[IpAddress] AS [IP Address]
FROM Users
WHERE ([IpAddress] LIKE '___.1%.%.___')
ORDER BY [Username]

-- Problem 17

SELECT [Name],
	CASE
		WHEN DATEPART(HOUR, [Start]) BETWEEN 0 and 11 THEN 'Morning'
		WHEN DATEPART(HOUR, [Start]) BETWEEN 12 AND 17 THEN 'Afternoon'
		ELSE 'Evening'
	END
	AS [Part of the Day],
	CASE
		WHEN [Duration] <= 3 THEN 'Extra Short'
		WHEN [Duration] BETWEEN 4 AND 6 THEN 'Short'
		WHEN [Duration] > 6 THEN 'Long'
		ELSE 'Extra Long'
	END
	AS [Duration]
FROM [Games]
ORDER BY [Name], [Duration], [Part of the Day]

-- Problem 18

CREATE DATABASE [TestDB]

GO

USE TestDB

GO

CREATE TABLE [Orders] (
	[Id] INT PRIMARY KEY IDENTITY,
	[ProductName] VARCHAR(100) NOT NULL,
	[OrderDate] DATETIME2 NOT NULL
)

INSERT INTO Orders (ProductName, OrderDate)
VALUES
('Butter', '2016-09-19 00:00:00.000'),
('Milk', '2016-09-30 00:00:00.000'),
('Cheese', '2016-09-04 00:00:00.000'),
('Bread', '2015-12-20 00:00:00.000'),
('Tomatoes', '2015-01-01 00:00:00.000')

SELECT [ProductName],
		[OrderDate],
		DATEADD(DAY, 3, [OrderDate]) AS [Pay Due],
		DATEADD(MONTH, 1, [OrderDate]) AS [Deliver Due]
FROM Orders