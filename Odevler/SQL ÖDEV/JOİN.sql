use Northwind

select * from Orders O join [Order Details] OD on O.OrderID=Od.OrderID
go
Select * from Products P join Categories C on P.CategoryID=C.CategoryID

--Kategorilerdeki ürünlerin sayýsýný gösteriniz
go
Select C.CategoryName,Count(*)from
Categories C join Products P on C.CategoryID=P.CategoryID
group by C.CategoryName

go

--Çalýþanlarýn sipariþlerini gösteriniz

Select E.FirstName, COUNT(*) from Employees E join Orders O on E.EmployeeID=O.EmployeeID group by E.FirstName

go
--Kategorilerden yapýlan satýþ sayýsýný çýkarýnýz

Select * from
Categories C 
join Products P on C.CategoryID=P.CategoryID 
join [Order Details] OD on P.ProductID=OD.ProductID
join Orders O on OD.OrderID=O.OrderID

go

--Müþteriler hangi ürünleri almýþtýr

Select CS.CompanyName,P.ProductName from 
Customers CS
join Orders O on O.CustomerID=CS.CustomerID
join [Order Details] OD on OD.OrderID=O.OrderID
join Products P on P.ProductID=OD.ProductID