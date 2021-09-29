-- Requirment 5.A

Select S.Name from Salesperson S where S.SalespersonID 
   in ( Select distinct O.SalespersonID FROM Orders O where O.CustomerID 
      in (select C.CustomerID from Customer C where C.Name = 'George'));

-- Requirment 5.B
Select S.Name from Salesperson S where S.SalespersonID 
   in ( Select distinct O.SalespersonID FROM Orders O where O.CustomerID 
      in (select C.CustomerID from Customer C where C.Name != 'George'));

-- Requirment 5.C	  
Select S.Name From Salesperson S inner join       
    (Select SalespersonID, Count(*) as SalesCount from Orders Group by SalespersonID Having Count(*) > 1) as SalesOrder
    On SalesOrder.SalespersonID = S.SalespersonID;	
