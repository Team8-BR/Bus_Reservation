create database transport

create table UserType(
UserTypeId int not null,
UserTypeName varchar(50),
primary key(UserTypeId));

insert into UserType(UserTypeId, UserTypeName) values(1,'User')
insert into UserType(UserTypeId, UserTypeName) values(2,'Admin')


create table Bus(
BusId int not null,
fare decimal(18,2),
AarrivalTime datetime ,
DepartureTime datetime ,
TravellingDate_span datetime,
NoOfPassengers int,
Availableseats int,
primary key(BusId),
)

alter table Bus
add constraint  FK_Route_Bus_RouteId foreign key (RouteId) references Bus (RouteId)

create table Route(
RouteId int not null,
DepartureStation varchar(50),
DestinationStation varchar(50),
TypeofTicket  varchar(50),
primary key (RouteId),
)


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
)




create table Payments(
PaymentId int not null,
CardType varchar(50),
BankNo varchar(50),
CardNo varchar(50),
CardHolderName varchar(50),
TotalAmount decimal(18,2),
BookingId int not null,
primary key(PaymentId),
)


create table Login(
UserId int,
Password varchar(50),
UserTypeId int not null,
primary key(UserId),
)


create table TicketBooking(
BookingId int not null,
AvailableSeats int,
Fare decimal(18,2),
DateOfBooking date,
TotalAmount decimal(18,2), 
CustomerId int not null,
primary key(BookingId),
)


create table TicketCancellation(
CancellationId int  not null,
BookingId int not null,
RefundAmount decimal(18,2),
CancellationDate date,
ReturnId int not null,
primary key(CancellationId),
)



create table ReturnDetails(
ReturnId int not null,
ReturnDate date, 
primary key(ReturnId));

 create table Driver(
 DriverId int,
 DriverName varchar(50),
 DriverContact varchar(50),
 RouteId int ,
 primary key(DriverId),
 )