--cs6--
-- TRUONG DE AN


DROP PROCEDURE update_DEAN;
CREATE OR REPLACE PROCEDURE update_DEAN (TDA_MADA NUMBER, TDA_TENDA VARCHAR2, TDA_NGAYBD DATE, TDA_PHONG NUMBER, TDA_MATRGDA NUMBER)
AS
BEGIN
    UPDATE DEAN SET TENDA = TDA_TENDA, NGAYBD = TDA_NGAYBD, PHONG = TDA_PHONG, MATRGDA = TDA_MATRGDA WHERE MADA = TDA_MADA;
    COMMIT;
END;
/


GRANT SELECT ON DEAN to TruongDeAn;
GRANT INSERT ON DEAN to TruongDeAn;
GRANT UPDATE ON DEAN to TruongDeAn;
GRANT DELETE ON DEAN to TruongDeAn;

GRANT SELECT ON NHANVIEN TO TruongDeAn;
GRANT EXECUTE ON update_DEAN TO TruongDeAn;

grant GeneralRole to TDA1;
grant Nhanvien to TDA1;
grant TruongDeAn to TDA1;