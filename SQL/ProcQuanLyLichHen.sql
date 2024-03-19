--Quản lý cuộc hẹn
--view Cuoc Hen
use QuanLyPhongKhamNhaKhoa
go
CREATE OR ALTER PROCEDURE p_KtraTKNS @MANS NVARCHAR(20), 
@OK BIT OUT
AS
BEGIN
	IF EXISTS(SELECT * FROM NhaSi WHERE @MANS = NhaSi.MA)
	BEGIN
	SET @OK = 1
	END
	ELSE
	BEGIN
	SET @OK = 0
	END
END;
go
create or alter procedure p_viewCuocHen 
as
begin
	SELECT * FROM CuocHen 
end;
go
create or alter procedure p_viewCuocHenNS @MANS NVARCHAR(20)
as
begin
	SELECT * FROM CuocHen WHERE @MANS = CuocHen.MANHASI
end;
go
create or alter procedure p_viewCuocHenBN @MABN NVARCHAR(20)
as
begin
	SELECT * FROM CuocHen WHERE @MABN = CuocHen.MaBN
end;
go
create or alter procedure p_viewCuocHenPK @MAPK NVARCHAR(20)
as
begin
	SELECT * FROM CuocHen WHERE @MAPK = CuocHen.Phong
end;



GO
--------------------------------
--insert Cuoc Hen
CREATE OR ALTER PROCEDURE p_insertCuocHen
       @ThoiGian datetime,
	   @MaBN char(10),
	   @MaNhaSi char(10),
	   @MaTroKham char(10),
	   @Phong nvarchar(255),
	   @LoaiCuocHen nvarchar(255)
AS
BEGIN

IF (EXISTS(SELECT * FROM CuocHen WHERE CuocHen.MANHASI = @MaNhaSi AND CuocHen.ThoiGian = @ThoiGian))
	BEGIN
		RAISERROR(N'TRÙNG THỜI GIAN VỚI MỘT LỊCH HẸN KHÁC CỦA NHA SĨ',14,1)
	END
else
begin
	DECLARE @THANG NVARCHAR(255),@TUAN NVARCHAR(255),@AUTO DATE
	SELECT @THANG =  NhaSi.Thang FROM NhaSi WHERE NhaSi.MA = @MaNhaSi
	SELECT @TUAN =  NhaSi.Tuan FROM NhaSi WHERE NhaSi.MA = @MaNhaSi
	SELECT @AUTO =  NhaSi.Ngay_auto FROM NhaSi WHERE NhaSi.MA = @MaNhaSi
	IF ((@TUAN not like '%'+CAST(DATEPART ( dw , @ThoiGian )AS nvarchar(255))+'%') and (@ThoiGian != @AUTO) and (@THANG not like '%'+CAST(DAY(@ThoiGian) AS nvarchar(255))+'%'))
		BEGIN
			RAISERROR(N'Không nằm trong khung giờ làm việc của nha sĩ',14,1)
		END
	else 
		begin
		INSERT INTO CuocHen(ThoiGian, MaBN, MANHASI, MATROKHAM, Phong, LoaiCuocHen)  
		VALUES (@ThoiGian, @MaBN, @MaNhaSi, @MaTroKham, @Phong, @LoaiCuocHen);
		end
END
end
go
CREATE OR ALTER PROCEDURE p_ViewYeuCauCuocHen
AS
BEGIN
SELECT TOP 1000 *  FROM YeuCauCuocHen ORDER BY NgayHen
END

GO
CREATE OR ALTER PROCEDURE p_RemoveCuocHen @NGAY DATE,@TEN NVARCHAR(20)
AS
IF (NOT EXISTS(SELECT * FROM YeuCauCuocHen WHERE @NGAY = YeuCauCuocHen.NgayHen AND @TEN = YeuCauCuocHen.TenBN))
BEGIN
	RAISERROR(N'Yêu cầu muốn xóa không tồn tại',14,1)
END
ELSE
BEGIN
	DELETE FROM YeuCauCuocHen WHERE YeuCauCuocHen.NgayHen = @NGAY AND YeuCauCuocHen.TenBN = @TEN
END
go
CREATE OR ALTER PROCEDURE p_checkHOSO @TEN NVARCHAR(255), @OK BIT OUT
AS
BEGIN
	IF EXISTS(SELECT * FROM HoSoChiTietBenhNhan WHERE HoSoChiTietBenhNhan.HoTen LIKE @TEN)
		BEGIN
		SET @OK = 1
		END
	ELSE
		BEGIN
		SET @OK = 0
		END

END
Go
CREATE OR ALTER PROCEDURE p_LaythongtincuochenCuochen @TEN NVARCHAR(255),@MABN NVARCHAR(255)OUT, @MANS NVARCHAR(255) OUT
AS
BEGIN
	
	SELECT TOP 1 @MABN = HoSoChiTietBenhNhan.MaBN FROM HoSoChiTietBenhNhan WHERE HoSoChiTietBenhNhan.HoTen LIKE @TEN
	DECLARE @BN nvarchar(255) 
	SET @BN = @MABN
	SELECT TOP 1 @MANS = CuocHen.MANHASI FROM CuocHen WHERE CuocHen.MaBN = @BN 
END

GO
CREATE OR ALTER PROCEDURE p_TaoHSMoi @MABN varchar(10), @HoTen NVARCHAR(255), @NgaySinh DATE, @DiaChi NVARCHAR(255),@SoDienThoai NVARCHAR(20), @Email NVARCHAR(255)
AS
BEGIN
	IF EXISTS (SELECT * FROM BenhNhan WHERE BenhNhan.MaBN = @MABN)
		BEGIN
			RAISERROR(N'Số tài khoản đã tồn tại',14,1)
			RETURN
		END
	ELSE
		BEGIN
		
			INSERT INTO BenhNhan VALUES (@MABN,@HoTen,@SoDienThoai,@Email,@DiaChi,@NgaySinh) 
		END
END;
GO

--update Cuoc Hen
CREATE PROCEDURE p_updateCuocHen @ThoiGian date, @MaBN char(10)
AS
BEGIN
	UPDATE CuocHen
	SET ThoiGian = @ThoiGian
	WHERE CuocHen.MaBN = @MaBN
end





