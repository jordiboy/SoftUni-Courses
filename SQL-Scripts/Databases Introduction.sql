--Problem 1

CREATE DATABASE [Minions]

GO

USE [Minions]

GO

--Problem 2

CREATE TABLE [Minions] (
	[Id] INT PRIMARY KEY,
	[Name] NVARCHAR(36) NOT NULL,
	[Age] INT 
) 

CREATE TABLE [Towns] (
	[Id] INT PRIMARY KEY,
	[Name] NVARCHAR(40) NOT NULL
)

--Problem 3

ALTER TABLE [Minions]
ADD [TownId] INT

ALTER TABLE [Minions]
ADD CONSTRAINT[FK_Minions_TownnId] 
FOREIGN KEY([TownId]) REFERENCES [Towns]([Id])

--Problem 4

INSERT INTO	[Towns]([Id], [Name])
VALUES 
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna')

INSERT INTO [Minions]([Id], [Name], [Age], [TownId])
VALUES
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2)

-- Problem 5

TRUNCATE TABLE [Minions]
TRUNCATE TABLE [Towns]

-- Problem 6

DROP TABLE [Minions]
DROP TABLE [Towns]

-- Problem 7

CREATE TABLE [People](
	[Id] BIGINT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(200) NOT NULL,
	[Picture] VARBINARY(MAX),
	[Height] DECIMAL(6, 2),
	[Weight] DECIMAL(6, 2),
	[Gender] VARCHAR(1) NOT NULL,
	[Birthdate] DATE NOT NULL,
	[Biography] NVARCHAR(MAX)
)

INSERT INTO [People] ([Name], [Gender], [Birthdate])
VALUES
	('Ivan Petrov Ivanov', 'm', '1997-07-11'),
	('Ivan Dimitrov Ivanov', 'm', '1995-05-20'),
	('Diana Petrova Ivanova', 'f', '1980-03-5'),
	('Stefan Dimitrov Ivanov', 'm', '2005-10-15'),
	('Stoianka Petrova Dimitrova', 'f', '1997-02-05')

-- Problem 8

CREATE TABLE [Users] (
	[Id] BIGINT PRIMARY KEY IDENTITY,
	[Username] VARCHAR(30) UNIQUE NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	[ProfilePicture] VARBINARY(MAX),
	[LastLoginTime] DATETIME2,
	[IsDeleted] BIT
)

INSERT INTO [Users] ([Username], [Password], [LastLoginTime])
VALUES
	('gosho', 'asdasdw', GETUTCDATE()),
	('ivan', 'asdasdw12', GETUTCDATE()),
	('stoian', 'asdasdw45', GETUTCDATE()),
	('jordi', 'asdasdw67', GETUTCDATE()),
	('petko', 'asdasdw80', GETUTCDATE())

-- Problem 9

ALTER TABLE [Users]
DROP [PK__Users__3214EC070E03C317]

ALTER TABLE [Users]
ADD CONSTRAINT [PK_Composite_Id_Username]
PRIMARY KEY([Id], [Username])

-- Problem 10

ALTER TABLE [Users]
ADD CONSTRAINT [CK_Passwordlenght_ min_5]
CHECK(LEN([Password]) >= 5)

-- Problem 11

ALTER TABLE [Users]
ADD CONSTRAINT [DF_LastLoginTime]
DEFAULT GETUTCDATE() FOR [LastLoginTime]

-- Problem 12

-- Problem 13

CREATE DATABASE [Movies]

GO

USE [Movies]

GO

CREATE TABLE [Directors] (
	[Id] INT PRIMARY KEY IDENTITY,
	[DirectorName] NVARCHAR(80) NOT NULL,
	[Notes] NVARCHAR(150)
)

CREATE TABLE [Genres] (
	[Id] INT PRIMARY KEY IDENTITY,
	[GenreName] NVARCHAR(30) NOT NULL,
	[Notes] NVARCHAR(150)
)

CREATE TABLE [Categories] (
	[Id] INT PRIMARY KEY IDENTITY,
	[CategoryName] NVARCHAR(30) NOT NULL,
	[Notes] NVARCHAR(150)
)

CREATE TABLE [Movies] (
	[Id] INT PRIMARY KEY IDENTITY,
	[Title] NVARCHAR(100) NOT NULL,
	[DirectorId] INT NOT NULL,
	[CopyrightYear] INT,
	[Length] TIME,
	[GenreId] INT NOT NULL,
	[CategoryId] INT NOT NULL,
	[Rating] DECIMAL(4, 2),
	[Notes] NVARCHAR(150)
)

ALTER TABLE [Movies]
ADD CONSTRAINT [FK_Movies_DirectorId]
FOREIGN KEY ([DirectorId]) REFERENCES [Directors]([Id])

ALTER TABLE [Movies]
ADD CONSTRAINT [FK_Movies_CategoryId]
FOREIGN KEY ([CategoryId]) REFERENCES [Categories]([Id])

ALTER TABLE [Movies]
ADD CONSTRAINT [FK_Movies_GenreId]
FOREIGN KEY ([GenreId]) REFERENCES [Genres]([Id])

INSERT INTO [Directors] ([DirectorName], [Notes])
VALUES 
  ('Christopher Nolan', 'Known for complex and innovative films, often dealing with time and memory.'),
  ('Quentin Tarantino', 'Famous for unique dialogue, nonlinear storytelling, and graphic violence.'),
  ('Steven Spielberg', 'One of the most successful filmmakers in history, known for blockbusters and emotional storytelling.'),
  ('Martin Scorsese', 'Renowned for gritty films about crime and redemption.'),
  ('Ridley Scott', 'Master of science fiction and historical epics, director of classics like "Blade Runner" and "Gladiator".');

INSERT INTO [Genres] ([GenreName], [Notes])
VALUES 
  ('Action', 'Films focused on exciting sequences, intense physical stunts, and fast pacing.'),
  ('Drama', 'Films that focus on emotional narratives and character development.'),
  ('Science Fiction', 'Films dealing with futuristic technology, space exploration, and alternative realities.'),
  ('Comedy', 'Films designed to entertain and induce laughter through humor.'),
  ('Horror', 'Films intended to evoke fear, suspense, and the supernatural.');

INSERT INTO [Categories] ([CategoryName], [Notes])
VALUES 
  ('Blockbuster', 'High-budget, widely marketed films with mass appeal.'),
  ('Independent', 'Low-budget films often produced outside the major studio system.'),
  ('Classic', 'Films that have stood the test of time and are often revered for their artistic value.'),
  ('Documentary', 'Non-fiction films intended to inform or educate the audience.'),
  ('Animated', 'Films that use animation techniques rather than live-action.');

INSERT INTO [Movies] ([Title], [DirectorId], [CopyrightYear], [Length], [GenreId], [CategoryId], [Rating], [Notes])
VALUES 
  ('Inception', 1, 2010, '02:28:00', 3, 1, 8.8, 'A mind-bending thriller about dream manipulation and heists.'),
  ('Pulp Fiction', 2, 1994, '02:34:00', 4, 2, 8.9, 'A nonlinear narrative with intertwining stories of crime and redemption.'),
  ('Jurassic Park', 3, 1993, '02:07:00', 1, 1, 8.1, 'A groundbreaking dinosaur adventure that blends science and wonder.'),
  ('Goodfellas', 4, 1990, '02:26:00', 2, 3, 8.7, 'A gritty portrayal of a mafia family’s rise and fall.'),
  ('Gladiator', 5, 2000, '02:35:00', 1, 4, 8.5, 'A former Roman general seeks revenge in a bloody arena.')


-- Problem 14

CREATE DATABASE [CarRental]

GO

USE [CarRental]

GO

CREATE TABLE [Categories] (
	[Id] INT PRIMARY KEY IDENTITY,
	[CategoryName] VARCHAR(30) NOT NULL,
	[DailyRate] DECIMAL(8, 2) NOT NULL,
	[WeeklyRate] DECIMAL(8, 2),
	[MonthlyRate] DECIMAL(8, 2),
	[WeekendRate] DECIMAL(8, 2)
)

CREATE TABLE [Cars] (
	[Id] INT PRIMARY KEY IDENTITY,
	[PlateNumber] VARCHAR(10) NOT NULL,
	[Manufacturer] VARCHAR(50) NOT NULL,
	[Model] VARCHAR(50) NOT NULL,
	[CarYear] SMALLINT,
	[CategoryId] INT NOT NULL,
	[Doors] TINYINT NOT NULL,
	[Picture] VARBINARY(MAX),
	[Condition] VARCHAR(20),
	[Available] BIT NOT NULL
)

CREATE TABLE [Employees] (
	[Id] INT PRIMARY KEY IDENTITY,
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) NOT NULL,
	[Title] VARCHAR(30) NOT NULL,
	[Notes] VARCHAR(150)
)

CREATE TABLE [Customers] (
	[Id] INT PRIMARY KEY IDENTITY,
	[DriverLicenceNumber] INT NOT NULL,
	[FullName] VARCHAR(150) NOT NULL,
	[Address] VARCHAR(100) NOT NULL,
	[City] VARCHAR(50) NOT NULL,
	[ZIPCode] VARCHAR(10),
	[Notes]	VARCHAR(150)
)

CREATE TABLE [RentalOrders] (
	[Id] INT PRIMARY KEY IDENTITY,
	[EmployeeId] INT NOT NULL,
	[CustomerId] INT NOT NULL,
	[CarId] INT NOT NULL,
	[TankLevel] VARCHAR(50) NOT NULL,
	[KilometrageStart] SMALLINT NOT NULL,
	[KilometrageEnd] SMALLINT NOT NULL,
	[TotalKilometrage] SMALLINT NOT NULL,
	[StartDate] DATE NOT NULL,
	[EndDate] DATE NOT NULL,
	[TotalDays] TINYINT NOT NULL,
	[RateApplied] DECIMAL(8,2) NOT NULL,
	[TaxRate] DECIMAL(8,2) NOT NULL,
	[OrderStatus] BIT NOT NULL,
	[Notes]	VARCHAR(150)
)

ALTER TABLE [Cars]
ADD CONSTRAINT [FK_Cars_CategoryId]
FOREIGN KEY ([CategoryId]) REFERENCES [Categories]([Id])

ALTER TABLE [RentalOrders]
ADD CONSTRAINT [FK_RentalOrders_EmployeeId]
FOREIGN KEY ([EmployeeId]) REFERENCES [Employees]([Id])

ALTER TABLE [RentalOrders]
ADD CONSTRAINT [FK_RentalOrders_CustomerId]
FOREIGN KEY ([CustomerId]) REFERENCES [Customers]([Id])

ALTER TABLE [RentalOrders]
ADD CONSTRAINT [FK_RentalOrders_CarId]
FOREIGN KEY ([CarId]) REFERENCES [Cars]([Id])

INSERT INTO [Categories] ([CategoryName], [DailyRate], [WeeklyRate], [MonthlyRate], [WeekendRate])
VALUES 
  ('Economy', 29.99, 179.99, 699.99, 59.99),
  ('SUV', 59.99, 349.99, 1299.99, 89.99),
  ('Luxury', 99.99, 599.99, 2299.99, 139.99);

INSERT INTO [Cars] ([PlateNumber], [Manufacturer], [Model], [CarYear], [CategoryId], [Doors], [Condition], [Available])
VALUES 
  ('AB123CD', 'Toyota', 'Corolla', 2020, 1, 4, 'New', 1),
  ('XY456ZT', 'Ford', 'Explorer', 2021, 2, 4, 'New', 1),
  ('LM789GH', 'Mercedes', 'S-Class', 2022, 3, 4, 'Excellent', 0);

INSERT INTO [Employees] ([FirstName], [LastName], [Title], [Notes])
VALUES 
  ('John', 'Doe', 'Manager', 'Has been with the company for 5 years'),
  ('Jane', 'Smith', 'Sales Representative', 'Specializes in customer service'),
  ('Michael', 'Johnson', 'Assistant Manager', 'Handles operations and logistics');

INSERT INTO [Customers] ([DriverLicenceNumber], [FullName], [Address], [City], [ZIPCode], [Notes])
VALUES 
  (12345, 'Alice Johnson', '123 Elm St', 'New York', '10001', 'Frequent renter'),
  (23456, 'Bob Martin', '456 Oak Ave', 'Los Angeles', '90001', 'First-time customer'),
  (34567, 'Charlie Brown', '789 Pine Rd', 'Chicago', '60601', 'Loyal customer with VIP status');

INSERT INTO [RentalOrders] ([EmployeeId], [CustomerId], [CarId], [TankLevel], [KilometrageStart], [KilometrageEnd], [TotalKilometrage], [StartDate], [EndDate], [TotalDays], [RateApplied], [TaxRate], [OrderStatus], [Notes])
VALUES 
  (1, 1, 1, 'Full', 1000, 1020, 20, '2025-09-01', '2025-09-03', 2, 29.99, 5.00, 1, 'Customer requested additional features'),
  (2, 2, 2, 'Half', 500, 520, 20, '2025-09-05', '2025-09-07', 2, 59.99, 8.00, 1, 'Late return expected'),
  (3, 3, 3, 'Full', 2000, 2040, 40, '2025-09-10', '2025-09-13', 3, 99.99, 12.00, 0, 'Car returned in poor condition');

GO

-- Problem 15

CREATE DATABASE [Hotel]

GO

USE [Hotel]

GO

CREATE TABLE [Employees] (
	[Id] INT PRIMARY KEY IDENTITY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[Title] NVARCHAR(20) NOT NULL,
	[Notes] NVARCHAR(150)
)

CREATE TABLE [Customers] (
	[AccountNumber] CHAR(10) PRIMARY KEY,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[PhoneNumber] VARCHAR(15) NOT NULL,
	[EmergencyName] VARCHAR(20),
	[EmergencyNumber] VARCHAR(15),
	[Notes] NVARCHAR(150)
)

CREATE TABLE [RoomStatus] (
	[RoomStatus] VARCHAR(10) PRIMARY KEY,
	[Notes] VARCHAR(150)
)

CREATE TABLE [RoomTypes] (
	[RoomType] VARCHAR(20) PRIMARY KEY,
	[Notes] VARCHAR(150)
)

CREATE TABLE [BedTypes] (
	[BedType] VARCHAR(20) PRIMARY KEY,
	[Notes] VARCHAR(150)
)

CREATE TABLE [Rooms] (
	[RoomNumber] INT PRIMARY KEY,
	[RoomType] VARCHAR(20) FOREIGN KEY REFERENCES [RoomTypes]([RoomType]) NOT NULL,
	[BedType] VARCHAR(20) FOREIGN KEY REFERENCES [BedTypes]([BedType]) NOT NULL,
	[Rate] DECIMAL(12, 2) NOT NULL,
	[RoomStatus] VARCHAR(10) FOREIGN KEY REFERENCES [RoomStatus]([RoomStatus]) NOT NULL,
	[Notes] VARCHAR(150)
)

CREATE TABLE [Payments] (
	[Id] INT PRIMARY KEY IDENTITY,
	[EmployeeId] INT FOREIGN KEY REFERENCES [Employees]([Id]) NOT NULL,
	[PaymentDate] DATE NOT NULL,
	[AccountNumber] CHAR(10) FOREIGN KEY REFERENCES [Customers]([AccountNumber]) NOT NULL,
	[FirstDateOccupied] DATE NOT NULL,
	[LastDateOccupied] DATE NOT NULL,
	[TotalDays] AS DATEDIFF(DAY, FirstDateOccupied, LastDateOccupied),
	[AmountCharged] DECIMAL(12, 2) NOT NULL,
	[TaxRate] DECIMAL(12, 2) NOT NULL,
	[TaxAmount] AS (AmountCharged * TaxRate / 100.0),
	[PaymentTotal] AS (AmountCharged + (AmountCharged * TaxRate / 100.0)),
	[Notes] VARCHAR(150)
)

CREATE TABLE [Occupancies] (
	[Id] INT PRIMARY KEY IDENTITY,
	[EmployeeId] INT FOREIGN KEY REFERENCES [Employees]([Id]) NOT NULL,
	[DateOccupied] DATE NOT NULL,
	[AccountNumber] CHAR(10) FOREIGN KEY REFERENCES [Customers]([AccountNumber]) NOT NULL,
	[RoomNumber] INT FOREIGN KEY REFERENCES [Rooms]([RoomNumber]) NOT NULL,
	[RateApplied] DECIMAL(12, 2) NOT NULL,
	[PhoneCharge] DECIMAL(12,2) NOT NULL DEFAULT 0,
	[Notes] VARCHAR(150)
)

-- Employees
INSERT INTO Employees (FirstName, LastName, Title, Notes)
VALUES
('Ivan', 'Ivanov', 'Manager', 'Oversees operations'),
('Maria', 'Petrova', 'Receptionist', 'Front desk and reservations'),
('Georgi', 'Dimitrov', 'Cleaner', 'Responsible for room cleaning');

-- Customers
INSERT INTO Customers (AccountNumber, FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes)
VALUES
('CUST000001', 'Peter', 'Johnson', '0888123456', 'Anna Johnson', '0888765432', 'Prefers quiet rooms'),
('CUST000002', 'Sophie', 'Williams', '0888234567', 'John Williams', '0888876543', 'Allergic to dust'),
('CUST000003', 'Daniel', 'Brown', '0888345678', 'Emma Brown', '0888987654', 'Needs extra pillows');

-- RoomStatus
INSERT INTO RoomStatus (RoomStatus, Notes)
VALUES
('Available', 'Ready for guests'),
('Occupied', 'Currently in use'),
('Cleaning', 'Being prepared');

-- RoomTypes
INSERT INTO RoomTypes (RoomType, Notes)
VALUES
('Single', 'One bed'),
('Double', 'Two beds'),
('Suite', 'Luxury room');

-- BedTypes
INSERT INTO BedTypes (BedType, Notes)
VALUES
('Twin', 'Two single beds'),
('Queen', 'One queen-size bed'),
('King', 'One king-size bed');

-- Rooms
INSERT INTO Rooms (RoomNumber, RoomType, BedType, Rate, RoomStatus, Notes)
VALUES
(101, 'Single', 'Twin', 50.00, 'Available', 'Ground floor'),
(202, 'Double', 'Queen', 90.00, 'Occupied', 'Sea view'),
(303, 'Suite', 'King', 150.00, 'Cleaning', 'VIP suite');

-- Payments
INSERT INTO Payments (EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, AmountCharged, TaxRate, Notes)
VALUES
(1, '2023-09-01', 'CUST000001', '2023-08-25', '2023-08-28', 150.00, 10.00, 'Paid in cash'),
(2, '2023-09-05', 'CUST000002', '2023-09-01', '2023-09-03', 180.00, 8.00, 'Credit card'),
(3, '2023-09-10', 'CUST000003', '2023-09-07', '2023-09-09', 300.00, 12.00, 'Invoice issued');

-- Occupancies
INSERT INTO Occupancies (EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes)
VALUES
(1, '2023-08-25', 'CUST000001', 101, 50.00, 5.00, 'Late check-in'),
(2, '2023-09-01', 'CUST000002', 202, 90.00, 0.00, 'No extra charges'),
(3, '2023-09-07', 'CUST000003', 303, 150.00, 12.50, 'International calls');


-- Problem 16

CREATE DATABASE [SoftUni]

GO

USE [SoftUni]

GO

CREATE TABLE [Towns] (
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR (50) NOT NULL
)

CREATE TABLE [Addresses] (
	[Id] INT PRIMARY KEY IDENTITY,
	[AddressText] VARCHAR (100) NOT NULL,
	[TownId] INT FOREIGN KEY REFERENCES [Towns]([Id])
)

CREATE TABLE [Departments] (
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR (50) NOT NULL
)

CREATE TABLE [Employees] (
	[Id] INT PRIMARY KEY IDENTITY,
	[FirstName] VARCHAR (50) NOT NULL,
	[MiddleName] VARCHAR (50),
	[LastName] VARCHAR (50) NOT NULL,
	[JobTitle] VARCHAR (50) NOT NULL,
	[DepartmentId] INT FOREIGN KEY REFERENCES [Departments]([Id]) NOT NULL,
	[HireDate] DATE DEFAULT GETDATE() NOT NULL,
	[Salary] DECIMAL (16, 2) NOT NULL,
	[AddressId] INT FOREIGN KEY REFERENCES [Addresses]([Id]) NOT NULL
)

-- Insert towns
INSERT INTO Towns (Name)
VALUES 
('Sofia'),
('Plovdiv'),
('Varna'),
('Burgas');

-- Insert departments
INSERT INTO Departments (Name)
VALUES 
('Engineering'),
('Sales'),
('Marketing'),
('Software Development'),
('Quality Assurance');

-- Insert employees
INSERT INTO Employees (FirstName, MiddleName, LastName, JobTitle, DepartmentID, HireDate, Salary)
VALUES
('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 
    (SELECT Id FROM Departments WHERE Name = 'Software Development'),
    '2013-02-01', 3500.00),

('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 
    (SELECT Id FROM Departments WHERE Name = 'Engineering'),
    '2004-03-02', 4000.00),

('Maria', 'Petrova', 'Ivanova', 'Intern', 
    (SELECT Id FROM Departments WHERE Name = 'Quality Assurance'),
    '2016-08-28', 525.25),

('Georgi', 'Teziev', 'Ivanov', 'CEO', 
    (SELECT Id FROM Departments WHERE Name = 'Sales'),
    '2007-12-09', 3000.00),

('Peter', 'Pan', 'Pan', 'Intern', 
    (SELECT Id FROM Departments WHERE Name = 'Marketing'),
    '2016-08-28', 599.88);

-- Problem 19

SELECT * 
FROM [Towns]

SELECT * 
FROM [Departments]

SELECT * 
FROM [Employees]

-- Problem 20

SELECT * 
FROM [Towns]
ORDER BY [Name]

SELECT * 
FROM [Departments]
ORDER BY [Name]

SELECT * 
FROM [Employees]
ORDER BY [Salary] DESC

-- Problem 21

SELECT [Name] 
FROM [Towns]
ORDER BY [Name]

SELECT [Name] 
FROM [Departments]
ORDER BY [Name]

SELECT [FirstName], [LastName], [JobTitle], [Salary] 
FROM [Employees]
ORDER BY [Salary] DESC

-- Problem 22

UPDATE [Employees]
SET [Salary] += [Salary] * 0.1;

SELECT [Salary] 
FROM [Employees]

-- Problem 23
USE [Hotel]

GO

UPDATE [Payments]
SET [TaxRate] -= [TaxRate] * 0.03;

SELECT [TaxRate]
FROM [Payments]

--Problem 24

DELETE [Occupancies]

