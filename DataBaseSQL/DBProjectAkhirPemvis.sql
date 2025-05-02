CREATE SCHEMA PeminjamanPT6;

USE PeminjamanPT6;

CREATE TABLE tbPeminjaman (
    kode CHAR(3) PRIMARY KEY,
    Status Varchar(45) DEFAULT 'Belum Membayar',
    Nama VARCHAR(50),
    Jumlah int,
    Alamat varchar(100),
    Nomor bigInt,
    Tanggal varchar(50),
    Foto Varchar(200)
);

CREATE TABLE tbnote (
	Note text,
    id varchar(45) Primary key,
    kode CHAR(3),
    foreign key (kode) references tbPeminjaman(kode)
);

CREATE TABLE login (
    Username varchar(30) Primary key,
    Password varchar(30)
);

INSERT INTO login (username, password) VALUES ('admin', 'admin');
select * from tbnote;
SELECT * FROM login WHERE Username = 'admin' AND password = 'admin';