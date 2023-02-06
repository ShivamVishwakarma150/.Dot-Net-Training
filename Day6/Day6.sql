use lms_db;

-- Display the booktitile, supplier name who has supplied the books and the member name who,has taken the book from the library.

select  l1.BOOK_TITLE,l2.SUPPLIER_NAME,l4.MEMBER_NAME from LMS_BOOK_DETAILS as l1 join LMS_SUPPLIERS_DETAILS as l2 on l1.SUPPLIER_ID=l2.SUPPLIER_ID join LMS_BOOK_ISSUE as l3 on l3.BOOK_CODE=l1.BOOK_CODE join LMS_MEMBERS as l4 on l4.MEMBER_ID=l3.MEMBER_ID;

-- for Eg
-- Time taken for compilation
-- 20s + time taken for fetch / execute (20s) == 40s
-- Real time application
-- 10 tables, 15 cols, group by, where, having, subqueries
--  1 min + 1 min ==> 2 min
-- 2*4 => 8 mins

-- solution for saving the time we have to use stored procedure
-- stored procedure
-- it contain pre compiled statements
-- it is compiled once and can execute multiple times
-- Eg


GO
Create proc usp_FetchBookDetails
AS
BEGIN
select  l1.BOOK_TITLE,l2.SUPPLIER_NAME,l4.MEMBER_NAME from LMS_BOOK_DETAILS as l1 join LMS_SUPPLIERS_DETAILS as l2 on l1.SUPPLIER_ID=l2.SUPPLIER_ID join LMS_BOOK_ISSUE as l3 on l3.BOOK_CODE=l1.BOOK_CODE join LMS_MEMBERS as l4 on l4.MEMBER_ID=l3.MEMBER_ID;
END

-- Running Stored Procedure
exec usp_FetchBookDetails;


--paremeterized procedure
-- Working with DML statements with dynamic values

select * from LMS_FINE_DETAILS;

GO
create proc usp_AddFine
(@fine_range char(5),@fine_amount int)
AS
Begin
insert into LMS_FINE_DETAILS values(@fine_range,@fine_amount)
END

execute usp_AddFine 'R9',275;


-- Creating the view - virtual table

GO
GO
create view vw_Book_Details
As
select  l1.BOOK_TITLE,l2.SUPPLIER_NAME,l4.MEMBER_NAME from LMS_BOOK_DETAILS as l1 join LMS_SUPPLIERS_DETAILS as l2 on l1.SUPPLIER_ID=l2.SUPPLIER_ID join LMS_BOOK_ISSUE as l3 on l3.BOOK_CODE=l1.BOOK_CODE join LMS_MEMBERS as l4 on l4.MEMBER_ID=l3.MEMBER_ID;

select * from vw_Book_Details;
select * from vw_Book_Details where SUPPLIER_NAME like 'S%';


-- Triggers

GO
Create trigger trg_InsertFine
on lms_fine_details
FOR insert As
BEGIN
print 'A New Row added '
END

GO
Create trigger trg_UpdateFine
on lms_fine_details
FOR update As
BEGIN
print 'A  Row updated in Fine Details table '
END


GO
create trigger trg_DeleteFine
on LMS_FINE_DETAILS
for delete As
BEGIN
Rollback -- undo changes
print 'Not Allowed to delete'
END

Delete from LMS_FINE_DETAILS where FINE_RANGE='R11';

Disable trigger trg_DeleteFine on lms_fine_details;
Enable trigger trg_DeleteFine on lms_fine_details;
