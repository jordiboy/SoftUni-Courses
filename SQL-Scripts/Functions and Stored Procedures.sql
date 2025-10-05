-- PART 1

USE SoftUni

GO

-- Problem 1

CREATE OR ALTER PROC usp_GetEmployeesSalaryAbove35000
AS
SELECT FirstName AS [First Name],
	   LastName AS [Last Name]
FROM Employees
WHERE Salary > 35000

EXEC usp_GetEmployeesSalaryAbove35000

-- Problem 2

CREATE PROC [usp_GetEmployeesSalaryAboveNumber] @MinSalary DECIMAL(18, 4)
AS
	(
		SELECT FirstName AS [First Name],
			   LastName AS [Last Name]
		FROM Employees
		WHERE Salary >= @MinSalary
	)

EXEC usp_GetEmployeesSalaryAboveNumber 48100

-- Problem 3

CREATE OR ALTER PROC usp_GetTownsStartingWith @TownStartWith CHAR(10)
AS
		
	DECLARE @stringLength INT = LEN(@TownStartWith);
		
	SELECT [Name] AS Town
	FROM Towns
	WHERE SUBSTRING([Name], 1, @stringLength) = @TownStartWith
	

EXEC usp_GetTownsStartingWith 'be'

-- Problem 4

CREATE OR ALTER PROC usp_GetEmployeesFromTown @TownName VARCHAR(50)
AS
	SELECT e.FirstName AS [First Name],
		   e.LastName AS [Last Name]
	FROM Employees AS e
	JOIN Addresses AS a ON e.AddressID = a.AddressID
	JOIN Towns AS t ON a.TownID = t.TownID
	WHERE t.[Name] = @TownName

EXEC usp_GetEmployeesFromTown 'Sofia'

-- Problem 5

CREATE OR ALTER FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS VARCHAR(10)
	AS
	BEGIN
			DECLARE @salaryLevel VARCHAR(10)

			IF @salary < 30000 SET @salaryLevel = 'Low'
			IF @salary BETWEEN 30000 AND 50000 SET @salaryLevel = 'Average'
			IF @salary > 50000 SET @salaryLevel = 'High'

			RETURN @salaryLevel
	END

SELECT Salary,
		dbo.ufn_GetSalaryLevel(Salary) AS [Salary Level]
FROM Employees

-- Problem 6

CREATE OR ALTER PROC usp_EmployeesBySalaryLevel @SalaryLevel VARCHAR(10)
	AS
	SELECT dt.FirstName AS [First Name],
		   dt.LastName AS [Last Name]
	FROM (
			SELECT FirstName,
				   LastName,
				   dbo.ufn_GetSalaryLevel(Salary) AS SalaryLevel
			  FROM Employees
		)
		AS dt
	WHERE dt.SalaryLevel = @SalaryLevel

EXEC usp_EmployeesBySalaryLevel 'high'

-- Problem 7

CREATE OR ALTER FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(50), @word VARCHAR(50))
RETURNS BIT
	AS
	BEGIN			
			DECLARE @index TINYINT = 1
			DECLARE @currentChar VARCHAR(1)

			WHILE (@index <= LEN(@word))
				BEGIN
					SET @currentChar = SUBSTRING(@word, @index, 1)

					IF CHARINDEX(@currentChar, @setOfLetters) <= 0 RETURN 0
						
					SET @index += 1
				END
			RETURN 1
	END

SELECT dbo.ufn_IsWordComprised('oistmiahf', 'halves')

-- Problem 8

-- TODO

-- PART 2

USE Bank

GO

-- Problem 9

CREATE OR ALTER PROC usp_GetHoldersFullName
	AS
		SELECT CONCAT_WS(' ', FirstName, LastName) AS [Full Name]
		FROM AccountHolders

EXEC usp_GetHoldersFullName

-- Problem 10

CREATE OR ALTER PROC usp_GetHoldersWithBalanceHigherThan @TotalBalance MONEY
	AS
		SELECT dt.FirstName AS [First Name],
			   dt.LastName AS [Last Name]
		FROM (
				SELECT FirstName,
					   LastName,
					   SUM(Balance) AS Total
				FROM Accounts AS a
				JOIN AccountHolders AS ah ON a.AccountHolderId = ah.Id
				GROUP BY FirstName, 
						 LastName
			 ) AS dt
		WHERE Total > @TotalBalance
		ORDER BY dt.FirstName,
				 dt.LastName

EXEC usp_GetHoldersWithBalanceHigherThan 25000

-- Problem 11

CREATE OR ALTER FUNCTION ufn_CalculateFutureValue
(
    @InitialSum DECIMAL(18,4),
    @YearlyInterestRate FLOAT,
    @Years INT
)
RETURNS DECIMAL(18,4)
AS
BEGIN
    DECLARE @FutureValue DECIMAL(18,4)

    SET @FutureValue = @InitialSum * POWER((1 + @YearlyInterestRate), @Years)

    RETURN ROUND(@FutureValue, 4)
END

SELECT dbo.ufn_CalculateFutureValue (123.12, 0.1, 5)

-- Problem 12

CREATE OR ALTER PROC usp_CalculateFutureValueForAccount @AccountId INT, @rate FLOAT
	AS
		SELECT a.Id AS [Account Id],
			   ah.FirstName AS [First Name],
			   ah.LastName AS [Last Name],
			   a.Balance AS [Current Balance],
			   dbo.ufn_CalculateFutureValue(a.Balance, @rate, 5) AS [Balance in 5 years]
		FROM Accounts AS a
		JOIN AccountHolders AS ah ON a.AccountHolderId = ah.Id
		WHERE a.Id = @AccountId

EXEC usp_CalculateFutureValueForAccount 1, 0.1

-- PART 3
USE Diablo

GO
-- Problem 13

CREATE OR ALTER FUNCTION ufn_CashInUsersGames(@GameName NVARCHAR(50))
RETURNS TABLE
	AS RETURN (
					SELECT SUM(Cash) AS SumCash
					FROM (
							SELECT ug.Cash,
									ROW_NUMBER() OVER(ORDER BY ug.Cash DESC) AS RowNum
							FROM UsersGames AS ug
							JOIN Games AS g ON ug.GameID = g.Id
							WHERE g.[Name] = @GameName
						 ) AS dt
					WHERE dt.RowNum % 2 = 1
			  )
