----------006 Task2 SQL
--create database MyJoinsDB
-----------------------------
use MyJoinsDB
-----------------------------
----------006 Task3 SQL
--create table Employees(
--	IdEmployee int identity primary key not null,
--	FullName varchar(50) null,
--	PhoneNumber varchar(30) null
--)
-----------------------------------
--create table Salary(
--	IdSalary int identity primary key not null,
--	Salary money null,
--	Position varchar(50) null,
--	EmployeeId int foreign key references Employees(IdEmployee) null

--)
-----------------------------------
--create table InfoEmpl(
--	IdInfoEmpl int identity primary key not null,
--	FamilyInfo varchar(50) null,
--	BirthDate date null,
--	Addresss varchar(max) null,
--	EmployeeId int foreign key references Employees(IdEmployee) not null
--)
---------------------------------------------
--insert into Employees
--(FullName,PhoneNumber)
--values
--('Ашыров Бактилек','+996704933737'),
--('Кудайбергенов Субан','+996555895623'),
--('Каныбеков Аскар','+996700524163'),
--('Сеитмуратов Самат','+996777895645'),
--('Сарыева Клара','+996701888888');
--------------------------------------------
--insert into Salary
--(Salary,Position,EmployeeId)
--values
--('$150000','Главный директор',1),
--('$80000','Менеджер',2),
--('$60000','Рабочий',3),
--('$60000','Рабочий',4),
--('$85000','Менеджер',5);
----------------------------------------
--insert into InfoEmpl
--(FamilyInfo,BirthDate,Addresss,EmployeeId)
--values
--('не женат','1999-05-01','обл.Нарын рн.Жумал с.Кызарт',1),
--('жента','1998-12-24','г.Бишкек',2),
--('не женат','2000-04-18','г.Каракол',3),
--('женат','1999-01-25','г.Бишкек',4),
--('не замужем','2000-07-15','г.Бишкек',5);
-----------------------------------------------
-----------006 Task 4 SQL
select FullName, PhoneNumber, Addresss from Employees as empl, InfoEmpl as info
where empl.IdEmployee in (select EmployeeId from InfoEmpl 
								where empl.IdEmployee=info.EmployeeId)
-------------------------------------------------------------
select FullName, BirthDate, PhoneNumber from Employees as empl, InfoEmpl as info
where empl.IdEmployee in (select EmployeeId from InfoEmpl
								where empl.IdEmployee=info.EmployeeId
								and FamilyInfo in (select FamilyInfo from InfoEmpl
														 where FamilyInfo='не женат' or FamilyInfo='не замужем'))
								
---------------------------------------------------------------
select FullName, BirthDate, PhoneNumber from Employees as empl, InfoEmpl as info, Salary as pos
where empl.IdEmployee in (select EmployeeId from InfoEmpl
								where empl.IdEmployee=info.EmployeeId and
								empl.IdEmployee=pos.EmployeeId and
								Position='Менеджер')
