-- PART 1
USE Gringotts

GO

-- Problem 1

SELECT 
	COUNT(Id) AS [Count]
FROM WizzardDeposits

-- Problem 2

SELECT 
	   MAX(MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits

-- Problem 3

SELECT DepositGroup,
	   MAX(MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits
GROUP BY DepositGroup

-- Problem 4

SELECT TOP (2)
		DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
HAVING AVG(MagicWandSize) > 1
ORDER BY AVG(MagicWandSize)

-- Problem 5

SELECT DepositGroup,
	   SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
GROUP BY DepositGroup

-- Problem 6

SELECT DepositGroup,
	   SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup

-- Problem 7

SELECT DepositGroup,
	   SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup
HAVING SUM(DepositAmount) < 150000
ORDER BY SUM(DepositAmount) DESC

-- Problem 8

SELECT DepositGroup,
	   MagicWandCreator,
	   MIN(DepositCharge) AS MinDepositCharge
FROM WizzardDeposits
GROUP BY DepositGroup,
		 MagicWandCreator
ORDER BY MagicWandCreator,
		 DepositGroup

-- Problem 9

-- TODO

-- Problem 11

SELECT DepositGroup,
	   IsDepositExpired,
	   AVG(DepositInterest) AS AverageInterest
FROM WizzardDeposits
WHERE DATEPART(YEAR, DepositStartDate) >= '1985'
GROUP BY DepositGroup,
		 IsDepositExpired
ORDER BY DepositGroup DESC,
		 IsDepositExpired

-- Problem 12

-- TODO

-- PART 2
USE SoftUni

GO
-- Problem 13

SELECT DepartmentID,
	   SUM(Salary) AS TotalSalary
FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID

-- Problem 14

SELECT DepartmentID,
	   MIN(Salary) AS MinimumSalary
FROM Employees
WHERE DepartmentID IN (2, 5, 7) AND DATEPART(YEAR, HireDate) >= '2000'
GROUP BY DepartmentID

-- Problem 15

SELECT *
INTO EmployeesOver30000
FROM Employees
WHERE Salary > 30000

DELETE 
FROM EmployeesOver30000
WHERE ManagerID = 42

UPDATE EmployeesOver30000
SET Salary += 5000
WHERE DepartmentID = 1

SELECT DepartmentID,
	   AVG(Salary) AS AverageSalary
FROM EmployeesOver30000
GROUP BY DepartmentID

-- Problem 16

SELECT DepartmentID,
	   MAX(Salary) AS MaxSalary
FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000

-- Problem 17

SELECT COUNT(Salary) AS Count
FROM Employees
WHERE ManagerID IS NULL

-- Problem 18

-- TODO

-- Problem 19

-- TODO

