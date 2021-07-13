--Select
--ANSII
Select  ContactName Adi,CompanyName Şirketadi,City Sehir from Customers

Select * from Customers where City= 'London'

--case insensitive
select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

--sıralama
select * from Products order By CategoryID,ProductName

select * from Products order By UnitPrice asc --ascending


select * from Products where CategoryID=1 order By UnitPrice desc --descending

select COUNT(*) Adet from Products where CategoryID=2

select categoryId,COUNT(*) Adet from Products where UnitPrice>20
group by CategoryID having COUNT(*)<10


--DTO Data Transformation Object
-- inner join sadece iki tabloda birleşenleri bir araya getirir.Eşleşmeyen dataları getirmez.
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10 

-- solda olup sağda olmayanlarıda getir.
Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID 
inner join Orders o 
on o.OrderID = od.OrderID

Select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID 
where o.CustomerID is null 
