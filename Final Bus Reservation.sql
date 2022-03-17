
create database bustravel

drop database transport

create table User_Type(
User_Type_Id int not null,
User_type_Name varchar(50),
primary key(User_Type_Id),
)

insert into User_Type(User_Type_Id, User_type_Name) values (1,'User')
insert into User_Type(User_Type_Id, User_type_Name) values (2,'Admin')

create table Bus_Type(
Bus_Type_Id int not null,
Bus_Type varchar(50),
primary key(Bus_Type_Id),
)

create table Bus_Details(
Bus_Id int not null,
Registration_Number int,
Total_Seats int,
Bus_Type_Id int,
primary key(Bus_Id),
foreign key (Bus_Type_Id) references Bus_Type,
)

create table Bus_Schedule(
Schedule_Id int not null,
Bus_Id int not null,
Driver_Name varchar(50),
Route_Id int not null,
Departure_Date Date,
Arrival_Date Date,
Booked_Seats int,
Available_Seats int,
Arrival_Time time,
Departure_Time time,
Fare_Id int not null,
primary key(Schedule_Id),
foreign key(Bus_Id) references Bus_Details,
foreign key(Route_Id) references Route_Details,
foreign key(Fare_Id) references Bus_Fare,
)

create table Route_Details(
Route_Id int not null,
Departure_Station varchar(50),
Destination_Station varchar(50),
Duration time,
primary key(Route_Id),
)

create table Bus_Fare(
Fare_Id int not null,
Route_Id int,
Fare_Amount decimal(18,2),
Bus_Type_Id int,
primary key(Fare_Id),
foreign key(Route_Id) references Route_Details,
foreign key(Bus_Type_Id) references Bus_Type,
)

create table Customer(
Customer_Id int not null,
First_Name varchar(50),
Last_Name varchar(50),
Date_Of_Birth Date,
Gender varchar(15),
Email_Id varchar(50),
Address varchar(200),
City varchar(50),
Pincode varchar(15),
Contact_No varchar(50),
User_Id int,
primary key(Customer_Id),
foreign key(User_Id) references Login,
)

create table Login(
User_Id  int not null,
Password varchar(50),
User_Type_Id int,
primary key(User_Id),
foreign key(User_Type_Id) references User_Type,
)

create table Type_Of_Ticket(
Ticket_Type_Id int not null,
Ticket_Type varchar(50),
primary key (Ticket_Type_Id),
)

Insert into Type_Of_Ticket(Ticket_Type_Id, Ticket_Type) values (1,'One Way')
Insert into Type_Of_Ticket(Ticket_Type_Id, Ticket_Type) values (2,'Return')

create table Payments(
Payment_Id int not null,
Card_Type varchar(50),
Bank_Name varchar(50),
Card_No varchar(50),
Card_Holder_Name varchar(50),
Total_Amount decimal(18,2),
Booking_Id int,
primary key(Payment_Id),
foreign key(Booking_Id) references Ticket_Booking,
)




create table Ticket_Booking(
Booking_Id int not null,
Available_Seats int,
Fare decimal(18,2),
Date_Of_Booking date,
Onward_Journey_Date date,
Return_Date date,
Customer_Id int,
Ticket_Type_Id int,
Schedule_Id int,
primary key(Booking_Id),
foreign key(Customer_Id) references Customer,
foreign key(Ticket_Type_Id) references Type_Of_Ticket,
foreign key(Schedule_Id) references Bus_Schedule,
)


create table Ticket_Cancellation(
Cancellation_Id int not null,
Booking_Id int,
Refund_Amount decimal(18,2),
Cancellation_Date date,
Ticket_Type_Id int,
Customer_Id int,
Schedule_Id int,
primary key(Cancellation_Id),
foreign key(Booking_Id) references Ticket_Booking,
foreign key(Ticket_Type_id) references Type_Of_Ticket,
foreign key(Customer_Id) references Customer,
foreign key(Schedule_Id) references Bus_Schedule,
)





