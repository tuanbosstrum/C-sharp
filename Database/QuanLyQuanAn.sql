CREATE DATABASE QuanLyQuanAn
GO

USE QuanLyQuanAn
GO

-- Food --
-- Table --
-- FoodCategory --
-- Account --
-- Bill -- 
-- BillInfo --

--------------------------- Tạo các table ---------------------------

CREATE TABLE TableFood 
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR (100) NOT NULL DEFAULT N'Bàn chưa có tên', 
	STATUS NVARCHAR (100) NOT NULL  DEFAULT N'Trống' -- Trống, Có người --
)
GO

CREATE TABLE Account 
(
	UserName NVARCHAR (100) PRIMARY KEY, 
	DisplayName NVARCHAR (100) NOT NULL DEFAULT N'xFillbert', 
	PassWord NVARCHAR (1000) NOT NULL DEFAULT 0, 
	Type INT NOT NULL DEFAULT 0 -- 1: 
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR (100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR (100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(), 
	DateCheckOut DATE, 
	idTable INT NOT NULL, 
	STATUS INT NOT NULL DEFAULT 0,  -- 1: Đã thanh toán && 0: Chưa thanh toán
	discount int NULL DEFAULT 0,
	totalPrice float NULL,
	
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	COUNT INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (IdBill) REFERENCES dbo.Bill(id), 
	FOREIGN KEY (IdFood) REFERENCES dbo.Food(id)
)
GO

--------------------------- Thêm Vào Tài Khoản (Admin, nonAdmin) ---------------------------

INSERT INTO dbo.Account
	(
		UserName,
		DisplayName,
		PassWord,
		Type
	)
VALUES ( N'xFillbert', -- UserName - nvarchar (100)
		 N'Ho Hoang Hao', -- DisplayName - nvarchar (100)
		 N'1', -- PassWord - nvarchar (1000)
		 1 -- Type - int
			
		)
GO

INSERT INTO dbo.Account
	(
		UserName,
		DisplayName,
		PassWord,
		Type
	)
VALUES ( N'Bac', -- UserName - nvarchar (100)
		 N'Nguyen Viet Bac', -- DisplayName - nvarchar (100)
		 N'1', -- PassWord - nvarchar (1000)
		 0 -- Type - int
		)
GO

--------------------------- Lấy Tài Khoản Theo Tên Người Dùng ---------------------------


CREATE PROC USP_GetAccountByUserName
@userName nvarchar (100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO

EXEC dbo.USP_GetAccountByUserName @userName = N'xFillbert' -- nvarchar (100)
GO

CREATE PROC USP_Login
@userName nvarchar (100), @passWord nvarchar (100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO	

------------------------------- Thêm Bàn -------------------------------

DECLARE @i INT = 1

WHILE @i <= 20
BEGIN 
	INSERT dbo.TableFood (NAME) VALUES (N'Bàn ' + CAST (@i AS nvarchar(100)))
	SET @i = @i + 1
END
GO

CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO

-- UPDATE dbo.TableFood SET STATUS = N'Có Người' WHERE id = 4

--EXEC USP_GetTableList
--GO

------------------------------- Thêm Category -------------------------------

SET IDENTITY_INSERT [dbo].[FoodCategory] ON

INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (1, N'Hải Sản')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (2, N'Nông Sản')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (3, N'Lâm Sản')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (4, N'Nước')

SET IDENTITY_INSERT [dbo].[FoodCategory] OFF

------------------------------- Thêm món ăn -------------------------------

SET IDENTITY_INSERT [dbo].[Food] ON

INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1, N'Mực trứng chiên nước mắm', 1, 100000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2, N'Nghêu hấp thái', 1, 60000)

INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3, N'Bò tái chanh', 2, 80000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4, N'Gà tìm thuốc bắc', 2, 75000)

INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5, N'Trâu gác bếp', 3, 85000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6, N'Nai xào lăn', 3, 100000)

INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7, N'Tiger Crystal', 4, 18000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (8, N'Pepsi', 4, 15000)

SET IDENTITY_INSERT [dbo].[Food] OFF

--------------------------- Indert Hoá Đơn ---------------------------

CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT dbo.Bill
			( DateCheckIn, 
			  DateCheckOut, 
			  idTable, 
			  STATUS, 
			  discount
			)
	VALUES  ( GETDATE(), -- DateCheckIn - date
			  NULL,  -- DateCheckOut - date
			  @idTable, -- idTable -  int
			  0,  -- status - int
			  0
			 )
END
GO

--------------------------- Insert Thông Tin Hoá Đơn ---------------------------

CREATE PROC dbo.USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, idFood, count )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
END
GO


------------------------------- Cập nhật thông tin Bill -------------------------------

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted

	DECLARE @idTable INT
	
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND STATUS = 0
	
	DECLARE @count INT
	SELECT @count = COUNT (*) FROM dbo.BillInfo WHERE idBill = @idBill
	
	IF (@count > 0)
	BEGIN
	
		PRINT @idTable
		PRINT @idBill
		PRINT @count
		
		UPDATE dbo.TableFood SET STATUS = N'Có Người' WHERE id = @idTable
		
	END
	ELSE
	BEGIN
	PRINT @idTable
		PRINT @idBill
		PRINT @count
	UPDATE dbo.TableFood SET STATUS = N'Trống' WHERE id = @idTable
	END
END
GO


------------------------------- Cập Nhật Hoá Đơn -------------------------------

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = id FROM Inserted

	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count int = 0
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND STATUS = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET STATUS = N'Trống' WHERE id = @idTable
END
GO

------------------------------- Chuyển Bàn -------------------------------

CREATE PROC dbo.USP_SwitchTable
@idTable1 INT , @idTable2 INT
AS BEGIN

	DECLARE @idFirstBill INT
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idFirstBill IS NULL)
	BEGIN
		PRINT '0000001'
		INSERT dbo.Bill
		        ( DateCheckIn ,  
		          DateCheckOut , 
		          idTable , 
		          STATUS
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0  -- status - int
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND STATUS = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT ' ----------- '
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		PRINT '0000002'
		INSERT dbo.Bill
		        ( DateCheckIn , 
		          DateCheckOut , 
		          idTable , 
		          STATUS
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0  -- status - int
		        )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
		
	IF (@isSecondTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO

---------------------- Lấy Danh Sách Hoá Đơn Theo Ngày ---------------------

CREATE PROC USP_GetListBillByDate 
@checkIn DATE , @checkOut DATE
AS 
BEGIN
	SELECT t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá] -- hiển thị tên thay cho...
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.STATUS = 1
	AND t.id = b.idTable
END
GO

------------------------------- Cập Nhật Tài Khoản -------------------------------

CREATE PROC dbo.USP_UpdateAccount 
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USERName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	END
END
GO

----------------------------------------------------------------------

-- INSERT dbo.Food (name, idCategory, price) VALUES ( N'', 0, 0.0)

----------------------------------------------------------------------

CREATE TRIGGER UTG_DeleteBillInfo 
ON
dbo.BillInfo FOR DELETE 
AS
BEGIN
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id, @idBill = Deleted.idBill FROM Deleted 
	
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count INT = 0
	
	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.STATUS = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET STATUS = N'Trống' WHERE id = @idTable
END
GO
	
-------------------------  Tạo Function convert tiếng Việt Có dấu -> Không dấu ------------------------- 

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO

----------------------------------------------------------------------

-- SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f
-- WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.STATUS = 0 AND b.idTable = 2


-- SELECT * FROM dbo.Bill
--SELECT * FROM dbo.BillInfo
--SELECT * FROM dbo.Food
--SELECT * FROM dbo.FoodCategory


--



