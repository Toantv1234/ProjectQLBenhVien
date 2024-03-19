use QuanLyPhongKhamNhaKhoa

--drop procedure XemDSNhaSi
go
--Xem danh sách nha sĩ
CREATE PROCEDURE XemDSNhaSi
AS
BEGIN
	SELECT MA AS ID, HOTEN AS Dentist
	FROM NhaSi
END;

--Thêm/Cập nhật thông tin nha sĩ
 --Thêm thông tin nha sĩ
-- drop PROCEDURE ThemNhaSi
go
 CREATE PROCEDURE ThemNhaSi
	@MaNS CHAR(10),
	@Hoten NVARCHAR(255),
	@Tuan NVARCHAR(MAX),
	@Thang NVARCHAR(MAX),
	@NgayAuto DATE,
	@newid int output
AS
BEGIN
	If Exists(select MA from NhaSi where MA = @MaNS)
	begin
		set  @newid = 1
		return @newid;
	end
	else
	begin
		insert into NhaSi(MA, HOTEN, Tuan, Thang ,Ngay_auto)
		values (@MaNS, @Hoten, @Tuan, @Thang, @NgayAuto)
		set  @newid = 0
		return @newid;
	end
END;


go
 --Cập nhật thông tin nha sĩ
 
 CREATE PROCEDURE CapNhatNhaSi
 	@MaNSOld CHAR(10),
	@MaNSNew CHAR(10),
	@Hoten NVARCHAR(255),
	@Tuan NVARCHAR(MAX),
	@Thang NVARCHAR(MAX),
	@NgayAuto DATE,
	@check int output
AS
BEGIN
	If not Exists(select MA from NhaSi where MA = @MaNSOld) 
	begin
		set @check = 1
		return @check;
	end;
	if Exists(select MA from NhaSi where MA = @MaNSNew)
	begin
		set @check = 2
		return @check;
	end;
	else
	begin
		update NhaSi set MA = @MaNSNew, HOTEN = @Hoten, Tuan = @Tuan, Thang = @Thang, Ngay_auto = @NgayAuto
		where MA = @MaNSOld
		set @check = 0
		return @check;
	end;
END;
--Xem danh sách nhân viên
go
CREATE PROCEDURE XemDSNhanVien
AS
BEGIN
	SELECT MaNV AS ID, HoTen AS HoTen
	FROM NhanVien
END;
go
--Thêm/Cập nhật thông tin nhân viên
--Thêm thông tin nhân viên
 CREATE PROCEDURE ThemNhanVien
	@MaNV CHAR(10),
	@Hoten NVARCHAR(255),
	@check int output
AS
BEGIN
	If Exists(select MaNV from NhanVien where MaNV = @MaNV)
	begin
		set  @check = 1
		return @check;
	end
	else
	begin
		insert into NhanVien(MaNV, HoTen)
		values (@MaNV, @Hoten)
		set  @check = 0
		return @check;
	end
END;
--Cập nhật thông tin nhân viên
go
 CREATE PROCEDURE CapNhatNhanVien
 	@MaNVOld CHAR(10),
	@MaNVNew CHAR(10),
	@Hoten NVARCHAR(255),
	@check int output
AS
BEGIN
	If not Exists(select MaNV from NhanVien where MaNV = @MaNVOld) 
	begin
		set @check = 1
		return @check;
	end;
	if Exists(select MaNV from NhanVien where MaNV = @MaNVNew)
	begin
		set @check = 2
		return @check;
	end;
	else
	begin
		update NhanVien set MaNV = @MaNVNew, HoTen = @Hoten
		where MaNV = @MaNVOld
		set @check = 0
		return @check;
	end;
END;


--Xem danh sách nha sĩ và lịch trình làm việc tương ứng
--drop procedure XemLichLamViecNhaSi
CREATE PROCEDURE XemLichLamViecNhaSi
AS
BEGIN
	SELECT MA AS ID, HOTEN AS Dentist, CONCAT('WEEKLY:', CHAR(13), Tuan, CHAR(13), 'MONTHLY:', CHAR(13), Thang, CHAR(13), 'AUTO:', CHAR(13), Ngay_auto) AS Schedule
	FROM NhaSi
END;
