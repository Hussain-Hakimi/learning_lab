use CASTUMER;

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerName VARCHAR(50),
    ProductName VARCHAR(50),
    City VARCHAR(50),
    Amount DECIMAL(10,2),
    OrderDate DATE
);  


INSERT INTO Orders VALUES
(1,'Ali','Laptop','Lahore',1200,'2025-01-05'),
(2,'Sara','Mouse','Karachi',25,'2025-01-06'),
(3,'Hassan','Keyboard','Islamabad',45,'2025-01-07'),
(4,'Ali','Monitor','Lahore',300,'2025-01-08'),
(5,'Fatima','Laptop','Karachi',1100,'2025-01-09'),
(6,'Omar','Headphones','Peshawar',150,'2025-01-10'),
(7,'Zain','Mouse','Lahore',30,'2025-01-11'),
(8,'Sara','Laptop','Karachi',1300,'2025-01-12'),
(9,'Hassan','Mouse','Islamabad',20,'2025-01-13'),
(10,'Fatima','Keyboard','Karachi',60,'2025-01-14'),
(11,'Omar','Laptop','Peshawar',1250,'2025-01-15'),
(12,'Zain','Monitor','Lahore',280,'2025-01-16'),
(13,'Ali','Mouse','Lahore',22,'2025-01-17'),
(14,'Sara','Headphones','Karachi',170,'2025-01-18'),
(15,'Hassan','Laptop','Islamabad',1150,'2025-01-19'),
(16,'Fatima','Mouse','Karachi',27,'2025-01-20'),
(17,'Omar','Keyboard','Peshawar',55,'2025-01-21'),
(18,'Zain','Laptop','Lahore',1180,'2025-01-22'),
(19,'Ali','Headphones','Lahore',160,'2025-01-23'),
(20,'Sara','Monitor','Karachi',310,'2025-01-24'),
(21,'Hassan','Mouse','Islamabad',24,'2025-01-25'),
(22,'Fatima','Laptop','Karachi',1220,'2025-01-26'),
(23,'Omar','Mouse','Peshawar',26,'2025-01-27'),
(24,'Zain','Keyboard','Lahore',58,'2025-01-28'),
(25,'Ali','Laptop','Lahore',1190,'2025-01-29'),
(26,'Sara','Mouse','Karachi',23,'2025-01-30'),
(27,'Hassan','Monitor','Islamabad',295,'2025-01-31'),
(28,'Fatima','Headphones','Karachi',165,'2025-02-01'),
(29,'Omar','Laptop','Peshawar',1280,'2025-02-02'),
(30,'Zain','Mouse','Lahore',21,'2025-02-03');


select * from Orders;

select * from Orders
order by Amount ;


select * from Orders
order by Amount desc;



select top 3 Amount,ProductName
from Orders
order by Amount desc;


select top 6 ProductName, Amount
from Orders
order by Amount desc


select City, count(Amount) as ToTalOrder
from Orders
group by City;



Select distinct ProductName 
from Orders
order by ProductName ;


Select city , Sum(Amount) as TotalSaleAmount
from Orders
group by City
order by TotalSaleAmount desc;



select CustomerName,Count(*) as TotalOrder
from Orders
group by CustomerName 
order by CustomerName;


select Top 3 CustomerName,Sum(Amount) as TotalSpent
from Orders
group by CustomerName
order by TotalSpent desc



select ProductName, sum(Amount) AS Totalsales
from Orders
group by ProductName;




select * from Orders
select city 
from Orders
Group by City
having count(*) > 2;



select CustomerName, Sum(Amount) as TotalPurchus 
from Orders 
group by CustomerName
having Sum(Amount) > 1000;


select ProductName ,Count(Amount) As TotalSold
from Orders
group by ProductName
Having count(Amount) >2;





















