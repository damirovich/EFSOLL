----003 Task2 SQL
-----------------------------------
create database SkladDB on
(
	name = 'SkladDB',		
	filename = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SkladDB.mdf',
	size = 30MB,              
	maxsize = 100MB,
	filegrowth=10MB
)
-----------------------------------
use SkladDB
-----------------------------------
--------003 Task3 SQL
create table Employees(
	EmployeeId int identity primary key  not null ,
	FullName varchar(45) null,
	Position varchar(50) null,
	Salary money null,
	PhoneNumber varchar(29) null
)
---------------------------------------
create table Provider(
	ProviderId int identity primary key not null,
	Product varchar(max) null,
	City varchar(50) null,
	Email varchar(35) null,
	PhoneNumber varchar(20) null,
	EmployeesId int not null foreign key references Employees(EmployeeId) 
)
------------------------------------------
create table Customers(
	CustomerId int identity primary key not null,
	FullName varchar(50) null,
	Addresss varchar(max) null,
	City varchar(30) null,
	PhoneNumber varchar(20) null,
	EmployeeId int not null foreign key references Employees(EmployeeId)
)
--------------------------------------------
insert into Employees 
(FullName, Position, Salary, PhoneNumber)
values
('Ашыров Бактилек','Директор','90000','+996704933737'),
('Кудайбергенов Субан', 'Менеджер по закупкам', '70000','+996701524535'),
('Узаков Урмат','Менеджер по продажам','75000','+996555874123');
----------------------------------------------
insert into Provider
(Product,City,Email,PhoneNumber,EmployeesId)
values
('Холодильники','Бишкек','abs@gmail.com','+996555895623',2),
('Ноутбуки','Алматы','sba@mail.ru','+779562784512',2),
('Газовые плиты','Ош','qwe@gmail.com','+996505154875',2);
------------------------------------------------
insert into Customers
(FullName,Addresss,City,PhoneNumber,EmployeeId)
values
('Турдумамбетов Азим','Кемин ул.Шабдан д.№19','Бишкек','+996700855225',3),
('Сеитмуратов Самат','рн.Октябирский ул.Ахунбаева д.№20','Бишкек','+996500235689',3);
------------------------------------------------
