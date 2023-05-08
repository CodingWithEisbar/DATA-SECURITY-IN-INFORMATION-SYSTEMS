--- USER: SYS
alter session set "_ORACLE_SCRIPT"=true;

drop user admin;
create user admin IDENTIFIED BY admin;
GRANT CREATE SESSION TO admin;
--1--
GRANT SELECT ON dba_users TO ADMIN;

--2--
GRANT SELECT ON DBA_TAB_PRIVS TO ADMIN;
GRANT SELECT ON ROLE_TAB_PRIVS TO ADMIN;
GRANT SELECT ON dba_col_privs TO ADMIN;
--3--
GRANT CREATE USER TO ADMIN;
GRANT DROP USER TO ADMIN;
GRANT ALTER USER TO ADMIN;

GRANT CREATE ROLE TO ADMIN;
GRANT DROP ANY ROLE TO ADMIN;
GRANT ALTER ANY ROLE TO ADMIN;
--4--
GRANT ALL PRIVILEGES TO ADMIN with admin option;


--- TAO CAC USER TRONG HE THONG
alter session set "_ORACLE_SCRIPT"=true; --- TRUOC KHI MUON DROP LAN DAU TIEN PHAI THUC THI CAU LENH NAY
--- NGUOI DUNG QUAN LY TRUC TIEP
DROP USER QLTT1;
CREATE USER QLTT1 IDENTIFIED BY 123;
GRANT CREATE SESSION TO QLTT1;

DROP USER QLTT2;
CREATE USER QLTT1 IDENTIFIED BY 123;
GRANT CREATE SESSION TO QLTT2;

DROP USER QLTT2;
CREATE USER QLTT2 IDENTIFIED BY 123;
GRANT CREATE SESSION TO QLTT2;

--- NGUOI DUNG TRUONG PHONG
DROP USER TP1;
CREATE USER TP1 IDENTIFIED BY 123;
GRANT CREATE SESSION TO TP1;

DROP USER TP2;
CREATE USER TP2 IDENTIFIED BY 123;
GRANT CREATE SESSION TO TP2;

DROP USER TP3;
CREATE USER TP3 IDENTIFIED BY 123;
GRANT CREATE SESSION TO TP3;

DROP USER TP4;
CREATE USER TP4 IDENTIFIED BY 123;
GRANT CREATE SESSION TO TP4;

DROP USER TC1;
CREATE USER TC1 IDENTIFIED BY 123;
GRANT CREATE SESSION TO TC1;

DROP USER TC2;
CREATE USER TC2 IDENTIFIED BY 123;
GRANT CREATE SESSION TO TC2;

DROP USER NS1;
CREATE USER NS1 IDENTIFIED BY 123;
GRANT CREATE SESSION TO NS1;

DROP USER NS2;
CREATE USER NS2 IDENTIFIED BY 123;
GRANT CREATE SESSION TO NS2;

DROP USER TDA1;
CREATE USER TDA1 IDENTIFIED BY 123;
GRANT CREATE SESSION TO TDA1;

DROP USER TDA2;
CREATE USER TDA2 IDENTIFIED BY 123;
GRANT CREATE SESSION TO TDA2;

DROP USER TDA3;
CREATE USER TDA3 IDENTIFIED BY 123;
GRANT CREATE SESSION TO TDA3;

DROP USER NV1;
CREATE USER NV1 IDENTIFIED BY 123;
GRANT CREATE SESSION TO NV1;

DROP USER NV2;
CREATE USER NV2 IDENTIFIED BY 123;
GRANT CREATE SESSION TO NV2;

DROP USER NV3;
CREATE USER NV3 IDENTIFIED BY 123;
GRANT CREATE SESSION TO NV3;

DROP USER NV4;
CREATE USER NV4 IDENTIFIED BY 123;
GRANT CREATE SESSION TO NV4;

grant execute on dbms_rls to admin;
grant execute on dbms_crypto to admid






