--cs4--
BEGIN
    DBMS_RLS.drop_policy
        (object_schema => 'admin',
        object_name => 'NHANVIEN',
        policy_name => 'selectNhanVienControl');
END;

BEGIN
  DBMS_RLS.add_policy (
    object_schema => 'admin',
    object_name => 'NHANVIEN',
    policy_name=> 'selectNhanVienControl',
    policy_function=> 'NhanVien_Select_NV',
    statement_types=> 'SELECT');
END;
/

CREATE OR REPLACE PROCEDURE update_luong(lg NUMBER,idnv NUMBER)
AS
BEGIN
  UPDATE Nhanvien SET luong = lg WHERE manv =idnv;
  COMMIT;
END;
/
CREATE OR REPLACE PROCEDURE update_phucap(pc NUMBER,idnv NUMBER)
AS
BEGIN
  UPDATE Nhanvien SET phucap = pc WHERE manv =idnv;
  COMMIT;
END;
/
grant select on NhanVien to TaiChinh;
grant select on PhanCong to TaiChinh;
GRANT EXECUTE ON update_luong TO TaiChinh;
GRANT EXECUTE ON update_phucap TO TaiChinh;
GRANT TaiChinh TO TC;
grant GeneralRole to TC;