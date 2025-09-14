-- Problem 1

CREATE TABLE [Persons] (
             PersonID INT PRIMARY KEY IDENTITY,
			 FirstName VARCHAR(50) NOT NULL,
			 Salary DECIMAL,
			 PassportID INT
)

CREATE TABLE [Passports] (
             PassportID INT PRIMARY KEY IDENTITY(100, 1),
			 PassportNumber VARCHAR(50) NOT NULL			 
)

ALTER TABLE [Persons]
ADD CONSTRAINT [FK_Persons_Passports]
FOREIGN KEY ([PassportID]) REFERENCES [Passports] ([PassportID])

-- Problem 2

CREATE TABLE [Manufacturers] (
             ManufacturerID INT PRIMARY KEY IDENTITY,
			 [Name] VARCHAR(50) NOT NULL,
			 EstablishedOn DATE			 
)

CREATE TABLE [Models] (
             ModelsID INT PRIMARY KEY IDENTITY(100, 1),
			 [Name] VARCHAR(50) NOT NULL,
			 ManufacturerID INT
)

ALTER TABLE [Models]
ADD CONSTRAINT [FK_Models_Manufacturers]
FOREIGN KEY ([ManufacturerID]) REFERENCES [Manufacturers] ([ManufacturerID])

-- Problem 3

CREATE TABLE [Students] (
             StudentID INT PRIMARY KEY IDENTITY,
			 [Name] VARCHAR(50) NOT NULL			 			 
)

CREATE TABLE [Exams] (
             ExamID INT PRIMARY KEY IDENTITY(100, 1),
			 [Name] VARCHAR(50) NOT NULL			 
)

CREATE TABLE [StudentsExams] (
             StudentID INT NOT NULL FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
			 ExamID INT NOT NULL FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)		 			 
)

ALTER TABLE StudentsExams
ADD CONSTRAINT PK_StudentsExams
PRIMARY KEY (StudentID, ExamID)

-- Problem 4

CREATE TABLE Teachers (
             TeacherID INT PRIMARY KEY IDENTITY(100, 1),
			 [Name] VARCHAR(50) NOT NULL,
			 ManagerID INT
			 CONSTRAINT FK_Teachers_ManagerID
			 FOREIGN KEY (ManagerID) REFERENCES Teachers(TeacherID)
)

-- Problem 5 Faild on judge

CREATE DATABASE OnlineStore

GO

CREATE TABLE Cities (
             CityID INT PRIMARY KEY IDENTITY,
			 [Name] VARCHAR(50) NOT NULL
)

CREATE TABLE Customers (
             CustomerID INT PRIMARY KEY IDENTITY,
			 [Name] VARCHAR(50) NOT NULL,
			 Birthday DATE,
			 CityID INT
  CONSTRAINT FK_Cusomers_Cities_CityID
 FOREIGN KEY (CityID) REFERENCES Cities(CityID)
)

CREATE TABLE Orders (
             OrderID INT PRIMARY KEY IDENTITY,
			 CustomerID INT NOT NULL
  CONSTRAINT FK_Orders_Customers_CustomerID
 FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
)

CREATE TABLE ItemTypes (
             ItemTypeID INT PRIMARY KEY IDENTITY,
			 [Name] VARCHAR(50) NOT NULL
)

CREATE TABLE Items (
             ItemID INT PRIMARY KEY IDENTITY,
			 [Name] VARCHAR(50) NOT NULL,
			 ItemTypeID INT
  CONSTRAINT FK_Items_ItemTypes_ItemTypeID
 FOREIGN KEY (ItemTypeID) REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE OrderItem (
             OrderID INT FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
			 ItemID INT FOREIGN KEY (ItemID) REFERENCES Items(ItemID)
  CONSTRAINT PK_OrderItem
 PRIMARY KEY (OrderID, ItemID)
)

-- Problem 6

CREATE DATABASE University
GO

USE University
GO

CREATE TABLE Subjects (
             SubjectID INT PRIMARY KEY IDENTITY,
			 SubjectName VARCHAR(60) NOT NULL
)

CREATE TABLE Majors (
             MajorID INT PRIMARY KEY IDENTITY,
			 [Name] VARCHAR(60) NOT NULL
)

CREATE TABLE Students (
             StudentID INT PRIMARY KEY IDENTITY,
			 StudentNumber SMALLINT NOT NULL,
			 StudentName VARCHAR(60) NOT NULL,
			 MajorID INT FOREIGN KEY (MajorID) REFERENCES Majors(MajorID)
)

CREATE TABLE Payments (
             PaymentID INT PRIMARY KEY IDENTITY,
			 PaymentDate DATE NOT NULL,
			 PaymentAmount DECIMAL(6, 2) NOT NULL,
			 StudentID INT FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
)

CREATE TABLE Agenda (
             StudentID INT FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
			 SubjectID INT FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
			 PRIMARY KEY (StudentID, SubjectID)
)