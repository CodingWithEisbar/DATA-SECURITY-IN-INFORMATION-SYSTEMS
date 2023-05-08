SELECT STATUS FROM DBA_OLS_STATUS WHERE NAME = 'OLS_CONFIGURE_STATUS';


EXEC LBACSYS.CONFIGURE_OLS;
EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS;
ALTER USER LBACSYS IDENTIFIED BY thuan ACCOUNT UNLOCK ;

--show con_name
--show pdbs;
--select*from V$PDBS
--alter pluggable database CDB$ROOT open;
--alter system set clonedb=TRUE scope=spfile;


exec sa_sysdba.create_policy(policy_name => 'OLS',column_name => 'r_label');
-- Gan quyen cho Quan tri vien
grant OLS_DBA to admin;



grant execute on SA_COMPONENTS to admin;
grant execute on SA_LABEL_ADMIN to admin;
grant execute on SA_POLICY_ADMIN to admin;
grant execute on SA_USER_ADMIN to admin;
grant execute on CHAR_TO_LABEL to admin;

-- ===== CHAY DUOI QUYEN admin=====
-- Tao level
BEGIN
sa_components.create_level(
    policy_name => 'OLS',
    long_name => 'Giam Doc',
    short_name => 'GD',
    level_num => 1000);

sa_components.create_level(
    policy_name => 'OLS',
    long_name => 'Truong Phong',
    short_name => 'TP',
    level_num => 100);

sa_components.create_level(
    policy_name => 'OLS',
    long_name => 'Nhan vien',
    short_name => 'NV',
    level_num => 10);
END;
/


-- Tao compartments
exec sa_components.create_compartment('OLS',1000,'MB','Mien Bac');
/
exec sa_components.create_compartment('OLS',1100,'MT','Mien Trung');
/
exec sa_components.create_compartment('OLS',1200,'MN','Mien Nam');
/

-- Tao groups
exec sa_components.create_group('OLS',1,'MB','Mua Ban',NULL);
/
exec sa_components.create_group('OLS',2,'SX','San Xuat',NULL);
/
exec sa_components.create_group('OLS',3,'GC','GiaCong',NULL);
/

-- Tao label
execute sa_label_admin.create_label('OLS',3000,'GD:MB,MT,MN:MB,SX,GC');
/
execute sa_label_admin.create_label('OLS',2000,'TP:MN:SX');
/
execute sa_label_admin.create_label('OLS',2500,'GD:MB:MB,SX,GC');
/

-- Xoa bang
drop table THONGBAO purge;
-- Tao bang du lieu
create table THONGBAO(
    NOIDUNG varchar2(255),
    NGAYGIO Date,
    DIADIEM varchar2(255),
    CAPBACTHAMGIA number, -- 3:Giam doc ; 2:Truong Phong; 1:Nhan Vien 
    VUNGLV number, -- 3:MIen Bac; 2:Mien Trung; 1:Mien Nam; 0:Tat ca cac vung
    CHUYENMON number -- 3:Mua Ban; 2:San Xuat; 1:Gia Cong; 0: Tat ca cac chuyen mon
);


insert into THONGBAO values ('Thong Bao Giam Doc',TO_DATE('2023/12/16 ', 'yyyy/mm/dd '),'TP.HCM',3,0,0);
insert into THONGBAO values ('Truong Phong San Xuat Mien Nam',TO_DATE('2023/10/16 ', 'yyyy/mm/dd '),'TP.HCM',2,1,2);
insert into THONGBAO values ('Giam Doc Bat Ky Linh Vuc Mien Ban',TO_DATE('2022/02/05 ', 'yyyy/mm/dd '),'TP.HCM',3,3,0);

begin
sa_policy_admin.apply_table_policy
(policy_name => 'OLS',
schema_name => 'admin',
table_name => 'THONGBAO',
table_options => 'READ_CONTROL');
end;
/

update THONGBAO 
set r_label = char_to_label('OLS', 'GD:MB,MT,MN:MB,SX,GC')
where CAPBACTHAMGIA >= 3 and VUNGLV = 0 and CHUYENMON = 0;

update THONGBAO 
set r_label = char_to_label('OLS', 'TP:MN:SX')
where CAPBACTHAMGIA >= 2 and VUNGLV = 1 and CHUYENMON = 2;

update THONGBAO 
set r_label = char_to_label('OLS', 'GD:MB:MB,SX,GC')
where CAPBACTHAMGIA >= 3 and VUNGLV = 3 and CHUYENMON = 0;

BEGIN
  sa_policy_admin.remove_table_policy(
  policy_name  => 'OLS',
  schema_name  => 'admin',
  table_name  => 'THONGBAO');
end;
/



-- Tao cac loai nguoi dung
alter session set "_ORACLE_SCRIPT"=true;
/
--Xoa nguoi dung
drop user GIAMDOC cascade;
drop user TruongPhong cascade;
drop user NhanVien cascade;

-- Tao nguoi dung
create user GIAMDOC identified by 0;
grant create session to GIAMDOC;

create user TruongPhong identified by 0;
grant create session to TruongPhong;

create user NhanVien identified by 0;
grant create session to NhanVien;



grant select on THONGBAO to GIAMDOC;
grant select on THONGBAO to TruongPhong;
grant select on THONGBAO to Nhanvien;

--gan quyen nguoi dung theo cac yeu cau cua label
begin
sa_user_admin.set_user_labels
  (policy_name => 'OLS',
  user_name => 'GIAMDOC',
  max_read_label => 'GD:MB,MT,MN:MB,SX,GC');
end;
/
begin
  sa_user_admin.set_user_labels
  (policy_name => 'OLS',
  user_name => 'Truongphong',
  max_read_label => 'TP:MN:SX');
end;
/
begin
  sa_user_admin.set_user_labels
  (policy_name => 'OLS',
  user_name => 'GIAMDOC',
  max_read_label => 'GD:MB:MB,SX,GC');
end;
/


select*from admin.thongbao;
