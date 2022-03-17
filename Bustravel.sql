create database Bustravel

create table Payments(
Payment_Id int not null,
Card_Type varchar(50),
Bank_Name varchar(50),
Card_No varchar(50),
Card_Holder_Name varchar(50),
Total_Amount decimal(18,2),
Primary key (Payment_Id ),
Booking_Id int FOREIGN KEY REFERENCeTicket_Booking ooking_Id));

create table Login(
User_Id  int not null,
Password varchar(50),
primary key (User_Id),
foreign key  (User_Type_Id) references User_Type,
)

create table Ticket_Booking(
Booking_Id int not null,
Available_Seats int,
Fare decimal(18,2),
Date_Of_Booking date,
Onward_Journey_Date date,
Return_Date date,
primary key (Booking_Id),
);


create table Ticket_Cancellation(
Cancellation_Id int not null,
Refund_Amount decimal(18,2),
Cancellation_Date date,
primary key (Cancellation_Id),
);



create table Type_Of_Ticket(
Ticket_Type_Id int not null,
Ticket_Type varchar(50),
Return_Date date,
primary key (Ticket_Type_Id),