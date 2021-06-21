-----001 Task 1 SQL
create database MyDB
-----------------------------------
-----001 Task 2 SQL
use MyDB
-----------------------------------
create table Employee(
	EmployeeId int identity not null,
	FullName varchar(50) null,
	PhoneNumber varchar(20) null
)
------------------------------------
create table Salary(
	SalaryId int identity not null,
	Salary money null,
	Position varchar(50)
)
-------------------------------------
create table EmployeeInfo(
	EmplInfoId int identity not null,
	FamilyStatus varchar(50) null,
	BirthDate datetime null,
	Addresss varchar(max) null
)
-------------------------------------