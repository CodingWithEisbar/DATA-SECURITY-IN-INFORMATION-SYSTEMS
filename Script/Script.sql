ALTER TABLE PHONGBAN
drop CONSTRAINT FK_PHONGBAN_NHANVIEN;

ALTER TABLE NHANVIEN
drop CONSTRAINT FK_NHANVIEN_PHONGBAN;

ALTER TABLE DEAN
drop CONSTRAINT FK_DEAN_PHONGBAN;

ALTER TABLE PHANCONG
drop CONSTRAINT FK_PHANCONG_NHANVIEN;

ALTER TABLE PHANCONG
drop CONSTRAINT FK_PHANCONG_PHONGBAN;

drop table NHANVIEN;
CREATE TABLE NHANVIEN (
    MANV NUMBER(4),
    Username varchar2(100),
    TENNV VARCHAR2(100),
    PHAI VARCHAR2(10),
    NGAYSINH DATE,
    DIACHI VARCHAR2(100),
    SODT VARCHAR2(100),
    LUONG NUMBER(7,2),
    PHUCAP NUMBER(7,2),
    VAITRO VARCHAR2(10),
    MANQL NUMBER(4),
    PHG NUMBER(4),
    
    CONSTRAINT NHANVIEN_PK
    PRIMARY KEY(MANV)
);
drop table PHONGBAN;
CREATE TABLE PHONGBAN (
    MAPB NUMBER(4),
    TENPB VARCHAR2(100),
    TRPHG NUMBER(4),
    
    CONSTRAINT PHONGBAN_PK
    PRIMARY KEY(MAPB)
);
drop table DEAN;
CREATE TABLE DEAN (
    MADA NUMBER(4),
    TENDA VARCHAR2(100),
    NGAYBD DATE,
    PHONG number(4),
    
    CONSTRAINT DEAN_PK
    PRIMARY KEY(MADA)
);
drop table PHANCONG;
CREATE TABLE PHANCONG(
    MANV NUMBER(4),
    MADA NUMBER(4),
    THOIGIAN DATE,
    
    CONSTRAINT PHANCONG_PK
    PRIMARY KEY(MANV, MADA) 
);

----------------------------------------------------------------------------------
--- KHAI BAO KHOA NGOAI
ALTER TABLE PHONGBAN
ADD CONSTRAINT FK_PHONGBAN_NHANVIEN
FOREIGN KEY (TRPHG)
REFERENCES NHANVIEN(MANV);

ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NHANVIEN_PHONGBAN
FOREIGN KEY (PHG)
REFERENCES PHONGBAN(MAPB);

ALTER TABLE DEAN
ADD CONSTRAINT FK_DEAN_PHONGBAN
FOREIGN KEY(PHONG)
REFERENCES PHONGBAN(MAPB);

ALTER TABLE PHANCONG
ADD CONSTRAINT FK_PHANCONG_NHANVIEN
FOREIGN KEY(MANV)
REFERENCES NHANVIEN(MANV);

ALTER TABLE PHANCONG
ADD CONSTRAINT FK_PHANCONG_PHONGBAN
FOREIGN KEY(MADA)
REFERENCES DEAN(MADA);

--Nhan vien--
INSERT INTO Nhanvien(MANV,Username,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) 
VALUES (1,N'ADMIN' ,N'Nguyen Van A', 'NAM',TO_DATE('2001/12/16 ', 'yyyy/mm/dd '),N'Tp. Da Lat','0852576282',1,1,N'Nhanvien',1,null);

INSERT INTO Nhanvien(MANV,Username,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) 
VALUES (2,N'QLTT' ,N'Nguyen Van A', 'NAM',TO_DATE('2001/12/16 ', 'yyyy/mm/dd '),N'Tp. Da Lat','0852576282',1,1,N'Quanly',1,null);

--Phongban--
INSERT INTO PHONGBAN (MAPB,TENPB,TRPHG) VALUES (1,N'x',1);

--Dean--
INSERT INTO DeAn (MADA,TENDA,NGAYBD,PHONG) VALUES (1,N'y',TO_DATE('2001/12/16 ', 'yyyy/mm/dd '),1);

--PhanCong--
INSERT INTO PHANCONG(MANV,MADA,THOIGIAN) VALUES (1,1,TO_DATE('2001/12/16 ', 'yyyy/mm/dd '));
INSERT INTO PHANCONG(MANV,MADA,THOIGIAN) VALUES (2,1,TO_DATE('2001/12/16 ', 'yyyy/mm/dd '));

update nhanvien set PHG=1 where MaNV=1;
update nhanvien set PHG=1 where MaNV=2;
--cs1--
--NhanVien
CREATE OR REPLACE VIEW NhanVien_Select_NV AS
SELECT NV.MANV,NV.Username,NV.TENNV,NV.PHAI,NV.NGAYSINH,NV.DIACHI,NV.SODT,NV.LUONG,NV.PHUCAP,NV.VAITRO,NV.MANQL,NV.PHG
FROM NHANVIEN NV
WHERE NV.USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER')
with check option;

CREATE OR REPLACE VIEW PhanCong_Select_NV AS
SELECT NV.MANV,PC.MADA,PC.THOIGIAN
FROM NHANVIEN NV,PHANCONG PC
WHERE NV.USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER') and NV.VAITRO=N'Nhanvien' AND PC.MANV=NV.MANV
with check option;

CREATE OR REPLACE TRIGGER updateNhanVien
    INSTEAD OF UPDATE ON NhanVien_Select
    FOR EACH ROW
BEGIN
    -- insert a new customer first
    Update NhanVien set Ngaysinh=:new.ngaysinh, diachi=:new.diachi, sodt=:new.sodt where USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER');
END;

--alter session set "_oracle_script"=true;
grant select on Phongban to Nhanvien;
grant select on Dean to Nhanvien;
grant select on NhanVien_Select_NV to Nhanvien;
grant update on NhanVien_Select_NV  to Nhanvien;
grant select on PhanCong_Select_NV to Nhanvien;
grant Nhanvien to NV;




alter session set "_oracle_script"=true;
drop role Nhanvien;
drop role QLTrucTiep;
drop role TruongPhong;
drop role TaiChinh;
drop role NhanSu;
drop role TruongDeAn;
drop role BanGiamDoc;

create role Nhanvien;
create role QLTrucTiep;
create role TruongPhong;
create role TaiChinh;
create role NhanSu;
create role TruongDeAn;
create role BanGiamDoc;