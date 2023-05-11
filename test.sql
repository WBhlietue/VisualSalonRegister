show databases

use VisualBD;
create table Customer (
    email varchar(50) primary key,
    pass varchar(50),
    firstName varchar(50),
    lastName varchar(50),
    age integer,
    phone integer
);

use VisualBD;
drop table Orders;
create table Orders (
    email varchar(50),
    orderDate char(10),
    orderTime int,
    orderType int,
    completed int,
    foreign key (email) references Customer(email)
);
select * from VisualBD.Customer
select * from VisualBD.Orders