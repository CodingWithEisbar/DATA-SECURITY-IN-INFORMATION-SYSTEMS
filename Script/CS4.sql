--cs4--
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