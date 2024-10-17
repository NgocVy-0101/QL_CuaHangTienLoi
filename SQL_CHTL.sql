-- Dùng cơ sở dữ liệu master
USE master
GO

-- Xóa cơ sở dữ liệu nếu đã tồn tại
IF DB_ID('QLCHTL') IS NOT NULL
BEGIN
    ALTER DATABASE QLCHTL SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QLCHTL;
END
GO

-- Tạo lại cơ sở dữ liệu
CREATE DATABASE QLCHTL
GO

-- Sử dụng cơ sở dữ liệu QLCHTL
USE QLCHTL
GO

-- Tạo bảng KhachHang
CREATE TABLE [KhachHang] (
    [MaKhach] nvarchar(50) PRIMARY KEY,
    [TenKhach] nvarchar(50),
    [DienThoai] nvarchar(20),
    [Diem] int
)
GO

-- Tạo bảng NhanVien
CREATE TABLE [NhanVien] (
    [MaNhanVien] nvarchar(50) PRIMARY KEY,
    [TenNhanVien] nvarchar(50),
    [GioiTinh] nvarchar(10),
    [NgaySinh] date,
    [DienThoai] nvarchar(20),
    [DiaChi] nvarchar(255),
    [MatKhau] nvarchar(50)
)
GO

-- Tạo bảng SanPham
CREATE TABLE [SanPham] (
    [MaSanPham] nvarchar(50) PRIMARY KEY,
    [TenSanPham] nvarchar(255),
    [SoLuongCon] int,
    [GiaNhap] float,
    [GiaBan] float,
    [HinhAnh] varbinary(max),
	[NgaySanXuat] date,
	[NgayHetHan] date,
	[XuatXu] nvarchar(255),
    [MaLoaiSanPham] nvarchar(50),
    [MaNCC] nvarchar(50),
    [GhiChu] nvarchar(255)
)
GO

-- Tạo bảng HoaDon
CREATE TABLE [HoaDon] (
    [MaHoaDon] nvarchar(50) PRIMARY KEY,
    [MaNhanVien] nvarchar(50),
    [MaKhach] nvarchar(50),
    [NgayBan] date,
    [GiamGia] float,
    [TongTien] float
)
GO

-- Tạo bảng ChiTietHoaDon
CREATE TABLE [ChiTietHoaDon] (
    [MaHoaDon] nvarchar(50),
    [MaSanPham] nvarchar(50),
    [SoLuong] int,
    [ThanhTien] float,
    PRIMARY KEY ([MaHoaDon], [MaSanPham])
)
GO

-- Tạo bảng LoaiSanPham
CREATE TABLE [LoaiSanPham] (
    [MaLoaiSanPham] nvarchar(50) PRIMARY KEY,
    [TenLoaiSanPham] nvarchar(50)
)
GO

-- Tạo bảng NhaCungCap
CREATE TABLE [NhaCungCap] (
    [MaNCC] nvarchar(50) PRIMARY KEY,
    [TenNCC] nvarchar(50),
    [DiaChi] nvarchar(255)
)
GO

-- Thêm khóa ngoại
ALTER TABLE [HoaDon] ADD FOREIGN KEY ([MaNhanVien]) REFERENCES [NhanVien] ([MaNhanVien])
GO
ALTER TABLE [HoaDon] ADD FOREIGN KEY ([MaKhach]) REFERENCES [KhachHang] ([MaKhach])
GO
ALTER TABLE [ChiTietHoaDon] ADD FOREIGN KEY ([MaHoaDon]) REFERENCES [HoaDon] ([MaHoaDon])
GO
ALTER TABLE [ChiTietHoaDon] ADD FOREIGN KEY ([MaSanPham]) REFERENCES [SanPham] ([MaSanPham])
GO
ALTER TABLE [SanPham] ADD FOREIGN KEY ([MaNCC]) REFERENCES [NhaCungCap] ([MaNCC])
GO
ALTER TABLE [SanPham] ADD FOREIGN KEY ([MaLoaiSanPham]) REFERENCES [LoaiSanPham] ([MaLoaiSanPham])
GO

-- Thêm dữ liệu vào bảng KhachHang
INSERT INTO [KhachHang] (MaKhach, TenKhach, DienThoai, Diem) VALUES
('KHTT0012245', 'Nguyen Van A', '0123456789', 100),
('KHTT0356302', 'Le Thi B', '0987654321', 200),
('KHTT0350377', 'Tran Van C', '0234567890', 150),
('KHTT0468304', 'Pham Thi D', '0345678901', 250),
('KHTT1205605', 'Hoang Van E', '0456789012', 300),
('KHTT0350976', 'Vu Thi F', '0567890123', 350),
('KHTT3052047', 'Do Van G', '0678901234', 400)
GO

-- Thêm dữ liệu vào bảng NhanVien
INSERT INTO [NhanVien] (MaNhanVien, TenNhanVien, GioiTinh, NgaySinh, DienThoai, DiaChi, MatKhau) VALUES
('NV0081', 'Nguyen Van An', 'Nam', '1990-01-01', '0123456789', 'TP.HCM', '123456'),
('NV0029', 'Le Thi Be', 'Nu', '1992-02-02', '0987654321', 'Ha Noi', 'abcdef'),
('NV0703', 'Tran Van Co', 'Nam', '1994-03-03', '0234567890', 'Bac Lieu', 'xyz789'),
('NV0094', 'Pham Thi De', 'Nu', '1996-04-04', '0345678901', 'Dong Thap', '123abc'),
('NV0405', 'Hoang Van Hoang', 'Nam', '1998-05-05', '0456789012', 'Ca Mau', '456def'),
('NV0076', 'Vu Thi Lanh', 'Nu', '2000-06-06', '0567890123', 'Long An', '789ghi'),
('NV0071', 'Do Van Go', 'Nam', '2002-07-07', '0678901234', 'TP.HCM', '012jkl')
GO

-- Thêm dữ liệu vào bảng NhaCungCap
INSERT INTO [NhaCungCap] (MaNCC, TenNCC, DiaChi) VALUES
('NCC001', 'Nha cung cap 1', 'Dia chi 1'),
('NCC002', 'Nha cung cap 2', 'Dia chi 2'),
('NCC003', 'Nha cung cap 3', 'Dia chi 3'),
('NCC004', 'Nha cung cap 4', 'Dia chi 4'),
('NCC005', 'Nha cung cap 5', 'Dia chi 5'),
('NCC006', 'Nha cung cap 6', 'Dia chi 6'),
('NCC007', 'Nha cung cap 7', 'Dia chi 7')
GO

-- Thêm dữ liệu vào bảng LoaiSanPham
INSERT INTO [LoaiSanPham] (MaLoaiSanPham, TenLoaiSanPham) VALUES
('LSP001', 'Loai san pham 1'),
('LSP002', 'Loai san pham 2'),
('LSP003', 'Loai san pham 3'),
('LSP004', 'Loai san pham 4'),
('LSP005', 'Loai san pham 5'),
('LSP006', 'Loai san pham 6'),
('LSP007', 'Loai san pham 7')
GO

-- Thêm dữ liệu vào bảng SanPham
INSERT INTO [SanPham] (MaSanPham, TenSanPham, SoLuongCon, GiaNhap, GiaBan, HinhAnh, NgaySanXuat, NgayHetHan, XuatXu, MaLoaiSanPham, MaNCC, GhiChu) VALUES
('SP001', 'Coca Cola', 10, 10000, 15000, null, '2023-01-01', '2029-01-01', 'TP.HCM','LSP001', 'NCC001', 'Ghi chu 1'),
('SP002', 'Sting do', 20, 20000, 25000, null, '2023-01-01', '2029-01-01', 'TP.HCM','LSP002', 'NCC002', 'Ghi chu 2'),
('SP003', 'Xuc xich bo', 30, 30000, 35000, null, '2023-01-01', '2029-01-01', 'TP.HCM','LSP003', 'NCC003', 'Ghi chu 3'),
('SP004', 'Mi haohao', 40, 40000, 45000, null, '2023-01-01', '2029-01-01', 'TP.HCM','LSP004', 'NCC004', 'Ghi chu 4'),
('SP005', 'Sua chuoi', 50, 50000, 55000, null, '2023-01-01', '2029-01-01', 'TP.HCM','LSP005', 'NCC005', 'Ghi chu 5'),
('SP006', 'Bot giac', 60, 60000, 65000, null, '2023-01-01', '2029-01-01', 'TP.HCM','LSP006', 'NCC006', 'Ghi chu 6'),
('SP007', 'Kem danh rang', 70, 70000, 75000, null, '2023-01-01', '2029-01-01', 'TP.HCM','LSP007', 'NCC007', 'Ghi chu 7')
GO

-- Thêm dữ liệu vào bảng HoaDon
INSERT INTO [HoaDon] (MaHoaDon, MaNhanVien, MaKhach, NgayBan, GiamGia, TongTien) VALUES
('HD001', 'NV0081', 'KHTT0468304', '2023-01-01', 10, 100000),
('HD002', 'NV0029', 'KHTT0356302', '2023-02-01', 20, 200000),
('HD003', 'NV0703', 'KHTT3052047', '2023-03-01', 15, 150000),
('HD004', 'NV0094', 'KHTT0350377', '2023-04-01', 25, 250000),
('HD005', 'NV0405', 'KHTT1205605', '2023-05-01', 30, 300000),
('HD006', 'NV0076', 'KHTT0350976', '2023-06-01', 35, 350000),
('HD007', 'NV0071', 'KHTT3052047', '2023-07-01', 40, 400000)
GO

-- Thêm dữ liệu vào bảng ChiTietHoaDon
INSERT INTO [ChiTietHoaDon] (MaHoaDon, MaSanPham, SoLuong, ThanhTien) VALUES
('HD001', 'SP001', 1, 15000),
('HD002', 'SP002', 2, 50000),
('HD003', 'SP003', 3, 105000),
('HD004', 'SP004', 4, 180000),
('HD005', 'SP005', 5, 275000),
('HD006', 'SP006', 6, 390000),
('HD007', 'SP007', 7, 525000)
GO



