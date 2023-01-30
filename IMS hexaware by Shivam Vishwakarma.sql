-- Created by Shivam Vishwakarma

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
TransactionType varchar(5),
Qty Int,
UpdatedBy Int
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


-- DQL SELECT -Fetch/Retrieve/show/Display/Get

select * from USERS;
SELECT * from PRODUCT_MASTER;






















