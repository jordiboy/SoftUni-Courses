
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
 WHERE  CHARINDEX('engineer', JobTitle) = 0

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
	   DENSE_RANK ( ) OVER ( PARTITION BY Salary ORDER BY EmployeeID ) AS Rank
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
				   DENSE_RANK ( ) OVER ( PARTITION BY Salary ORDER BY EmployeeID ) AS Rank
			FROM Employees
			WHERE Salary BETWEEN 10000 AND 50000			
		) 
	  AS e
   WHERE [Rank] = 2
ORDER BY Salary DESC