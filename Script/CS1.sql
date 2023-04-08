--cs1--
--NhanVien
CREATE OR REPLACE FUNCTION NhanVien_Select_NV (
p_schema IN VARCHAR2,
p_object IN VARCHAR2)
RETURN VARCHAR2
AS
user VARCHAR2(100);
BEGIN
    RETURN 'USERNAME = SYS_CONTEXT(''userenv'', ''SESSION_USER'')';
END;
/


begin
    DBMS_RLS.add_policy(object_schema => 'ADMIN',object_name => 'Nhanvien',policy_name => 'VPD_Nhanvien',policy_function => 'NhanVien_Select_NV');
end;
/
CREATE OR REPLACE VIEW PhanCong_Select_NV AS
SELECT NV.MANV,PC.MADA,PC.THOIGIAN
FROM NHANVIEN NV,PHANCONG PC
WHERE NV.USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER') and NV.VAITRO=N'Nhanvien' AND PC.MANV=NV.MANV
with check option;

CREATE OR REPLACE PROCEDURE update_NV_NV(NV_MANV NUMBER,NV_NGAYSINH DATE,NV_DIACHI VARCHAR2,NV_SODT VARCHAR2)
AS
BEGIN
  update Nhanvien set ngaysinh=nv_ngaysinh, diachi=nv_diachi, sodt=nv_sodt where manv=NV_MANV ;
  COMMIT;
END;
/
GRANT EXECUTE ON update_NV_NV TO NhanVien;

grant select on Phongban to GeneralRole;
grant select on Dean to GeneralRole;

grant select on NhanVien to Nhanvien;
grant update(ngaysinh,diachi,sodt) on NhanVien  to Nhanvien;
grant select on PhanCong_Select_NV to Nhanvien;
grant Nhanvien to NV;
grant GeneralRole to NV;