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
);


-- Bảng Khách Hàng (Customer)
CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    PhoneNumber NVARCHAR(20) UNIQUE NOT NULL,
    Email NVARCHAR(100) NULL,
    Address NVARCHAR(255) NULL
);

-- Bảng Tour
CREATE TABLE Tours (
    TourID INT IDENTITY(1,1) PRIMARY KEY,
    TourName NVARCHAR(255) NOT NULL,
    TourType NVARCHAR(50) CHECK (TourType IN ('Luxury', 'Standard', 'Budget')) NOT NULL,
    Transport NVARCHAR(50) CHECK (Transport IN ('Car', 'Airplane')) NOT NULL,
    Price DECIMAL(18,2) NOT NULL,
    Description NVARCHAR(MAX) NULL
);


-- Bảng Đơn Đặt Tour (Booking)
CREATE TABLE Bookings (
    BookingID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    TourID INT NOT NULL,
    BookingDate DATETIME DEFAULT GETDATE(),
	Status NVARCHAR(50) CHECK (Status IN ('Deposited', 'Completed', 'Canceled')) NOT NULL,
    TotalAmount DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID) ON DELETE CASCADE,
    FOREIGN KEY (TourID) REFERENCES Tours(TourID) ON DELETE CASCADE
);

-- Bảng Lịch Trình (Itinerary)
CREATE TABLE Schedule (
    ItineraryID INT IDENTITY(1,1) PRIMARY KEY,
    TourID INT NOT NULL,
    DayNumber INT NOT NULL,
    Description NVARCHAR(MAX) NOT NULL,
    FOREIGN KEY (TourID) REFERENCES Tours(TourID) ON DELETE CASCADE
);

-- Bảng Báo Cáo Doanh Thu
CREATE TABLE RevenueReports (
    ReportID INT IDENTITY(1,1) PRIMARY KEY,
    ReportDate DATETIME DEFAULT GETDATE(),
    TourType NVARCHAR(50),
    TotalRevenue DECIMAL(18,2) NOT NULL
);

-- Bảng Nhật Ký Hệ Thống
CREATE TABLE SystemLogs (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    UserID NVARCHAR(10),
    Action NVARCHAR(255) NOT NULL,
    LogDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE SET NULL
);


--triger

CREATE TRIGGER trg_AutoGenerate_UserID ON Users
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @NewID NVARCHAR(10);
    
    -- Lấy UserID lớn nhất hiện tại (VD: NV005)
    SELECT @NewID = MAX(UserID) FROM Users;
    
    -- Nếu chưa có User nào, bắt đầu từ NV001
    IF @NewID IS NULL
        SET @NewID = 'NV001';
    ELSE
        -- Lấy số cuối cùng, tăng lên 1 và format lại thành NVxxx
        SET @NewID = 'NV' + RIGHT('000' + CAST(CAST(RIGHT(@NewID, 3) AS INT) + 1 AS NVARCHAR), 3);

    -- Chèn dữ liệu vào bảng Users với UserID tự động sinh
    INSERT INTO Users (UserID, Password, Role, FullName, Address, Phone, Email)
    SELECT @NewID, Password, Role, FullName, Address, Phone, Email
    FROM inserted;
END;


-- Thêm dữ liệu vào bảng Customers
INSERT INTO Customers (FullName, PhoneNumber, Email, Address)
VALUES 
(N'Phạm Văn D', '0987654321', 'phamvand@example.com', N'123 Lê Lợi, Hà Nội'),
(N'Nguyễn Thị E', '0976543210', 'nguyenthie@example.com', N'456 Hai Bà Trưng, TP.HCM'),
(N'Hoàng Văn F', '0965432109', NULL, N'789 Trần Phú, Đà Nẵng');

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

                 