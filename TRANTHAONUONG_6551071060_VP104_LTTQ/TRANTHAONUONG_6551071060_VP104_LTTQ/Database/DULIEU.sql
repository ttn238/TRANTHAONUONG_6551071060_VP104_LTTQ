IF DB_ID(N'DuLieu') IS NULL
    CREATE DATABASE DuLieu;
GO

USE DuLieu;
GO

IF OBJECT_ID(N'dbo.NhanVien', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.NhanVien
    (
        MaNhanVien NVARCHAR(10) NOT NULL,
        TenNhanVien NTEXT NOT NULL,
        LuongCoBan NVARCHAR(12) NOT NULL,
        CONSTRAINT PK_NhanVien PRIMARY KEY (MaNhanVien)
    );
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.NhanVien)
BEGIN
    INSERT INTO dbo.NhanVien (MaNhanVien, TenNhanVien, LuongCoBan)
    VALUES
    (N'NV001', N'Nguyễn Văn A', N'500000'),
    (N'NV002', N'Trần Thị B', N'1500000'),
    (N'NV003', N'Lê Văn C', N'900000'),
    (N'NV004', N'Phạm Thị D', N'6500000'),
    (N'NV005', N'Hoàng Văn E', N'800000');
END;
GO

SELECT *
FROM dbo.NhanVien
ORDER BY MaNhanVien;
GO