--- USER: ADMIN
----------------------------------------------------------------------------------
--- XOA BANG TON TAI TRUOC KHI TAO BANG MOI

DROP TABLE NHANVIEN CASCADE CONSTRAINTS;
DROP TABLE PHONGBAN CASCADE CONSTRAINTS;
DROP TABLE DEAN CASCADE CONSTRAINTS;
DROP TABLE PHANCONG PURGE;

----------------------------------------------------------------------------------
--- TAO BANG DU LIEU
CREATE TABLE NHANVIEN (
    MANV NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT BY 1),
    TENNV VARCHAR2(100),
    PHAI VARCHAR2(10),
    NGAYSINH DATE,
    DIACHI VARCHAR2(100),
    SODT VARCHAR2(50),
    LUONG NUMBER(7,2),
    PHUCAP NUMBER(7,2),
    VAITRO VARCHAR2(100),
    MANQL NUMBER(4),
    PHG NUMBER(4),
    USERNAME VARCHAR(100),
    
    CONSTRAINT NHANVIEN_PK
    PRIMARY KEY(MANV)
);

CREATE TABLE PHONGBAN (
    MAPB NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT BY 1),
    TENPB VARCHAR2(100),
    TRPHG NUMBER(4),
    
    CONSTRAINT PHONGBAN_PK
    PRIMARY KEY(MAPB)
);

CREATE TABLE DEAN (
    MADA NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT BY 1),
    TENDA VARCHAR2(100),
    NGAYBD DATE,
    PHONG NUMBER,
    
    CONSTRAINT DEAN_PK
    PRIMARY KEY(MADA)
);

CREATE TABLE PHANCONG(
    MANV NUMBER,
    MADA NUMBER,
    THOIGIAN DATE,
    
    CONSTRAINT PHANCONG_PK
    PRIMARY KEY(MANV, MADA) 
);
----------------------------------------------------------------------------------
--- KHAI BAO KHOA NGOAI
ALTER TABLE NHANVIEN
ADD CONSTRAINT FK_NHANVIEN_PHONGBAN
FOREIGN KEY (PHG)
REFERENCES PHONGBAN(MAPB);

ALTER TABLE PHONGBAN
ADD CONSTRAINT FK_PHONGBAN_NHANVIEN
FOREIGN KEY (TRPHG)
REFERENCES NHANVIEN(MANV);

ALTER TABLE DEAN
ADD CONSTRAINT FK_DEAN_PHONGBAN
FOREIGN KEY(PHONG)
REFERENCES PHONGBAN(MAPB);

ALTER TABLE PHANCONG
ADD CONSTRAINT FK_PHANCONG_NHANVIEN
FOREIGN KEY(MANV)
REFERENCES NHANVIEN(MANV);

ALTER TABLE PHANCONG
ADD CONSTRAINT FK_PHANCONG_DEAN
FOREIGN KEY(MADA)
REFERENCES DEAN(MADA);

----------------------------------------------------------------------------------
--- NHAP THONG TIN VAO BANG
--- A. PHONG BAN
INSERT INTO PHONGBAN (TENPB, TRPHG)
VALUES (N'IT',7);
INSERT INTO PHONGBAN (TENPB, TRPHG)
VALUES (N'MARKETING',8);
INSERT INTO PHONGBAN (TENPB, TRPHG)
VALUES (N'TAI CHINH',9);
INSERT INTO PHONGBAN (TENPB, TRPHG)
VALUES (N'NHAN SU',10);

--- B. NHAN VIEN
--- 1. BAN GIAM DOC
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'THOMAS', N'NAM', TO_DATE('09-06-1981','dd-mm-yyyy'), N'21 BROWN STREET', N'0597789781',5000,1500,N'Ban giam doc',NULL,NULL, 'BGD1');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'HENRY', N'NAM', TO_DATE('12-10-2000','dd-mm-yyyy'), N'23 THOMAS STREET', N'057389781',5000,1500,N'Ban giam doc',NULL,NULL, 'BGD2');
--- 2. QL TRUC TIEP
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'LUKAS', N'NAM', TO_DATE('09-06-1981','dd-mm-yyyy'), N'15 FORT WATT', N'0559416800',3000,1200,N'QL Truc tiep',NULL,1, 'QLTT1'); --- MANV: 3
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'CARTER', N'NU', TO_DATE('09-06-1981','dd-mm-yyyy'), N'15 JOHHNY SINS', N'0559416800',3000,1200,N'QL Truc tiep',NULL,2, 'QLTT2'); --- MANV: 4
--- 3. TRUONG PHONG
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'ANNA', N'NU', TO_DATE('01-10-1990','dd-mm-yyyy'), N'45 GROVE STREET', N'0522326035',2000,1000,N'Truong phong',NULL,1, 'TP1'); --- TRUONG PHONG IT 7
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'STACY', N'NU', TO_DATE('11-01-2002','dd-mm-yyyy'), N'45 SAINT JOSEPH', N'0897441783',2100,1000,N'Truong phong',NULL,2, 'TP2'); --- TRUONG PHONG MARKERTING 8
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'JACKMAN', N'NAM', TO_DATE('02-12-2000','dd-mm-yyyy'), N'45 LIBERTY', N'0327198398',2100,1000,N'Truong phong',NULL,3, 'TP3'); --- TRUONG PHONG TAI CHINH 9
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'DAISY', N'NU', TO_DATE('02-12-2001','dd-mm-yyyy'), N'54 SAN JOSE', N'03274458398',2100,1000,N'Truong phong',NULL,4, 'TP4'); --- TRUONG PHONG NHAN SU 10
--- 4. TAI CHINH
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'JAMES', N'NAM', TO_DATE('01-11-1993','dd-mm-yyyy'), N'15 THOMAS SELLER', N'0994848587',2000,1700,N'Tai chinh',9,3, 'TC1');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'MARY', N'NU', TO_DATE('20-04-2000','dd-mm-yyyy'), N'15 ROOSEVELT', N'0559723731',2000,1700,N'Tai chinh',9,3, 'TC2');
--- 5. NHAN SU
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'SAMUEL', N'NAM', TO_DATE('20-11-1993','dd-mm-yyyy'), N'212 NORTH EDINBURG', N'0559883732',2000,1700,N'Nhan su',10,4, 'NS1');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'CARL', N'NAM', TO_DATE('30-10-1996','dd-mm-yyyy'), N'212 LOS GATOS', N'0559883732',2000,1700,N'Nhan su',10,4, 'NS2');
--- 6. TRUONG DE AN
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'KENNEDY', N'NAM', TO_DATE('01-02-1992','dd-mm-yyyy'), N'126 LUSIANA', N'0391066319',2100,1000,N'Truong de an',NULL,1, 'TDA1');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'FRED', N'NAM', TO_DATE('01-07-1998','dd-mm-yyyy'), N'126 JOHN WICK', N'0337864923',2100,1000,N'Truong de an',NULL,2, 'TDA2');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'PHINEAS', N'NAM', TO_DATE('15-02-1993','dd-mm-yyyy'), N'25 GARDEN GROVE', N'0522686982',2100,1000,N'Truong de an',NULL,3, 'TDA3');
--- 7. NHAN VIEN
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'MICHAEL', N'NAM', TO_DATE('13-03-2002','dd-mm-yyyy'), N'27 SOUTH YORK', N'0322967082',1000,500,N'Nhan vien',3,1, 'NV1');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'SUSAN', N'NU', TO_DATE('23-05-1998','dd-mm-yyyy'), N'16 SANCHEZ', N'0304213331',1000,1000,N'Nhan vien',4,2, 'NV2');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'KATE', N'NU', TO_DATE('13-10-1990','dd-mm-yyyy'), N'23 THOMAS MILLER', N'0840667154',2000,1000,N'Nhan vien',3,3, 'NV3');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'NATASHA', N'NU', TO_DATE('13-10-2000','dd-mm-yyyy'), N'23 JOHN HOPKINS', N'0840667345',2000,1000,N'Nhan vien',4,4, 'NV3');

--- C. DE AN
INSERT INTO DEAN (TENDA, NGAYBD, PHONG)
VALUES (N'XAY DUNG CO SO DU LIEU TRONG DOANH NGHIEP',TO_DATE('12-05-2021','dd-mm-yyyy'), 1);
INSERT INTO DEAN (TENDA, NGAYBD, PHONG)
VALUES (N'CACH THUC DUA HANG HOA DEN TAY NGUOI TIEU DUNG',TO_DATE('30-06-2020','dd-mm-yyyy'), 2);
INSERT INTO DEAN (TENDA, NGAYBD, PHONG)
VALUES (N'LUONG THUONG CHO NHAN VIEN',TO_DATE('30-06-2021','dd-mm-yyyy'), 3);

--- D. PHAN CONG 
INSERT INTO PHANCONG (MANV, MADA, THOIGIAN)
VALUES (16,2, TO_DATE('30-06-2020','dd-mm-yyyy'));
INSERT INTO PHANCONG (MANV, MADA, THOIGIAN)
VALUES (15,1, TO_DATE('12-05-2021','dd-mm-yyyy'));

SELECT * FROM NHANVIEN



alter session set "_oracle_script"=true;
drop role Nhanvien;
drop role QLTrucTiep;
drop role TruongPhong;
drop role TaiChinh;
drop role NhanSu;
drop role TruongDeAn;
drop role BanGiamDoc;
drop role GeneralRole; ---

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

---DROP TRIGGER updateTP;
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
grant GeneralRole to TP; ---

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