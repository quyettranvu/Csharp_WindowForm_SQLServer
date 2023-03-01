/*
This query text was retrieved from showplan XML, and may be truncated.
*/

--CREATE PROC PhongBan_SelectAll
--AS
--BEGIN
--	SELECT * FROM PhongBan
--END;

--CREATE PROC PhongBan_Insert(
--	@Department nvarchar(50)
--)
--AS 
--BEGIN 
--	INSERT INTO PhongBan(Department) VALUES(@Department)
--END

--CREATE PROC PhongBan_Update(
--	@Department nvarchar(50),
--	@ID int
--)
--AS
--BEGIN
--	UPDATE PhongBan SET Department=@Department WHERE ID =@ID
--END

--CREATE PROC PhongBan_Delete(
--	@ID int
--)
--AS
--BEGIN
--	DELETE FROM PhongBan WHERE ID =@ID
--END

--CREATE PROC NhanVien_SelectID(
--	@ID int
--)
--AS 
--BEGIN 
--	SELECT * FROM SinhVien WHERE ID=@ID
--END

--CREATE PROC NhanVien_Insert(
--	@fullName nvarchar(50),
--	@homeTown nvarchar(50),
--	@ID int
--)
--AS
--BEGIN
--	INSERT INTO SinhVien(fullName,homeTown, ID) VALUES(@fullName, @homeTown, @ID)
--END;

--CREATE PROC NhanVien_Update(
--	@fullName nvarchar(50),
--	@homeTown nvarchar(50),
--	@IDStudent int
--)
--AS
--BEGIN
--	UPDATE SinhVien SET fullName=@fullName, homeTown =@homeTown WHERE IDStudent=@IDStudent
--END;

CREATE PROC NhanVien_Delete(
	@IDStudent int
)
AS
BEGIN
	DELETE FROM SinhVien WHERE IDStudent=@IDStudent
END;

