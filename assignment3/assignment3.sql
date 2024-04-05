-- 1
select distinct e.City from Employees e join Customers c on e.City = c.City

-- 2.a
select distinct c.city from Customers c where c.city not in (select distinct e.city from Employees e)

-- 2.b
select distinct c.city from Customers c left join Employees e on c.City = e.City where e.City is NULL

-- 3
select p.ProductID, p.ProductName ,sum(od.Quantity) as 'Total Order Quantities'  from Products p join [Order Details] od on p.ProductID = od.ProductID group by p.ProductID, p.ProductName

-- 4
select c.City, sum(od.Quantity) as 'Total Products Ordered Quantities' from Customers c left join Orders o on c.City = o.ShipCity join [Order Details] od on o.OrderID = od.OrderID group by c.City

-- 5.a
select distinct c1.City from Customers c1 join Customers c2 on c1.City = c2.City where c1.CustomerID != c2.CustomerID

-- 5.b
select distinct c.City from Customers c where (select count(*) from Customers where City = c.City) >= 2

-- 6
select o.ShipCity from [Order Details] od join Orders o on od.OrderID = o.OrderID join Customers c on o.ShipCity = c.City group by o.ShipCity having count(distinct od.ProductID) >= 2

-- 7
select distinct c.* from Customers c join Orders o on c.CustomerID = o.CustomerID where c.Address != o.ShipCity

-- 8
select top 5 p.ProductID, (
		select sum(od.UnitPrice * (1-od.Discount) * od.Quantity) / sum(od.Quantity) 
		from [Order Details] od 
		where ProductID = p.ProductID
	) as 'Average Price', (
		select top 1 c.City 
		from Orders o join Customers c on o.ShipCity = c.City join [Order Details] od on od.OrderID = o.OrderID 
		where od.ProductID = p.ProductID 
		group by c.City 
		order by count(*) desc
	) as 'Customer City' 
from products p join [Order Details] od on p.ProductID = od.ProductID 
group by p.ProductID 
order by sum(od.Quantity) desc

-- 9.a
select distinct e.City from Employees e where e.City not in (select distinct o.ShipCity from Orders o)

-- 9.b
select distinct e.City from Employees e left join Orders o on e.City = o.ShipCity where o.ShipCity is NULL

-- 10
select a.ShipCity from (
	select top 1 o.ShipCity 
	from orders o 
	group by o.ShipCity 
	order by count(*) desc) 
a join (
	select top 1 o.ShipCity 
	from [Order Details] od join Orders o on od.OrderID = o.OrderID 
	group by o.ShipCity 
	order by count(od.Quantity) desc) 
b on a.ShipCity = b.ShipCity

-- 11
-- delete from (
-- 	select *, rank() over (partition by <checked columns> order by <order by columns>) as drank
--	from table
-- ) d where d.drank > 1