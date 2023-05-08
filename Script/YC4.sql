--CAU A
BEGIN
  DBMS_FGA.add_policy(
    object_schema   => 'sys',
    object_name     => 'PHANCONG',
    policy_name     => 'CAU_A',
    audit_condition => NULL, -- T??ng ???ng v?i TRUE
    audit_column    => 'THOIGIAN',
    statement_types => 'UPDATE');
END;
/
BEGIN
DBMS_FGA.ENABLE_POLICY (
object_schema      =>  'SYS', 
   object_name        =>  'PHANCONG', 
    policy_name        =>  'CAU_A');
END;
/


--CAU B
BEGIN
  DBMS_FGA.add_policy(
    object_schema   => 'sys',
    object_name     => 'NHANVIEN',
    policy_name     => 'CAU_B',
    audit_condition => 'USERNAME != USER' , -- T??ng ???ng v?i TRUE
    audit_column    => 'LUONG,PHUCAP',
    statement_types => 'SELECT');
END;
/
BEGIN
DBMS_FGA.ENABLE_POLICY (
object_schema      =>  'SYS', 
   object_name        =>  'NHANVIEN', 
    policy_name        =>  'CAU_B');
END;
/
--CAU C
DBMS_FGA.add_policy(
    object_schema   => 'sys',
    object_name     => 'NHANVIEN',
    policy_name     => 'CAU_C',
    audit_condition => 'VAITRO!=''Taichinh''' , -- T??ng ???ng v?i TRUE
    audit_column    => 'LUONG,PHUCAP',
    statement_types => 'UPDATE');
END;
/
BEGIN
DBMS_FGA.ENABLE_POLICY (
object_schema      =>  'SYS', 
   object_name        =>  'NHANVIEN', 
    policy_name        =>  'CAU_C');
END;
/



