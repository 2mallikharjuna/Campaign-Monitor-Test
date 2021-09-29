-- create a table
CREATE TABLE Salesperson (
  id SalespersonID PRIMARY KEY,
  name TEXT NOT NULL,
  Age Number NOT NULL,
  Salary Number NOT NULL
);


-- insert some values
INSERT INTO Salesperson VALUES (1, 'Alice', 61, 14000);
INSERT INTO Salesperson VALUES (2, 'Bob', 34, 14000);
INSERT INTO Salesperson VALUES (6, 'Chris', 34, 14000);
INSERT INTO Salesperson VALUES (8, 'Derek', 51, 14000);
INSERT INTO Salesperson VALUES (11, 'Emmit', 57, 14000);
INSERT INTO Salesperson VALUES (16, 'Fred', 38, 14000);

CREATE TABLE Customer (
  id CustomerID PRIMARY KEY,
  name TEXT NOT NULL
);

INSERT INTO Customer VALUES (4, 'George');
INSERT INTO Customer VALUES (6, 'Harry');
INSERT INTO Customer VALUES (7, 'Ingrid');
INSERT INTO Customer VALUES (11, 'Jerry');


CREATE TABLE Orders (
  id OrderID PRIMARY KEY,
  OrderDate date NOT NULL,
  CustomerID Number NOT NULL,
  SalespersonID Number NOT NULL,
  NumberOfUnits Number NOT NULL,
  CostOfUnit Number NOT NULL
);

INSERT INTO Orders VALUES (3, '17/01/2013', 4, 2, 4, 400);
INSERT INTO Orders VALUES (6, '07/02/2013', 4, 1, 1, 600);
INSERT INTO Orders VALUES (10, '04/03/2013', 7, 6, 2, 300);
INSERT INTO Orders VALUES (17, '15/03/2013', 6, 1, 5, 300);
INSERT INTO Orders VALUES (25, '19/04/2013', 11, 11, 7, 300);
INSERT INTO Orders VALUES (34, '22/04/2013', 11, 11, 100, 26);
INSERT INTO Orders VALUES (57, '12/07/2013', 7, 11, 14, 11);


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
