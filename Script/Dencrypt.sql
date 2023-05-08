create or replace function decrypt_SODT (p_data in varchar2)  
    return varchar2  
as  
    output_string VARCHAR2 (200);
    decrypted_raw RAW (2000); -- stores decrypted binary text
    v_key raw(128) := utl_i18n.string_to_raw( 'ATBMHTTT1', 'AL32UTF8' );
    encryption_type PLS_INTEGER := SYS.DBMS_CRYPTO.ENCRYPT_DES + SYS.DBMS_CRYPTO.CHAIN_CBC + SYS.DBMS_CRYPTO.PAD_PKCS5;
begin  
    decrypted_raw := DBMS_CRYPTO.Decrypt
        (
            src => HEXTORAW(p_data),
            typ => encryption_type,
            key => v_key
        );
    output_string := UTL_I18N.RAW_TO_CHAR (decrypted_raw, 'AL32UTF8');
    return output_string;  
end; 
/

select MANV,Username,TENNV,PHAI,NGAYSINH,DIACHI,cast(admin.decrypt_SODT(sodt) as nvarchar2(255)) sodt,LUONG,PHUCAP ,VAITRO,MANQL,PHG from admin.nhanvien;
select*from admin.PhanCong_Select_NV;
select*from admin.PhongBan;
select*from admin.dean;
exec admin.update_NV_NV(TO_DATE('13-03-2002','dd-mm-yyyy'), N'27 SOUTH YORK', '0322967083');
select*from nhanvien;
--cs2
select MANV,Username,TENNV,PHAI,NGAYSINH,DIACHI,cast(admin.decrypt_SODT(sodt) as nvarchar2(255)) sodt,LUONG,PHUCAP ,VAITRO,MANQL,PHG from admin.NhanVien_Select_QL;
select *from admin.PHANCONG_Select_QL;
select*from admin.PhongBan;
select*from admin.dean;
UPDATE admin.NhanVien_Select_QL set sodt='0322967083',diachi=N'27 SOUTH YORK',ngaysinh=TO_DATE('13-03-2002','dd-mm-yyyy') where username=SYS_CONTEXT ('USERENV', 'SESSION_USER');
--cs3
select MANV,Username,TENNV,PHAI,NGAYSINH,DIACHI,cast(admin.decrypt_SODT(sodt) as nvarchar2(255)) sodt,LUONG,PHUCAP ,VAITRO,MANQL,PHG from admin.NhanVien_Select_TP;
select*from admin.PhanCong_Select_TP;
select*from admin.PhongBan;
select*from admin.dean;
UPDATE admin.NhanVien_Select_TP set sodt='0322967083',diachi=N'27 SOUTH YORK',ngaysinh=TO_DATE('13-03-2002','dd-mm-yyyy') where username=SYS_CONTEXT ('USERENV', 'SESSION_USER');
insert into admin.PhanCong_Select_TP values(15,3,TO_DATE('13-03-2002','dd-mm-yyyy'));
update admin.PhanCong_Select_TP set manv=16 where manv=3 and mada=2;
delete admin.PhanCong_Select_TP where manv=16 and mada=2;


--cs4
select MANV,Username,TENNV,PHAI,NGAYSINH,DIACHI,cast(admin.decrypt_SODT(sodt) as nvarchar2(255)) sodt,LUONG,PHUCAP ,VAITRO,MANQL,PHG from admin.nhanvien;
select*from admin.phancong;
select*from admin.phongban;
select*from admin.dean;
exec admin.update_luong(4000,1);
exec admin.update_phucap(1600,1);
exec admin.update_NV_NV(TO_DATE('13-03-2002','dd-mm-yyyy'), N'27 SOUTH YORK', '0322967083');

--cs5
select MANV,Username,TENNV,PHAI,NGAYSINH,DIACHI,cast(admin.decrypt_SODT(sodt) as nvarchar2(255)) sodt,LUONG,PHUCAP ,VAITRO,MANQL,PHG from admin.NhanVien_Select_NS;
select*from admin.PhanCong_Select_NS;
select*from admin.phongban;
select*from admin.dean;
exec admin.insert_NV_NS('NV10','a','Nam',TO_DATE('13-03-2002','dd-mm-yyyy'), N'27 SOUTH YORK', '0322967083','Nhan vien',1,1);
exec admin.update_NV_NS(20,'NV10','b','Nam',TO_DATE('13-03-2002','dd-mm-yyyy'), N'27 SOUTH YORK', '0322967083','Nhan vien',1,1);

insert into admin.phongban(tenpb,trphg) values('a',11);
update admin.phongban set trphg=12 where mapb=5;
--cs6
select MANV,Username,TENNV,PHAI,NGAYSINH,DIACHI,cast(admin.decrypt_SODT(sodt) as nvarchar2(255)) sodt,LUONG,PHUCAP ,VAITRO,MANQL,PHG from admin.nhanvien;
select*from admin.PhanCong_Select_TDA;
select*from admin.PhongBan;
select*from admin.dean;
exec admin.update_NV_NV(TO_DATE('13-03-2002','dd-mm-yyyy'), N'27 SOUTH YORK', '0322967083');
insert into admin.dean(tenda,ngaybd,phong) values('a',TO_DATE('13-03-2002','dd-mm-yyyy'),1);
update admin.dean set phong =2 where mada=4;
delete admin.dean where mada=4;
