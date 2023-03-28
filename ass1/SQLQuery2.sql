--1
Select ProductID,Name,Color,ListPrice
From Production.Product
--2
Select ProductID,Name,Color,ListPrice
From Production.Product
where ListPrice != 0
--3
Select ProductID,Name,Color,ListPrice
From Production.Product
where Color is Null
--4
Select ProductID,Name,Color,ListPrice
From Production.Product
where Color is not Null
--5
Select ProductID,Name,Color,ListPrice
From Production.Product
where Color is not Null and ListPrice >0
--6
Select Name + ' '+ Color [concatname]
From Production.Product
where Color is not Null
--7
Select 'Name: ' + Name+' -- COLOR: '+Color  [Name And Color]
From Production.Product
where Color is not Null
--8
Select ProductID, Name
From Production.Product
where ProductID >= 400 and ProductID <= 500
--9
Select ProductID,Name, Color
From Production.Product
where Color = 'black' or Color = 'blue'
--10
Select Name [products begin with S]
From Production.Product
where Name like 'S%'
--11
Select Name,ListPrice
From Production.Product
order by Name
--12
Select Name,ListPrice
From Production.Product
where Name like 'A%' or Name like 'S%'
order by Name
--13
Select Name
From Production.Product
where Name like 'SPO%' and Name not like 'spok%'
order by Name
--14
Select Distinct Color
From Production.Product
where Color is not null
order by Color desc
--15
Select Distinct ProductSubcategoryID,Color
From Production.Product
where ProductSubcategoryID is not null and Color is not null
order by ProductSubcategoryID,Color