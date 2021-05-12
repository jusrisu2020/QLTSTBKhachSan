CREATE DATABASE HinhAnh
GO
USE HinhAnh
GO



CREATE TABLE LoadHinhAnh
(
	tenhinh NVARCHAR(100),
	ha VARBINARY(MAX)
)

SELECT * FROM dbo.LoadHinhAnh 

INSERT INTO dbo.LoadHinhAnh
(
    tenhinh,
    ha
)
VALUES
(   N'Hình 1',ha FROM OPENROWSET(BULK N'C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\BackGLoading-1.png', SINGLE_BLOB) AS ImageSource(ha))
