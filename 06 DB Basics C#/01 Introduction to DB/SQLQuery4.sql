/****** Script for SelectTopNRows command from SSMS  ******/
Use Bank

Select * from Clients

Select * from AccountTypes

Select * from Accounts


insert into Accounts (ClientId, AccountTypeId) values
(1, 1),
(2, 1),
(3, 1),
(3, 2),
(4, 1)

go
create view v_ClientAccounts as
select Accounts.id, FirstName + ' ' + LastName as[Client Name],
AccountTypes.Name as [AccountType], 
Balance from Accounts
join Clients on Clients.id = Accounts.ClientId
join AccountTypes on AccountTypes.Id = Accounts.AccountTypeId 
go

select * from v_ClientAccounts

select SUM(Balance) from Accounts
where ClientId = 3

go
create function f_CalculateBalance(@ClientId int) 
returns decimal(15, 2)
begin 
	declare @TotalResult Decimal(15, 2) = (select SUM(Balance) from Accounts where ClientId = 3)
	return @TotalResult
end
go

select *, dbo.f_CalculateBalance(3) as TotalBalance from Clients
where Id = 3

go
CREATE PROCEDURE p_AddAccount @ClientId int, @AccountTypeId int As
insert into Accounts(ClientId, AccountTypeId) values
(@ClientId, @AccountTypeId)

go

execute p_AddAccount 3, 2

select * from Accounts

select * from v_ClientAccounts

go
CREATE PROCEDURE p_deposit @Account int, @Amount decimal(15, 2) As
Update Accounts 
set Balance += @Amount
where id = @Account

execute p_deposit 8, 50

go
CREATE PROCEDURE p_withdraw @Account int, @Amount decimal(15, 2) As
declare @OldBalance decimal(15, 2) = (select Balance from Accounts where id = @Account)
if(@OldBalance - @Account >= 0)
begin
	update Accounts
	set Balance -= @Amount
	where id = @Account
end
else
begin
	raiserror('Insufficient Funds.', 10, 1) 
end

execute p_withdraw 8, 305
select * from v_ClientAccounts


go
create table Transactions
(
	Id int primary key identity not null,
	OldBalance decimal(15, 2) not null,
	NewBalance Decimal(15, 2) not null,
	Ammount as (NewBalance - OldBalance),
	Datetime datetime2 Default getdate()
)

select * from Transactions

go
create trigger t_Transaction on Accounts
after Update
as
insert	into Transactions(OldBalance, NewBalance)
select deleted.Balance, inserted.Balance from deleted
join inserted on inserted.id = deleted.id

select * from v_ClientAccounts

exec p_withdraw 4, 50

go
