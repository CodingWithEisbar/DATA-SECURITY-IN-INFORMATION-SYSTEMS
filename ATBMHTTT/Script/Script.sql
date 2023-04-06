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
    MANV NUMBER(4) generated always as identity(start with 1 increment by 1),
    Username varchar2(100),
    TENNV VARCHAR2(100),
    PHAI VARCHAR2(10),
    NGAYSINH DATE,
    DIACHI VARCHAR2(100),
    SODT VARCHAR2(100),
    LUONG NUMBER(7,2),
    PHUCAP NUMBER(7,2),
    VAITRO VARCHAR2(20),
    MANQL NUMBER(4),
    PHG NUMBER(4),
    
    CONSTRAINT NHANVIEN_PK
    PRIMARY KEY(MANV)
);
drop table PHONGBAN;
CREATE TABLE PHONGBAN (
    MAPB NUMBER(4) generated always as identity(start with 1 increment by 1),
    TENPB VARCHAR2(100),
    TRPHG NUMBER(4),
    
    CONSTRAINT PHONGBAN_PK
    PRIMARY KEY(MAPB)
);
drop table DEAN;
CREATE TABLE DEAN (
    MADA NUMBER(4) generated always as identity(start with 1 increment by 1),
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
INSERT INTO Nhanvien(Username,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) 
VALUES (N'admin' ,N'Nguyen Van A', 'NAM',TO_DATE('2001/12/16 ', 'yyyy/mm/dd '),N'Tp. Da Lat','0852576282',1,1,N'Nhanvien',2,null);
select*from nhanvien;

INSERT INTO Nhanvien(Username,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) 
VALUES (N'QLTT' ,N'Nguyen Van A', 'NAM',TO_DATE('2001/12/16 ', 'yyyy/mm/dd '),N'Tp. Da Lat','0852576282',1,1,N'Quanly',1,null);

INSERT INTO Nhanvien(Username,TENNV,PHAI,NGAYSINH,DIACHI,SODT,LUONG,PHUCAP,VAITRO,MANQL,PHG) 
VALUES (N'TDA' ,N'Nguyen Van A', 'NAM',TO_DATE('2001/12/16 ', 'yyyy/mm/dd '),N'Tp. Da Lat','0852576282',1,1,N'TRUONGPHONG',NULL,null);

--Phongban--
INSERT INTO PHONGBAN (TENPB,TRPHG) VALUES (N'x',3);

--Dean--
INSERT INTO DeAn (TENDA,NGAYBD,PHONG) VALUES (N'y',TO_DATE('2001/12/16 ', 'yyyy/mm/dd '),1);

--PhanCong--
INSERT INTO PHANCONG(MANV,MADA,THOIGIAN) VALUES (1,1,TO_DATE('2001/12/16 ', 'yyyy/mm/dd '));
--INSERT INTO PHANCONG(MANV,MADA,THOIGIAN) VALUES (2,1,TO_DATE('2001/12/16 ', 'yyyy/mm/dd '));
INSERT INTO PHANCONG(MANV,MADA,THOIGIAN) VALUES (3,1,TO_DATE('2001/12/16 ', 'yyyy/mm/dd '));


update nhanvien set PHG=1 where MaNV=1;
update nhanvien set PHG=1 where MaNV=2;
update nhanvien set PHG=1 where MaNV=3;
alter session set "_oracle_script"=true;
drop role Nhanvien;
drop role QLTrucTiep;
drop role TruongPhong;
drop role TaiChinh;
drop role NhanSu;
drop role TruongDeAn;
drop role BanGiamDoc;
drop role GeneralRole;

create role Nhanvien;
create role QLTrucTiep;
create role TruongPhong;
create role TaiChinh;
create role NhanSu;
create role TruongDeAn;
create role BanGiamDoc;
create role GeneralRole;
--cs1--
--NhanVien
/
CREATE OR REPLACE FUNCTION NhanVien_Select_NV (
p_schema IN VARCHAR2,
p_object IN VARCHAR2)
RETURN VARCHAR2
AS
user VARCHAR2(100);
BEGIN
    RETURN 'USERNAME = SYS_CONTEXT(''userenv'', ''SESSION_USER'')';
END;
/


begin
    DBMS_RLS.add_policy(object_schema => 'ADMIN',object_name => 'Nhanvien',policy_name => 'VPD_Nhanvien',policy_function => 'NhanVien_Select_NV');
end;
/
CREATE OR REPLACE VIEW PhanCong_Select_NV AS
SELECT NV.MANV,PC.MADA,PC.THOIGIAN
FROM NHANVIEN NV,PHANCONG PC
WHERE NV.USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER') and NV.VAITRO=N'Nhanvien' AND PC.MANV=NV.MANV
with check option;

CREATE OR REPLACE PROCEDURE update_NV_NV(NV_MANV NUMBER,NV_NGAYSINH DATE,NV_DIACHI VARCHAR2,NV_SODT VARCHAR2)
AS
BEGIN
  update Nhanvien set ngaysinh=nv_ngaysinh, diachi=nv_diachi, sodt=nv_sodt where manv=NV_MANV ;
  COMMIT;
END;
/
GRANT EXECUTE ON update_NV_NV TO NhanVien;


grant select on Phongban to GeneralRole;
grant select on Dean to GeneralRole;

grant select on NhanVien to Nhanvien;
grant update(ngaysinh,diachi,sodt) on NhanVien  to Nhanvien;
grant select on PhanCong_Select_NV to Nhanvien;
grant Nhanvien to NV;
grant GeneralRole to NV;



--cs2--
CREATE OR REPLACE VIEW NhanVien_Select_QL AS
SELECT distinct NV.MANV,NV.Username,NV.TENNV,NV.PHAI,NV.NGAYSINH,NV.DIACHI,NV.SODT,NV.VAITRO,NV.MANQL,NV.PHG,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),luong) luong,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),phucap) phucap
FROM NHANVIEN NV
union
SELECT distinct NV2.MANV,NV2.Username,NV2.TENNV,NV2.PHAI,NV2.NGAYSINH,NV2.DIACHI,NV2.SODT,NV2.VAITRO,NV2.MANQL,NV2.PHG,decode(NV2.Username,null,NV2.luong) luong,decode(NV2.Username,null,Nv2.phucap) phucap
FROM NHANVIEN NV1,Nhanvien NV2
where NV1.UserName=SYS_CONTEXT ('USERENV', 'SESSION_USER') and nv2.manql=nv1.manv and nv1.manv!=nv2.manv and nv2.vaitro=N'Nhanvien'
with check option;

CREATE OR REPLACE VIEW PhanCong_Select_QL AS
SELECT NV.MANV,PC.MADA,PC.THOIGIAN
FROM PHANCONG PC,nhanvien nv
WHERE NV.USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER') and NV.VAITRO=N'Quanly' AND PC.MANV=NV.MANV
union
SELECT NV2.MANV,PC.MADA,PC.THOIGIAN
FROM NHANVIEN NV1,PHANCONG PC,NHANVIEN NV2
where NV1.username=SYS_CONTEXT ('USERENV', 'SESSION_USER') and NV2.MANQL=NV1.MANV AND PC.MANV=NV2.MANV  and nv2.manv!=nv1.manv
with check option;

CREATE OR REPLACE TRIGGER updateQuanLy
    INSTEAD OF UPDATE ON NhanVien_Select_QL
    FOR EACH ROW
BEGIN
    -- insert a new customer first
    Update NhanVien set Ngaysinh=:new.ngaysinh, diachi=:new.diachi, sodt=:new.sodt where USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER');
END;
/
grant select on NhanVien_Select_QL to QLTrucTiep;--
grant select on PHANCONG_Select_QL to QLTrucTiep;
grant update on NhanVien_Select_QL to QLTrucTiep;
grant QLTrucTiep to QLTT;
grant GeneralRole to QLTT; 



--cs3--
CREATE OR REPLACE VIEW NhanVien_Select_TP AS
SELECT distinct NV.MANV,NV.Username,NV.TENNV,NV.PHAI,NV.NGAYSINH,NV.DIACHI,NV.SODT,NV.VAITRO,NV.MANQL,NV.PHG,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),luong) luong,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),phucap) phucap
FROM NHANVIEN NV
union
SELECT distinct NV2.MANV,NV2.Username,NV2.TENNV,NV2.PHAI,NV2.NGAYSINH,NV2.DIACHI,NV2.SODT,NV2.VAITRO,NV2.MANQL,NV2.PHG,decode(NV2.Username,null,NV2.luong) luong,decode(NV2.Username,null,Nv2.phucap) phucap
FROM NHANVIEN NV1,Nhanvien NV2,PHONGBAN PB
where NV1.UserName=SYS_CONTEXT ('USERENV', 'SESSION_USER') and nv1.manv!=nv2.manv and nv1.vaitro=N'TRUONGPHONG' and PB.TRPHG=NV1.MANV AND NV2.PHG=PB.MAPB
with check option;

CREATE OR REPLACE VIEW PhanCong_Select_TP AS
SELECT PC.MANV,PC.MADA,PC.THOIGIAN
FROM NHANVIEN NV1,Nhanvien NV2,PHONGBAN PB,PHANCONG PC
where NV1.UserName=SYS_CONTEXT ('USERENV', 'SESSION_USER') and nv1.vaitro=N'TRUONGPHONG' and PB.TRPHG=NV1.MANV AND NV2.PHG=PB.MAPB AND PC.MANV=NV2.MANV;

CREATE OR REPLACE TRIGGER updateTP
    INSTEAD OF UPDATE ON PhanCong_Select_QL
    FOR EACH ROW
BEGIN
    Update PhanCong set manv=:new.manv, MADA=:new.MADA, THOIGIAN=:new.THOIGIAN;
END;
/
CREATE OR REPLACE TRIGGER insertTP
    INSTEAD OF INSERT ON PhanCong_Select_QL
    FOR EACH ROW
DECLARE
    MaNV1 NUMBER(4);
    MaDA1 NUMBER(4);
BEGIN
    INSERT INTO PhanCong(manv, MADA, THOIGIAN)
    VALUES(:NEW.manv,:NEW.MADA, :NEW.THOIGIAN);
END;
/
CREATE OR REPLACE TRIGGER deleteTP
INSTEAD OF DELETE ON PhanCong_Select_QL
FOR EACH ROW
BEGIN
  DELETE FROM PhanCong WHERE manv=:old.manv and MADA=:old.MADA;
END;
/
grant select on NhanVien_Select_TP to TRUONGPHONG;
grant select on PhanCong_Select_TP to TRUONGPHONG;
grant update on PhanCong_Select_TP to TRUONGPHONG;
grant delete on PhanCong_Select_TP to TRUONGPHONG;
grant insert on PhanCong_Select_TP to TRUONGPHONG;
grant TRUONGPHONG to TP;
grant GeneralRole to TP;

--cs4--
CREATE OR REPLACE PROCEDURE update_luong(lg NUMBER,idnv NUMBER)
AS
BEGIN
  UPDATE Nhanvien SET luong = lg WHERE manv =idnv;
  COMMIT;
END;
/
CREATE OR REPLACE PROCEDURE update_phucap(pc NUMBER,idnv NUMBER)
AS
BEGIN
  UPDATE Nhanvien SET phucap = pc WHERE manv =idnv;
  COMMIT;
END;
/
grant select on NhanVien to TaiChinh;
grant select on PhanCong to TaiChinh;
GRANT EXECUTE ON update_luong TO TaiChinh;
GRANT EXECUTE ON update_phucap TO TaiChinh;
GRANT TaiChinh TO TC;
grant GeneralRole to TC;

--cs5--
grant update on Phongban to Nhansu;
grant insert on phongban to Nhansu;
CREATE OR REPLACE VIEW NhanVien_Select_NS AS
SELECT distinct NV.MANV,NV.Username,NV.TENNV,NV.PHAI,NV.NGAYSINH,NV.DIACHI,NV.SODT,NV.VAITRO,NV.MANQL,NV.PHG,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),luong) luong,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),phucap) phucap
FROM NHANVIEN NV
union
SELECT distinct NV2.MANV,NV2.Username,NV2.TENNV,NV2.PHAI,NV2.NGAYSINH,NV2.DIACHI,NV2.SODT,NV2.VAITRO,NV2.MANQL,NV2.PHG,decode(NV2.Username,null,NV2.luong) luong,decode(NV2.Username,null,Nv2.phucap) phucap
FROM NHANVIEN NV1,Nhanvien NV2;
grant select on NhanVien_Select_NS to Nhansu;
CREATE OR REPLACE PROCEDURE insert_NV_NS(NV_MANV NUMBER,NV_Username varchar2,NV_TENNV varchar2,NV_PHAI varchar2,NV_NGAYSINH DATE,NV_DIACHI VARCHAR2,NV_SODT VARCHAR2,NV_VAITRO VARCHAR2,NV_MANQL NUMBER,NV_PHG NUMBER)
AS
BEGIN
  insert into Nhanvien values (NV_MANV,NV_Username,NV_TENNV,NV_PHAI,NV_NGAYSINH,NV_DIACHI,NV_SODT,null,null,NV_VAITRO,NV_MANQL,NV_PHG);
  COMMIT;
END;
/
GRANT EXECUTE ON insert_NV_NS TO NhanSu;
CREATE OR REPLACE PROCEDURE update_NV_NS(NV_MANV NUMBER,NV_Username varchar2,NV_TENNV varchar2,NV_PHAI varchar2,NV_NGAYSINH DATE,NV_DIACHI VARCHAR2,NV_SODT VARCHAR2,NV_VAITRO VARCHAR2,NV_MANQL NUMBER,NV_PHG NUMBER)
AS
BEGIN
  update Nhanvien set Username=NV_Username,TENNV=NV_TENNV,PHAI=NV_PHAI,NGAYSINH=NV_NGAYSINH,DIACHI=NV_DIACHI,SODT=NV_SODT,VAITRO=NV_VAITRO,MANQL=NV_MANQL,PHG=NV_PHG where manv=NV_MANV;
  COMMIT;
END;
/

GRANT EXECUTE ON update_NV_NS TO NhanSu;
grant Nhansu to NS;
grant GeneralRole to NS;

--cs6--
grant insert on Dean to Truongdean;
grant update on Dean to Truongdean;
grant delete on Dean to Truongdean;


grant GeneralRole to TDA;
grant Nhanvien to TDA;
grant Truongdean to TDA;