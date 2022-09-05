CREATE Database myHotel
Go
use myHotel
Go

Create Table Rooms
(
	roomId int Primary Key Identity,
	roomNo varchar(50) not null unique,
	roomType varchar(50) not null,
	bed varchar(50) not null,
	price Money not null,
	booked varchar(50) default 'No'

)
Go
Insert Into Rooms(roomNo,roomType,bed,price,booked) Values('101','AC','Single',5000,'No')
Insert Into Rooms(roomNo,roomType,bed,price,booked) Values('102','AC','Double',8000,'No')
Insert Into Rooms(roomNo,roomType,bed,price,booked) Values('103','AC','Triple',8500,'No')
Insert Into Rooms(roomNo,roomType,bed,price) Values('104','Non-Ac','Single',4000)
Insert Into Rooms(roomNo,roomType,bed,price) Values('107','AC','Duplex',10000)
Insert Into Rooms(roomNo,roomType,bed,price) Values('108','Non-Ac','Single',8500)
Insert Into Rooms(roomNo,roomType,bed,price) Values('109','AC','Duplex',12000)
Insert Into Rooms(roomNo,roomType,bed,price) Values('110','AC','Cabana',15000)
Insert Into Rooms(roomNo,roomType,bed,price) Values('111','AC','Quad',16000)
Insert Into Rooms(roomNo,roomType,bed,price) Values('112','AC','King',18000)
Insert Into Rooms(roomNo,roomType,bed,price) Values('113','AC','Queen',18000)
Insert Into Rooms(roomNo,roomType,bed,price) Values('114','Non-Ac','Double',5000)
Insert Into Rooms(roomNo,roomType,bed,price) Values('115','Non-Ac','Double',5000)
Insert Into Rooms(roomNo,roomType,bed,price) Values('116','Non-Ac','Double',5000)
Insert Into Rooms(roomNo,roomType,bed,price) Values('117','Non-Ac','Triple',8000)
Go
Select * from Rooms
Go
CREATE TABLE Customers
(
	customerId int Identity Primary Key,
	customerName varchar(50) not null,
	dob varchar(50) not null,
	religion varchar(50) not null,
	[address] varchar(50) not null,
	gender varchar(50) not null,
	nationality varchar(50) not null,
	nationalId varchar(50) not null,
	contactNo varchar(50) not null,
	email varchar(50) not null,
	checkInDate varchar(50) not null,
	checkOutDate varchar(50) null,
	checkOutStatus varchar(50) default 'No',
	picture varbinary(max) null,
	roomId int not null,
	Foreign Key(roomId) references Rooms(roomId)
)
Go

Insert Into Customers(customerName,dob,religion,[address],gender,nationality,nationalId,contactNo,email,checkInDate,roomId)
Values('Rafi Hasan','5/5/1999','Islam','#63,DOHS-Baridhara,Dhaka-1206','Male','Bangladeshi','1925962225','01952634154','rafi@gmail.com','04/16/2022',1)
Go
Select customerId as 'Customer ID',customerName as 'Customer Name',dob as 'Date Of Birth',religion as Religion,address as Address,gender as Gender,nationality as Nationality,nationalId as 'National ID',contactNo as 'Contact No',email as Email,checkInDate as 'Check In Date',checkOutDate as 'Check Out Date',checkOutStatus as 'Check Out Status',picture as Picture,Rooms.roomNo as 'Room No',Rooms.bed as Bed,Rooms.price as Price ,Rooms.roomType as 'Room Type' from Customers inner join Rooms on Customers.roomId=Rooms.roomId
Go

select roomNo,roomType,bed from Rooms where booked='No' and bed='single';
Go
Select price,roomId from Rooms where roomNo='105';
Go
Create Table Designation
(
	id int identity primary key,
	designation varchar(50) not null
)
Go
Insert Into Designation(designation) Values('Manager')
Insert Into Designation(designation) Values('Reciptionist')
Insert Into Designation(designation) Values('Sr. Accountant')
Insert Into Designation(designation) Values('Jr.Accountant')
Insert Into Designation(designation) Values('Assistant Officer')
Insert Into Designation(designation) Values('Personal Officer')
Go
Create Table Employees
(
	empId int primary key,
	empName varchar(50) not null,
	empAddress varchar(50) not null,
	empEmail varchar(50) not null,
	empPhone varchar(50) not null,
	designationId int References Designation(id),
	salary money not null,
	photo varbinary(max) null,
)
Go
select * from Employees
go



