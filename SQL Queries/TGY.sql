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
WHERE ProductName = 'Perth Pasties'



      