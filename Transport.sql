create database transport

create table UserType(
UserTypeId int not null,
UserTypeName varchar(50),
primary key(UserTypeId));


create table Bus(
BuFId int not null,
fare decimal(18,2),
AarrivalTime datetime ,
DepartureTime datetime ,
TravellingDate_span datetime,
NoOfPassengers int,
Availableseats int,
RouteId int FOREIGN KEY REFERENCES Route(RouteId),
DriverId int FOREIGN KEY REFERENCES Driver(DriverId),
ReturnId int FOREIGN KEY REFERENCES Route(ReturnId));



create table Route(
RouteId int not null,
DepartureStation varchar(50),
DestinationStation varchar(50),
TypeofTicket  varchar(50),
type_of_ticket varchar(50) null,
BusId int FOREIGN KEY REFERENCES Bus(BusId),
DriverId int FOREIGN KEY REFERENCES Driver(DriverId));


create table Customer(
CustomerId int not null,
FirstName varchar(50),
LastName varchar(50),
DOB date,
Gender varchar(50),
EmailId varchar(50),
Address varchar(50),
City varchar(50),
Pincode int,
ContactNo int, 
primary key (CustomerId),
UserId int FOREIGN KEY REFERENCES Login(UserId));




create table Payments(
PaymentId int not null,
CardType varchar(50),
BankNo varchar(50),
CardNo varchar(50),
CardHolderName varchar(50),
TotalAmount decimal(18,2),
BookingId int not null,
primary key(PaymentId),
BookingId int FOREIGN KEY REFERENCES TicketBooking(BookingId));


create table Login(
UserId int,
Password varchar(50),
UserTypeId int not null,
primary key(UserId),
UserTypeId int FOREIGN KEY REFERENCES UserType(UserTypeId));


create table TicketBooking(
BookingId int not null,
AvailableSeats int,
Fare decimal(18,2),
DateOfBooking date,
TotalAmount decimal(18,2), 
CustomerId int not null,
primary key(BookingId),
CustomerId int FOREIGN KEY REFERENCES Customer(CustomerId));


create table TicketCancellation(
CancellationId int  not null,
BookingId int not null,
RefundAmount decimal(18,2),
CancellationDate date,
ReturnId int not null,
primary key(CancellationId),
ReturnId int FOREIGN KEY REFERENCES Return(ReturnId));



create table Return (
ReturnId int not null,
ReturnDate date, 
primary key(ReturnId));

 create table Driver(
 DriverId int,
 DriverName varchar(50),
 DriverContact varchar(50),
 RouteId int ,
 primary key(DriverId),
 RouteId int FOREIGN KEY REFERENCES Route(RouteId));