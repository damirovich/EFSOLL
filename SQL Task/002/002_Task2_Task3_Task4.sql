---002 Task2 SQL
create database HomeWork
----------------------
use HomeWork
-------------------------------------
create table Product(
	ProductId smallint identity not null,
	Name varchar(45) null,
	ProductNumber varchar(30) null,
	Cost money null,
	Countt integer null,
	SellStartDate date null
)
-----------------------------------------------
insert into Product 
(Name, ProductNumber, Cost, Countt, SellStartDate)
values
('������', 'AK-53818', '5', '50', '2011-08-15'), 
('�����', 'AM-51122', '6.1', '50', '2011-07-15'), 
('������', 'AA-52211', '2.5','20', '2011-06-15'), 
('Snickers', 'BS-32118', '2.8','50','2011-08-15'), 
('Snickers', 'BSL-3818', '5', '100', '2011-08-20'), 
('Bounty', 'BB-38218', '3', '100', '2011-08-01'), 
('Nuts', 'BN-37818', '3', '100', '2011-08-21'), 
('Mars', 'BM-3618', '2.5', '50', '2011-08-24'), 
('������', 'AS-54181', '5', '100', '2011-08-12'), 
('������', 'AS-54182', '5', '100', '2011-08-12');
---------------------------------------------------
----002 Task3 SQL
select *from Product where Countt>59
select *from Product where Cost>3 and SellStartDate='2011-08-20'
----------------------------------------------------
----002 Task4 SQL
update Product set Cost =5.25 where Name='������'
