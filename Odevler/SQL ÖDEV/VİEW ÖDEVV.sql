use Northwind
go
create view OrderDetailsView
With Encryption
As
select 
	T.TerritoryID,
	E.Address,
	E.EmployeeID,
	OD.Quantity,
	S.City,
	C.CategoryName,
	Cs.CompanyName,
	R.RegionDescription,
	O.OrderDate,
	Sh.Phone
from [Order Details] OD
inner join Products P on P.ProductID = OD.ProductID
inner join Suppliers S on S.SupplierID = P.SupplierID
inner join Categories C on C.CategoryID = P.CategoryID
inner join Orders O on O.OrderID = OD.OrderID
inner join Shippers Sh on Sh.ShipperID = O.ShipVia
inner join Customers Cs on Cs.CustomerID = O.CustomerID
inner join Employees E on E.EmployeeID = O.EmployeeID
inner join EmployeeTerritories empter on empter.EmployeeID = E.EmployeeID
inner join Territories T on T.TerritoryID = empter.TerritoryID
inner join Region R on R.RegionID = T.RegionID
where OD.OrderID = 10248
go

create view ViewProducts
With Encryption
As
select 
	P.ProductID,
	T.TerritoryID,
	E.Address,
	ET.EmployeeID,
	OD.Quantity,
	Cs.CompanyName,
	R.RegionDescription,
	O.OrderDate,
	Sh.Phone
from Products P
inner join [Order Details] OD on P.ProductID = OD.ProductID
inner join Suppliers spl on spl.SupplierID = P.SupplierID
inner join Categories cat on cat.CategoryID = P.CategoryID
inner join Orders O on O.OrderID = OD.OrderID
inner join Shippers Sh on Sh.ShipperID = O.ShipVia
inner join Customers Cs on Cs.CustomerID = O.CustomerID
inner join Employees E on E.EmployeeID = O.EmployeeID
inner join EmployeeTerritories ET on ET.EmployeeID = E.EmployeeID
inner join Territories T on T.TerritoryID = ET.TerritoryID
inner join Region R on R.RegionID = T.RegionID
where P.ProductID = 3
go

create view ViewSuppliers
With Encryption
As
select 
	S.SupplierID,
	E.Address,
	ET.EmployeeID,
	OD.Quantity,
	S.City,
	C.CategoryName,
	Cs.CompanyName,
	R.RegionDescription,
	O.OrderDate,
	Sh.Phone
from Suppliers S
inner join Products P on S.SupplierID = P.SupplierID
inner join [Order Details] OD on P.ProductID = OD.ProductID
inner join Categories C on C.CategoryID = P.CategoryID
inner join Orders O on O.OrderID = OD.OrderID
inner join Shippers Sh on Sh.ShipperID = O.ShipVia
inner join Customers Cs on Cs.CustomerID = O.CustomerID
inner join Employees E on E.EmployeeID = O.EmployeeID
inner join EmployeeTerritories ET on ET.EmployeeID = E.EmployeeID
inner join Territories ter on ter.TerritoryID = ET.TerritoryID
inner join Region R on R.RegionID = R.RegionID
where S.SupplierID = 4
go

create view ViewCategories
With Encryption
As
select 
	C.CategoryID,
	E.Address,
	ET.EmployeeID,
	OD.Quantity,
	S.City,
	C.CategoryName,
	Cs.CompanyName,
	R.RegionDescription,
	O.OrderDate,
	Sh.Phone
from Categories C 
inner join Products P on P.ProductID = C.CategoryID
inner join [Order Details] OD on OD.ProductID = P.ProductID
inner join Suppliers S on S.SupplierID = S.SupplierID
inner join Orders O on O.OrderID = OD.OrderID
inner join Shippers Sh on Sh.ShipperID =O.ShipVia
inner join Customers Cs on Cs.CustomerID = O.CustomerID
inner join Employees E on E.EmployeeID = O.EmployeeID
inner join EmployeeTerritories ET on ET.EmployeeID = E.EmployeeID
inner join Territories ter on ter.TerritoryID = ET.TerritoryID
inner join Region R on R.RegionID = R.RegionID
where C.CategoryID = 2
go

create view ViewOrders
With Encryption
As
select 
	T.TerritoryID,
	E.Address,
	E.EmployeeID,
	OD.Quantity,
	S.City,
	Cs.CompanyName,
	R.RegionDescription	
from 
Orders ord 
inner join [Order Details] OD on OD.OrderID = OD.OrderID
inner join Products P on P.ProductID = OD.ProductID
inner join Suppliers S on S.SupplierID = P.SupplierID
inner join Categories cat on cat.CategoryID = P.CategoryID
inner join Customers Cs on Cs.CustomerID = Cs.CustomerID
inner join Employees E on E.EmployeeID = E.EmployeeID
inner join EmployeeTerritories ET on ET.EmployeeID = E.EmployeeID
inner join Territories T on t.TerritoryID = ET.TerritoryID
inner join Region R on R.RegionID = T.RegionID
where ord.OrderID = 10248
go

create view ViewShippers
With Encryption
As
select 
	OD.Quantity,
	S.City,
	C.CategoryName,
	Cs.CompanyName,
	R.RegionDescription,
	O.OrderDate,
	Sh.Phone
from Shippers Sh 
inner join Orders O on O.ShipVia = Sh.ShipperID
inner join [Order Details] OD on OD.OrderID = O.OrderID
inner join Products P on P.ProductID = OD.ProductID
inner join Suppliers S on S.SupplierID = P.SupplierID
inner join Categories C on C.CategoryID = P.CategoryID
inner join Customers Cs on Cs.CustomerID = O.CustomerID
inner join Employees emp on emp.EmployeeID = O.EmployeeID
inner join EmployeeTerritories ET on ET.EmployeeID = ET.EmployeeID
inner join Territories ter on ter.TerritoryID = ET.TerritoryID
inner join Region R on R.RegionID = R.RegionID
where sh.ShipperID = 2
go

create view ViewCustomers
With Encryption
As
select 
	Cs.CustomerID,
	T.TerritoryID,
	E.Address,
	ET.EmployeeID,
	OD.Quantity,
	S.City,
	C.CategoryName,
	Cs.CompanyName,
	R.RegionDescription,
	O.OrderDate,
	Sh.Phone
from Customers Cs
inner join Orders O on O.CustomerID = Cs.CustomerID
inner join [Order Details] OD on OD.OrderID = O.OrderID
inner join Products P on P.ProductID = OD.ProductID
inner join Suppliers S on S.SupplierID = P.SupplierID
inner join Categories C on C.CategoryID = P.CategoryID
inner join Shippers sh on sh.ShipperID = O.ShipVia
inner join Employees E on E.EmployeeID = O.EmployeeID
inner join EmployeeTerritories ET on ET.EmployeeID = E.EmployeeID
inner join Territories t on T.TerritoryID = ET.TerritoryID
inner join Region r on r.RegionID = t.RegionID
where Cs.CustomerID = 'VINET'
go

create view ViewEmployees
With Encryption
As
select 
	T.TerritoryID,
	E.Address,
	E.EmployeeID,
	OD.Quantity,
	S.City,
	C.CategoryName,
	Cs.CompanyName,
	R.RegionDescription,
	O.OrderDate,
	Sh.Phone
from Employees E 
inner join Orders O on O.EmployeeID = E.EmployeeID
inner join [Order Details] OD on OD.OrderID = o.OrderID
inner join Products p on p.ProductID = od.ProductID
inner join Suppliers s on s.SupplierID = p.SupplierID
inner join Categories c on c.CategoryID = p.CategoryID
inner join Shippers sh on sh.ShipperID = o.ShipVia
inner join Customers cs on cs.CustomerID = o.CustomerID
inner join EmployeeTerritories et on et.EmployeeID = e.EmployeeID
inner join Territories t on t.TerritoryID = et.TerritoryID
inner join Region r on r.RegionID = t.RegionID
where e.EmployeeID = 5
go

create view ViewEmployeeTerritories
With Encryption
As
select 
	T.TerritoryID,
	E.Address,
	E.EmployeeID,
	OD.Quantity,
	S.City,
	Cs.CompanyName,
	R.RegionDescription,
	O.OrderDate,
	Sh.Phone
from EmployeeTerritories  ET
inner join Employees e on e.EmployeeID = et.EmployeeID
inner join Orders o on o.EmployeeID = e.EmployeeID
inner join [Order Details] od on od.OrderID = o.OrderID
inner join Products p on et.EmployeeID = e.EmployeeID
inner join Suppliers s on s.SupplierID = p.SupplierID
inner join Categories cat on cat.CategoryID = p.CategoryID
inner join Shippers sh on sh.ShipperID = o.ShipVia
inner join Customers cs on cs.CustomerID = o.CustomerID
inner join Territories t on t.TerritoryID = et.TerritoryID
inner join Region r on r.RegionID = t.RegionID
where et.EmployeeID = 6
go

create view ViewTerritories
With Encryption
As
select 
	T.TerritoryID,
	E.Address,
	E.EmployeeID,
	OD.Quantity,
	S.City,
	C.CategoryName,
	Cs.CompanyName,
	R.RegionDescription,
	O.OrderDate,
	Sh.Phone
from Territories T
inner join EmployeeTerritories et on t.TerritoryID = et.TerritoryID
inner join Employees e on e.EmployeeID = et.EmployeeID
inner join Orders o on o.EmployeeID = e.EmployeeID
inner join [Order Details] od on od.OrderID = o.OrderID
inner join Products p on et.EmployeeID = e.EmployeeID
inner join Suppliers s on s.SupplierID = p.SupplierID
inner join Categories c on c.CategoryID = p.CategoryID
inner join Shippers sh on sh.ShipperID = o.ShipVia
inner join Customers cs on cs.CustomerID = o.CustomerID
inner join Region r on r.RegionID = t.RegionID
where t.TerritoryID = 01581
go
select * from OrderDetailsView
go
select * from ViewCategories
go
select * from ViewProducts
go
select * from ViewShippers
go
select * from ViewSuppliers
go
select * from ViewTerritories
go
select * from ViewEmployees
go
select * from ViewEmployeeTerritories
go
select * from ViewOrders
go 
select * from Viewcustomers