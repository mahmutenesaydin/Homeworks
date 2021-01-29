use Northwind

select * from Orders O join [Order Details] OD on O.OrderID=Od.OrderID
go
Select * from Products P join Categories C on P.CategoryID=C.CategoryID

--Kategorilerdeki �r�nlerin say�s�n� g�steriniz
go
Select C.CategoryName,Count(*)from
Categories C join Products P on C.CategoryID=P.CategoryID
group by C.CategoryName

go

--�al��anlar�n sipari�lerini g�steriniz

Select E.FirstName, COUNT(*) from Employees E join Orders O on E.EmployeeID=O.EmployeeID group by E.FirstName

go
--Kategorilerden yap�lan sat�� say�s�n� ��kar�n�z

Select * from
Categories C 
join Products P on C.CategoryID=P.CategoryID 
join [Order Details] OD on P.ProductID=OD.ProductID
join Orders O on OD.OrderID=O.OrderID

go

--M��teriler hangi �r�nleri alm��t�r

Select CS.CompanyName,P.ProductName from 
Customers CS
join Orders O on O.CustomerID=CS.CustomerID
join [Order Details] OD on OD.OrderID=O.OrderID
join Products P on P.ProductID=OD.ProductID