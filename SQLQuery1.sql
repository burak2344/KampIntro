--Her bir üründen toplamda ne kadar para kazandığımızı bulunuz.
--İpucu : Group by kullanılacak
--İpucu : Products, Orders, Order Details tabloları join edilecek.
--İpucu : Sum kullanılacak.
--Sonuç aşağıdaki formatta olmalıdır.
--Ürün Adı, Kazanılan Toplam Miktar
--Not : Kazanılan tutar toplamı Order Details tablosunda unitPrice ve quantity alanlarının çarpımından beslenecek


--1.Çözüm
Select p.ProductName as [UrunAdi] ,SUM(od.Quantity*od.UnitPrice) as [Toplam Tutar] 
from Products p  inner join [Order Details] od
on p.ProductID = od.ProductID 
group by p.ProductName


--2.Çözüm
select Products.ProductName,sum(([Order Details].Quantity*[Order Details].UnitPrice)) 
as [toplam tutar] 
from ((Products inner join [Order Details] 
on Products.ProductID=[Order Details].ProductID ) 
inner join Orders on [Order Details].OrderID=Orders.OrderID)
group by Products.ProductName 
order by Products.ProductName
