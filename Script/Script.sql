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
    SODT VARCHAR2(255),
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

CREATE OR REPLACE TRIGGER ENCRYPT_NHANVIEN_SODT
BEFORE INSERT ON NHANVIEN
FOR EACH ROW
WHEN (new.MANV > 0)
DECLARE
    input_string VARCHAR2(200);
    encrypted_raw RAW (2000); -- stores encrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMHTTT1', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    input_string := TO_CHAR(:new.SODT);
    DBMS_OUTPUT.PUT_LINE(input_string);
    encrypted_raw := DBMS_CRYPTO.ENCRYPT
          (
             src => UTL_I18N.STRING_TO_RAW (input_string,'AL32UTF8'),
             typ => encryption_type,
            key => v_key
         );
    --DBMS_OUTPUT.PUT_LINE(v_key);
    input_string := RAWTOHEX(encrypted_raw);
    :new.SODT :=input_string;
END;
/
create or replace function ENCRYPT_SODT(p_data in varchar2)
    return varchar2  
as
    input_string VARCHAR2(200);
    encrypted_raw RAW (2000); -- stores encrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMHTTT1', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    input_string := TO_CHAR(p_data);
    DBMS_OUTPUT.PUT_LINE(input_string);
    encrypted_raw := DBMS_CRYPTO.ENCRYPT
          (
             src => UTL_I18N.STRING_TO_RAW (input_string,'AL32UTF8'),
             typ => encryption_type,
            key => v_key
         );
    --DBMS_OUTPUT.PUT_LINE(v_key);
    input_string := RAWTOHEX(encrypted_raw);
    return input_string;
END;
/
----------------------------------------------------------------------------------
--- NHAP THONG TIN VAO BANG
--- A. NHAN VIEN
--- 1. BAN GIAM DOC
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'THOMAS', N'NAM', TO_DATE('09-06-1981','dd-mm-yyyy'), N'21 BROWN STREET', '0123456789',5000,1500,N'Ban giam doc',NULL,NULL, 'BGD1');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'HENRY', N'NAM', TO_DATE('12-10-2000','dd-mm-yyyy'), N'23 THOMAS STREET', '0234567891',5000,1500,N'Ban giam doc',NULL,NULL, 'BGD2');
--- 2. QL TRUC TIEP
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'LUKAS', N'NAM', TO_DATE('09-06-1981','dd-mm-yyyy'), N'15 FORT WATT', '0123456789',3000,1200,N'QL Truc tiep',NULL,NULL, 'QLTT1'); --- MANV: 3 PHG: 1 MANV: 3
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'CARTER', N'NU', TO_DATE('09-06-1981','dd-mm-yyyy'), N'15 JOHHNY SINS', '0559416800',3000,1200,N'QL Truc tiep',NULL,NULL, 'QLTT2'); --- MANV: 4 PHG: 2 MANV: 4
--- 3. TRUONG PHONG
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'ANNA', N'NU', TO_DATE('01-10-1990','dd-mm-yyyy'), N'45 GROVE STREET', '0522326035',2000,1000,N'Truong phong',NULL,NULL, 'TP1'); --- TRUONG PHONG IT 7 PHG: 1 MANV: 5
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'STACY', N'NU', TO_DATE('11-01-2002','dd-mm-yyyy'), N'45 SAINT JOSEPH', '0897441783',2100,1000,N'Truong phong',NULL,NULL, 'TP2'); --- TRUONG PHONG MARKERTING 8 PHG: 2 MANV: 6
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'JACKMAN', N'NAM', TO_DATE('02-12-2000','dd-mm-yyyy'), N'45 LIBERTY', '0327198398',2100,1000,N'Truong phong',NULL,NULL, 'TP3'); --- TRUONG PHONG TAI CHINH 9 PHG: 3 MANV: 7
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'DAISY', N'NU', TO_DATE('02-12-2001','dd-mm-yyyy'), N'54 SAN JOSE', '03274458398',2100,1000,N'Truong phong',NULL,NULL, 'TP4'); --- TRUONG PHONG NHAN SU 10 PHG: 4 MANV: 8
--- 4. TAI CHINH
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'JAMES', N'NAM', TO_DATE('01-11-1993','dd-mm-yyyy'), N'15 THOMAS SELLER', '0994848587',2000,1700,N'Tai chinh',NULL, NULL, 'TC1'); --- MANQL: 9 PHG: 3 MANV: 9
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'MARY', N'NU', TO_DATE('20-04-2000','dd-mm-yyyy'), N'15 ROOSEVELT', '0559723731',2000,1700,N'Tai chinh',NULL, NULL, 'TC2'); --- MANQL: 9 PHG: 3 MANV: 10
--- 5. NHAN SU
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'SAMUEL', N'NAM', TO_DATE('20-11-1993','dd-mm-yyyy'), N'212 NORTH EDINBURG', '0559883732',2000,1700,N'Nhan su',NULL, NULL, 'NS1'); --- MANQL: 10 PHG: 4 MANV: 11
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'CARL', N'NAM', TO_DATE('30-10-1996','dd-mm-yyyy'), N'212 LOS GATOS', '0559883732',2000,1700,N'Nhan su',NULL, NULL, 'NS2'); --- MANQL: 10 PHG: 4 MANV: 12
--- 6. TRUONG DE AN
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'KENNEDY', N'NAM', TO_DATE('01-02-1992','dd-mm-yyyy'), N'126 LUSIANA', '0391066319',2100,1000,N'Truong de an',NULL,NULL, 'TDA1'); --- PHG: 1 MANV: 13
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'FRED', N'NAM', TO_DATE('01-07-1998','dd-mm-yyyy'), N'126 JOHN WICK', '0337864923',2100,1000,N'Truong de an',NULL,NULL, 'TDA2'); --- PHG: 2 MANV: 14
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'PHINEAS', N'NAM', TO_DATE('15-02-1993','dd-mm-yyyy'), N'25 GARDEN GROVE', '0522686982',2100,1000,N'Truong de an',NULL,NULL, 'TDA3'); --- PHG: 3 MANV: 15
--- 7. NHAN VIEN
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'MICHAEL', N'NAM', TO_DATE('13-03-2002','dd-mm-yyyy'), N'27 SOUTH YORK', '0322967082',1000,500,N'Nhan vien',3,NULL, 'NV1');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'SUSAN', N'NU', TO_DATE('23-05-1998','dd-mm-yyyy'), N'16 SANCHEZ', '0304213331',1000,1000,N'Nhan vien',NULL,NULL, 'NV2');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'KATE', N'NU', TO_DATE('13-10-1990','dd-mm-yyyy'), N'23 THOMAS MILLER', '0840667154',2000,1000,N'Nhan vien',NULL,NULL, 'NV3');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'NATASHA', N'NU', TO_DATE('13-10-2000','dd-mm-yyyy'), N'23 JOHN HOPKINS', '0840667345',2000,1000,N'Nhan vien',NULL,NULL, 'NV4');

--- B. PHONG BAN
INSERT INTO PHONGBAN (TENPB, TRPHG)
VALUES (N'IT', NULL);
INSERT INTO PHONGBAN (TENPB, TRPHG)
VALUES (N'MARKETING',NULL);
INSERT INTO PHONGBAN (TENPB, TRPHG)
VALUES (N'TAI CHINH', NULL);
INSERT INTO PHONGBAN (TENPB, TRPHG)
VALUES (N'NHAN SU', NULL);


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
INSERT INTO PHANCONG (MANV, MADA, THOIGIAN)
VALUES (11,1, TO_DATE('12-05-2021','dd-mm-yyyy'));
INSERT INTO PHANCONG (MANV, MADA, THOIGIAN)
VALUES (13,1, TO_DATE('12-05-2021','dd-mm-yyyy'));

--- CAP NHAT PHONG VA NGUOI QUAN LY CHO BANG NHANVIEN
UPDATE NHANVIEN SET PHG=1 WHERE MANV=3;
UPDATE NHANVIEN SET PHG=2 WHERE MANV=4;

UPDATE NHANVIEN SET PHG=1 WHERE MANV=5;
UPDATE NHANVIEN SET PHG=2 WHERE MANV=6;
UPDATE NHANVIEN SET PHG=1 WHERE MANV=7;
UPDATE NHANVIEN SET PHG=1 WHERE MANV=8;

UPDATE NHANVIEN SET MANQL=7, PHG=1 WHERE MANV=9;
UPDATE NHANVIEN SET MANQL=7, PHG=2 WHERE MANV=10;

UPDATE NHANVIEN SET MANQL=8, PHG=1 WHERE MANV=11;
UPDATE NHANVIEN SET MANQL=8, PHG=2 WHERE MANV=12;

UPDATE NHANVIEN SET PHG=1 WHERE MANV=13;
UPDATE NHANVIEN SET PHG=2 WHERE MANV=14;
UPDATE NHANVIEN SET PHG=1 WHERE MANV=15;

UPDATE NHANVIEN SET MANQL=3, PHG=1 WHERE MANV=16;
UPDATE NHANVIEN SET MANQL=3, PHG=2 WHERE MANV=17;
UPDATE NHANVIEN SET MANQL=3, PHG=3 WHERE MANV=18;
UPDATE NHANVIEN SET MANQL=3, PHG=4 WHERE MANV=19;

--- CAP NHAT BANG PHONG BAN
UPDATE PHONGBAN SET TRPHG=7 WHERE MAPB=1;
UPDATE PHONGBAN SET TRPHG=8 WHERE MAPB=2;
UPDATE PHONGBAN SET TRPHG=9 WHERE MAPB=3;
UPDATE PHONGBAN SET TRPHG=10 WHERE MAPB=4;
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
    user := SYS_CONTEXT('userenv', 'SESSION_USER');
    if user = 'ADMIN'  then
        return '1=1';
    elsif user like 'TC%' then
        return '1=1';
     elsif user like 'NV%' then
        return  'USERNAME = SYS_CONTEXT(''userenv'', ''SESSION_USER'')';
    elsif user like 'TDA%' then
        return  'USERNAME = SYS_CONTEXT(''userenv'', ''SESSION_USER'')';
    else return '';
    end if;
END;
/



begin
    DBMS_RLS.add_policy(object_schema => 'ADMIN',object_name => 'Nhanvien',policy_name => 'VPD_Nhanvien',policy_function => 'NhanVien_Select_NV');
end;
/
CREATE OR REPLACE VIEW PhanCong_Select_NV AS
SELECT NV.MANV,PC.MADA,PC.THOIGIAN
FROM NHANVIEN NV,PHANCONG PC
WHERE NV.USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER') and NV.VAITRO=N'Nhan vien' AND PC.MANV=NV.MANV
with check option;

CREATE OR REPLACE PROCEDURE update_NV_NV(NV_NGAYSINH DATE,NV_DIACHI VARCHAR2,NV_SODT VARCHAR2)
AS
BEGIN  
  update Nhanvien set ngaysinh=nv_ngaysinh, diachi=nv_diachi, sodt=ENCRYPT_SODT(nv_sodt) where username= SYS_CONTEXT ('USERENV', 'SESSION_USER');
  COMMIT;
END;
/
GRANT EXECUTE ON update_NV_NV TO NhanVien;

GRANT EXECUTE ON decrypt_SODT TO GeneralRole;
GRANT EXECUTE ON ENCRYPT_SODT TO GeneralRole;


grant select on Phongban to GeneralRole;
grant select on Dean to GeneralRole;

grant select on NhanVien to Nhanvien;
grant update(ngaysinh,diachi,sodt) on NhanVien  to Nhanvien;
grant select on PhanCong_Select_NV to Nhanvien;
grant Nhanvien to NV1;
grant GeneralRole to NV1;



--cs2--
CREATE OR REPLACE VIEW NhanVien_Select_QL AS
SELECT distinct NV.MANV,NV.Username,NV.TENNV,NV.PHAI,NV.NGAYSINH,NV.DIACHI,NV.SODT,NV.VAITRO,NV.MANQL,NV.PHG,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),luong) luong,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),phucap) phucap
FROM nhanvien NV
where NV.UserName=SYS_CONTEXT ('USERENV', 'SESSION_USER')
union
SELECT distinct NV2.MANV,NV2.Username,NV2.TENNV,NV2.PHAI,NV2.NGAYSINH,NV2.DIACHI,NV2.SODT,NV2.VAITRO,NV2.MANQL,NV2.PHG,decode(NV2.Username,null,NV2.luong) luong,decode(NV2.Username,null,Nv2.phucap) phucap
FROM nhanvien NV1,nhanvien NV2
where NV1.UserName=SYS_CONTEXT ('USERENV', 'SESSION_USER') and nv2.manql=nv1.manv and nv1.manv!=nv2.manv and nv2.vaitro=N'Nhan vien'
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
    Update NhanVien set Ngaysinh=:new.ngaysinh, diachi=:new.diachi, sodt=ENCRYPT_SODT(:new.sodt) where USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER');
END;
/
grant select on NhanVien_Select_QL to QLTrucTiep;--
grant select on PHANCONG_Select_QL to QLTrucTiep;
grant update(ngaysinh,diachi,sodt) on NhanVien_Select_QL to QLTrucTiep;
grant QLTrucTiep to QLTT1;
grant GeneralRole to QLTT1; 



--cs3--
CREATE OR REPLACE VIEW NhanVien_Select_TP AS
SELECT distinct NV.MANV,NV.Username,NV.TENNV,NV.PHAI,NV.NGAYSINH,NV.DIACHI,NV.SODT,NV.VAITRO,NV.MANQL,NV.PHG,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),luong) luong,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),phucap) phucap
FROM NHANVIEN NV
WHERE NV.UserName=SYS_CONTEXT ('USERENV', 'SESSION_USER')
union
SELECT distinct NV2.MANV,NV2.Username,NV2.TENNV,NV2.PHAI,NV2.NGAYSINH,NV2.DIACHI,NV2.SODT,NV2.VAITRO,NV2.MANQL,NV2.PHG,decode(NV2.Username,null,NV2.luong) luong,decode(NV2.Username,null,Nv2.phucap) phucap
FROM NHANVIEN NV1,Nhanvien NV2,PHONGBAN PB
where NV1.UserName=SYS_CONTEXT ('USERENV', 'SESSION_USER') and nv1.manv!=nv2.manv and nv1.vaitro=N'Truong phong' and PB.TRPHG=NV1.MANV AND NV2.PHG=PB.MAPB
with check option;

CREATE OR REPLACE TRIGGER update_TP
    INSTEAD OF UPDATE ON NhanVien_Select_TP
    FOR EACH ROW
BEGIN
    -- insert a new customer first
    Update NhanVien set Ngaysinh=:new.ngaysinh, diachi=:new.diachi, sodt=ENCRYPT_SODT(:new.sodt) where USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER');
END;
/
CREATE OR REPLACE VIEW PhanCong_Select_TP AS
SELECT PC.MANV,PC.MADA,PC.THOIGIAN
FROM NHANVIEN NV1,Nhanvien NV2,PHONGBAN PB,PHANCONG PC
where NV1.UserName=SYS_CONTEXT ('USERENV', 'SESSION_USER') and nv1.vaitro=N'Truong phong' and PB.TRPHG=NV1.MANV AND NV2.PHG=PB.MAPB AND PC.MANV=NV2.MANV;
/
CREATE OR REPLACE TRIGGER updateTP
    INSTEAD OF UPDATE ON PhanCong_Select_TP
    FOR EACH ROW
DECLARE
    l_customer_id NUMBER;
BEGIN
    select manv into l_customer_id from NhanVien_Select_TP where manv=:new.manv;
    IF (l_customer_id=:new.manv)then
    Update PhanCong set manv=:new.manv, MADA=:new.MADA, THOIGIAN=:new.THOIGIAN where manv=:old.manv and mada=:old.mada;
    end if;
END;
/
CREATE OR REPLACE TRIGGER insertTP
    INSTEAD OF INSERT ON PhanCong_Select_TP
    FOR EACH ROW
DECLARE
    l_customer_id NUMBER;
BEGIN
    select manv into l_customer_id from NhanVien_Select_TP where manv=:new.manv;
    IF (l_customer_id=:new.manv)then
    INSERT INTO PhanCong(manv, MADA, THOIGIAN)
    VALUES(:NEW.manv,:NEW.MADA, :NEW.THOIGIAN);
    end if;
END;
/
CREATE OR REPLACE TRIGGER deleteTP
INSTEAD OF DELETE ON PhanCong_Select_TP
FOR EACH ROW
DECLARE
    l_customer_id NUMBER;
BEGIN
    select manv into l_customer_id from NhanVien_Select_TP where manv=:old.manv;
    IF (l_customer_id=:old.manv)then
  DELETE FROM PhanCong WHERE manv=:old.manv and MADA=:old.MADA;
  end if;
END;
/
grant select on NhanVien_Select_TP to TRUONGPHONG;
grant update(ngaysinh,diachi,sodt) on NhanVien_Select_TP to TRUONGPHONG;
grant select on PhanCong_Select_TP to TRUONGPHONG;
grant update on PhanCong_Select_TP to TRUONGPHONG;
grant delete on PhanCong_Select_TP to TRUONGPHONG;
grant insert on PhanCong_Select_TP to TRUONGPHONG;
grant TRUONGPHONG to TP3;
grant GeneralRole to TP3;

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
GRANT EXECUTE ON update_NV_NV TO TaiChinh;
GRANT TaiChinh TO TC1;
grant GeneralRole to TC1;


--cs5--
grant update on Phongban to Nhansu;
grant insert on phongban to Nhansu;
CREATE OR REPLACE VIEW NhanVien_Select_NS AS
SELECT distinct NV.MANV,NV.Username,NV.TENNV,NV.PHAI,NV.NGAYSINH,NV.DIACHI,NV.SODT,NV.VAITRO,NV.MANQL,NV.PHG,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),luong) luong,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),phucap) phucap
FROM NHANVIEN NV
union
SELECT distinct NV2.MANV,NV2.Username,NV2.TENNV,NV2.PHAI,NV2.NGAYSINH,NV2.DIACHI,NV2.SODT,NV2.VAITRO,NV2.MANQL,NV2.PHG,decode(NV2.Username,null,NV2.luong) luong,decode(NV2.Username,null,Nv2.phucap) phucap
FROM NHANVIEN NV1,Nhanvien NV2;

CREATE OR REPLACE PROCEDURE insert_NV_NS(NV_Username varchar2,NV_TENNV varchar2,NV_PHAI varchar2,NV_NGAYSINH DATE,NV_DIACHI VARCHAR2,NV_SODT VARCHAR2,NV_VAITRO VARCHAR2,NV_MANQL NUMBER,NV_PHG NUMBER)
AS
BEGIN
  insert into Nhanvien(Username,TENNV,PHAI,NGAYSINH,DIACHI,sodt,LUONG,PHUCAP ,VAITRO,MANQL,PHG) values (NV_Username,NV_TENNV,NV_PHAI,NV_NGAYSINH,NV_DIACHI,ENCRYPT_SODT(NV_SODT),null,null,NV_VAITRO,NV_MANQL,NV_PHG);
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE update_NV_NS(NV_MANV NUMBER,NV_Username varchar2,NV_TENNV varchar2,NV_PHAI varchar2,NV_NGAYSINH DATE,NV_DIACHI VARCHAR2,NV_SODT VARCHAR2,NV_VAITRO VARCHAR2,NV_MANQL NUMBER,NV_PHG NUMBER)
AS
BEGIN
  update Nhanvien set Username=NV_Username,TENNV=NV_TENNV,PHAI=NV_PHAI,NGAYSINH=NV_NGAYSINH,DIACHI=NV_DIACHI,SODT=ENCRYPT_SODT(NV_SODT),VAITRO=NV_VAITRO,MANQL=NV_MANQL,PHG=NV_PHG where manv=NV_MANV;
  COMMIT;
END;
/

CREATE OR REPLACE VIEW PhanCong_Select_NS AS
SELECT NV.MANV,PC.MADA,PC.THOIGIAN
FROM NHANVIEN NV,PHANCONG PC
WHERE NV.USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER') and NV.VAITRO=N'Nhan su' AND PC.MANV=NV.MANV
with check option;
/
grant select on NhanVien_Select_NS to Nhansu;
GRANT EXECUTE ON insert_NV_NS TO NhanSu;
GRANT select ON PhanCong_Select_NS to nhansu;
GRANT EXECUTE ON update_NV_NS TO NhanSu;

grant Nhansu to NS1;
grant GeneralRole to NS1;


--cs6--
grant insert on Dean to Truongdean;
grant update on Dean to Truongdean;
grant delete on Dean to Truongdean;

CREATE OR REPLACE VIEW PhanCong_Select_TDA AS
SELECT NV.MANV,PC.MADA,PC.THOIGIAN
FROM NHANVIEN NV,PHANCONG PC
WHERE NV.USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER') and NV.VAITRO=N'Truong de an' AND PC.MANV=NV.MANV
with check option;
/
GRANT EXECUTE ON update_NV_NV TO Truongdean;
grant GeneralRole to TDA1;
grant select on nhanvien to Truongdean;
grant select on PhanCong_Select_TDA to Truongdean;
grant Truongdean to TDA1;



BEGIN
DBMS_FGA.DROP_POLICY(
  object_schema      => 'admin',
  object_name        => 'phancong',
  policy_name        => 'CHECK_thoigian_ON_phancong');
END;
/
-- tao policy
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'admin',
   object_name        => 'phancong',
   policy_name        => 'CHECK_thoigian_ON_phancong',
   enable             =>  TRUE,
   statement_types    => 'UPDATE',
   audit_column       => 'thoigian',
   audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
END;
/

CREATE OR REPLACE FUNCTION system.CheckFGA(pTxtUser IN VARCHAR2)
    RETURN PLS_INTEGER IS
    BEGIN
        IF(UPPER(pTxtUser) = 'SYS_CONTEXT(''USERENV'', ''SESSION_USER'')') THEN
            RETURN 0;
        ELSE
            RETURN 1;
        END IF;
    END;
/
BEGIN
DBMS_FGA.DROP_POLICY(
  object_schema      => 'admin',
  object_name        => 'nhanvien',
  policy_name        => 'luong_phucap_audit');
END;
/
BEGIN
        DBMS_FGA.ADD_POLICY(OBJECT_SCHEMA   => 'admin'
                            , OBJECT_NAME     => 'nhanvien'
                            , POLICY_NAME     => 'luong_phucap_audit'
                            , enable             =>  TRUE
                            , AUDIT_CONDITION => 'SYSTEM.CheckFGA(SYS_CONTEXT(''USERENV'', ''SESSION_USER'')) = 1'
                            , STATEMENT_TYPES => 'select'
                            ,audit_column       => 'luong,phucap'
                            ,audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
    END;
    /
    
CREATE OR REPLACE FUNCTION system.CheckFGA2(pTxtUser IN VARCHAR2)
    RETURN PLS_INTEGER IS
    BEGIN
        IF(UPPER(pTxtUser)like 'TC%' ) THEN
            RETURN 0;
        ELSE
            RETURN 1;
        END IF;
    END;
/
BEGIN
DBMS_FGA.DROP_POLICY(
  object_schema      => 'admin',
  object_name        => 'nhanvien',
  policy_name        => 'luong_phucap_audit2');
END;
/
BEGIN
        DBMS_FGA.ADD_POLICY(OBJECT_SCHEMA   => 'admin'
                            , OBJECT_NAME     => 'nhanvien'
                            , POLICY_NAME     => 'luong_phucap_audit2'
                            , enable             =>  TRUE
                            , AUDIT_CONDITION => 'SYSTEM.CheckFGA2(SYS_CONTEXT(''USERENV'', ''SESSION_USER'')) = 1'
                            , STATEMENT_TYPES => 'update'
                            ,audit_column       => 'luong,phucap'
                            ,audit_trail        =>  DBMS_FGA.DB + DBMS_FGA.EXTENDED);
    END;
    /

alter system set audit_trail = DB,EXTENDED scope = spfile;
shutdown immediate;
startup;
-- Theo doi hanh vi cua cac user tren tat ca cac table
AUDIT ALL ON admin.phancong BY ACCESS;
select*from admin.nhanvien;
SELECT DBUID, LSQLTEXT, NTIMESTAMP# FROM SYS.FGA_LOG$;