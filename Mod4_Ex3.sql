SELECT * FROM Sales.Customer;

SELECT * FROM Sales.Store
ORDER BY Name ASC;

SELECT * FROM HumanResources.Employee
WHERE BirthDate > '1989-09-28'
LIMIT 10;

SELECT NationalIDNumber, LoginID, JobTitle 
FROM HumanResources.Employee
WHERE RIGHT(LoginID, 1) = '0'
ORDER BY JobTitle;

SELECT * FROM Person.Person
WHERE YEAR(ModifiedDate) = 2008 AND MiddleName IS NOT NULL AND Title IS NULL;

SELECT DISTINCT d.Name
FROM HumanResources.Department d
JOIN HumanResources.EmployeeDepartmentHistory edh ON d.DepartmentID = edh.DepartmentID;

SELECT TerritoryID, SUM(CommissionPct) as TotalCommission
FROM Sales.SalesPerson
WHERE CommissionPct > 0
GROUP BY TerritoryID;

SELECT * FROM HumanResources.Employee
WHERE VacationHours = (SELECT MAX(VacationHours) FROM HumanResources.Employee);

SELECT * FROM HumanResources.Employee
WHERE JobTitle IN ('Sales Representative', 'Network Administrator', 'Network Manager');

SELECT e.*, poh.*
FROM HumanResources.Employee e
LEFT JOIN Purchasing.PurchaseOrderHeader poh ON e.BusinessEntityID = poh.EmployeeID;