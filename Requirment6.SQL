-- Requirment 6.A
SELECT Name FROM Salesperson ORDER BY salary DESC LIMIT 2, 1;

-- Requirment 6.B
CREATE TABLE BigOrders AS 
 SELECT
    CustomerID,
    SUM(NumberOfUnits * CostOfUnit) AS TotalOrderValue
    FROM
    Orders
  GROUP BY
    CustomerID
  HAVING
    TotalOrderValue > 1000 ;

-- Requirment 6.C
select YEAR(OrderDate) AS OrderYear, MONTH(OrderDate) as OrderMonth, sum(NumberOfUnits)
     from Orders group by OrderYear, OrderMonth
     order by OrderYear desc, OrderMonth desc;	
