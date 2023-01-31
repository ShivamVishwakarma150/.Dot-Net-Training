CREATE TABLE USERS(
	UserID INT primary key IDENTITY(1,1),
	UserName varchar(50) default 'Admin',
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



-- Day 2

select * from users;

-- Create a Default constraint for category column as 'Admin'
alter table users add constraint A_Cat DEFAULT 'Admin' for category;

insert into Users(UserName,Password,FullName,IsActive) values 
('Sachin','Sachin@134','Sachin Mishra',1);



-- Create a check constraint for the transaction as it should accept only the IN/OUT values.
alter table [transaction] add constraint transactionType check (transactionType='inward'  or transactionType='outward'); 

insert into [TRANSACTION] values('07-12-2012',1,'nward',12,1);