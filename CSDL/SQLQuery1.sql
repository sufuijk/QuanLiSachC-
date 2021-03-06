

CREATE DATABASE QUANLISACH
USE QUANLISACH
CREATE TABLE THELOAI(
	ID_THELOAI INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TENLOAI NVARCHAR(30) NOT NULL
);

CREATE TABLE NHAXUATBAN(
	ID_NXB INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TENNXB NVARCHAR(30) NOT NULL,
	DIACHI NVARCHAR(30) NOT NULL,
	DIENTHOAI NVARCHAR(30) NOT NULL
);

CREATE TABLE SACH(
	ID_SACH INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TENSACH NVARCHAR(30) NOT NULL,
	TACGIA NVARCHAR(30) NOT NULL,
	ID_NXB INT FOREIGN KEY REFERENCES NHAXUATBAN(ID_NXB),
	ID_THELOAI INT FOREIGN KEY REFERENCES THELOAI(ID_THELOAI),
	SOTRANG INT NOT NULL,
	GIABIA FLOAT NOT NULL
);