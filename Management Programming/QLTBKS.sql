------------------------------------  Project ----------------------------------------------------------
CREATE DATABASE TSTBKhachSan
GO
USE TSTBKhachSan
GO

------------------------------------  Function TimKiemGanDung ----------------------------------------------------------
CREATE FUNCTION dbo.TimKiemKyTu ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL RETURN @strInput IF @strInput = '' 
		RETURN @strInput DECLARE @RT NVARCHAR(4000) 
		DECLARE @SIGN_CHARS NCHAR(136) 
		DECLARE @UNSIGN_CHARS NCHAR (136) 
		SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế 
							ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý 
							ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ 
							ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
		SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee 
							iiiiiooooooooooooooouuuuuuuuuuyyyyy 
							AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII 
							OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
		DECLARE @COUNTER INT 
		DECLARE @COUNTER1 INT 
		SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) 
		BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
		BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
	ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = REPLACE(@strInput,' ','-') 
	RETURN @strInput 
END
GO
------------------------------------BoPhan ------------------------------------------------
CREATE TABLE BoPhan
(
	ID INT IDENTITY,
	MaBP NVARCHAR(20) PRIMARY KEY,
	TenBP NVARCHAR(100),
)
GO
CREATE PROC USP_ThemBoPhan
		@TenBP NVARCHAR(50)
	AS
	BEGIN
		DECLARE @MaBP NVARCHAR(20)
			SET @MaBP=(SELECT IDENT_CURRENT('dbo.BoPhan'))
			IF EXISTS (SELECT * FROM dbo.BoPhan WHERE ID = @MaBP)	
				SET @MaBP=@MaBP+1
				SET @MaBP='BP'+REPLICATE('0',2-LEN(@MaBP))+@MaBP
				INSERT INTO dbo.BoPhan VALUES(@MaBP,@TenBP)
	END
GO
EXEC dbo.USP_ThemBoPhan @TenBP = N'Sảnh đón tiếp'
GO
EXEC dbo.USP_ThemBoPhan @TenBP = N'Buồng phòng'
GO
EXEC dbo.USP_ThemBoPhan @TenBP = N'Khu vực Bar'
GO
EXEC dbo.USP_ThemBoPhan @TenBP = N'Khu vực Bếp'
GO
EXEC dbo.USP_ThemBoPhan @TenBP = N'Nhà Hàng'
GO
EXEC dbo.USP_ThemBoPhan @TenBP = N'Khu vực khác'
GO

CREATE PROC USP_SelectBoPhan
AS SELECT * FROM dbo.BoPhan
GO
EXEC USP_SelectBoPhan
GO
--------------------	Tìm kiếm gần đúng
CREATE PROC USP_TKTenBoPhan
	@TenBP NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.BoPhan WHERE dbo.TimKiemKyTu(TenBP) LIKE N'%'+dbo.TimKiemKyTu(@TenBP)+'%'
END
GO
-------------------------------------NhaCungCap ------------------------------------------------
CREATE TABLE NhaCungCap
(
	Id INT IDENTITY,
	MaNCC NVARCHAR(20) PRIMARY KEY,
	TenNCC NVARCHAR(255),
	SDT NVARCHAR(50),
	DiaChi NVARCHAR(300),
	Email NVARCHAR(50),
	STK NVARCHAR(50),
	TenCongTy NVARCHAR(300)
)
GO
CREATE PROC USP_ThemNhaCungCap
		@TenNCC NVARCHAR(255),
		@SDT NVARCHAR(50),
		@DiaChi NVARCHAR(300),
		@Email NVARCHAR(50),
		@STK NVARCHAR(50),
		@TenCongTy NVARCHAR(300)
	AS
	BEGIN
		DECLARE @MaNCC NVARCHAR(20)
		SET @MaNCC=(SELECT IDENT_CURRENT('dbo.NhaCungCap'))
		IF EXISTS (SELECT * FROM dbo.NhaCungCap WHERE ID = @MaNCC)
			SET @MaNCC=@MaNCC+1
			SET @MaNCC='NCC'+REPLICATE('0',2-LEN(@MaNCC))+@MaNCC
			INSERT INTO dbo.NhaCungCap VALUES(@MaNCC,@TenNCC,@SDT,@DiaChi,@Email,@STK,@TenCongTy)
	END
GO

EXEC dbo.USP_ThemNhaCungCap @TenNCC = N'Trần Long Kiên',@SDT = N'147258',@DiaChi = 'TP.HCM',
						  @Email = N'longkien@gmail.com',@STK = N'123456',@TenCongTy = N'Công ty bàn ghế Long Kiên'
GO
EXEC dbo.USP_ThemNhaCungCap @TenNCC = N'Hải Lý',@SDT = N'111111',@DiaChi = 'Cà Mau',
						  @Email = N'haily@gmail.com',@STK = N'222222',@TenCongTy = N'Công ty Hải lý'
GO

CREATE PROC USP_SelectNhaCungCap
AS SELECT * FROM dbo.NhaCungCap
GO
EXEC USP_SelectNhaCungCap
GO

CREATE PROC USP_TKTenNCC
	@TenNCC NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.NhaCungCap WHERE dbo.TimKiemKyTu(TenNCC) LIKE N'%'+dbo.TimKiemKyTu(@TenNCC)+'%'
END
GO
EXEC USP_TKTenNCC N'A'
GO

CREATE PROC USP_UpdateNCC
	@TenNCC NVARCHAR(255),
	@SDT NVARCHAR(50),
	@DiaChi NVARCHAR(300),
	@Email NVARCHAR(50),
	@STK NVARCHAR(50),
	@TenCongTy NVARCHAR(300),
	@MaNCC NVARCHAR(20)
AS
BEGIN
	UPDATE dbo.NhaCungCap SET TenNCC = @TenNCC,SDT = @SDT,DiaChi = @DiaChi,Email = @Email,STK = @STK,TenCongTy = @TenCongTy WHERE MaNCC = @MaNCC
END
GO
-------------------------------------ChucVu ------------------------------------------------
CREATE TABLE ChucVu
(
	ID INT IDENTITY,
	MaCV NVARCHAR(20) PRIMARY KEY,
	TenCV NVARCHAR(100)
)
GO
CREATE PROC USP_ThemChucVu
		@TenCV NVARCHAR(50)
	AS
	BEGIN
		DECLARE @MaCV NVARCHAR(20)
		SET @MaCV=(SELECT IDENT_CURRENT('dbo.ChucVu'))
		IF EXISTS (SELECT * FROM dbo.ChucVu WHERE ID = @MaCV)
			SET @MaCV=@MaCV+1
			SET @MaCV='CV'+REPLICATE('0',2-LEN(@MaCV))+@MaCV
			INSERT INTO dbo.ChucVu VALUES(@MaCV,@TenCV)
	END
GO
EXEC dbo.USP_ThemChucVu @TenCV = N'Admin'
GO
EXEC dbo.USP_ThemChucVu @TenCV = N'Quản lí'
GO
EXEC dbo.USP_ThemChucVu @TenCV = N'Nhân viên khu vực'
GO

CREATE PROC USP_SelectChucVu
AS SELECT * FROM dbo.ChucVu
GO
EXEC USP_SelectChucVu
GO

CREATE PROC USP_TKTenChucVu
	@TenCV NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.ChucVu WHERE dbo.TimKiemKyTu(@TenCV) LIKE N'%'+dbo.TimKiemKyTu(@TenCV)+'%'
END
GO
-------------------------------------NhanVien ------------------------------------------------
CREATE TABLE NhanVien
(
	ID INT IDENTITY,
	MaNV NVARCHAR(20) PRIMARY KEY,
	HoTen NVARCHAR(50),
	GioiTinh NVARCHAR(5),
	NgaySinh DATE,
	DiaChi NVARCHAR(50),
	SDT NVARCHAR(50),
	Email NVARCHAR(50),
	TonGiao NVARCHAR(50),
	CMND NVARCHAR(50),
	MaBP NVARCHAR(20) CONSTRAINT FK_NhanVien_BoPhan FOREIGN KEY(MaBP) REFERENCES  dbo.BoPhan(MaBP),
	MaCV NVARCHAR(20) CONSTRAINT FK_NhanVien_ChucVu FOREIGN KEY(MaCV) REFERENCES  dbo.ChucVu(MaCV)
)
GO

CREATE PROC USP_ThemNhanVien
		@HoTen NVARCHAR(50),
		@GioiTinh NVARCHAR(5),
		@NgaySinh DATE,
		@DiaChi NVARCHAR(50),
		@SDT NVARCHAR(50),
		@Email NVARCHAR(50),
		@TonGiao NVARCHAR(50),
		@CMND NVARCHAR(50),
		@MaBP NVARCHAR(20),
		@MaCV NVARCHAR(20)
	AS
	BEGIN
		DECLARE @MaNV NVARCHAR(20)
		SET @MaNV=(SELECT IDENT_CURRENT('dbo.NhanVien'))
		IF EXISTS (SELECT * FROM dbo.NhanVien WHERE ID = @MaNV)
			SET @MaNV=@MaNV+1
			SET @MaNV='NV'+REPLICATE('0',2-LEN(@MaNV))+@MaNV
			INSERT INTO dbo.NhanVien VALUES(@MaNV,@HoTen,@GioiTinh,@NgaySinh,@DiaChi,@SDT,@Email,@TonGiao,@CMND,@MaBP,@MaCV)
	END
GO
EXEC dbo.USP_ThemNhanVien @HoTen = N'Nguyễn Văn Lâm',@GioiTinh = N'Nam',@NgaySinh = '1/1/1990',
						  @DiaChi = N'An Giang',@SDT = N'012345',@Email = N'lam@gmail.com',
						  @TonGiao = N'Phật',@CMND = N'32323232',@MaBP = N'BP01',@MaCV = N'CV01'
GO
EXEC dbo.USP_ThemNhanVien @HoTen = N'Nguyễn Thành Nam',@GioiTinh = N'Nam',@NgaySinh = '1/2/1990',
						  @DiaChi = N'Cần Thơ',@SDT = N'111222',@Email = N'nam@gmail.com',
						  @TonGiao = N'Thiên Chúa',@CMND = N'121212',@MaBP = N'BP02',@MaCV = N'CV02'
GO
EXEC dbo.USP_ThemNhanVien @HoTen = N'Lý Nhã Kỳ',@GioiTinh = N'Nữ',@NgaySinh = '1/3/1990',
						  @DiaChi = N'Long An',@SDT = N'22221111',@Email = N'ky@gmail.com',
						  @TonGiao = N'Phật',@CMND = N'1212111',@MaBP = N'BP03',@MaCV = N'CV03'
GO

CREATE PROC USP_SelectNhanVien
AS SELECT * FROM dbo.NhanVien
GO
EXEC dbo.USP_SelectNhanVien
GO

CREATE PROC USP_TKTenNhanVien
	@Hoten NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.NhanVien WHERE dbo.TimKiemKyTu(HoTen) LIKE N'%'+dbo.TimKiemKyTu(@Hoten)+'%'
END
GO
--------------------------------------------------------Tài khoản
CREATE TABLE TaiKhoan
(
	Id INT IDENTITY,
	MaTK NVARCHAR(20) PRIMARY KEY,
	HinhAnh NVARCHAR(4000),
	MaNV NVARCHAR(20) CONSTRAINT FK_TaiKhoan_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
	TenTK NVARCHAR(100),
	TenHienThi NVARCHAR(100),
	Pass NVARCHAR(100),
	MaCV NVARCHAR(20) CONSTRAINT FK_TaiKhoan_ChucVu FOREIGN KEY(MaCV) REFERENCES dbo.ChucVu(MaCV)
)
GO
CREATE PROC USP_ThemTaiKhoan
		@HinhAnh NVARCHAR(4000),
		@MaNV NVARCHAR(20),
		@TenTK NVARCHAR(100),
		@TenHienThi NVARCHAR(100),
		@Pass NVARCHAR(100),
		@MaCV NVARCHAR(20)
	AS
	BEGIN
		DECLARE @MaTK NVARCHAR(20)
		SET @MaTK=(SELECT IDENT_CURRENT('dbo.TaiKhoan'))
		IF EXISTS (SELECT * FROM dbo.TaiKhoan WHERE ID = @MaTK)
			SET @MaTK=@MaTK+1
			SET @MaTK='TK'+REPLICATE('0',2-LEN(@MaTK))+@MaTK
			INSERT INTO dbo.TaiKhoan VALUES(@MaTK,@HinhAnh,@MaNV,@TenTK,@TenHienThi,@Pass,@MaCV)
	END
GO

EXEC USP_ThemTaiKhoan @HinhAnh = N'C:\Users\PC GAMING\Desktop\IT\QLTSTBKhachSan\Management Programming\Img\Avatar.jpg',@MaNV = 'NV01',@TenTK = 'Ad', @TenHienThi=N'Trần Minh Trí',@Pass='1',@MaCV='CV01'
GO
UPDATE dbo.TaiKhoan SET TenHienThi = N'Trần Minh Trí' WHERE ID = 1

USE TSTBKhachSan
--------------------	Tìm kiếm gần đúng
CREATE PROC USP_TKTenTK
	@TenTK NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.TaiKhoan WHERE TenTK LIKE N'%'+@TenTK+'%'
END
GO

CREATE PROC USP_DangNhap
	@TenTK NVARCHAR(100),
	@Pass NVARCHAR(100)
AS 
BEGIN
    SELECT * FROM dbo.TaiKhoan WHERE @TenTK = TenTK AND  @Pass = Pass
END
GO
--PROC Select Tất cả tài khoản
CREATE PROC USP_SelectATaiKhoan
AS 
BEGIN
    SELECT * FROM dbo.TaiKhoan
END
GO
EXEC USP_SelectATaiKhoan
GO

CREATE PROC USP_UpdateTaiKhoan
	@HinhAnh NVARCHAR(4000),
	@TenTK NVARCHAR(100),
	@TenHienThi NVARCHAR(100),
	@Pass NVARCHAR(100),
	@newPass NVARCHAR(100)
AS
BEGIN
	DECLARE @RightPass INT = 0

	SELECT @RightPass = COUNT(*)FROM dbo.TaiKhoan WHERE TenTK = @TenTK AND Pass = @Pass;

	IF(@RightPass = 1)
	BEGIN
	    IF(@newPass = NULL OR @newPass = '')
		BEGIN
		    UPDATE dbo.TaiKhoan SET HinhAnh = @HinhAnh , TenHienThi = @TenHienThi WHERE TenTK = @TenTK
		END
		ELSE
		    UPDATE dbo.TaiKhoan SET HinhAnh = @HinhAnh ,TenHienThi = @TenHienThi, Pass = @newPass WHERE TenTK = @TenTK 
	END
END
GO
-------------------------------------HoaDonMuaTB ------------------------------------------------
CREATE TABLE HoaDonMuaTB
(
	Id INT IDENTITY,
	MaHDMua NVARCHAR(20) PRIMARY KEY,
	NgayMuaTB DATE,
	MaNV NVARCHAR(20) CONSTRAINT FK_HoaDonMuaTB_NhanVien FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV),
	MaNCC NVARCHAR(20) CONSTRAINT FK_HoaDonMuaTB_NhaCungCap FOREIGN KEY(MaNCC) REFERENCES dbo.NhaCungCap(MaNCC),
	TongSLTB INT
)
GO
CREATE PROC USP_ThemHoaDonMuaTB
		@NgayMuaTB DATE,
		@MaNV NVARCHAR(20),
		@MaNCC NVARCHAR(20),
		@TongSLTB INT
	AS
	BEGIN
		DECLARE @MaHDMua NVARCHAR(20)
		SET @MaHDMua=(SELECT IDENT_CURRENT('dbo.HoaDonMuaTB'))
		IF EXISTS (SELECT * FROM dbo.HoaDonMuaTB WHERE ID = @MaHDMua)
			SET @MaHDMua=@MaHDMua+1
			SET @MaHDMua='HDM'+REPLICATE('0',2-LEN(@MaHDMua))+@MaHDMua
			INSERT INTO dbo.HoaDonMuaTB VALUES(@MaHDMua,@NgayMuaTB,@MaNV,@MaNCC,@TongSLTB)
	END
GO

EXEC dbo.USP_ThemHoaDonMuaTB @NgayMuaTB = '1/2/2015',@Manv = N'NV01',@MaNCC = 'NCC01',@TongSLTB = 5000
GO
EXEC dbo.USP_ThemHoaDonMuaTB @NgayMuaTB = '1/2/2015',@Manv = N'NV01',@MaNCC = 'NCC01',@TongSLTB = 6000
GO
EXEC dbo.USP_ThemHoaDonMuaTB @NgayMuaTB = '1/2/2015',@Manv = N'NV01',@MaNCC = 'NCC01',@TongSLTB = 3000
GO
SELECT * FROM HoaDonMuaTB
GO

CREATE PROC USP_HoaDonMuaTB
	@MaHDMua NVARCHAR(20)
AS
BEGIN
	DELETE dbo.HoaDonMuaTB WHERE MaHDMua = @MaHDMua
END
GO
EXEC USP_HoaDonMuaTB N'HDM04'
GO

CREATE PROC USP_ShowHoaDon
AS
	SELECT *FROM dbo.HoaDonMuaTB
GO
EXEC dbo.USP_ShowHoaDon
GO

--Tìm kiếm Mã hoá đơn
CREATE PROC USP_TKMaHDMua
	@MaHDMua NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.HoaDonMuaTB WHERE MaHDMua LIKE '%' +@MaHDMua+ '%'
END
GO
--Tìm kiếm Mã Tổng SL
CREATE PROC USP_TKTongSL
	@TongSL INT
AS
BEGIN
	SELECT * FROM dbo.HoaDonMuaTB WHERE TongSLTB LIKE @TongSL
END
GO

--Tìm kiếm Mã NCC
CREATE PROC USP_TKMaNCC
	@MaNCC NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.HoaDonMuaTB WHERE TongSLTB LIKE '%' +@MaNCC+ '%'
END
GO

--Tìm kiếm Theo ngày
CREATE PROC USP_HDTheoNgay
	@Ngay1 DATETIME,
	@Ngay2 DATETIME
AS
BEGIN
	SELECT * FROM dbo.HoaDonMuaTB WHERE NgayMuaTB BETWEEN @Ngay1 AND @Ngay2
END
GO
-------------------------------------------------ThietBi chưa thêm---------------------------------
CREATE TABLE ThietBi
(
	Id INT IDENTITY,
	MaTB NVARCHAR(20) PRIMARY KEY,
	TenTB NVARCHAR(1000),
	DonVi NVARCHAR(50),
	SoLuong INT,
	TenDanhMuc NVARCHAR(100),
	MaBP NVARCHAR(20) CONSTRAINT FK_ThietBi_BoPhan FOREIGN KEY(MaBP) REFERENCES dbo.BoPhan(MaBP),
	ThoiGianBH DATE,
	TinhTrangTB INT,
	MaNCC NVARCHAR(20) CONSTRAINT FK_ThietBi_NhaCungCap FOREIGN KEY(MaNCC) REFERENCES dbo.NhaCungCap(MaNCC),
	MaHDMuaTB NVARCHAR(20) CONSTRAINT FK_ThietBi_HoaDonMuaTB FOREIGN KEY(MaHDMuaTB) REFERENCES dbo.HoaDonMuaTB(MaHDMua),
	GiaTBMua INT
)
GO
CREATE PROC USP_ThemThietBi
		@TenTB NVARCHAR(255),
		@DonVi NVARCHAR(50),
		@SoLuong INT,
		@TenDanhMuc NVARCHAR(100),
		@MaBP NVARCHAR(20),
		@ThoiGianBH DATE,
		@TinhTrangTB NVARCHAR(50),
		@MaNCC NVARCHAR(20),
		@MaHDMuaTB NVARCHAR(20),
		@GiaTBMua INT
	AS
	BEGIN
		DECLARE @MaTB NVARCHAR(20)
		SET @MaTB=(SELECT IDENT_CURRENT('dbo.ThietBi'))
		IF EXISTS (SELECT * FROM dbo.ThietBi WHERE ID = @MaTB)
			SET @MaTB=@MaTB+1
			SET @MaTB='TB'+REPLICATE('0',2-LEN(@MaTB))+@MaTB
			INSERT INTO dbo.ThietBi VALUES(@MaTB,@TenTB,@DonVi,@SoLuong,@TenDanhMuc,@MaBP,@ThoiGianBH,
			@TinhTrangTB,@MaNCC,@MaHDMuaTB,@GiaTBMua)
	END
GO
EXEC dbo.USP_ThemThietBi @TenTB = N'Ghế tiếp khách',@DonVi = N'bộ',@SoLuong = 10,
						  @TenDanhMuc = N'dsd',@MaBP = N'BP01',@ThoiGianBH = N'3/3/2025',
						  @TinhTrangTB= 1,@MaNCC='NCC01',@MaHDMuaTB='HDM01',@GiaTBMua=50000
GO
EXEC dbo.USP_ThemThietBi @TenTB = N'Bàn tiếp khách',@DonVi = N'bộ',@SoLuong = 10,
						  @TenDanhMuc = N'DM01',@MaBP = N'BP02',@ThoiGianBH = N'3/3/2025',
						  @TinhTrangTB= 1,@MaNCC='NCC01',@MaHDMuaTB='HDM02',@GiaTBMua=60000
GO
EXEC dbo.USP_ThemThietBi @TenTB = N'Bàn tiếp khách',@DonVi = N'bộ',@SoLuong = 10,
						  @TenDanhMuc = N'DM02',@MaBP = N'BP02',@ThoiGianBH = N'3/3/2025',
						  @TinhTrangTB= 1,@MaNCC='NCC01',@MaHDMuaTB='HDM03',@GiaTBMua=70000
GO
EXEC dbo.USP_ThemThietBi @TenTB = N'Bàn tiếp khách',@DonVi = N'bộ',@SoLuong = 10,
						  @TenDanhMuc = N'DM02',@MaBP = N'BP02',@ThoiGianBH = N'3/3/2025',
						  @TinhTrangTB= 0,@MaNCC='NCC01',@MaHDMuaTB='HDM03',@GiaTBMua=70000
GO
CREATE PROC USP_SelectAThietBi
AS SELECT * FROM dbo.ThietBi
GO
EXEC USP_SelectAThietBi
GO


