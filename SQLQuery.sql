select ContactName Adi, CompanyName Sirketi, City Sehir from Customers

select * from Customers where City='Berlin'

select *from Products where CategoryID=1 or CategoryID=3

select *from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by CategoryID, ProductName

select * from Products order by UnitPrice desc

select * from Products where CategoryID=1 order by UnitPrice desc

Select count(*) Adet from Products

Select CategoryID, count(*) Adet from Products group by CategoryID  --hangi kategoride kaç ürün var 

Select CategoryID, count(*) Adet from Products group by CategoryID having count(*)<10   -- 10 taneden az olan kategorileri verir


Select CategoryID, count(*) Adet from Products where UnitPrice>20 group by CategoryID having  count(*)<10  -- Unitprice 20 den kucuk, hangi kategorilerde Sayısı 10 dan az olan urunlerı getır

select Products.ProductID, Products.ProductName,Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID= Categories.CategoryID

--DTO Data Transformation object

select Products.ProductID, Products.ProductName,Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID= Categories.CategoryID where Products.UnitPrice>10

select * from Products p left join [Order Details]  od on p.ProductID=od.ProductID -- solda olup sağda olmayanlarıda getir

select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null --musteri olup urun almayanları getırır.

select * from Products p inner join [Order Details]  od on p.ProductID=od.ProductID  inner join Orders o on o.OrderId=od.OrderID






