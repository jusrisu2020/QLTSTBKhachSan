CREATE DATABASE SaveImageDataBase
GO
USE SaveImageDataBase
GO

DROP TABLE img

CREATE TABLE Img
(
	id INT IDENTITY,
	Fullname NVARCHAR(100),
	Paths VARCHAR(1000)
)

INSERT INTO dbo.Img
(
    Fullname,
    Paths
)
VALUES
(   N'Hình 1',
    'C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\eagle-logo-vector_93835-8.png'
    )

INSERT INTO dbo.Img VALUES
(
N'Hình 1',
'C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\PersonalProject\Winform\Img\riven.jpg'
)


	SELECT * FROM dbo.Img