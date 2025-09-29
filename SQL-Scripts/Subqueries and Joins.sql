USE [SoftUni]

GO

-- Problem 1

SELECT TOP (5) e.EmployeeId,
		e.JobTitle,
		a.AddressID,
		a.AddressText
FROM [Employees] AS e
JOIN [Addresses] AS a 
	ON e.AddressID = a.AddressID
ORDER BY a.AddressID

-- Problem 2

SELECT TOP (50) e.FirstName,
				e.LastName,
				t.[Name] AS Town,
				a.AddressText
FROM [Employees] AS e
JOIN [Addresses] AS a 
	ON e.AddressID = a.AddressID
JOIN [Towns] AS t 
	ON a.TownID = t.TownID
ORDER BY e.FirstName, e.LastName

-- Problem 3

SELECT e.EmployeeID,
		e.FirstName,
		e.LastName,
		d.[Name] AS DepartmentName
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE d.[Name] = 'Sales'
ORDER BY e.EmployeeID

-- Problem 4

SELECT TOP 5 e.EmployeeID,
			 e.FirstName,
			 e.Salary,
			 d.[Name] AS DepartmentName
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE e.Salary > 15000
ORDER BY d.DepartmentID

-- Problem 5

SELECT TOP 3 e.EmployeeID,
			 e.FirstName
FROM Employees AS e
LEFT JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
WHERE ep.EmployeeID IS NULL
ORDER BY e.EmployeeID

-- Problem 6

SELECT e.FirstName,
		e.LastName,
		e.HireDate,
		d.[Name] AS [DeptName]
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE d.[Name] IN ('Sales', 'Finance') AND DATEPART(YEAR, e.HireDate) >= 1999
ORDER BY e.HireDate

-- Problem 7

SELECT TOP (5)
		e.EmployeeID,
		e.FirstName,
		p.[Name] AS ProjectName
FROM EmployeesProjects AS ep
JOIN Employees AS e ON ep.EmployeeID = e.EmployeeID
JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE p.StartDate > '08/13/2002' AND p.EndDate IS NULL
ORDER BY ep.EmployeeID

-- Problem 8

SELECT e.EmployeeID,
		e.FirstName,
		p.[Name] AS ProjectName
FROM EmployeesProjects AS ep
JOIN Employees AS e ON ep.EmployeeID = e.EmployeeID
LEFT JOIN Projects AS p ON ep.ProjectID = p.ProjectID AND DATEPART(YEAR, p.StartDate) < '2002'
WHERE e.EmployeeID = 24

-- Problem 9

SELECT e.EmployeeID,
		e.FirstName,
		e.ManagerID,
		m.FirstName AS ManagerName
FROM Employees AS e
JOIN Employees AS m ON e.ManagerID = m.EmployeeID
WHERE e.ManagerID IN (3, 7)
ORDER BY e.EmployeeID

-- Problem 10

SELECT TOP (50)
		e.EmployeeID,
		CONCAT_WS(' ', e.FirstName, e.LastName) AS EmployeeName,		
		CONCAT_WS(' ', m.FirstName, m.LastName) AS ManagerName,
		d.[Name] AS DepartmentName
FROM Employees AS e
JOIN Employees AS m ON e.ManagerID = m.EmployeeID
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
ORDER BY e.EmployeeID

-- Problem 11

SELECT TOP (1) 
		AVG(Salary) AS MinAverageSalary
FROM Employees AS e
GROUP BY DepartmentID
ORDER BY MinAverageSalary

-- Problem 12

USE [Geography]

GO

SELECT mc.CountryCode,
		m.MountainRange,
		p.PeakName,
		p.Elevation
FROM MountainsCountries AS mc
JOIN Mountains AS m ON mc.MountainId = m.Id
JOIN Peaks AS p ON m.Id = p.MountainId
WHERE mc.CountryCode = 'BG' AND p.Elevation > 2835
ORDER BY p.Elevation DESC

-- Problem 13

SELECT CountryCode,
		COUNT(m.MountainRange) AS MountainRanges
FROM MountainsCountries mc
JOIN Mountains AS m ON mc.MountainId = m.Id 
WHERE CountryCode IN ('US', 'RU', 'BG')
GROUP BY CountryCode

-- Problem 14

SELECT TOP (5)
		cy.CountryName,
		r.RiverName
FROM Countries AS cy
JOIN Continents AS c ON cy.ContinentCode = c.ContinentCode
LEFT JOIN CountriesRivers AS cr ON cy.CountryCode = cr.CountryCode
LEFT JOIN Rivers AS r ON cr.RiverId = r.Id
WHERE c.ContinentName = 'Africa'
ORDER BY cy.CountryName

-- Problem 15

SELECT ContinentCode,
	   CurrencyCode,
	   CurrencyUsage
FROM (
		SELECT *,
	   DENSE_RANK() OVER (PARTITION BY ContinentCode ORDER BY CurrencyUsage DESC) AS [Rank]
		FROM (
				SELECT ContinentCode,
					   CurrencyCode,
				COUNT(CountryCode) AS CurrencyUsage
				FROM Countries
				WHERE CurrencyCode IS NOT NULL
				GROUP BY ContinentCode, 
						 CurrencyCode
				HAVING COUNT(CurrencyCode) > 1
			 ) AS dt
	 ) AS dt2
WHERE [Rank] = 1
ORDER BY ContinentCode



-- Problem 16

SELECT COUNT(c.CountryCode) AS [Count]
FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
WHERE mc.MountainId IS NULL

-- Problem 17

SELECT  TOP (5)
		CountryName,
		HighestPeakElevation,
		LongestRiverLength
FROM  (
		  SELECT 
				 c.CountryName,
				 p.Elevation AS HighestPeakElevation,
				 r.[Length] AS LongestRiverLength,
				 DENSE_RANK() OVER (PARTITION BY c.CountryName ORDER BY p.Elevation DESC,
				 r.[Length] DESC) AS [Rank]
			FROM Countries AS c
			LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
			LEFT JOIN Mountains AS m ON mc.MountainId = m.Id
			LEFT JOIN Peaks AS p ON m.Id = p.MountainId
			LEFT JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
			LEFT JOIN Rivers AS r ON cr.RiverId = r.Id			
	  ) AS dt
WHERE [Rank] = 1
ORDER BY HighestPeakElevation DESC,
		 LongestRiverLength DESC,
		 CountryName

-- Problem 18

SELECT TOP (5)
	   Country,
	   CASE
			WHEN [Highest Peak Name] IS NULL THEN '(no highest peak)'
			ELSE [Highest Peak Name]
		END AS [Highest Peak Name],
		CASE
			WHEN [Highest Peak Elevation] IS NULL THEN '0'
			ELSE [Highest Peak Elevation]
		END AS [Highest Peak Elevation],
		CASE
			WHEN Mountain IS NULL THEN '(no mountain)'
			ELSE Mountain
		END AS Mountain
FROM (
		SELECT c.CountryName AS Country,
			   p.PeakName AS [Highest Peak Name],
			   p.Elevation AS [Highest Peak Elevation],
			   m.MountainRange AS Mountain,
			   DENSE_RANK() OVER (PARTITION BY c.CountryName ORDER BY p.Elevation DESC) AS [Rank]
		FROM Countries AS c
		LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
		LEFT JOIN Mountains AS m ON mc.MountainId = m.Id
		LEFT JOIN Peaks AS p ON m.Id = p.MountainId
	 ) AS dt
WHERE [Rank] = 1
ORDER BY Country,
		 [Highest Peak Name]