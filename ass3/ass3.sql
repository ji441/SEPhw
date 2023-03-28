--1
select distinct c.city [city has both employers and customers]
from Employees e join Customers c on e.city = c.city
--2 donot use subquery
select distinct c.city [city has customer but no employee]
from Customers c left join Employees e on e.city = c.City
where e.city is null
--2 use subquery
select distinct c.city [city has customer but no employee]
from Customers c
where not exists(
select distinct e.city from Employees e where e.city = c.city
)
--3
select productname, sum(Quantity) [total order quant]
from products p left join [order details] od on p.ProductID = od.ProductID
group by productname
--4
select c.City,count(distinct ProductID) [total products ordered]
from (Customers c left join orders o on c.CustomerID = o.CustomerID) left join [Order Details] od on o.OrderID = od.OrderID 
group by c.City
--5 no subquery
select city
from customers
group by city
having count(distinct CustomerID) > 1

--5 subquery
select city
from
(select city, count(distinct CustomerID) [customernum]
from Customers
group by City) m 
where customernum >1
--6
select c.City,count(distinct ProductID) [total products ordered]
from (Customers c left join orders o on c.CustomerID = o.CustomerID) left join [Order Details] od on o.OrderID = od.OrderID 
group by c.City
having count(distinct ProductID) >=2
--7
select distinct c.CustomerID [customers order out city]
from Customers c left join Orders o on c.CustomerID = o.CustomerID
where City != ShipCity
--8
select c.CustomerID,city,o.OrderID,od.ProductID,UnitPrice,Quantity into tempB
from (Orders o join [Order Details] od on o.OrderID = od.OrderID) join Customers c on o.CustomerID = c.CustomerID

select top 5 ProductID [top 5 product id],avg(UnitPrice) [avg price] into tempA
from tempB
group by ProductID
order by (sum(Quantity)) desc

select city, ProductID, [avg price],Quantity into tempC
from tempA join tempB on [top 5 product id] = ProductID

select ProductID,[avg price],city,sum(Quantity) [quantity percity] into tempD
from tempC
group by ProductID,[avg price],city


select ProductID,[avg price],max([quantity percity]) [maxquantity] into tempE
from tempD
group by ProductID,[avg price]


select * from tempD
select * from tempE
select e.ProductID,e.[avg price], d.City
from tempE e join tempD d on d.ProductID = e.ProductID and d.[avg price] = e.[avg price] and [quantity percity] = maxquantity
--9 no subquery
select distinct c.City
from (customers c left join orders o on c.customerID = o.CustomerID) left join Employees e on e.city = c.City
where OrderID is null and e.city is not null
--9 subquery
select distinct c.city
from customers c
where not exists(select o.customerid from orders o where o.customerID = c.CustomerID)
and exists (select e.city from Employees e where e.city = c.city)

--10
select city,count(OrderID) [ordernum] into temp10A
from orders o join Employees e on o.EmployeeID = e.EmployeeID
group by city

select city, sum(Quantity)[orderquant] into temp10B
from orders o join Employees e on o.EmployeeID = e.EmployeeID join [Order Details] od on od.OrderID = o.OrderID
group by City

select city into temp10C
from temp10A 
where ordernum = (select max(ordernum) from temp10A)

select city into temp10D
from temp10B 
where orderquant = (select max(orderquant) from temp10B)

select c.city
from temp10C c join temp10D d on c.city = d.City 
--since one is london one is seattle, the intersection is null.

--11
--we can generate a temp table that contains al the duplicates rows.
--like select distinct * into dup from original group by key having count(key) >1
--then delete from original table all the dup rows, and finally insert only one dup rows back
-- finally drop the dup table and we are done.











