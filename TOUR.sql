-- Tạo Database
CREATE DATABASE TourManagement;
GO
USE TourManagement;
GO

-- Bảng Người Dùng (User)
CREATE TABLE Users (
    UserID NVARCHAR(10) PRIMARY KEY,
    Password NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50) CHECK (Role IN ('Admin', 'Staff')) NOT NULL, 
    FullName NVARCHAR(100) NOT NULL,
    Address NVARCHAR(255) NULL,
    Phone NVARCHAR(20) NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
	link NVARCHAR(250) NULL,
	note NVARCHAR(250) NUlL,
);

go
-- Bảng Khách Hàng (Customer)
CREATE TABLE Customers (
    CustomerID NVARCHAR(10) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10)  NOT NULL, 
    PhoneNumber NVARCHAR(20)  NULL,
    Email NVARCHAR(100) NULL,
    Address NVARCHAR(255) NULL,
    Nationality NVARCHAR(50) NULL,
    Notes NVARCHAR(500) NULL 
);
go
-- Bảng Tour
CREATE TABLE Tours (
    TourID INT IDENTITY(1,1) PRIMARY KEY,
    TourName NVARCHAR(255) NOT NULL,
    TourType NVARCHAR(50) NOT NULL, 
    Transport NVARCHAR(50) NOT NULL, 
    Price  NVARCHAR(50) NOT NULL,
	LinkImage NVARCHAR(255) NULL,
	Description NVARCHAR(1000) NULL
);

go
-- Bảng lưu danh sách tour của khách hàng
CREATE TABLE CustomerTours (
    BookingID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID NVARCHAR(10)  NOT NULL,
	CustomerName NVARCHAR(100) NOT NULL,
    TourID INT NOT NULL,
	TourName NVARCHAR(255) NOT NULL,
    BookingDate DATETIME DEFAULT GETDATE(),
	Status NVARCHAR(50) CHECK (Status IN ('Booked', 'Completed', 'Canceled')) NOT NULL,
    TotalAmount INT NOT NULL,
	PrePay INT,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID) ON DELETE CASCADE,
    FOREIGN KEY (TourID) REFERENCES Tours(TourID) ON DELETE CASCADE
);

go
 -- bảng lịch trình
CREATE TABLE Schedule (
    ScheduleID INT IDENTITY(1,1) PRIMARY KEY,
    TourID INT NOT NULL,
    TourName NVARCHAR(255) NOT NULL, 
    CustomerID NVARCHAR(50), 
    CustomerName NVARCHAR(255), 
    Day_Start DATETIME NOT NULL, 
    Day_End DATETIME NOT NULL, 
    Status_Pay NVARCHAR(50), 
	TotalAmount INT NOT NULL,
    Description NVARCHAR(MAX) NOT NULL,
    FOREIGN KEY (TourID) REFERENCES Tours(TourID) ON DELETE CASCADE
);
GO


--triger generate User id
CREATE TRIGGER trg_AutoGenerate_UserID ON Users
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @NewID NVARCHAR(10);
    SELECT @NewID = MAX(UserID) FROM Users;
    
    IF @NewID IS NULL
        SET @NewID = 'NV001';
    ELSE
        SET @NewID = 'NV' + RIGHT('000' + CAST(CAST(RIGHT(@NewID, 3) AS INT) + 1 AS NVARCHAR), 3);

    INSERT INTO Users (UserID, Password, Role, FullName, Address, Phone, Email, note)
    SELECT @NewID, Password, Role, FullName, Address, Phone, Email, note
    FROM inserted;
END;


--trigger for custommer ID
CREATE TRIGGER trg_AutoGenerate_CustomerID 
ON Customers
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @NewID NVARCHAR(10);
    DECLARE @MaxID NVARCHAR(10);
    DECLARE @NextNumber INT;

    SELECT @MaxID = MAX(CustomerID) FROM Customers;

    IF @MaxID IS NULL
        SET @NewID = 'KH001';
    ELSE
    BEGIN
        SET @NextNumber = CAST(RIGHT(@MaxID, 3) AS INT) + 1;
        SET @NewID = 'KH' + RIGHT('000' + CAST(@NextNumber AS NVARCHAR), 3);
    END;
    INSERT INTO Customers (CustomerID, FullName, Gender, PhoneNumber, Email, Address, Nationality, Notes)
    SELECT @NewID, FullName, Gender, PhoneNumber, Email, Address, Nationality, Notes
    FROM inserted;
END;
