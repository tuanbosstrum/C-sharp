USE master
CREATE DATABASE csdl_cafe
GO
USE csdl_cafe
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Nhơn Nguyễn',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0,
	image NVARCHAR(100) NULL,
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATETIME NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATETIME,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán
	total FLOAT NOT NULL DEFAULT 0 ,
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

CREATE TABLE Staff (
		id INT IDENTITY PRIMARY KEY NOT NULL,
		FullName NVARCHAR(100) NOT NULL ,
		Phone NVARCHAR(12) ,
		Address NVARCHAR(100),
		NameLevel nvarchar(100) not null ,
		
		
)
GO
-- TÀI KHOẢN ADMIN
INSERT INTO Account(UserName,DisplayName,PassWord,Type) VALUES('admin','Nguyen Van Nhon','123456',1)
GO
--THÊM DANH MỤC
INSERT INTO FoodCategory(name) VALUES(N'Cafe')
INSERT INTO FoodCategory(name) VALUES(N'Sữa')
INSERT INTO FoodCategory(name) VALUES(N'Nước')
INSERT INTO FoodCategory(name) VALUES(N'Thức ăn')
INSERT INTO FoodCategory(name) VALUES(N'Trà')
INSERT INTO FoodCategory(name) VALUES(N'Khác')
GO
--THÊM MÓN
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Cafe đen',1,20000,N'cafe_den.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Cafe sữa',1,25000,N'cafe_sua.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'7-Up',3,15000,N'7_up.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Coca',3,15000,N'coca.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Pepsi',3,15000,N'pepsi.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Nước suối',3,8000,N'nuoc.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Trà tắc',5,25000,N'tra_tac.png')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Trà đào',5,25000,N'tra_dao.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Sữa nóng',2,15000,N'sua_nong.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Sữa chua',2,55000,N'sua_chua.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Bò khô',4,55000,N'bo_kho.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Gà khô',4,45000,N'gakho.jpg')
INSERT INTO Food(name,idCategory,price,image) VALUES(N'Xoài lắc',4,13000,N'xoai.jpg')

GO
-- KIỂM TRA ĐĂNG NHẬP
CREATE PROC CheckAccount
	@username NVARCHAR(100),
	@password NVARCHAR(1000)
AS
	BEGIN
	SELECT * FROM Account WHERE UserName = @username AND PassWord = @password
	END
GO
--THÊM BÀN ĂN
DECLARE @i INT = 1
WHILE @i < =10
BEGIN
	INSERT INTO TableFood ([name]) VALUES ('' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1

END
GO

--PROC DANH SÁCH BÀN
CREATE PROC ListTable
AS
SELECT * FROM TableFood
GO

-- CẬP NHẬT TRẠNG THÁI BÀN
CREATE PROC UpdateStatusTable
@id int,@status nvarchar(100)
AS
UPDATE TableFood SET status = @status WHERE id = @id
GO

--PROC DANH SÁCH MÓN
CREATE PROC ListFood
AS
SELECT * FROM Food
GO

--PROC LẤY BILL THEO ID BÀN
CREATE PROC getBillByIdTable
@idTable int
AS
SELECT * FROM Bill WHERE idTable = @idTable AND status = 0
GO

-- THÊM HÓA ĐƠN
CREATE PROC InsertBill
@idTable int
AS
INSERT INTO Bill(DateCheckIn,idTable,[status]) VALUES(GETDATE(),@idTable,0)
GO

--THÊM BILLINFO PROC
CREATE PROC InsertBillInfo
@idBill int, @idFood int, @count int
AS
INSERT INTO BillInfo(idBill,idFood,[count]) VALUES(@idBill,@idFood,@count)
GO

-- LẤY DANH SÁCH BILLINFO PROC
CREATE PROC getBillInfoById
@idBill int
AS
SELECT * FROM BillInfo WHERE idBill = @idBill
GO

--ITEM BILL
CREATE PROC ItemBill(
	 @idTable int
)
AS

SELECT Food.name as NameFood, BillInfo.[count] as [SL],BillInfo.id as idBillInfo, Food.price as Price FROM Bill,BillInfo,Food 
WHERE Bill.id = BillInfo.idBill AND BillInfo.idFood = Food.id  AND Bill.idTable = @idTable AND Bill.status = 0
GO

-- CẬP NHẬT BILL INFO
CREATE PROC UpdateBillInfo
@count int ,@id int
AS
UPDATE BillInfo SET count =@count WHERE id = @id
GO

--XÓA BILL INFO
CREATE PROC DelBillInfo
@idBill int,@idFood int
AS
DELETE BillInfo WHERE idBill = @idBill AND idFood = @idFood
GO
--CHECKOUT
CREATE PROC Checkout
@idBill int,
@total float
AS
UPDATE Bill SET status = 1 , total = @total , DateCheckOut = GETDATE() WHERE id = @idBill
GO
--CHUYỂN BÀN BÀN
CREATE PROC MoveTable
@idTable int,
@status NVARCHAR(50),
@idTableTo int,
@idBill int,
@statusTo NVARCHAR(50),
@idTableToCurrent int
AS
UPDATE TableFood SET status = @status WHERE id = @idTable
UPDATE Bill SET idTable = @idTableTo  WHERE id = @idBill
UPDATE TableFood SET status = @statusTo WHERE id = @idTableToCurrent
GO
-- CẬP NHẬT BILL
CREATE PROC UpdateBill
@idTableTo int,
@idBill int,
@total float
AS
UPDATE Bill SET idTable = @idTableTo, total =@total  WHERE id = @idBill
GO
-- DANH SÁCH BILL THEO NGÀY THÁNG NĂM
CREATE PROC ListBillByDate
@fromDate varchar(100),
@toDate varchar(100)
AS
SELECT Bill.id,Bill.DateCheckIn,Bill.DateCheckOut,TableFood.name,Bill.total 
FROM Bill,TableFood 
WHERE Bill.idTable = TableFood.id 
AND Bill.status = 1
AND Bill.DateCheckIn >= @fromDate
AND Bill.DateCheckIn <= @toDate

GO
--TÌM KIẾM HÓA ĐƠN
CREATE PROC SearchBillByDate
@fromDate varchar(100),
@toDate varchar(100),
@name int
AS
SELECT Bill.id,Bill.DateCheckIn,Bill.DateCheckOut,TableFood.name,Bill.total 
FROM Bill,TableFood 
WHERE Bill.idTable = TableFood.id 
AND Bill.status = 1
AND Bill.DateCheckIn >= @fromDate
AND Bill.DateCheckIn <= @toDate
AND Bill.id LIKE @name
GO
--LỌC MÓN THEO DANH MỤC
CREATE PROC ListFoodByCate
@name NVARCHAR(100)
AS
SELECT Food.id,Food.name,Food.price,Food.image 
FROM Food ,FoodCategory 
WHERE Food.idCategory = FoodCategory.id AND FoodCategory.name = @name
GO
--LỌC MÓN THEO GIÁ
CREATE PROC ListFoodByPrice
@price int
AS
IF @price < 20000
SELECT Food.id,Food.name,Food.price,Food.image 
FROM Food ,FoodCategory 
WHERE Food.idCategory = FoodCategory.id AND Food.price < @price
IF (@price >= 20000 AND @price < 50000)
SELECT Food.id,Food.name,Food.price,Food.image 
FROM Food ,FoodCategory 
WHERE Food.idCategory = FoodCategory.id AND Food.price >= @price AND Food.price <= 50000
IF @price > 50000
SELECT Food.id,Food.name,Food.price,Food.image 
FROM Food ,FoodCategory 
WHERE Food.idCategory = FoodCategory.id AND Food.price > 50000
GO
-- DANH SÁCH NHÂN VIÊN
CREATE PROC ListStaff 
AS
	Select * from Staff
GO
-- THÊM NHÂN VIÊN
CREATE PROC InsertStaff
@fullname Nvarchar(100) , 
@phone Nvarchar(12) ,
@address Nvarchar(100) ,
@namelevel  nvarchar(100)
AS
	INSERT INTO Staff(FullName,Phone,Address ,NameLevel) VALUES (@fullname,@phone,@address,@namelevel)
GO
--CẬP NHẬT NHÂN VIÊN
CREATE PROC UpdateStaff 
@id int ,
@fullname Nvarchar(100) , 
@phone Nvarchar(12) ,
@address Nvarchar(100) ,
@namelevel  nvarchar(100)
as 
	UPDATE Staff SET FullName = @fullname , Phone =@phone, Address = @address ,NameLevel = @namelevel where id = @id
GO
--XÓA NHÂN VIÊN
CREATE PROC DeleteStaff
@id int 
as
	DELETE staff where id = @id 
GO
--TÌM KIẾM NHÂN VIÊN
CREATE PROC FindStaff
@fullname Nvarchar(100) 
as
select * from Staff WHERE FullName like '%'+@fullname+'%'
GO
-- THÊM BÀN MỚI
CREATE PROC InsertTable
@name NVARCHAR(100)
AS
INSERT INTO TableFood ([name]) VALUES(@name)
GO
--CẬP NHẬT BÀN ĂN
CREATE PROC UpdateTable
@idTable INT,
@name NVARCHAR(100)
AS
UPDATE TableFood SET name = @name WHERE id = @idTable
GO
--LẤY 1 MÓN THEO ID
CREATE PROC GetFood
@id int
AS
SELECT * FROM Food WHERE id = @id
GO
--LẤY DANH SÁCH LOẠI MÓN
CREATE PROC GetListCate
AS
select * from  FoodCategory
GO
--THÊM MÓN
CREATE PROC InsertFood
@name NVARCHAR(100),
@idCategory int,
@price int,
@image varchar(250)
AS
INSERT INTO Food(name,idCategory,price,image) VALUES(@name,@idCategory,@price,@image)
GO
--CẬP NHẬT MÓN ĂN
CREATE PROC UpdateFood
@name NVARCHAR(100),
@idCategory int,
@price int,
@image varchar(250),
@id int
AS
UPDATE Food SET name = @name, idCategory = @idCategory, price = @price, image = @image WHERE id =@id 








