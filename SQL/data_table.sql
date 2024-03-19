

use QuanLyPhongKhamNhaKhoa
go

create table BenhNhan(
	MaBN char(10) PRIMARY KEY,
	HoTen nvarchar(Max),
	SDT VARCHAR(15), --*
	Email char(50),
	DiaChi char(50),
	NgaySinh date	
)
go

create table DieuTri(
	MaDTR char(10) PRIMARY KEY,
	Phi integer,
	LoaiThanhToan  nvarchar(20) check(LoaiThanhToan = N'Tiền Mặt' or LoaiThanhToan = N'Online'),
	DsRang char(50),
	DsBeMatRang char(50),
	MaNhaSi char(10),
	MaTroKham char(10),
	NgayDtr date,
	TrangThaiDieuTri varchar(50) check (TrangThaiDieuTri = N'kế hoạch' or TrangThaiDieuTri =N'Đã Hoàn Thành' or TrangThaiDieuTri = N'Đã Hủy')
)
go
create table HoaDon(
	MaHD char(10) primary key,
	NgayGiaoDich date,
	TongTien integer,
	NgayThanhToan date,
	TienDaTra integer,
	TienThoi integer,
	LoaiThanhToan  nvarchar(20) check(LoaiThanhToan = N'Tiền Mặt' or LoaiThanhToan = N'Online'),
	Ghichu nvarchar(MAX),
	MaDTR char(10),
	NguoiThanhToan nvarchar(MAX),
	Foreign key (MaDTR) references DieuTri(MaDTR)
)
go

create table HoSoChiTietBenhNhan(
	MaBN char(10) primary key,
	HoTen nvarchar(Max),
	Tuoi integer,
	Gioi_Tinh varchar(4) check(Gioi_Tinh = N'Nam' or Gioi_tinh = N'Nữ'),
	SucKhoe	nvarchar(MAX),
	--KeHoachDieuTri vì Hiển thị theo hóa đơn
	MaHD char(10),
	DonThuoc char(10),
	Ghichu nvarchar(MAX),
	foreign key (MaBN) references BenhNhan(MaBN),
	foreign key (DonThuoc) references HoaDon(MaHD)
)
go

create table Thuoc(
	MaThuoc char(10) PRIMARY KEY,
	TenThuoc nvarchar(MAX)
)
go

create table DonThuoc(
	MaHD char(10),
	MaThuoc char(10),
	PRIMARY KEY (MaHD, MaThuoc),
	Foreign key (MaHD) references HoaDon(MaHD),
	Foreign key (MaThuoc) references Thuoc(MaThuoc)
)
go

CREATE TABLE NhaSi 
(
    MA CHAR(10) PRIMARY KEY,
    HOTEN NVARCHAR(255),
    Tuan NVARCHAR(MAX),
    Thang NVARCHAR(MAX), --*
	Ngay_auto DATE
);
go
CREATE TABLE ThoiGianLamViec 
(
    ID CHAR(10) PRIMARY KEY,
    MA CHAR(10),
    NgayLamViec DATE,
    GioBatDau TIME,
    GioKetThuc TIME,
    FOREIGN KEY (MA) REFERENCES NhaSi(MA)
);
go
-------------------------------------
CREATE TABLE CuocHen
(
	ThoiGian DATE,
	MaBN CHAR(10),
	MANHASI CHAR(10),
	MATROKHAM CHAR(10),
	Phong NVARCHAR(255),
	LoaiCuocHen NVARCHAR(255),
	CONSTRAINT PK_CuocHen PRIMARY KEY (MaBN,ThoiGian),
	CONSTRAINT FK_CuocHen_NhaSi FOREIGN KEY (MANHASI) REFERENCES NhaSi(MA),
	CONSTRAINT FK_CuocHen_NhaSiTrokham FOREIGN KEY (MATROKHAM) REFERENCES NhaSi(MA),
	CONSTRAINT FK_CuocHen_BenhNhan FOREIGN KEY (MaBN) REFERENCES BenhNhan(MaBN)
)
go
create table YeuCauCuocHen
(
 TenBN nvarchar(50),
 NgayHen date,
 ghichu nvarchar(max),
 ThoiGian time,
 primary key(NgayHen, ThoiGian)
)
go


select * from BenhNhan