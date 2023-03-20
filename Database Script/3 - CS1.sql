--cs1--
--NhanVien
CREATE OR REPLACE VIEW NhanVien_Select_NV AS
SELECT NV.MANV,NV.Username,NV.TENNV,NV.PHAI,NV.NGAYSINH,NV.DIACHI,NV.SODT,NV.LUONG,NV.PHUCAP,NV.VAITRO,NV.MANQL,NV.PHG
FROM NHANVIEN NV
WHERE NV.USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER')
with check option;

CREATE OR REPLACE VIEW PhanCong_Select_NV AS
SELECT NV.MANV,PC.MADA,PC.THOIGIAN
FROM NHANVIEN NV,PHANCONG PC
WHERE NV.USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER') and NV.VAITRO=N'Nhanvien' AND PC.MANV=NV.MANV
with check option;

CREATE OR REPLACE TRIGGER updateNhanVien
    INSTEAD OF UPDATE ON NhanVien_Select
    FOR EACH ROW
BEGIN
    -- insert a new customer first
    Update NhanVien set Ngaysinh=:new.ngaysinh, diachi=:new.diachi, sodt=:new.sodt where USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER');
END;

--alter session set "_oracle_script"=true;
grant select on Phongban to Nhanvien;
grant select on Dean to Nhanvien;
grant select on NhanVien_Select_NV to Nhanvien;
grant update on NhanVien_Select_NV  to Nhanvien;
grant select on PhanCong_Select_NV to Nhanvien;
grant Nhanvien to NV;


alter session set "_oracle_script"=true;
drop role Nhanvien;
drop role QLTrucTiep;
drop role TruongPhong;
drop role TaiChinh;
drop role NhanSu;
drop role TruongDeAn;
drop role BanGiamDoc;

create role Nhanvien;
create role QLTrucTiep;
create role TruongPhong;
create role TaiChinh;
create role NhanSu;
create role TruongDeAn;
create role BanGiamDoc;