/*Group 03 - 20HTTT1*/
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
