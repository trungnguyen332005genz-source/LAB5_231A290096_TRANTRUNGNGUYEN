-- ==========================================================
-- SCRIPT TẠO CSDL VÀ STORED PROCEDURES CHO PHẦN SQL SERVER UNIT TEST
-- Tham chiếu theo tài liệu: Trang 10 - 18 (CSDL Bookstore)
-- ==========================================================

USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'Bookstore')
BEGIN
    CREATE DATABASE Bookstore;
END
GO

USE Bookstore;
GO

-- 1. Bảng Category
IF OBJECT_ID('dbo.Category', 'U') IS NOT NULL DROP TABLE dbo.Category;
CREATE TABLE dbo.Category
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);
GO

-- 2. Bảng Author
IF OBJECT_ID('dbo.Author', 'U') IS NOT NULL DROP TABLE dbo.Author;
CREATE TABLE dbo.Author
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Address NVARCHAR(200) NULL,
    Phone VARCHAR(20) NULL,
    Email VARCHAR(100) NULL
);
GO

-- 3. Bảng Book
IF OBJECT_ID('dbo.Book', 'U') IS NOT NULL DROP TABLE dbo.Book;
CREATE TABLE dbo.Book
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    Price DECIMAL(18,2) NOT NULL,
    CategoryId INT FOREIGN KEY REFERENCES dbo.Category(Id)
);
GO

-- 4. Bảng BookAuthor
IF OBJECT_ID('dbo.BookAuthor', 'U') IS NOT NULL DROP TABLE dbo.BookAuthor;
CREATE TABLE dbo.BookAuthor
(
    BookId INT FOREIGN KEY REFERENCES dbo.Book(Id),
    AuthorId INT FOREIGN KEY REFERENCES dbo.Author(Id),
    PRIMARY KEY (BookId, AuthorId)
);
GO

-- ==========================================================
-- CHÈN DỮ LIỆU MẪU (Theo dữ liệu chụp màn hình tại Trang 17)
-- ==========================================================
SET IDENTITY_INSERT dbo.Author ON;
INSERT INTO dbo.Author (Id, FirstName, LastName, Address, Phone, Email)
VALUES
(1, N'Thành', N'Dương', N'Hậu Giang', '0984461466', 'dhthanhqa@gmail.com'),
(2, N'Lê', N'Nguyên', N'Tp.HCM', '0984461467', 'lenguyen@gmail.com'),
(3, N'Nam', N'Võ', N'Long An', '0984461468', 'namvo@gmail.com'),
(4, N'Tuấn', N'Trần', N'Đà Nẵng', '0984461469', 'tuantran@gmail.com'),
(5, N'Hương', N'Mai', N'Hà Nội', '0984461470', 'huongmai@gmail.com');
SET IDENTITY_INSERT dbo.Author OFF;
GO

-- ==========================================================
-- STORED PROCEDURES
-- ==========================================================

-- SP 1: Đếm số lượng tác giả
IF OBJECT_ID('dbo.sp_CountAuthors', 'P') IS NOT NULL DROP PROCEDURE dbo.sp_CountAuthors;
GO
CREATE PROCEDURE dbo.sp_CountAuthors
AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) AS TotalAuthors FROM dbo.Author;
END
GO

-- SP 2: Lấy Top 3 tác giả (Được dùng trong Unit Test tại Trang 13 - 18)
IF OBJECT_ID('dbo.sp_Top3Authors', 'P') IS NOT NULL DROP PROCEDURE dbo.sp_Top3Authors;
GO
CREATE PROCEDURE dbo.sp_Top3Authors
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 3 Id, FirstName, LastName, Address, Phone, Email
    FROM dbo.Author
    ORDER BY Id ASC;
END
GO
