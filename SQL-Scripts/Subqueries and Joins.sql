USE [SoftUni]

GO

-- Problem 1

SELECT TOP 5 e.EmployeeId,
		e.JobTitle,
		a.AddressID,
		a.AddressText
FROM [Employees] AS e
JOIN [Addresses] AS a 
	ON e.AddressID = a.AddressID
ORDER BY a.AddressID

-- Problem 2

SELECT TOP 50 e.FirstName,
				e.LastName,
				t.[Name],
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
		d.[Name]
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE d.[Name] = 'Sales'
ORDER BY e.EmployeeID

-- Problem 4

SELECT TOP 5 e.EmployeeID,
			 e.FirstName,
			 e.Salary,
			 d.[Name]
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
		p.[Name]
FROM EmployeesProjects AS ep
JOIN Employees AS e ON ep.EmployeeID = e.EmployeeID
JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE p.StartDate > '08/13/2002' AND p.EndDate IS NULL
ORDER BY ep.EmployeeID

