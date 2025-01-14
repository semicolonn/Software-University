/****** Script for SelectTopNRows command from SSMS  ******/
use Bank

create table AccountTypes
(
Id int primary key identity not null, 
Name nvarchar(50) not null,

)

insert into AccountTypes (Name) values 
('Checking'),
('Savings')

select * from AccountTypes

drop table Accounts

create table Accounts 
(
id int primary key identity not null,
ClientId int foreign key references Clients(Id),
AccountTypeId int foreign key references AccountTypes(Id),
Balance decimal(15, 2) default 0
)