--cs5--

grant GeneralRole to NhanSu
grant NhanVien to NhanSu
grant update(ngaysinh,diachi,sodt) on NhanVien  to NhanSu;
grant select on dean to Nhansu
grant select on Phongban to Nhansu;
grant update on Phongban to Nhansu;
grant insert on phongban to Nhansu;
create or replace view NhanSu_EditProfile as --- View nay de nhan su chinh sua thong tin ca nhan
select NV.MANV,NV.TENNV,NV.NGAYSINH,NV.DIACHI,NV.SODT,CAST (decrypt_luong(luong) AS varchar2 (255)) as luong, CAST (decrypt_phucap(phucap) AS varchar2 (255)) as phucap from nhanvien NV
where Username = SYS_CONTEXT ('USERENV', 'SESSION_USER')
with check option;
grant select on NhanSu_EditProfile to Nhansu;
CREATE OR REPLACE VIEW NhanVien_Select_NS AS --- View nay de nhan su xem tat ca cac thong tin cua NV khac tru LUONG VA PHUCAP
SELECT distinct NV.MANV,NV.Username,NV.TENNV,NV.PHAI,NV.NGAYSINH,NV.DIACHI,NV.SODT,NV.VAITRO,NV.MANQL,NV.PHG,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),CAST (decrypt_luong(luong) AS varchar2 (255))) luong,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),CAST (decrypt_luong(phucap) AS varchar2 (255))) phucap
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
--grant Nhansu to NS;
--grant GeneralRole to NS;
