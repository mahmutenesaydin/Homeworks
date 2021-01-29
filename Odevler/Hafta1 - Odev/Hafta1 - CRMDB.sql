Create database CRMDB
go
Use CRMDB
go

Create table Products
(
	Id int primary key Identity,
	Brand varchar(20),
	Name varchar(25),
	Price money,
	Stock int
)
go
Create proc SP_Insert
	@Brand varchar(25),
	@Name varchar(25),
	@Price money,
	@Stock int
as
Insert into Products(Brand,Name,Price,Stock) values(@Brand,@Name,@Price,@Stock)

go

exec SP_Insert 'Xiaomi','Mi Mix 3',3950,25
exec SP_Insert 'Lenovo','IdeaPad 330',6200,20
exec SP_Insert 'Fiat','Doblo',25000,15

go

Create proc SP_Delete
	@Id int
as
Delete from Products where Id=@Id

go

Create proc SP_Update
	@Id int,
	@Brand varchar(25),
	@Name varchar(25),
	@Price money,
	@Stock int
as
Update Products set Brand=@Brand, Name=@Name, Price=@Price, Stock=@Stock
where Id=@Id

go

Create proc SP_Select
as
Select * from Products

