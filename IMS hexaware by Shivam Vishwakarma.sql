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


























