-- LMS Joins Questions

-- 1.	Write a query to display the book title, supplier name who has supplied books to library.

select b.book_title,s.supplier_name from LMS_BOOK_DETAILS as b join LMS_SUPPLIERS_DETAILS as s on b.SUPPLIER_ID=s.SUPPLIER_ID;

-- 2.	Write a query to display member name and book code for the book he/she taken from the library.

select distinct m.member_name,b.book_code from LMS_BOOK_ISSUE as b join LMS_MEMBERS as m on b.MEMBER_ID=m.MEMBER_ID ;

-- 3.	Write a query to display the book title and date when the book was taken from the library.

select BOOK_TITLE,DATE_ISSUE FROM LMS_BOOK_DETAILS as b join LMS_BOOK_ISSUE as bi on b.BOOK_CODE=bi.BOOK_CODE;


-- 4.	Write a query to display the member id and the fine amount paid by the member in the library.
select bi.member_id,fd.fine_amount from LMS_BOOK_ISSUE as bi join LMS_FINE_DETAILS as fd on bi.FINE_RANGE=fd.FINE_RANGE;

-- 5.	Write a query to display the member name and the date difference between the date return and date returned.

select member_name,DATEDIFF(day,date_return,date_returned) as 'ExtraDays' from LMS_BOOK_ISSUE as bi join LMS_MEMBERS as m on bi.MEMBER_ID=m.MEMBER_ID;

-- 6.	Write a query to display the book title and the member name of member who has taken book from library.

select distinct book_title,member_name from LMS_BOOK_DETAILS as bd join LMS_BOOK_ISSUE as bi on bd.BOOK_CODE=bi.BOOK_CODE join
LMS_MEMBERS as m on m.MEMBER_ID=bi.MEMBER_ID;

-- 7.	Write a query to display the book title, member name and the supplier name for the books taken from the library.
select distinct bd.book_title,m.member_name,sd.supplier_name from LMS_BOOK_DETAILS as bd join LMS_BOOK_ISSUE as bi on bd.BOOK_CODE=bi.BOOK_CODE join
LMS_MEMBERS as m on m.MEMBER_ID=bi.MEMBER_ID join LMS_SUPPLIERS_DETAILS as sd on sd.SUPPLIER_ID=bd.SUPPLIER_ID;



-- 8.	Write a query to display the book title and the different fine amount paid for the book in library.

select * from LMS_FINE_DETAILS;
select bd.book_title,fi.fine_amount from LMS_BOOK_DETAILS as bd join LMS_BOOK_ISSUE as bi on bd.BOOK_CODE=bi.BOOK_CODE join LMS_FINE_DETAILS as fi on bi.FINE_RANGE=fi.FINE_RANGE;













