--SELECT
SELECT ContactName Adi,CompanyName SirketAdi,City Sehir FROM Customers

SELECT * FROM Customers WHERE City='London'--ANSI standardına göre tek tırnak ile yazılır

--case insensitive(büyük küçük harf duyarsız)
SELECT * FROM Products WHERE CategoryID=3 or CategoryID=1--ürünler tablosunda categoryıd si 3 ya da 1 olanları getir

SELECT * FROM Products WHERE CategoryID=1 and UnitPrice<10--categoryıd si 1 ve birim fiyatı 10 dan az olanları seçer

SELECT * FROM Products ORDER BY CategoryID,ProductName

SELECT * FROM Products ORDER BY UnitPrice DESC--azalan fiyata göre sıralıyorum 
SELECT * FROM Products ORDER BY UnitPrice ASC--artan fiyata göre sıralıyorum
--ascending-->artan
--descending-->azalan

SELECT * FROM Products WHERE CategoryID=1 ORDER BY UnitPrice DESC

SELECT COUNT(*) FROM Products WHERE CategoryID=2-- ıd si 2 olan tüm ürünlerin sayısını verir

SELECT CategoryID,COUNT(*) FROM Products GROUP BY CategoryID--group by kullandığım zaman * kullanılmaz 
--bütün kategorileri tekrar etmeyecek şekilde listele ve her kategoride kaç adet ürün olduğunu ver

SELECT CategoryID ,COUNT(*) FROM Products 
WHERE UnitPrice>20 GROUP BY CategoryID having COUNT(*)<10--sayısı 10 dan küçük olan birim fiyatı 20 den büyük olanların sayısı


SELECT Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName 
FROM Products inner join Categories 
ON Products.CategoryID=Categories.CategoryID
WHERE Products.UnitPrice>10--Fiyatı 10 dan büyük olan ürünleri kategori ismi ile birleştirip getir

--DTO Data Tranformation Object -->

SELECT * FROM Products p left join [Order Details] od
ON p.ProductID=od.ProductID--order details ve product tablosunda ortak olan eşleşen kayıtları getirir
--left join -->solda olup sağda olmayanları da getir (ürünler tablosunda var ama satış yok)

SELECT * FROM Customers c left join Orders o 
ON c.CustomerID=o.CustomerID--müşteri de olup siparişte olmayanları da getirir.
--sisteme kayıt olup da hiç sipariş vermeyenleri bulur (ilk siparişe özel indirim yapmak için)

SELECT * FROM Customers c left join Orders o 
ON c.CustomerID=o.CustomerID
WHERE o.CustomerID is null--hiç sipariş vermemiş müşterileri bulur



