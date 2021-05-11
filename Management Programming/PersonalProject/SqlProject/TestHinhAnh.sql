CREATE DATABASE HinhAnh
GO
USE HinhAnh
GO

CREATE TABLE LoadHinhAnh
(
	tenhinh NVARCHAR(100),
	ha IMAGE 
)

SELECT * FROM dbo.LoadHinhAnh 
SELECT * FROM dbo.LoadHinhAnh2


CREATE TABLE LoadHinhAnh2
(
	tenhinh NVARCHAR(100),
	ha IMAGE
)

INSERT INTO dbo.LoadHinhAnh2
(
    tenhinh,
    ha
)
VALUES
(   N'H1', 'C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\riven.jpg')
    

	SELECT * FROM dbo.LoadHinhAnh2

	DROP TABLE dbo.LoadHinhAnh2