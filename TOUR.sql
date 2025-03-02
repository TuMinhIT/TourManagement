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
-- Bảng lưu danh sách tour của khách hàng
CREATE TABLE CustomerTours (
    BookingID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    TourID INT NOT NULL,
    BookingDate DATETIME DEFAULT GETDATE(),
	Status NVARCHAR(50) CHECK (Status IN ('Deposited', 'Completed', 'Canceled')) NOT NULL,
    TotalAmount DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID) ON DELETE CASCADE,
    FOREIGN KEY (TourID) REFERENCES Tours(TourID) ON DELETE CASCADE
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

-- Bảng Lịch Trình (Itinerary)
CREATE TABLE Schedule (
    ItineraryID INT IDENTITY(1,1) PRIMARY KEY,
    TourID INT NOT NULL,
    DayNumber INT NOT NULL,
    Description NVARCHAR(MAX) NOT NULL,
    FOREIGN KEY (TourID) REFERENCES Tours(TourID) ON DELETE CASCADE
);
go

-- Bảng Báo Cáo Doanh Thu
CREATE TABLE RevenueReports (
    ReportID INT IDENTITY(1,1) PRIMARY KEY,
    ReportDate DATETIME DEFAULT GETDATE(),
    TourType NVARCHAR(50),
    TotalRevenue DECIMAL(18,2) NOT NULL
);
go
-- Bảng Nhật Ký Hệ Thống
CREATE TABLE SystemLogs (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    UserID NVARCHAR(10),
    Action NVARCHAR(255) NOT NULL,
    LogDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE SET NULL
);

go
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



-- Thêm dữ liệu vào bảng Customers

-- Thêm dữ liệu vào bảng Tours
INSERT INTO Tours (TourName, TourType, Transport, Price, Description)
VALUES 
(N'Du lịch Hạ Long 3N2Đ', 'Luxury ', 'Car', 5000000, N'Chuyến đi Hạ Long 3 ngày 2 đêm'),
(N'Tour Đà Nẵng 4N3Đ', 'Standard', 'Airplane', 7000000, N'Khám phá Đà Nẵng cùng biển Mỹ Khê'),
(N'Phú Quốc 5N4Đ', 'Budget', 'Airplane', 9000000, N'Du lịch Phú Quốc với giá hấp dẫn');

-- Thêm dữ liệu vào bảng Bookings
INSERT INTO Bookings (CustomerID, TourID, BookingDate, Status, TotalAmount)
VALUES 
(1, 1, GETDATE(), 'Deposited', 5000000),
(2, 2, GETDATE(), 'Completed', 7000000),
(3, 3, GETDATE(), 'Canceled', 9000000);

-- Thêm dữ liệu vào bảng Itineraries
INSERT INTO Schedule(TourID, DayNumber, Description)
VALUES 
(1, 1, N'Khởi hành từ Hà Nội, tham quan Vịnh Hạ Long'),
(1, 2, N'Tham quan hang Sửng Sốt và đảo Ti Tốp'),
(2, 1, N'Bay đến Đà Nẵng, nhận phòng khách sạn');

-- Thêm dữ liệu vào bảng RevenueReports

-- Thêm dữ liệu vào bảng SystemLogs
INSERT INTO SystemLogs (UserID, Action, LogDate)
VALUES 
(1, N'Tạo mới tour Hạ Long 3N2Đ', GETDATE()),
(2, N'Cập nhật giá tour Đà Nẵng', GETDATE()),
(3, N'Hủy booking của khách hàng Hoàng Văn F', GETDATE());


SELECT UserID, FullName, Role, Address, Phone, Email FROM Users WHERE UserID = 'NV008' AND Password = '$2a$11$Iakk36m.XHr6hJHAwRDWdeJy//cHL1xijxdXisePp7pEiNaAXFRV2'

                 