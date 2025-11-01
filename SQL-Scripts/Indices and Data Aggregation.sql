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
SELECT AgeGroup,
	   COUNT(AgeGroup) AS WizardCount
FROM (
		SELECT CASE
					WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
					WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
					WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
					WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
					WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
					WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
					WHEN Age > 60 THEN '[61+]'
				END AS AgeGroup		
		FROM WizzardDeposits
	 ) AS dt
GROUP BY AgeGroup

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

SELECT SUM(dt.[Difference]) AS SumDifference
FROM (
		SELECT h.FirstName AS [Host Wizard],
			   h.DepositAmount AS [Host Wizard Deposit],
			   g.FirstName AS [Guest Wizard],
			   g.DepositAmount AS [Guest Wizard Deposit],
			   h.DepositAmount - g.DepositAmount AS [Difference]
		FROM WizzardDeposits AS h
		JOIN WizzardDeposits AS g ON g.Id = h.Id + 1
	 ) AS dt


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

SELECT
DISTINCT DepartmentID,
		 Salary AS ThirdHighestSalary
FROM (
		SELECT DepartmentID, 
			   Salary,
			   DENSE_RANK() OVER(PARTITION BY DepartmentID ORDER BY Salary DESC) AS [Rank]
		FROM Employees
	 ) AS RankSalary
WHERE [Rank] = 3

-- Problem 19
SELECT TOP (10)
	   e.FirstName,
	   e.LastName,
	   e.DepartmentID
FROM Employees AS e
WHERE e.Salary > (
					SELECT AVG(DepAvg.Salary) AS AvgSalary
					FROM Employees AS DepAvg
					WHERE DepAvg.DepartmentID = e.DepartmentID
					GROUP BY DepAvg.DepartmentID
				  )


