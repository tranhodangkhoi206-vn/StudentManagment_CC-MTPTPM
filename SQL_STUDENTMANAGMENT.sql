CREATE DATABASE STUDENTMANAGMENT
GO
USE STUDENTMANAGMENT 
GO

CREATE TABLE SinhVien (
    MSSV        VARCHAR(10)    PRIMARY KEY,
    HoTen       NVARCHAR(100)  NOT NULL,
    Lop         VARCHAR(20)    NOT NULL,
    Khoa        NVARCHAR(100)  NOT NULL,
    GPA         NCHAR(5)       NOT NULL
);

INSERT INTO SinhVien (MSSV, HoTen, Lop, Khoa, GPA) VALUES
('SV001', N'Nguy?n Van An', 'DH24CT', N'K? thu?t ph?n m?m', '3.65'),
('SV002', N'Tr?n Th? Bích Ng?c', 'DH24CT1', N'An toàn thông tin', '3.80'),
('SV003', N'Lê Hoàng Nam', 'DH24CT2', N'Trí tu? nhân t?o', '2.95'),
('SV004', N'Ph?m Minh Tu?n', 'DH24CT1', N'K? thu?t ph?n m?m', '3.42'),
('SV005', N'Ð? Qu?nh Huong', 'DH24CT', N'An toàn thông tin', '3.10'),
('SV006', N'Vu Qu?c Huy', 'DH24CT2', N'Trí tu? nhân t?o', '2.50'),
('SV007', N'Bùi Phuong Th?o', 'DH24CT1', N'Trí tu? nhân t?o', '3.90'),
('SV008', N'Ð?ng Gia B?o', 'DH24CT', N'K? thu?t ph?n m?m', '3.15'),
('SV009', N'Hoàng Tr?ng Nghia', 'DH24CT2', N'An toàn thông tin', '2.80'),
('SV010', N'Ngô Mai Phuong', 'DH24CT1', N'Trí tu? nhân t?o', '3.55');
