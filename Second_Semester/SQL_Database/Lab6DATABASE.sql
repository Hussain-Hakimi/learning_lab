use CASTUMER;

select * from Sales;

--1

select top 3 CustomerName, sum(Price*Quantity) as TotalRevenue
from Sales
group by CustomerName
Order by TotalRevenue desc;



--2
select top 2 Category,sum(Price*Quantity) As TotalRevenue
From Sales
group by Category
order by TotalRevenue desc;


--3
Select Top 3  ProductName, Sum(Quantity) As Quantity
From Sales 
group by ProductName
order by Quantity desc;


--4
select top 5 customerName,category,sum(price* quantity) as totalSpending
from Sales
group by CustomerName,Category
order by CustomerName;


--5

select top 5 CustomerName,sum(Quantity) as Quantity
From Sales
group by CustomerName
Order by Quantity desc;

--6


SELECT TOP 5 ProductName, Sum(price* Quantity) as TotalRevenue
From Sales
Group by ProductName
order by Sum(price*Quantity) desc;


--7
SELECT top 3 category,AVG(Price) as AveragePrice
from Sales
group by Category
order by AveragePrice desc

--8
SELECT top 4 category, Count(*) as TotalSale
from Sales
group by Category
Order by Category ;

--9
SELECT top 5 ProductName, Sum(Price*Quantity) as TotalRevenue
from Sales
Group by ProductName
Order by TotalRevenue desc;


--10
SELECT top 6 CustomerName, sum(Price*Quantity) as TotalRevenue
from Sales
Group by CustomerName
Order by CustomerName;



