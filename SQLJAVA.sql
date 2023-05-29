CREATE DATABASE QLSQA;
GO

USE QLSQA;
GO

CREATE TABLE DANGNHAP (
    TenDN nvarchar(20) not null,
    MK nvarchar(20) not null,
    CONSTRAINT pk5 PRIMARY KEY (TenDN, MK)
);

CREATE TABLE HANGHOA (
    MAHH nvarchar(10) not null PRIMARY KEY,
    TENHH nvarchar(30) not null,
    GIABAN nvarchar(30) not null,
    DONVITINH nvarchar(30) not null,
    MANCC nvarchar(30) not null,
    FOREIGN KEY (MANCC) REFERENCES NHACUNGCAP(MANCC)
);

CREATE TABLE HOADON (
    SOHD nvarchar(7) not null PRIMARY KEY,
    NGAYLAP date not null,
    MANV nvarchar(10) not null,
    TENKH nvarchar(30) not null,
    TONG int not null
);

CREATE TABLE CHITIETHOADON (
    SOHD nvarchar(7),
    MAHH nvarchar(10) not null,
    TENHH nvarchar(30) not null,
    DONGIA int,
    SOLUONG int,
    THANHTIEN int,
    PRIMARY KEY (SOHD, MAHH),
    FOREIGN KEY (SOHD) REFERENCES HOADON(SOHD),
    FOREIGN KEY (MAHH) REFERENCES HANGHOA(MAHH)
);

CREATE TABLE NGUOIDUNG (
    MANV nvarchar(30) not null primary key,
    TAIKHOAN nvarchar(30) not null,
    MATKHAU nvarchar(30) not null,
    QUYEN nvarchar(30) not null
);

CREATE TABLE NHACUNGCAP (
    MANCC nvarchar(30) not null primary key,
    TENNCC nvarchar(30) not null,
    DIACHI nvarchar(30) not null,
    DIENTHOAI nvarchar(30) not null,
    WEBSITE nvarchar(30) not null
);
