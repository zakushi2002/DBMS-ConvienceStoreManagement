--Tao Co So Du Lieu
CREATE DATABASE StoreManagement
GO
USE StoreManagement
GO
--Phan Code Tao Bang
--Nhan Vien
CREATE TABLE [dbo].[Employee] (
 [eid] nchar(20) NOT NULL,
 [ename] nchar(40) NOT NULL,
 [ebirthdate] date NULL,
 [egender] nchar(15) NULL,
 [ephone] nchar(15) NULL,
 [eaddress] nchar(50) NULL,
 [eposition] nchar(40) NULL,
 [esalary] float NULL,
 [eimage] image NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([eid] ASC),
)
Go
--Tai Khoan
CREATE TABLE [Account] (
 [ausername] nchar(15) NOT NULL,
 [apassword] int NOT NULL,
 [eid] nchar(20) NOT NULL,
 [aemail] VARCHAR(100) NULL,
 [active] BIT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([ausername] ASC),
 CONSTRAINT [FK_Account_Employee_eid] FOREIGN KEY ([eid]) REFERENCES [Employee] ([eid]) ON DELETE CASCADE ON UPDATE CASCADE,
 CONSTRAINT [CK_Account_aemail] CHECK ([aemail] like '%_@%_._%')
)
Go
--Khach Hang
CREATE TABLE [Customer] (
 [cid] nchar(20) NOT NULL,
 [cname] nchar(40) NULL,
 [ctotalpay] float NULL,
 [cphone] nchar(15) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([cid] ASC)
)

Go
--Loai San Pham
CREATE TABLE [Type] (
 [tid] nchar(20) NOT NULL,
 [tname] nchar(20) NOT NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED ([tid] ASC),
)
Go
--Kho Hang
CREATE TABLE [Stock] (
 [batchid] nchar(20) NOT NULL,
 [importdate] date NULL,
 [amountofproduct] int NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED ([batchid] ASC),
)
Go
--Nha San Xuat
CREATE TABLE [Manuafacture] (
 mid nchar(20) NOT NULL,
 mname nchar(40) NULL,
 CONSTRAINT [PK_Manuafacture] PRIMARY KEY CLUSTERED ([mid] ASC),
)
Go
--San Pham
CREATE TABLE [Product] (
 [pid] nchar(20) NOT NULL,
 [pname] nchar(30) NOT NULL,
 [pprice] float NOT NULL,
 [tid] nchar(20) NOT NULL,
 [unitname] nchar(20) NULL,
 [pimage] image NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([pid] ASC),
 CONSTRAINT [FK_Product_Type_tid] FOREIGN KEY ([tid]) REFERENCES [Type] ([tid]) ON UPDATE CASCADE
)
Go
--Hoa Don
CREATE TABLE [Invoice] (
 iid nchar(20) NOT NULL,
 eid nchar(20) NOT NULL,
 cid nchar(20) NULL,
 idate datetime NULL,
 itotalpay float NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED ([iid] ASC),
 CONSTRAINT [FK_Invoice_Employee_eid] FOREIGN KEY ([eid]) REFERENCES [Employee] ([eid]) ON UPDATE CASCADE ON DELETE CASCADE,
 CONSTRAINT [FK_Invoice_Customer_cid] FOREIGN KEY ([cid]) REFERENCES [Customer] ([cid]) ON UPDATE CASCADE ON DELETE CASCADE
)
Go
--Chi Tiet Hoa Don
CREATE TABLE [Detail] (
 iid nchar(20) NOT NULL,
 pid nchar(20) NOT NULL,
 damount int NULL,
 dprice float NULL,
 
 CONSTRAINT [PK_Detail] PRIMARY KEY CLUSTERED ([iid] ASC, [pid]),
 CONSTRAINT [FK_Detail_Invoice_iid] FOREIGN KEY ([iid]) REFERENCES [Invoice] ([iid]) ON DELETE CASCADE ON UPDATE CASCADE,
 CONSTRAINT [FK_Detail_Product_pid] FOREIGN KEY ([pid]) REFERENCES [Product] ([pid]) ON DELETE CASCADE ON UPDATE CASCADE
)
Go
--Quan he 3 ngoi cung cap san pham
CREATE TABLE [Supply] (
 [pid] nchar(20) NOT NULL,
 [batchid] nchar(20) NOT NULL,
 [mid] nchar(20) NOT NULL,
 CONSTRAINT [PK_Supply] PRIMARY KEY CLUSTERED ([pid] ASC, [batchid], [mid]),
 CONSTRAINT [FK_Supply_Supply_batchid] FOREIGN KEY ([batchid]) REFERENCES [Stock] ([batchid]) ON DELETE CASCADE ON UPDATE CASCADE,
 CONSTRAINT [FK_Supply_Supply_mid] FOREIGN KEY ([mid]) REFERENCES [Manuafacture] ([mid]) ON DELETE CASCADE ON UPDATE CASCADE,
 CONSTRAINT [FK_Supply_Supply_pid] FOREIGN KEY ([pid]) REFERENCES [Product] ([pid]) ON DELETE CASCADE ON UPDATE CASCADE
)
Go


USE StoreManagement
--26 Stored Procedures_7 DELETE_9 ADD_8 UPDATE_1 FIND_1 LIST
GO

--AddAccount
CREATE PROC [dbo].[SP_AddAccount] 
@user NCHAR(15),
@pass INT,
@type NCHAR(20),
@mail VARCHAR(100),
@status BIT
AS
BEGIN
INSERT INTO Account(ausername,apassword,eid,aemail,active) VALUES(@user,@pass,@type,@mail,@status)
END
Go

--AddEmployee
Create Proc SP_AddEmployee
@id nchar(20),
@name nchar(40), 
@birthdate date, 
@gender nchar(15),
@phone nchar(15), 
@address nchar(50),
@position nchar(40), 
@salary float,
@image image
As
Begin
if(year(getdate())-year(@birthdate)>18)
begin
INSERT INTO Employee (eid, ename, ebirthdate, egender, ephone, eaddress, eposition, esalary, eimage)
Values(@id,@name, @birthdate, @gender, @phone, @address, @position, @salary,@image)
end
else begin
Print('Invalid Age') Rollback TRANSACTION
end
End
GO
--Exec SP_AddEmployee @id='301',@name='TITEO', @birthdate='4/6/2000', @gender='Male', @phone='', @address='', @position='Manager', @salary=10000,@image=''

--UpdateEmployee
Create Proc SP_UpdateEmployee
@id nchar(20),
@name nchar(40), 
@birthdate date, 
@gender nchar(15),
@phone nchar(15), 
@address nchar(50), 
@position nchar(40), 
@salary float,
@image image
As
Begin 
if(year(getdate())-year(@birthdate)>18)
begin
Update Employee SET ename=@name, ebirthdate=@birthdate, egender=@gender, ephone=@phone, eaddress=@address,eposition=@position, esalary=@salary, eimage=@image WHERE Employee.eid=@id
end
else begin
print('Invalid Age') Rollback TRAN
end
End
Go
--Exec SP_UpdateEmployee @id='300',@name='TITEOTEOTEO', @birthdate='4/6/2000', @gender='nu', @phone='', @address='', @mail='thiendz@ff.com', @position='', @salary=10000,@image=''
--DeleteEmployee
Create Proc SP_DeleteEmployee
@id nchar(20)
As
Begin Delete From Employee Where Employee.eid=@id
end
Go
--Exec SP_DeleteEmployee @id='300'

--List Employee
Create Proc SP_ListEmployee
As
Begin
Select eid AS [Employee ID],ename AS [Name],ebirthdate AS [Birthdate],egender AS [Gender],ephone AS [Phone],eaddress AS [Address],eposition AS [Position],esalary AS [Salary],eimage AS [Image] From Employee
end
Go

--Find Employee
Create Proc SP_FindEmployee
@find VARCHAR(MAX)
As
Begin
Select eid AS [Employee ID],ename AS [Name],ebirthdate AS [Birthdate],egender AS [Gender],ephone AS [Phone],eaddress AS [Address],eposition AS [Position],esalary AS [Salary],eimage AS [Image] From Employee Where CONCAT(ename,eposition) LIKE '%'+@find+'%'
End
Go

--AddCustomer
Create Proc SP_AddCustomer
@c nchar(20), 
@name nchar(40), 
@total float, 
@phone nchar(15)
As
Begin
if(@phone like '0%' AND Len(@phone)=10)
begin
INSERT INTO Customer (cid, cname, ctotalpay, cphone) Values (@c,@name,@total,@phone)
end
else begin
Print('Invalid Phone') Rollback TRANSACTION
end
End
Go

--Add Product
Create Proc SP_AddProduct
@id nchar(20),
@name nchar(30),
@price float,
@typeid nchar(20),
@unitname nchar(20),
@image image
As
Begin
INSERT INTO Product (pid, pname, pprice, tid,unitname,pimage) Values (@id,@name,@price,@typeid,@unitname,@image)
End
Go

--Update Product
Create Proc SP_UpdateProduct
@id nchar(20),
@name nchar(30),
@price float,
@typeid nchar(20),
@unitname nchar(20),
@image image
As
Begin Update Product Set pname=@name, pprice=@price,tid=@typeid,unitname=@unitname,pimage=@image Where pid=@id
End
go

--Delete Product
Create Proc SP_DeleteProduct
@id nchar(20)
As
Begin Delete From Product Where pid=@id
End
Go

--Add Invoice
Create Proc SP_AddInvoice
@i nchar(20),
@e nchar(20), 
@c nchar(20), 
@date datetime, 
@total float
AS
Begin
INSERT INTO Invoice (iid, eid, cid, idate, itotalpay)  VALUES (@i,@e, @c, @date, @total)
End
Go

--Update Invoice
Create Proc [dbo].[SP_UpdateInvoice]
@i nchar(20),
@e nchar(20), 
@c nchar(20) NULL, 
@date datetime, 
@total float
As
Begin 
Update Invoice Set eid=@e,cid=@c,idate=@date,itotalpay=@total WHERE iid=@i
End
Go

--Delete Invoice
Create Proc SP_DeleteInvoice
@i nchar(20)
As
Begin DELETE FROM Invoice WHERE iid =@i
End
Go

--Add Detail
CREATE Proc [dbo].[SP_AddDetail]
@id nchar(20),
@pid nchar(20),
@amount int,
@price float
As
Begin INSERT INTO Detail (iid, pid, damount,dprice)  VALUES (@id,@pid, @amount, @price)
End
Go

--Update Detail
Create Proc SP_UpdateDetail
@id nchar(20),
@pid nchar(20),
@amount int,
@price float
As
Begin Update Detail Set pid=@pid,damount=@amount,dprice=@price Where iid=@id
End
Go

--Delete Detail
Create Proc [dbo].[SP_DeleteDetail]
@id nchar(20),
@pid NCHAR(20)
AS
Begin Delete From Detail Where iid=@id AND pid =@pid
End
GO

--AddManuafacture
Create Proc SP_AddManuafacture
@mid nchar(20),
@name nchar(40)
As
Begin INSERT INTO Manuafacture (mid, mname)  VALUES (@mid,@name)
End
Go

--UpdateManuafacture
Create Proc SP_UpdateManuafacture
@mid nchar(20),
@name nchar(40)
AS
Begin Update Manuafacture Set mname=@name Where mid=@mid
End
Go

--DeleteManuafacture
Create Proc SP_DeleteManuafacture
@mid nchar(20)
As
Begin Delete From Manuafacture Where mid=@mid
End
Go

--AddStock
Create Proc SP_AddStock
@batid nchar(20),
@date date,
@amount int
As
Begin INSERT INTO Stock (batchid,importdate,amountofproduct) Values (@batid,@date,@amount)
End
Go
--Update Stock
Create Proc SP_UpdateStock
@batid nchar(20),
@date date,
@amount int
As
Begin Update Stock Set importdate=@date,amountofproduct=@amount Where batchid=@batid
End 
Go
--Delete Stock
Create Proc SP_DeleteStock
@batid nchar(20)
As
Begin Delete From Stock Where batchid=@batid
End 
Go

--Add Supply
Create Proc SP_AddSupply
@pid nchar(20),
@batid nchar(20),
@mid nchar(20)
As
Begin INSERT INTO Supply (pid,batchid,mid) Values (@pid,@batid,@mid)
End
Go

--Add Type
Create Proc SP_AddTypes
@tid nchar(20),
@name nchar(20)
As
Begin INSERT INTO [Type] (tid,tname) Values (@tid,@name)
End
Go

--Update Type
Create Proc SP_UpdateType
@tid nchar(20),
@name nchar(20)
As
Begin Update [Type] Set tname=@name Where tid=@tid
End
Go

--Delete Type
Create Proc SP_DeleteType
@tid nchar(20)
As
Begin Delete From [Type] Where tid=@tid
End 
Go

--UpdateInvoiceNotCustomer
CREATE Proc [dbo].[SP_UpdateInvoiceNotCustomer]
@i nchar(20),
@e nchar(20), 
@date datetime, 
@total float
As
Begin
Update Invoice Set eid=@e,idate=@date,itotalpay=@total WHERE iid=@i
End
go
--_____________________________________________________________________________________________________________________________________________________________________________________________________



--View 5
USE StoreManagement
GO
--Thong tin kho hang_ManageStock_Form  C#
CREATE VIEW V_Stock AS SELECT batchid AS [Batch ID], importdate AS [Import Date], amountofproduct [Amount Of Product] FROM [Stock]
GO
--Loai san pham_ManageType_ Form C#
CREATE VIEW V_Type AS SELECT tid AS [Type ID], tname AS [Type Name] FROM [Type]
GO
--Thong tin san pham_ManageProduct_ListProduct_EmployeeMainForm_Form C#
CREATE VIEW V_Product AS Select pid AS [Product ID],pname AS [Product Name],pprice AS [Price], tid AS [Type ID], unitname AS [Unit], pimage AS [Image] From [Product]
GO
--Thong tin san pham (ngoai tru tid va unitname)_ManageInvoice_EmployeeMainForm_Form C#
CREATE VIEW V_Product_Invoice AS Select pid AS [Product ID],pname AS [Product Name],pprice AS [Price], pimage AS [Image] From [Product]
GO
--Thong tin khach hang_ListCustomer_Form C#
CREATE VIEW V_Customer AS SELECT cid AS [ID], cname as [Name], cphone as [Phone] FROM [Customer]
GO

--______________________________________________________________________________________________________________________________________________________________________________________________________



--Function 13
USE StoreManagement 
GO

-- Tim san pham theo ten va loai san pham(ky tu)
CREATE FUNCTION FN_FindProduct(@string VARCHAR(MAX))
RETURNS TABLE
AS
RETURN
(
    Select * FROM V_Product WHERE CONCAT([Product Name],[Type ID]) LIKE '%'+@string+'%'
)
GO
--Tim khach hang theo SDT_ManageInvoice
CREATE FUNCTION FN_FindCustomer(@Search NCHAR(15))
RETURNS TABLE
AS
RETURN
(
    SELECT cid, cname FROM Customer WHERE cphone =@Search
)
GO
--Select * FROM FN_FindCustomer('0395817795')

--Tong so nhan ven
CREATE FUNCTION FN_CountEmployee()
RETURNS INT
AS
BEGIN
	DECLARE @SL INT
	SELECT @SL=Count(eid) FROM Employee
	RETURN @SL
END
GO
--PRINT dbo.fn_CountEmployee()

--Tong so khach hang
CREATE FUNCTION FN_CountCustomer()
RETURNS INT
AS
BEGIN
	DECLARE @SLKH INT
	SELECT @SLKH=Count(cid) FROM Customer
	RETURN @SLKH
END
GO
--PRINT dbo.fn_CountCustomer()

--Tong so san pham
CREATE FUNCTION FN_CountProducts()
RETURNS INT
AS
BEGIN
	DECLARE @SLSP INT
	SELECT @SLSP=Count(pid) FROM Product
	RETURN @SLSP
END
GO
--PRINT dbo.fn_CountProducts()

--Kiem tra dang nhap_Nut Login_LoginForm
CREATE FUNCTION FN_CheckAccount(@user NCHAR(15),@pass INT)
RETURNS TABLE
AS
RETURN
(
    select * from Account where ausername = @user and apassword = @pass
)
GO
--Select * From FN_SearchInvoice('1')

--Hoa don theo thang
Create Function FN_Statics(@tmp date)
Returns int
As
Begin
Declare @A int
Select @A=SUM(itotalpay) From Invoice Where MONTH(@tmp)=MONTH(idate)
Return @A
End
Go
--Print dbo.FN_Statics('12/2/2002')

--Hien thi chi tiet hoa don theo ma hoa don iid_ManageInvoice
Create Function FN_ShowDetail(@iid nchar(20))
returns Table
As
Return (
Select *From Detail Where iid=@iid
)
Go
--Select * From Fn_ShowDetail('1')

--Tu dong hien hien thong tin san pham theo o Product ID_ManageInvoice_Form
Create Function [dbo].[FN_AutoShowProductInfo](@id NCHAR(20))
Returns Table
As
Return
(
Select pname,pprice,unitname, pimage FROM Product WHERE pid=@id
)
GO
--SELECT * FROM FN_AutoShowProductInfo('BW1')

--Tong tien phai tra cua hoa don_ManageInvoice_Form
CREATE FUNCTION [dbo].[FN_GetTotalPay](@iid NCHAR(20))
RETURNS float
AS
BEGIN
	DECLARE @total float
	SELECT @total=itotalpay FROM Invoice WHERE iid=@iid
	RETURN @total
END
GO

--ManageInvoice_Employee_Form
CREATE FUNCTION [dbo].[FN_SearchEmployeeByID](@eid nchar(40) null)
RETURNS TABLE
AS
RETURN
(
	SELECT * FROM Employee 
	WHERE eid =@eid
)
GO
--Thong ke gioi tinh nhan vien_Statistics
Create Function Fn_ListGender(@gen nchar(10))
RETURNS INT
AS
BEGIN
	DECLARE @SL INT
	SELECT @SL=Count(eid) FROM Employee Where egender=@gen
	RETURN @SL
END
Go
--Print dbo.Fn_ListGender('Male')


--Phan Quyen
USE StoreManagement
GO
--Quyen Hanh Cua Nhan Vien
Create Role employee
--View for employee
GRANT SELECT ON FN_CheckAccount TO employee
GRANT SELECT ON V_Product TO employee
--Execute
GRANT EXECUTE ON SP_UpdateInvoice TO employee
GRANT EXECUTE ON SP_UpdateInvoiceNotCustomer TO employee
GRANT EXECUTE ON SP_AddInvoice TO employee
GRANT EXECUTE ON SP_AddCustomer TO employee
GRANT EXECUTE ON SP_AddDetail TO employee
GRANT EXECUTE ON SP_DeleteDetail TO employee
GO


USE StoreManagement
GO

Create ROLE manager
GRANT SELECT ON FN_CheckAccount TO manager
GRANT SELECT ON V_Product TO manager
GRANT SELECT ON V_Customer TO manager
GRANT EXECUTE ON SP_AddInvoice TO manager
GRANT EXECUTE ON SP_AddCustomer TO manager
GRANT EXECUTE ON SP_AddDetail TO manager
GRANT EXECUTE ON SP_AddEmployee TO manager
GRANT EXECUTE ON SP_AddAccount TO manager

GRANT EXECUTE ON SP_AddManuafacture TO manager
GRANT EXECUTE ON SP_AddProduct TO manager
GRANT EXECUTE ON SP_AddStock TO manager
GRANT EXECUTE ON SP_AddSupply TO manager
GRANT EXECUTE ON SP_AddTypes TO manager
GRANT EXECUTE ON SP_DeleteDetail TO manager
GRANT EXECUTE ON SP_DeleteEmployee TO manager
GRANT EXECUTE ON SP_DeleteInvoice TO manager
GRANT EXECUTE ON SP_DeleteManuafacture TO manager
GRANT EXECUTE ON SP_DeleteProduct TO manager
GRANT EXECUTE ON SP_DeleteStock TO manager
GRANT EXECUTE ON SP_DeleteType TO manager
GRANT EXECUTE ON SP_FindEmployee TO manager
GRANT EXECUTE ON SP_ListEmployee TO manager
GRANT EXECUTE ON SP_UpdateDetail TO manager
GRANT EXECUTE ON SP_UpdateEmployee TO manager
GRANT EXECUTE ON SP_UpdateInvoice TO manager
GRANT EXECUTE ON SP_UpdateInvoiceNotCustomer TO manager
GRANT EXECUTE ON SP_UpdateManuafacture TO manager
GRANT EXECUTE ON SP_UpdateProduct TO manager
GRANT EXECUTE ON SP_UpdateStock TO manager
GRANT EXECUTE ON SP_UpdateType TO manager
Go

--Trigger cho viec phan quyen tu dong
Use StoreManagement
GO

--Phan quyen tai khoan khi tao tai khoan username, password tu bang Account
CREATE TRIGGER CreateUserLogin ON Account
FOR INSERT
AS
BEGIN
	DECLARE @user NCHAR(15), @password INT, @type NCHAR(20), @db_name NVARCHAR(MAX), @active BIT
	SET @db_name = DB_NAME()
	SELECT @user = ausername, @password = apassword, @type = eid, @active = active
	FROM inserted
	
	EXEC('CREATE LOGIN [' + @user + '] WITH PASSWORD = '''+ @password +''', DEFAULT_DATABASE=[' + @db_name + ']')
	EXEC('CREATE USER [' + @user + '] FOR LOGIN [' + @user + ']')

	IF @type LIKE 'manager%'
	BEGIN
		EXEC sp_addrolemember 'db_owner', @user
		EXEC sp_addrolemember 'db_accessadmin', @user
		EXEC sp_addrolemember 'db_securityadmin', @user
		EXEC sp_addrolemember 'manager', @user
		EXEC('USE master; GRANT ALTER ANY LOGIN TO [' + @user + '] WITH GRANT OPTION')
	END
	ELSE IF @type LIKE 'employee%'
	BEGIN
		EXEC sp_addrolemember 'employee', @user
	END
	IF @active = 0
		EXEC('ALTER LOGIN [' + @user + '] DISABLE')
	ELSE
		EXEC('ALTER LOGIN [' + @user + '] ENABLE')
END
GO
USE StoreManagement
GO
CREATE TRIGGER UpdateUserLogin ON Account
FOR UPDATE
AS
BEGIN
	DECLARE @old_active BIT, @new_active BIT, @old_user NCHAR(15), @new_user NCHAR(15), @old_password INT, @new_password INT, @type NCHAR(20), @db_name NVARCHAR(MAX)
	SET @db_name = DB_NAME()
	SELECT @old_user = ausername, @old_password = apassword, @old_active = active
	FROM deleted
	SELECT @new_user = ausername, @new_password = apassword, @type = eid, @new_active = active
	FROM inserted

	IF (@new_user = @old_user AND @new_password = @old_password AND @old_active = @new_active)
		RETURN
	ELSE IF (@new_user <> @old_user) --Quan Ly
	BEGIN
		EXEC('DROP USER [' + @old_user + ']')
		EXEC('DROP LOGIN [' + @old_user + ']')
		EXEC('CREATE LOGIN [' + @new_user + '] WITH PASSWORD = ''' + @new_password + ''', DEFAULT_DATABASE=[' + @db_name + ']')
		EXEC('CREATE USER [' + @new_user + '] FOR LOGIN [' + @new_user + ']')
		IF @type LIKE 'manager%'
		BEGIN
			EXEC sp_addrolemember 'db_owner', @new_user
			EXEC sp_addrolemember 'db_accessadmin', @new_user
			EXEC sp_addrolemember 'db_securityadmin', @new_user
			EXEC sp_addrolemember 'manager', @new_user
			EXEC('USE master; GRANT ALTER ANY LOGIN TO [' + @new_user + '] WITH GRANT OPTION')
		END
		ELSE IF @type LIKE 'employee%'
		BEGIN
			EXEC sp_addrolemember 'employee', @new_user
			EXEC('USE master; GRANT ALTER ANY LOGIN TO [' + @new_user + '] WITH GRANT OPTION')
		END
	END
	ELSE IF (@new_password <> @old_password) --Ca 2
	BEGIN
		EXEC('ALTER LOGIN [' + @new_user + '] WITH PASSWORD = ''' + @new_password + ''' OLD_PASSWORD = ''' + @old_password + '''')
	END
	ELSE --Quan Ly
	BEGIN
		IF @new_active = 0
			EXEC('ALTER LOGIN [' + @new_user + '] DISABLE')
		ELSE
			EXEC('ALTER LOGIN [' + @new_user + '] ENABLE')
	END
END
GO
CREATE TRIGGER DeleteUserLogin ON Account
FOR DELETE
AS
BEGIN
	DECLARE @user NCHAR(15)
	
	SELECT @user = ausername
	FROM deleted
	
	EXEC('DROP USER [' + @user + ']')
	EXEC('DROP LOGIN [' + @user + ']')
END
GO

--Trigger can thiet cho viec xu ly hoa don
USE StoreManagement
GO
CREATE TRIGGER [dbo].[Update_TotalPay_Invoice] ON [dbo].[Detail] 
AFTER INSERT
AS
BEGIN
	DECLARE @totalamount float, @iid nchar(20), @sum float
	Select @iid=iid From inserted
	SELECT @totalamount=damount*dprice FROM inserted
	Select @sum= Sum(itotalpay) From Invoice Where invoice.iid=@iid
	UPDATE Invoice SET itotalpay= @sum + @totalamount Where Invoice.iid=@iid
END
GO
CREATE TRIGGER [dbo].[Decrease_TotalPay_Invoice] ON [dbo].[Detail] 
AFTER DELETE
AS
BEGIN
	DECLARE @totalamount float
	SELECT @totalamount=damount*dprice FROM deleted
	UPDATE Invoice SET itotalpay= itotalpay - @totalamount
END
GO
CREATE TRIGGER [dbo].[CheckInvoice_Exist] ON [dbo].[Detail] INSTEAD OF INSERT
AS
BEGIN
	Declare @tmp int, @tmp1 nchar(20)
	Select @tmp1=iid from inserted
	--Select @tmp=Count(Invoice.iid) From Invoice Where Invoice.iid=@tmp1
	DECLARE @totalamount float
	DECLARE @pid NCHAR(20), @dprice float, @damount int
	SELECT @pid=pid, @dprice=dprice, @damount=damount  FROM inserted  
	SELECT @totalamount  =  damount*dprice FROM inserted 
	
	If Exists( Select iid From Invoice Where iid=@tmp1)
	begin
		
		if Exists(Select pid From Detail Where pid=@pid and iid=@tmp1)
		begin
		Update Detail Set damount=damount+@damount Where pid=@pid and iid=@tmp1
		end
		else
		begin
		INSERT INTO Detail(iid,pid,damount,dprice) VALUES(@tmp1,@pid,@damount,@dprice)
		end
	End
	Else 
		BEGIN
			DECLARE @date datetime
			SET @date =getdate()
			Insert Into Invoice(iid,eid,idate,itotalpay) Values(@tmp1,'manager1',@date,0)
			INSERT INTO Detail(iid,pid,damount,dprice) VALUES(@tmp1,@pid,@damount,@dprice)
		END
END
GO
CREATE TRIGGER [dbo].[UpdateInvoice] ON [dbo].[Detail] 
AFTER Update
AS
BEGIN
	Declare @damount int ,@dprice float,@iid nchar(20),@pid nchar(20),@sum float,@total float
	Select @pid=pid,@iid=iid from inserted
	Select @damount=damount,@dprice=dprice,@iid=iid From Detail Where iid=@iid
	select @total=Sum(damount*dprice) From Detail Where iid=@iid
	
	Update Invoice Set itotalpay=0 Where Invoice.iid=@iid
	Select @sum= Sum(itotalpay) From Invoice Where invoice.iid=@iid
	UPDATE Invoice SET itotalpay= @total+@sum Where Invoice.iid=@iid
END
GO


--2 Tai khoan phan quyen thu cong
--Tai khoan quan ly (Ho tro C# Test App)

CREATE LOGIN [managerAdmin] WITH PASSWORD ='1', DEFAULT_DATABASE = [StoreManagement]
CREATE USER [managerAdmin] FOR LOGIN [managerAdmin]
EXEC sp_addrolemember 'db_owner',[managerAdmin]
EXEC sp_addrolemember 'db_accessadmin',[managerAdmin]
EXEC sp_addrolemember 'db_securityadmin',[managerAdmin]
EXEC sp_addrolemember 'manager',[managerAdmin]
USE master; GRANT ALTER ANY LOGIN TO [managerAdmin] WITH GRANT OPTION
ALTER LOGIN [managerAdmin] ENABLE
--Tai khoan nhan vien
CREATE LOGIN [employeeTest] WITH PASSWORD ='1', DEFAULT_DATABASE = [StoreManagement]
CREATE USER [employeeTest] FOR LOGIN [employeeTest]
EXEC sp_addrolemember 'employee',[employeeTest]
USE master; GRANT ALTER ANY LOGIN TO [employeeTest] WITH GRANT OPTION
ALTER LOGIN [employeeTest] ENABLE
go