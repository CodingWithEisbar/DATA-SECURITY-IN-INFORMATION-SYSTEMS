alter session set "_ORACLE_SCRIPT"=true;
/*drop role role_name;
CREATE ROLE role_name;
GRANT SELECT ON dba_users TO role_name;*/
drop user admin;
create user admin IDENTIFIED BY admin;
GRANT CREATE SESSION TO admin;
--1--
GRANT SELECT ON dba_users TO ADMIN;
--2--
GRANT SELECT ON DBA_TAB_PRIVS TO ADMIN;
GRANT SELECT ON ROLE_TAB_PRIVS TO ADMIN;
--3--
GRANT CREATE USER TO ADMIN;
GRANT DROP USER TO ADMIN;
GRANT ALTER USER TO ADMIN;

GRANT CREATE ROLE TO ADMIN;
GRANT DROP ANY ROLE TO ADMIN;
GRANT ALTER ANY ROLE TO ADMIN;
--4--
GRANT ALL PRIVILEGES TO ADMIN with admin option;

select*from dba_users;

SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE ='ADMIN';--t�y c�ng d?ng m� s? d?ng
SELECT role FROM ROLE_TAB_PRIVS WHERE ROLE ='ROLE_NAME';--??


alter session set "_ORACLE_SCRIPT"=true;
drop user NV;
create user NV IDENTIFIED BY NV;
GRANT CREATE SESSION TO NV;

drop user QLTT;
create user QLTT IDENTIFIED BY QLTT;
GRANT CREATE SESSION TO QLTT;

drop user TP;
create user TP IDENTIFIED BY TP;
GRANT CREATE SESSION TO TP;

drop user TC;
create user TC IDENTIFIED BY TC;
GRANT CREATE SESSION TO TC;

drop user NS;
create user NS IDENTIFIED BY NS;
GRANT CREATE SESSION TO NS;

drop user TDA;
create user TDA IDENTIFIED BY TDA;
GRANT CREATE SESSION TO TDA;

select*from user_role_privs;

--database
--- TAO BANG DU LIEU

----------------------------------------------------------------------------------
--- NHAP THONG TIN VAO BANG





