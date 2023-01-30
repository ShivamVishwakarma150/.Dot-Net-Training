CREATE TABLE USERS(
	UserID INT primary key IDENTITY(1,1),
	UserName varchar(50),
	Password varchar(25),
	FullName varchar(255),
	IsActive bit,
	Category varchar(50)
);

CREATE TABLE PRODUCT_MASTER(
Productid INT PRIMARY KEY IDENTITY(1,1),
ProductName varchar(50),
AvialableQty Bigint
);

Create Table [TRANSACTION] (
TransactionID Int Primary key IDENTITY(1,1),
TansactionDate Date,
ProductID int foreign key references PRODUCT_MASTER(Productid),
TransactionType varchar(10),
Qty Int,
UpdatedBy Int foreign key references USERS(USERID)
);




-- Make column updatedBy column in [transaction] as a foreign key relating with the user id of the users table
alter table [TRANSACTION] add  foreign key(UpdatedBy) references users(userid); 




-- Make the productId column as Not Null column in [transaction]
alter table [transaction] alter column productid int not null;



-- Make the updatedby, TansactionType columns as not Null.
alter table [transaction] alter column updatedby int not null;
alter table [transaction] alter column transactionType int not null;



-- Make the productname, AvailableQTY column productMaster as Not Null
alter table PRODUCT_MASTER alter column productname varchar(50) not null;
alter table PRODUCT_MASTER alter column AvialableQty BigInt not null;


-- Droping a foreign key

Alter table [Transaction] drop FK__TRANSACTI__Produ__31EC6D26;


-- Data Manipulation Language
-- INSERT- Add new Row
-- UPDATE -- Modifying the available data
-- DELETE -- Deletes the row(s) from the  table


insert into PRODUCT_MASTER values('TubeLight',500);

insert into PRODUCT_MASTER values('Switch',1000),('Screws',2000),('Nails',500);

insert into Users(UserName,Password,FullName,IsActive) values 
('Mathew','Mathew@111','John Mathew',1);

insert into Users(UserName,Password,FullName,IsActive) values 
('Shivam','Shivam@1332','Shivam Vishwakarma',1);

insert into Users(UserName,Password,FullName,IsActive) values 
('Vikash','Vikas@32','Vikas Paswan',1);

insert into Users(UserName,Password,FullName,IsActive) values 
('Prashant','Prashan@34','Prashant Bhardwaj',1);

insert into Users(UserName,Password,FullName,IsActive) values 
('Abhisek','Abhisek@123','Abhisek Mishra',1);


insert into [TRANSACTION] values('10-11-2012',2,'Inward',12,1),('07-04-2012',2,'Inward',15,1);

-- DQL SELECT -Fetch/Retrieve/show/Display/Get

select * from USERS;
SELECT * from PRODUCT_MASTER;


-- Update

Update Users set category='Staff' where USERID=2;
Update Users set category='Worker' where USERID=3;
Update Users set category='Doctor' where USERID=4;
Update Users set category='Staff' where USERID=5;
Update Users set category='Manager' where USERID=1;

-- Delete

Delete from users where USERID in (6,7);


-- 100% ( DDL,DML 20% 80% DQL select)

select * from users;


select Username,fullname,category from USERS;

select distinct fullname,username,category from users;


-- Filter the data where clause
Select * from PRODUCT_MASTER where AvialableQty=500;

select ProductName from PRODUCT_MASTER where AvialableQty<2000;

-- between >= and <=

Select * from PRODUCT_MASTER where AvialableQty between 1000 and 2000;

Select * from PRODUCT_MASTER where AvialableQty not between 1000 and 2000;


-- Select All the users FullName and category

select fullname, category from users;

-- Select ProductName where the AvailableQty is less than 500.

select productName from PRODUCT_MASTER where AvialableQty<500;

-- select Transaction details which is done by user Mathew

select t.* from [TRANSACTION] as t,USERS as u where t.ProductID=u.UserID;

-- Select the transactionDate and Transaction type from transaction table

select TansactionDate,transactiontype from [TRANSACTION];

-- Fetch only the Inward Transaction details
select * from [TRANSACTION] where TransactionType='Inward';

-- Fetch the product details of Nails.
select * from PRODUCT_MASTER where ProductName='Nails';







