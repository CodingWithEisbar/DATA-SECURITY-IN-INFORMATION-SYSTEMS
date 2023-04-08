--cs2--
CREATE OR REPLACE VIEW NhanVien_Select_QL AS
SELECT distinct NV.MANV,NV.Username,NV.TENNV,NV.PHAI,NV.NGAYSINH,NV.DIACHI,NV.SODT,NV.VAITRO,NV.MANQL,NV.PHG,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),luong) luong,decode(NV.Username,SYS_CONTEXT ('USERENV', 'SESSION_USER'),phucap) phucap
FROM NHANVIEN NV
union
SELECT distinct NV2.MANV,NV2.Username,NV2.TENNV,NV2.PHAI,NV2.NGAYSINH,NV2.DIACHI,NV2.SODT,NV2.VAITRO,NV2.MANQL,NV2.PHG,decode(NV2.Username,null,NV2.luong) luong,decode(NV2.Username,null,Nv2.phucap) phucap
FROM NHANVIEN NV1,Nhanvien NV2
where NV1.UserName=SYS_CONTEXT ('USERENV', 'SESSION_USER') and nv2.manql=nv1.manv and nv1.manv!=nv2.manv and nv2.vaitro=N'Nhanvien'
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
    Update NhanVien set Ngaysinh=:new.ngaysinh, diachi=:new.diachi, sodt=:new.sodt where USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER');
END;
/
grant select on NhanVien_Select_QL to QLTrucTiep;--
grant select on PHANCONG_Select_QL to QLTrucTiep;
grant update on NhanVien_Select_QL to QLTrucTiep;
grant QLTrucTiep to QLTT;
grant GeneralRole to QLTT; 