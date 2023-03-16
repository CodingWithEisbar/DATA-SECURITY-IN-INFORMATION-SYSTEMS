/*Group 03 - 20HTTT1*/
--- SETUP KIEU NGAY THANG NAM
ALTER SESSION SET nls_date_format='dd-mm-yyyy';
----------------------------------------------------------------------------------
--- CHECK EXISTS AND DROP TABLE
DECLARE
    exist_check_01 INTEGER;
BEGIN
    SELECT COUNT(*)
    INTO exist_check_01
    FROM USER_OBJECTS
    WHERE OBJECT_NAME = 'NHANVIEN' AND OBJECT_TYPE = 'TABLE'; --- Kiem tra co TABLE nao trung ten nay khong
    IF exist_check_01 > 0 THEN --- Neu bien count khac khong tuc la co ton tai
        EXECUTE IMMEDIATE 'DROP TABLE NHANVIEN PURGE'; --- Thuc hien lenh DROP TABLE
        dbms_output.put_line( 'Table droppped' );
    END IF;
END;
/

DECLARE
    exist_check_02 INTEGER;
BEGIN
    SELECT COUNT(*)
    INTO exist_check_02
    FROM USER_OBJECTS
    WHERE OBJECT_NAME = 'PHONGBAN' AND OBJECT_TYPE = 'TABLE';
    IF exist_check_02 > 0 THEN
        EXECUTE IMMEDIATE 'DROP TABLE PHONGBAN PURGE';
        dbms_output.put_line( 'Table droppped' );
    END IF;
END;
/

DECLARE
    exist_check_03 INTEGER;
BEGIN
    SELECT COUNT(*)
    INTO exist_check_03
    FROM USER_OBJECTS
    WHERE OBJECT_NAME = 'DEAN' AND OBJECT_TYPE = 'TABLE'; 
    IF exist_check_03 > 0 THEN 
        EXECUTE IMMEDIATE 'DROP TABLE DEAN PURGE'; 
        dbms_output.put_line( 'Table droppped' );
    END IF;
END;
/

DECLARE
    exist_check_04 INTEGER;
BEGIN
    SELECT COUNT(*)
    INTO exist_check_04
    FROM USER_OBJECTS
    WHERE OBJECT_NAME = 'PHANCONG' AND OBJECT_TYPE = 'TABLE'; 
    IF exist_check_04 > 0 THEN 
        EXECUTE IMMEDIATE 'DROP TABLE PHANCONG PURGE';
        dbms_output.put_line( 'Table droppped' );
    END IF;
END;
/

----------------------------------------------------------------------------------
--- TAO BANG DU LIEU
CREATE TABLE NHANVIEN (
    MANV NUMBER(4) GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT BY 1),
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

CREATE TABLE PHONGBAN (
    MAPB NUMBER(4) GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT BY 1),
    TENPB VARCHAR2(100),
    TRPHG NUMBER(4),
    
    CONSTRAINT PHONGBAN_PK
    PRIMARY KEY(MAPB)
);

CREATE TABLE DEAN (
    MADA NUMBER(4) GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT BY 1),
    TENDA VARCHAR2(100),
    NGAYBD DATE,
    PHONG VARCHAR2(10),
    
    CONSTRAINT DEAN_PK
    PRIMARY KEY(MADA)
);

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
FOREIGN KEY(MANV)
REFERENCES NHANVIEN(MANV);

----------------------------------------------------------------------------------
--- NHAP THONG TIN VAO BANG
INSERT INTO NHANVIEN (TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG)
VALUES (N'THOMAS', N'NAM', TO_DATE('09-06-1981','dd-mm-yyyy'), N'21 Brown Street', N'');

INSERT INTO PHONGBAN (TENPB, TRPHG)
VALUES ();

INSERT INTO DEAN (TENDA, NGAYBD, PHONG)
VALUES ();

INSERT INTO PHANCONG (MANV, MADA, THOIGIAN)
VALUES ();

