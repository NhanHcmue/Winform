CREATE DATABASE QLTC
GO

USE QLTC
GO

Create table TaiKhoan
(
	id int identity(1,1) primary key,
	TenDangNhap nvarchar(100) not null,
	MatKhau nvarchar(1000 ) not null
)
go

Create table ThongTinSanh
(
	id int identity(1,1) primary key,
	LoaiSanh nvarchar(100) ,
	TenSanh nvarchar(100) not null default N'Chưa Đặt Tên',
	SoLuongBanToiDa int not null,
	DonGiaToiThieu bigint not null,
	GhiChu nvarchar(100) default N'Trống',
	TiSoPhat float default 0.01
)
go

Create table ThucDon
(
	id int identity,
	MaThucDon varchar(100),
	MonKhaiVi nvarchar(100) not null,
	MonChinh1 nvarchar(100)not null,
	MonChinh2 nvarchar(100) not null,
	MonChinh3 nvarchar(100) not null,
	Lau nvarchar(100) not null,
	TrangMieng nvarchar(100) not null,
	Bia nvarchar(100) not null,
	NuocNgot nvarchar(100)not null,
	GiaThucDon bigint not null
	primary key(id)
)
go

create table DichVu
(
	id int identity ,
	MaDichVu  varchar(100),
	Ruou nvarchar(100),
	BanhKem nvarchar(100),
	Mc nvarchar(100),
	BanNhac nvarchar(100),
	CaSi nvarchar(100),
	Dj nvarchar(100),
	GiaDichVu bigint,
	primary key(id)
)
go

Create table Tiec
(
	id  int identity(1,1),
	Ca nvarchar(20),
	TrangThai nvarchar(100) default N'Chưa săn sàng'
)
go

Create table ThongTinkhachHang
(
	id int identity(1,1),
	MaKhachHang  AS RIGHT('KH' + CAST(id AS VARCHAR(7)), 7) PERSISTED,
	NgayLap date not null,
	TenKhachHang nvarchar(100) not null,
	TenChuRe nvarchar(100) not null,
	TenCoDau nvarchar(100) not null,
	DiaChi nvarchar(100) not null,
	DienThoai nvarchar(100) not null,
	Email nvarchar(100) not null,
	NgayToChuc date not null,
	TienCoc bigint,
	primary key(id)
)
go

Create table NhanVien
(
	id int identity(5,1) primary key,
	MaNhanVien AS RIGHT('NV00' + CAST(id AS VARCHAR(5)), 5) PERSISTED,
	TenNhanVien nvarchar(100) not null,
	SoDienThoai nvarchar(100) not null,
	DiaChi nvarchar(100) not null,
	LoaiSanh nvarchar(100) ,
	ChucVu nvarchar(100) not null,
	Ca nvarchar(100) not null,
)
go

Create table ThongTinDatTiec
(
	id int identity(1,1) ,
	MaDatTiec  AS RIGHT('DT' + CAST(id AS VARCHAR(7)), 7) PERSISTED,
	IDNhanVien int FOREIGN KEY REFERENCES NhanVien(id),
	IDThongTinKhachHang int FOREIGN KEY REFERENCES ThongTinKhachHang(id),
	IdLoaiSanh int FOREIGN KEY REFERENCES ThongTinSanh(id),
	IdDichVu int FOREIGN KEY REFERENCES DichVu(id),
	IdThucDon int FOREIGN KEY REFERENCES ThucDon(id),
	SoLuongNhanVien int not null,
	SoLuongBan int,
	Ca nvarchar(100) not null,
	primary key(id )
)
go

Create table HoaDon
(
	id int identity(1,1) primary key,
	MaHoaDon  AS RIGHT('HĐ' + CAST(id AS VARCHAR(7)), 7) PERSISTED,
	IdMaDatTiec INT,
	IDThongTinKhachHang INT,
	IdLoaiSanh int FOREIGN KEY REFERENCES ThongTinSanh(id),
	IdDichVu int FOREIGN KEY REFERENCES DichVu(id),
	IdThucDon int FOREIGN KEY REFERENCES ThucDon(id),
	TienPhat bigint,
	TongTienHoaDon bigint not null,
	TienCoc bigint not null,
	TienConLai bigint ,
	
)
go



Create table ChucVu
(
	id int  primary key,
	ChucVu nvarchar(100) not null

)
go

Create table LapBaoCao
(
	id int identity(1,1) primary key,
	MaBaoCao AS RIGHT('BC00' + CAST(id AS VARCHAR(5)), 5) PERSISTED,
	NgayLap date not null,
	TenNguoiLap nvarchar(100),
	Thang int,
	SoLuongTiec int,
	DoanhThu int

)
go

Create table BaoCaoDoanhThu
(
	id int identity(1,1) primary key,
	Thang int,
	TongDoanhThu int
)

insert into TaiKhoan values(N'NHAN',N'1')


insert into ThongTinSanh values(N'Loai A',N'Kim Cương',N'500',N'50000000','Không', 0.01)
insert into ThongTinSanh values(N'Loai B',N'Bạch Kim',N'450',N'45000000','Không', 0.01)
insert into ThongTinSanh values(N'Loai C',N'Vàng',N'400',N'40000000','Không', 0.01)
insert into ThongTinSanh values(N'Loai D',N'Bạc',N'350',N'35000000','Không', 0.01)
insert into ThongTinSanh values(N'Loai E',N'Đồng',N'300',N'30000000','Không', 0.01)

insert into ThucDon values(N'TĐ 1',N'Chả Giò Rế Hà Nội',N'Gà Ấp Chảo + Bánh Bao',N'Dê Hấp Lá Tía Tô',N'Tôm Sông Rang Muối',N'Lẩu Thái Hải Sản',N'Thanh Nhiệt Sâm Sâm',N'Heniken',N'Pepsi',N'2000000')
insert into ThucDon values(N'TĐ 2',N'Suop Cua Gà Xé',N'Gà Bó Xôi',N'Bò Nấu Đậu + Bánh Mì',N'Vịt Quay Bắc Kinh',N'Lẩu Nắm Hải Sản',N'Chè Hạt Sen',N'Tiger Bạc',N'Trà Xanh',N'1800000')
insert into ThucDon values(N'TĐ 3',N'Gỏi Gó Sen Tôm Thit',N'Gà Hấp Hành + Xôi',N'Cá Điêu Hồng Chưng Tương',N'Chim Cút Roti + Bánh Mì',N'Lẩu Thái Hải Sản',N'Chè Hạt Sen',N'Heniken',N'Cocacola',N'2000000')
insert into ThucDon values(N'TĐ 4',N'Suop Hải Sản Nấm Tuyết',N'Gà Nấu Lagu + Bánh Mì',N'Cá Điêu Hồng Hấp HongKong',N'Gà Bó Xôi',N'Lẩu Cua Đồng',N'Rau Câu Ngũ Sắc',N'Tiger',N'Pepsi',N'1800000')
insert into ThucDon values(N'TĐ 5',N'Chả Giò Venus',N'Chim Cút Roti + Bánh Mì',N'Tôm Sông Rang Muối',N'Cá Điêu Hồng Chưng Tương',N'Lẩu Cá Bớp',N'Chè Khúc Bạch',N'Heniken',N'Pepsi',N'2000000')

insert into DichVu values(N'DV1',N'Rượu Vang',N'2Tầng',N'Minh Anh',N'Band 1', N'NhưYến',N'Dan',1000000)
insert into DichVu values(N'DV2',N'Rượu Vang',N'3Tầng',N'Ngọc Như',N'Band 2',N'NgọcBích',N'Black', 2000000)
insert into DichVu values(N'DV3',N'Rượu Vang',N'4Tầng',N'Anh Tuấn',N'Band 3',N'HoàngNgọc',N'DN', 3000000)
insert into DichVu values(N'DV4',N'Rượu Vang',N'5Tầng',N'Tuấn Khang',N'Band 4',N'NguyênKhang',N'Mie', 4000000)

insert into Tiec values (N'Sáng', N'Chưa sẵn sàng')
insert into Tiec values (N'Trưa', N'Chưa sẵn sàng')
insert into Tiec values (N'Tối', N'sẵn sàng')

insert into ThongTinKhachHang values('4/10/2018',N'Hà Như Ý',N'Hà Như Ý',N'Nguyễn Thị Tố Như',N'Phường Linh Trung, Quận Thủ Đức, Tp.Hồ Chí Minh','0162345347',N'nhuy1998@gmail.com','12/12/2018', 1000000)
insert into ThongTinKhachHang values('2/10/2018',N'Hà Như',N'Hà Như ',N'Nguyễn Thị Tố ',N'Phường Linh Trung, Quận Thủ Đức, Tp.Hồ Chí Minh','01623453',N'nhu1998@gmail.com','1/12/2018', 1000000)


insert into ChucVu values( 1, N'Phục vụ')
insert into ChucVu values( 2,  N'Giám Sát')
insert into ChucVu values( 3,  N'Quản lý')
insert into ChucVu values( 4,  N'Tiếp Tân')

insert into NhanVien values( N'Hoa', N'01223810110',N'Hoàng Diệu 2',N'Loai A', N'Phục vụ', N'Sáng')
insert into NhanVien values( N'Hồng', N'01223810111',N'Hoàng Diệu 3',N'Loai B', N'Giám Sát', N'Trưa')
insert into NhanVien values( N'Cúc', N'01223810112',N'Hoàng Diệu 4',N'Loai C', N'Phục vụ', N'Tối')
insert into NhanVien values( N'Duy', N'01223810113',N'Hoàng Diệu 5',N'Loai E', N'Quản lý', N'Sáng')
insert into NhanVien values( N'Hoàng', N'01223811234',N'Hoàng Diệu 6',N'Loai A', N'Phục vụ', N'Sáng')
insert into NhanVien values( N'Mai', N'01223811235',N'Hoàng Diệu 7',N'Loai B', N'Giám Sát', N'Trưa')
insert into NhanVien values( N'Ngọc', N'01223811236',N'Hoàng Diệu 8',N'Loai C', N'Phục vụ', N'Tối')
insert into NhanVien values( N'Uyên', N'01223811237',N'Hoàng Diệu9',N'Loai E', N'Quản lý', N'Sáng')