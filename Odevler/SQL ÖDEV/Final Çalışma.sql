     /* SCALAR*/

Create Function Topla
(
	@Sayi1 int,
	@Sayi2 int
)
returns int
as
Begin
	Return @Sayi1 + @Sayi2
End

Select dbo.Topla(2,5) --Results
print dbo.Topla(10,30)--Messages

--------------

create Function Maliyet
(
	@BirimFiyat int,
	@StokMiktar� int
)
Returns nvarchar(max)
as
Begin
	Return @BirimFiyat * @StokMiktar� * 1.18
End	

Select dbo.Maliyet (10,20)
print dbo.Maliyet(10,20)

go

---------------
use Northwind
go
	/*STORED PROCEDURE*/

--Geriye De�er D�nd�ren SP 


Create Procedure UrunGetir
(
	@Fiyat Money
)
as
Select * from Products where UnitPrice > @Fiyat
Return @@Rowcount

exec UrunGetir 40

go

----- OUTPUT Parametresi ile de�er d�nd�rme

Create Proc OutputDe�er
(
	@ID int,
	@Adi nvarchar(max) OUTPUT,
	@Soyadi nvarchar(max) OUTPUT
)
as
Select FirstName=@Adi,LastName=@Soyadi from Employees where EmployeeID=@ID

Declare @Adi nvarchar(max),@Soyadi nvarchar(max)
exec OutputDe�er 1,@Adi output,@Soyadi output
select @Adi+ ' ' + @Soyadi

select * from Employees

go


-----------------------------

		/*TR�GGER*/

Create Trigger Ornek1
On Employees
After Insert
as 
Select * from Employees

Insert Employees(FirstName,LastName) values('Mahmut','Ayd�n')


--Tedarik�iler(Suppliers)tablosundan bir veri silindi�inde t�m �r�nlerin fiyat� otomatik olarak 10 arts�n

Create Trigger SuppliersArt�ON
on Suppliers
After Delete
as
Update Products set UnitPrice=UnitPrice+10
select * from Products

Delete from Suppliers where SupplierID=36


