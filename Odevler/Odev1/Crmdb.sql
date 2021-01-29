Create database CRMDb
go
Use CRMDb
go

Create table Products
(
	Id int primary key Identity,
	Name nvarchar(50),
	Price money,
	Stock int
)

go

Create proc SP_Insert
	@Name nvarchar(50),
	@Price money,
	@Stock int
as
Insert into Products(Name,Price,Stock) values(@Name,@Price,@Stock)

go

Create proc SP_Update
	@Id int,
	@Name nvarchar(50),
	@Price money,
	@Stock int
as
Update Products set Name=@Name, Price=@Price, Stock=@Stock
where Id=@Id

go

Create proc SP_Delete
	@Id int
as
Delete from Products where Id=@Id

go

Create proc SP_Select
as
Select * from Products