-- INSERT into [Tablo Adı] ([Kolon Adı 1],[Kolon Adı 2],[Kolon Adı n])
--                  values ([Deger 1], [Deger 2],[Deger N])

Insert into Products (ProductName, UnitPrice)
            values ('Leblebi',50)

Insert into Categories (CategoryName, Description)
            values ('Tatlılar','her türlü Türk tatlısı')         

-- UPDATE [Tablo Adı] SET [Kolon Adı 1]=[Değer 1],
--                        [Kolon Adı 2]=[Değer 2]
-- WHERE [Satır Kriteri]
UPDATE Products SET UnitPrice = 75
WHERE ProductID = 78

UPDATE Categories SET Description = 'Bütün dünyadan tatlılar'
WHERE CategoryID = 9

-- DELETE FROM [Tablo Adı] 
-- WHERE [Kriter]
DELETE FROM Products WHERE ProductID = 78

SELECT
  *
FROM Products

SELECT 
 ProductName, UnitsInStock, QuantityPerUnit, UnitPrice
FROM Products
WHERE UnitPrice < 50
ORDER BY UnitPrice 

SELECT 
 ProductName, UnitsInStock, QuantityPerUnit, UnitPrice
FROM Products
WHERE ProductName LIKE 'a%'

SELECT 
 ProductName, UnitsInStock, QuantityPerUnit, UnitPrice, 'a ile biten' as durum
FROM Products
WHERE ProductName LIKE '%a'
ORDER BY ProductName

SELECT
  FirstName, LastName, YEAR(GETDATE()) - YEAR(BirthDate)  as Yas 
FROM Employees
ORDER BY Yas DESC 

SELECT 
  CompanyName, Country
FROM Customers
ORDER BY Country

--Aggragete Function:
SELECT 
  COUNT(CustomerID)
FROM Customers 
WHERE Country = 'UK'


SELECT 
  Country,City, COUNT(CustomerID) MusteriSayisi
FROM Customers
GROUP BY Country, City
/*
  Arjantin  3
  Brasil 9
  UK 7

*/

SELECT 
 ProductID, SUM(Quantity) Adet
FROM [Order Details]
GROUP BY ProductID 
ORDER BY ProductID

SELECT 
 ProductName, SUM(Quantity) Adet
FROM [Order Details]  JOIN Products
ON [Order Details].ProductID = Products.ProductID
GROUP BY ProductName 
ORDER BY ProductName

SELECT COUNT(*) FROM Customers
SELECT COUNT(Distinct CustomerID) FROM Orders

SELECT CompanyName, City, Country, OrderDate 
FROM Customers LEFT JOIN Orders
ON Customers.CustomerID = Orders.CustomerID
WHERE OrderDate is NULL
ORDER BY CompanyName

SELECT CompanyName, City, Country, OrderDate 
FROM  Orders 
RIGHT JOIN Customers
ON Customers.CustomerID = Orders.CustomerID
WHERE OrderDate is NULL
ORDER BY CompanyName

SELECT * FROM Categories
INSERT into Products (ProductName, UnitPrice) values ('Tulumba',30)

SELECT CategoryName,ProductName
FROM Products FULL OUTER JOIN Categories
ON Products.CategoryID = Categories.CategoryID
WHERE CategoryName is NULL OR ProductName is NULL

--Stored procedure
CREATE PROC UrunEkle
   @isim nvarchar(40),
   @fiyat money
AS
INSERT into Products (ProductName, UnitPrice)
values  (@isim,@fiyat)

UrunEkle 'Çikolata',1.5

/*
* Migrosta Coca-Cola alanlar, başka ne aldılar (en çok alınan 5 ürün)? 
*/
 
SELECT OrderID
FROM [Order Details] 
WHERE ProductID =1 

CREATE PROC Bunu_Alan_Bunu_Aldi
  @id int
AS
SELECT TOP 5 ProductName, SUM(Quantity) Qty FROM [Order Details] JOIN Products
ON [Order Details].ProductID = Products.ProductID
where [Order Details].ProductID !=@id  AND OrderID IN 
(
SELECT OrderID
FROM [Order Details] 
WHERE ProductID =@id 
)
GROUP BY ProductName 
ORDER BY Qty DESC


Bunu_Alan_Bunu_Aldi 27








      