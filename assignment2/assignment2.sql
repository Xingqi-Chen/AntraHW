-- 1
select count(*) as count from Production.Product

-- 2
select count(*) as count from Production.Product where ProductSubcategoryID is not NULL

-- 3
select ProductSubcategoryID, count(*) as CountedProducts from Production.Product where ProductSubcategoryID is not null group by ProductSubcategoryID

-- 4
select count(*) as count from Production.Product where ProductSubcategoryID is NULL

-- 5
select sum(Quantity) as sum from Production.ProductInventory

-- 6
select ProductID, sum(Quantity) as TheSum from Production.ProductInventory where LocationID = 40 group by ProductID having sum(Quantity) < 100

-- 7
select Shelf, ProductID, sum(Quantity) as TheSum from Production.ProductInventory where Shelf != 'N/A' and LocationID = 40 group by Shelf, ProductID having sum(Quantity) < 100

-- 8
select avg(Quantity)as average from Production.ProductInventory where LocationID = 10

-- 9
select ProductID, Shelf, avg(Quantity) as TheAvg from Production.ProductInventory group by ProductID, Shelf

-- 10
select ProductID, Shelf, avg(Quantity) as TheAvg from Production.ProductInventory where Shelf != 'N/A' group by ProductID, Shelf

-- 11
select Color, Class, count(*) as TheCount, avg(ListPrice) as AvgPrice from Production.Product where Color is not null and Class is not null group by Color, Class

-- 12
select c.Name as Country, s.Name as Province from person.CountryRegion c join person.StateProvince s on c.CountryRegionCode = s.CountryRegionCode 

-- 13
select c.Name as Country, s.Name as Province from person.CountryRegion c join person.StateProvince s on c.CountryRegionCode = s.CountryRegionCode where c.Name in ('Germany', 'Canada')

-- 14
select p.* from Products p join [Order Details] od on p.ProductID = od.ProductID join Orders o on od.OrderID = o.OrderID where o.OrderDate >= DATEADD(year, -25, GETDATE())

-- 15
select top 5 o.ShipPostalCode as 'Zip Code' from Orders o join [Order Details] od on o.OrderID = od.OrderID group by o.ShipPostalCode order by sum(od.Quantity) desc

-- 16
select top 5 o.ShipPostalCode as 'Zip Code' from Orders o join [Order Details] od on o.OrderID = od.OrderID where o.OrderDate >= DATEADD(year, -25, GETDATE()) group by o.ShipPostalCode order by sum(od.Quantity) desc

-- 17
select ShipCity as City, count(distinct CustomerID) as 'Customers Number' from Orders group by ShipCity

-- 18
select ShipCity as City, count(distinct CustomerID) as 'Customers Number' from Orders group by ShipCity having count(distinct CustomerID) > 2

-- 19
select distinct c.ContactName as Name from Orders o join Customers c on o.CustomerID = c.CustomerID where o.OrderDate > '1998-01-01'

-- 20
select c.ContactName as Name, o.md as 'Most Recent Order Date' from Customers c left join (select CustomerID, max(OrderDate) as md from Orders group by CustomerID) o on c.CustomerID = o.CustomerID

-- 21
select c.ContactName as Name, ISNULL(qt.q, 0) as Count from Customers c left join (select o.CustomerID, sum(od.Quantity) as q from Orders o join [Order Details] od on o.OrderID = od.OrderID group by o.CustomerID) qt on c.CustomerID = qt.CustomerID

-- 22
select o.CustomerID, sum(od.Quantity) as q from Orders o join [Order Details] od on o.OrderID = od.OrderID group by o.CustomerID having sum(od.Quantity) > 100

-- 23
select distinct s.CompanyName as 'Supplier Company Name', sp.CompanyName as 'Shipping Company Name' from Suppliers s left join Products p on s.SupplierID = p.SupplierID join [Order Details] od on p.ProductID = od.ProductID join Orders o on o.OrderID = od.OrderID join Shippers sp on o.ShipVia = sp.ShipperID

-- 24
select o.OrderDate, p.ProductName from Orders o join [Order Details] od on o.OrderID = od.OrderID join Products p on od.ProductID = p.ProductID

-- 25
select e1.EmployeeID, e2.EmployeeID from Employees e1 join Employees e2 on e1.Title = e2.Title and e1.EmployeeID < e2.EmployeeID

-- 26
select m.EmployeeID from Employees m join Employees e on m.EmployeeID = e.ReportsTo group by m.EmployeeID having count(e.EmployeeID) > 2

-- 27
select c.City, c.CompanyName as Name, c.ContactName as 'Contact Name', 'Customer' as Type from Customers c
union
select s.City, s.CompanyName as Name, s.ContactName as 'Contact Name', 'Supplier' as Type from Suppliers s