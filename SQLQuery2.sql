
Create Table Designation
(
	id int identity primary key,
	designation varchar(50) not null
)
Go
drop table Designation
go
Insert Into Designation(designation) Values('Manager')
Insert Into Designation(designation) Values('Reciptionist')
Insert Into Designation(designation) Values('Sr. Accountant')
Insert Into Designation(designation) Values('Jr.Accountant')
Insert Into Designation(designation) Values('Assistant Officer')
Insert Into Designation(designation) Values('Personal Officer')
Go
Select * from Designation
Go
Create Table Employees
(
	empId int primary key,
	empName varchar(50) not null,
	empAddress varchar(50) not null,
	empEmail varchar(50) not null,
	empPhone varchar(50) not null,
	designationId int References Designation(id),
	photo varbinary(max) null,
)
Go

Select empId from Employees
Go
Insert Into Employees(empId,empName,empAddress,empEmail,empPhone,designationId) Values(1,'Johir Uddin','Nilkhet,Dhaka','johir@gmail.com','01966655541',1)
Go
Select empId,empName,empAddress,empEmail,empPhone,designationId,photo from Employees where empId=2
Go
Delete from Employees where empId=1
Go
Update Employees SET empName='Monira Khatun',empAddress='Dhaka, Bosundhara',empEmail='monira@gmail.com',empPhone='01925636317',designationId=1,photo=null WHERE empId=2
Go
Select * from Employees
Go
Select * from Rooms where booked='No'
go
Select price,roomId from Rooms where roomNo=103
Go
select * from Customers
Go
Select * from Rooms
