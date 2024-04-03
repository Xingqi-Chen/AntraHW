SELECT ProductID, Name, Color, ListPrice FROM Production.Product

SELECT ProductID, Name, Color, ListPrice FROM Production.Product WHERE ListPrice = 0

SELECT ProductID, Name, Color, ListPrice FROM Production.Product WHERE Color IS NULL

SELECT ProductID, Name, Color, ListPrice FROM Production.Product WHERE Color IS NOT NULL

SELECT ProductID, Name, Color, ListPrice FROM Production.Product WHERE Color IS NOT NULL AND ListPrice > 0 

SELECT Name + ', ' + Color AS "Name, Color" FROM Production.Product WHERE Color IS NOT NULL

SELECT 'NAME: ' + Name + ' -- COLOR: ' + Color AS Result FROM Production.Product WHERE Color IN ('Black', 'Silver') AND Name LIKE '%Crankarm%' OR Name LIKE '%Chainring%'

SELECT ProductID, Name FROM Production.Product WHERE ProductID BETWEEN 400 AND 500

SELECT ProductID, Name, Color FROM Production.Product WHERE Color IN ('black', 'blue')

SELECT * FROM Production.Product WHERE Name LIKE 'S%'

SELECT Name, ListPrice FROM Production.Product WHERE Name LIKE 'Seat%' OR Name LIKE 'Short%, L' OR Name LIKE 'Short%, M' ORDER BY ListPrice, Name

SELECT Name, ListPrice FROM Production.Product WHERE Name LIKE 'A%' OR Name LIKE 'S%' ORDER BY Name

SELECT * FROM Production.Product WHERE Name LIKE 'SPO[^K]%' ORDER BY Name

SELECT DISTINCT Color FROM Production.Product ORDER BY Color DESC

SELECT DISTINCT ProductSubcategoryID, Color FROM Production.Product WHERE ProductSubcategoryID IS NOT NULL AND Color IS NOT NULL ORDER BY ProductSubcategoryID
