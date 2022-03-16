create database transport

use [transport]

create table usertype(
user_type_id int not null,
user_type_name varchar(50) null,
primary key(user_type_id)
)

insert into usertype(user_type_id,user_type_name) values (1,'User');
insert into usertype(user_type_id,user_type_name) values (2,'Admin');

create table bus_details(
bus_id int not null,
fare decimal(18,2) null,
arrival_time datetime null,
departure_time datetime null,
travelling_date_span datetime null,
no_of_passengers int null,
available_seats int null,
foreign key (route_id) references routedetails,
foreign key (driver_id) references driver_details,
foreign key (return_id) references route_details,
)

create table route_details(
route_id int not null,
departure_station varchar(50) null,
destination_station varchar(50) null,
type_of_ticket varchar(50) null,
foreign key (bus_id) references bus_details,
foreign key (driver_id) references driver_details,
)

create table customer_details(
customer_id int not null,
first_name varchar(50) null,
last_name varchar(50) null,
date_of_birth datetime null,
gender varchar(20) null,
email_id varchar(50) null,
address varchar(200) null,
city varchar(50) null,
pincode varchar(15) null,
contact_no varchar(50)




