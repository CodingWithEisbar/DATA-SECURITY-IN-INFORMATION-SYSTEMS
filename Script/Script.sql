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
    LUONG NUMBER(7,2), --CHUYEN THANH VARCHAR2(255) KHI CAI DAT ENCRYPTION
    PHUCAP NUMBER(7,2), --CHUYEN THANH VARCHAR2(255) KHI CAI DAT ENCRYPTION
    VAITRO VARCHAR2(100),
    MANQL NUMBER,
    PHG NUMBER,
    USERNAME VARCHAR(100),
    
    CONSTRAINT NHANVIEN_PK
    PRIMARY KEY(MANV)
);

CREATE TABLE PHONGBAN (
    MAPB NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT BY 1),
    TENPB VARCHAR2(100),
    TRPHG NUMBER,
    
    CONSTRAINT PHONGBAN_PK
    PRIMARY KEY(MAPB)
);

CREATE TABLE DEAN (
    MADA NUMBER GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT BY 1),
    TENDA VARCHAR2(100),
    NGAYBD DATE,
    PHONG NUMBER,
    MATRGDA NUMBER,
    
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

ALTER TABLE DEAN
ADD CONSTRAINT FK_DEAN_NHANVIEN
FOREIGN KEY (MATRGDA)
REFERENCES NHANVIEN(MANV);

ALTER TABLE PHANCONG
ADD CONSTRAINT FK_PHANCONG_NHANVIEN
FOREIGN KEY(MANV)
REFERENCES NHANVIEN(MANV);

ALTER TABLE PHANCONG
ADD CONSTRAINT FK_PHANCONG_DEAN
FOREIGN KEY(MADA)
REFERENCES DEAN(MADA);
----------------------------------------------------------------------------------
--LUU Y : PHAI DOI CAU TRUC O BANG NHANVIEN O COT LUONG VA PHUCAP TRUOC KHI CHAY PHAN NAY
--TAO CAC TRIGGER MA HOA DU LIEU
/*CREATE OR REPLACE TRIGGER ENCRYPT_NHANVIEN_LUONG
BEFORE INSERT OR UPDATE ON NHANVIEN
FOR EACH ROW
WHEN(new.MANV > 0 AND new.LUONG IS NOT NULL AND NOT REGEXP_LIKE(new.LUONG, '^[a-zA-Z]'))
DECLARE
    INPUT_STRING VARCHAR2(200);
    ENCRYPTED_RAW RAW(200);
    V_KEY RAW(128) := utl_i18n.string_to_raw('ATBMHTTT01','AL32UTF8');
    ENCRYPTION_TYPE PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    INPUT_STRING := TO_CHAR(:new.LUONG);
    ENCRYPTED_RAW := DBMS_CRYPTO.ENCRYPT
        (
            src => UTL_I18N.STRING_TO_RAW (input_string,'AL32UTF8'),
            typ => ENCRYPTION_TYPE,
            key => V_KEY
        );
    INPUT_STRING := RAWTOHEX(ENCRYPTED_RAW);
    :new.LUONG := INPUT_STRING;
END;

CREATE OR REPLACE TRIGGER ENCRYPT_NHANVIEN_PHUCAP
BEFORE INSERT OR UPDATE ON NHANVIEN
FOR EACH ROW
WHEN(new.MANV > 0 AND new.PHUCAP IS NOT NULL AND NOT REGEXP_LIKE(new.PHUCAP, '^[a-zA-Z]'))
DECLARE
    INPUT_STRING VARCHAR2(200);
    ENCRYPTED_RAW RAW(200);
    V_KEY RAW(128) := utl_i18n.string_to_raw('ATBMHTTT01','AL32UTF8');
    ENCRYPTION_TYPE PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
BEGIN
    INPUT_STRING := TO_CHAR(:new.PHUCAP);
    ENCRYPTED_RAW := DBMS_CRYPTO.ENCRYPT
        (
            src => UTL_I18N.STRING_TO_RAW (input_string,'AL32UTF8'),
            typ => ENCRYPTION_TYPE,
            key => V_KEY
        );
    INPUT_STRING := RAWTOHEX(ENCRYPTED_RAW);
    :new.PHUCAP := INPUT_STRING;
END;*/
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
--- B. PHONG BAN
INSERT INTO PHONGBAN (TENPB, TRPHG)
VALUES (N'IT', NULL);
INSERT INTO PHONGBAN (TENPB, TRPHG)
VALUES (N'MARKETING',NULL);
INSERT INTO PHONGBAN (TENPB, TRPHG)
VALUES (N'TAI CHINH', NULL);
INSERT INTO PHONGBAN (TENPB, TRPHG)
VALUES (N'NHAN SU', NULL);
--- A. NHAN VIEN
--- 1. BAN GIAM DOC
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'THOMAS', N'NAM', TO_DATE('09-06-1981','dd-mm-yyyy'), N'21 BROWN STREET', N'0597789781',5000,1500,N'Ban giam doc',NULL,NULL, 'BGD1');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'HENRY', N'NAM', TO_DATE('12-10-2000','dd-mm-yyyy'), N'23 THOMAS STREET', N'057389781',5000,1500,N'Ban giam doc',NULL,NULL, 'BGD2');
--- 2. QL TRUC TIEP
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'LUKAS', N'NAM', TO_DATE('09-06-1981','dd-mm-yyyy'), N'15 FORT WATT', N'0559416800',3000,1200,N'QL Truc tiep',NULL,NULL, 'QLTT1'); --- MANV: 3 PHG: 1 MANV: 3
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'CARTER', N'NU', TO_DATE('09-06-1981','dd-mm-yyyy'), N'15 JOHHNY SINS', N'0559416800',3000,1200,N'QL Truc tiep',NULL,NULL, 'QLTT2'); --- MANV: 4 PHG: 2 MANV: 4
--- 3. TRUONG PHONG
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'ANNA', N'NU', TO_DATE('01-10-1990','dd-mm-yyyy'), N'45 GROVE STREET', N'0522326035',2000,1000,N'Truong phong',NULL,NULL, 'TP1'); --- TRUONG PHONG IT 7 PHG: 1 MANV: 5
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'STACY', N'NU', TO_DATE('11-01-2002','dd-mm-yyyy'), N'45 SAINT JOSEPH', N'0897441783',2100,1000,N'Truong phong',NULL,NULL, 'TP2'); --- TRUONG PHONG MARKERTING 8 PHG: 2 MANV: 6
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'JACKMAN', N'NAM', TO_DATE('02-12-2000','dd-mm-yyyy'), N'45 LIBERTY', N'0327198398',2100,1000,N'Truong phong',NULL,NULL, 'TP3'); --- TRUONG PHONG TAI CHINH 9 PHG: 3 MANV: 7
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'DAISY', N'NU', TO_DATE('02-12-2001','dd-mm-yyyy'), N'54 SAN JOSE', N'03274458398',2100,1000,N'Truong phong',NULL,NULL, 'TP4'); --- TRUONG PHONG NHAN SU 10 PHG: 4 MANV: 8
--- 4. TAI CHINH
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'JAMES', N'NAM', TO_DATE('01-11-1993','dd-mm-yyyy'), N'15 THOMAS SELLER', N'0994848587',2000,1700,N'Tai chinh',NULL, NULL, 'TC1'); --- MANQL: 9 PHG: 3 MANV: 9
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'MARY', N'NU', TO_DATE('20-04-2000','dd-mm-yyyy'), N'15 ROOSEVELT', N'0559723731',2000,1700,N'Tai chinh',NULL, NULL, 'TC2'); --- MANQL: 9 PHG: 3 MANV: 10
--- 5. NHAN SU
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'SAMUEL', N'NAM', TO_DATE('20-11-1993','dd-mm-yyyy'), N'212 NORTH EDINBURG', N'0559883732',2000,1700,N'Nhan su',NULL, NULL, 'NS1'); --- MANQL: 10 PHG: 4 MANV: 11
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'CARL', N'NAM', TO_DATE('30-10-1996','dd-mm-yyyy'), N'212 LOS GATOS', N'0559883732',2000,1700,N'Nhan su',NULL, NULL, 'NS2'); --- MANQL: 10 PHG: 4 MANV: 12
--- 6. TRUONG DE AN
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'KENNEDY', N'NAM', TO_DATE('01-02-1992','dd-mm-yyyy'), N'126 LUSIANA', N'0391066319',2100,1000,N'Truong de an',NULL,NULL, 'TDA1'); --- PHG: 1 MANV: 13
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'FRED', N'NAM', TO_DATE('01-07-1998','dd-mm-yyyy'), N'126 JOHN WICK', N'0337864923',2100,1000,N'Truong de an',NULL,NULL, 'TDA2'); --- PHG: 2 MANV: 14
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'PHINEAS', N'NAM', TO_DATE('15-02-1993','dd-mm-yyyy'), N'25 GARDEN GROVE', N'0522686982',2100,1000,N'Truong de an',NULL,NULL, 'TDA3'); --- PHG: 3 MANV: 15
--- 7. NHAN VIEN
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'MICHAEL', N'NAM', TO_DATE('13-03-2002','dd-mm-yyyy'), N'27 SOUTH YORK', N'0322967082',1000,500,N'Nhan vien',NULL,NULL, 'NV1');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'SUSAN', N'NU', TO_DATE('23-05-1998','dd-mm-yyyy'), N'16 SANCHEZ', N'0304213331',1000,1000,N'Nhan vien',NULL,NULL, 'NV2');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'KATE', N'NU', TO_DATE('13-10-1990','dd-mm-yyyy'), N'23 THOMAS MILLER', N'0840667154',2000,1000,N'Nhan vien',NULL,NULL, 'NV3');
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG, USERNAME)
VALUES (N'NATASHA', N'NU', TO_DATE('13-10-2000','dd-mm-yyyy'), N'23 JOHN HOPKINS', N'0840667345',2000,1000,N'Nhan vien',NULL,NULL, 'NV4');




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

--- CAP NHAT PHONG VA NGUOI QUAN LY CHO BANG NHANVIEN
UPDATE NHANVIEN SET PHG=1 WHERE MANV=3;
UPDATE NHANVIEN SET PHG=2 WHERE MANV=4;

UPDATE NHANVIEN SET PHG=1 WHERE MANV=5;
UPDATE NHANVIEN SET PHG=2 WHERE MANV=6;
UPDATE NHANVIEN SET PHG=3 WHERE MANV=7;
UPDATE NHANVIEN SET PHG=4 WHERE MANV=8;

UPDATE NHANVIEN SET MANQL=7, PHG=3 WHERE MANV=9;
UPDATE NHANVIEN SET MANQL=7, PHG=3 WHERE MANV=10;

UPDATE NHANVIEN SET MANQL=8, PHG=4 WHERE MANV=11;
UPDATE NHANVIEN SET MANQL=8, PHG=4 WHERE MANV=12;

UPDATE NHANVIEN SET PHG=1 WHERE MANV=13;
UPDATE NHANVIEN SET PHG=2 WHERE MANV=14;
UPDATE NHANVIEN SET PHG=3 WHERE MANV=15;

UPDATE NHANVIEN SET MANQL=3, PHG=1 WHERE MANV=16;
UPDATE NHANVIEN SET MANQL=4, PHG=2 WHERE MANV=17;
UPDATE NHANVIEN SET MANQL=3, PHG=3 WHERE MANV=18;
UPDATE NHANVIEN SET MANQL=4, PHG=4 WHERE MANV=19;

--- CAP NHAT MA TRUONG DE AN
UPDATE DEAN SET MATRGDA = 13 WHERE PHONG =1;
UPDATE DEAN SET MATRGDA = 14 WHERE PHONG =2;
UPDATE DEAN SET MATRGDA = 15 WHERE PHONG =3;

--- CAP NHAT BANG PHONG BAN
UPDATE PHONGBAN SET TRPHG=7 WHERE MAPB=1;
UPDATE PHONGBAN SET TRPHG=8 WHERE MAPB=2;
UPDATE PHONGBAN SET TRPHG=9 WHERE MAPB=3;
UPDATE PHONGBAN SET TRPHG=10 WHERE MAPB=4;

SELECT * FROM NHANVIEN;
SELECT * FROM PHONGBAN;
SELECT * FROM DEAN;
SELECT * FROM PHANCONG;
    

---- CAP QUYEN
alter session set "_oracle_script"=true;
drop role Nhanvien;
drop role QLTrucTiep;
drop role TruongPhong;
drop role TaiChinh;
drop role NhanSu;
drop role TruongDeAn;
drop role BanGiamDoc;
drop role GeneralRole; ---

create role BanGiamDoc;

create role Nhanvien;
grant Nhanvien to NV1;
grant Nhanvien to NV2;
grant Nhanvien to NV3;
grant Nhanvien to NV4;

create role QLTrucTiep;
grant QLTrucTiep to QLTT1;
grant QLTrucTiep to QLTT2;

create role TruongPhong;
grant TruongPhong to TP1;
grant TruongPhong to TP2;
grant TruongPhong to TP3;
grant TruongPhong to TP4;

create role TaiChinh;
grant TaiChinh to TC1;
grant TaiChinh to TC2;

create role NhanSu;
grant NhanSu to NS1;
grant NhanSu to NS2;

create role TruongDeAn;
grant TruongDeAn to TDA1;
grant TruongDeAn to TDA2;
grant TruongDeAn to TDA3;

create role GeneralRole;

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