CREATE DATABASE HinhAnh
GO
USE HinhAnh
GO

CREATE TABLE LoadHinhAnh
(
	tenhinh NVARCHAR(100),
	ha IMAGE 
)

INSERT INTO dbo.LoadHinhAnh(tenhinh,ha)VALUES(   N'', NULL);
SELECT * FROM dbo.LoadHinhAnh 
