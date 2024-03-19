
use QuanLyPhongKhamNhaKhoa
go

-- thay đổi trong BenhNhan SDT -> varchar(15)
--thay đổi thang trong	 nhasi -> nvarchar(MAX)
-- thay doi trangthai dieu tri trong Dieutri -> nvarchar(50)
go
-- them Benh Nhan 1
BULK INSERT BenhNhan
FROM 'G:\KHTN\CSDLNC\CSDLNC\SQL\data_ho_so_benh_nhan.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 2 ); -- Nếu có header
go
-- them nhasi 2

BULK INSERT NhaSi
FROM 'G:\KHTN\CSDLNC\CSDLNC\SQL\data_nhasi.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 2 ); -- Nếu có header
go
-- them Thuoc 3
BULK INSERT Thuoc
FROM 'G:\KHTN\CSDLNC\CSDLNC\SQL\data_Thuoc.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 2 ); -- Nếu có header
go
-- Them DonTHuoc 4
BULK INSERT DonThuoc
FROM 'G:\KHTN\CSDLNC\CSDLNC\SQL\data_DonThuoc.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 2 ); -- Nếu có 

go
-- Dieu tri 5
BULK INSERT DieuTri
FROM 'G:\KHTN\CSDLNC\CSDLNC\SQL\Dieu_tri.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 2,  -- Nếu có header
	CODEPAGE = '65001'  -- Mã hóa UTF-
);
go
-- Hoa Don 5
-- chỉnh lại tên
-- exec sp_rename 'HoaDon.TienTienDaTRa', 'TienDaTra','column';

BULK INSERT HoaDon
FROM 'G:\KHTN\CSDLNC\CSDLNC\SQL\HoaDon.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 2,
	CODEPAGE = '65001'); -- Nếu có 
go
-- HoSoBenhNhanChiTiet
-- thay đổi ghi chú nvarchar(10) -> nvarchar(MAX)
--ALTER TABLE HoSoChiTietBenhNhan
--ALTER COLUMN  Ghichu NVARCHAR(MAX);

-- doi giotinh varchar -> nvarchar
--ALTER TABLE HoSoChiTietBenhNhan
--ALTER COLUMN  Gioi_Tinh NVARCHAR(4);
--delete HoSoChiTietBenhNhan
BULK INSERT HoSoChiTietBenhNhan
FROM 'G:\KHTN\CSDLNC\CSDLNC\SQL\HoSoChiTietBenhNhan.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 2,
	CODEPAGE = '65001'); -- Nếu 
go
-- cuoc hen
BULK INSERT CuocHen
FROM 'G:\KHTN\CSDLNC\CSDLNC\SQL\CuocHen.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 2,
	CODEPAGE = '65001'); -- Nếu 
go
BULK INSERT YeuCauCuocHen
FROM 'G:\KHTN\CSDLNC\CSDLNC\SQL\YeuCauCuocHen.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '\n',
    FIRSTROW = 2,
	CODEPAGE = '65001'); -- Nếu 
go
create table YeuCauCuocHen
(
 TenBN nvarchar(50),
 NgayHen datetime,
 ghichu nvarchar(max),
 primary key(NgayHen, TenBN)
)
go
drop table YeuCauCuocHen
SELECT * FROM YeuCauCuocHen