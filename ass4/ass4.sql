--problem1
create view view_product_order_ji as(
	select ProductID,sum(Quantity) [product quant]
	from [Order Details] od 
	group by ProductID
)
go

--problem2
create procedure sp_product_order_quantity_ji
	@id int,
	@res int out
as
Begin
	set @res = (select sum(Quantity) [product quant]
	from [Order Details] od
	where ProductID = @id
	group by ProductID)

	
End
go


--problem3
create procedure sp_product_order_city_ji
@prodname nvarchar
as
Begin
	select top 5 ShipCity,sum(Quantity) [quant]
	from (Products p left join [Order Details] od on p.ProductID = od.ProductID) left join Orders o on o.OrderID = od.OrderID
	where ProductName = @prodname
	group by ShipCity
	order by sum(Quantity) desc
End
go

--problem 4
Create Table people_ji(
	id int,
	name varchar(30),
	city int
)
Create Table city_ji(
	id int,
	city varchar(30)
	)
go

insert people_ji values(1,'Aaron Roders',2)
insert people_ji values(2,'Russell Wilson',1)
insert people_ji values(3,'Jody Nelson',2)
insert city_ji values(1,' Seattle')
insert city_ji values(2,' Green Bay')
--data initilized, now begin to create new city Madison and then change people in sealtle to madison
insert city_ji values(3,'Madison')
update people_ji set city = 3 where city = 1
--now delete the city of seatle
delete city_ji where city = ' Seattle'
go
create view Packers_ji as(
	select name
	from people_ji left join city_ji on people_ji.city = city_ji.id
	where city_ji.city = ' Green Bay'
)
go
select * from Packers_ji
--no error occurs, good.
drop table people_ji,city_ji
drop view Packers_ji
go
--problem 5
Create procedure sp_birthday_employees_ji
as
begin
	select EmployeeID,LastName,FirstName into birthday_employees_ji
	from Employees
	where month(BirthDate) = 2
end
go
exec sp_birthday_employees_ji
select * from birthday_employees_ji
drop table birthday_employees_ji

--problem 6
-- let t1, t2 be 2 tables does not contain duplicates,and we want to identity if they are the same.
-- (t1 union t2) except (t1 intersect t2) will tell if they are the same
-- if the result is empty, then it means all union elements are in the intersect tables, which means t1, t2 are the same
-- else if the result is not empty they are not same.


