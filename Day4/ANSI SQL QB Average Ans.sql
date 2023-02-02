-- 1,3,4,5,6,7,8,10,11,12,13,15 from Average
-- 17 in simple questions

-- Problem # 1:
-- Write a query to display the member id, member name of the members, book code and book title of the books taken by them.

select distinct m.member_id,m.member_name,bd.book_code,book_title from LMS_BOOK_DETAILS as bd join LMS_BOOK_ISSUE as bi on bd.BOOK_CODE=bi.BOOK_CODE join LMS_MEMBERS as m on m.MEMBER_ID=bi.MEMBER_ID;

-- Problem # 3:
-- Write a query to display the member id, member name, fine range and fine amount of the members whose fine amount is less than 100.

select m.member_id,member_name,fd.fine_range,fine_amount from LMS_BOOK_ISSUE as bi join LMS_MEMBERS as m on bi.MEMBER_ID=m.MEMBER_ID join LMS_FINE_DETAILS as fd on fd.FINE_RANGE=bi.FINE_RANGE and fd.FINE_AMOUNT<100;

-- Problem # 4:
-- Write a query to display the book code, book title, publisher, edition, price and year of publication and sort based on year of publication, publisher and edition.

select distinct book_code,book_title,publication,book_edition,year(publish_date) as publish_year,price from LMS_BOOK_DETAILS order by publish_year,PUBLICATION,BOOK_EDITION;


-- Problem # 5:
-- Write a query to display the book code, book title and rack number of the books which are placed in rack 'A1' and sort by book title in ascending order.

select book_code,book_title,rack_num from LMS_BOOK_DETAILS where RACK_NUM='A1' order by BOOK_TITLE;

-- Problem # 6:
-- Write a query to display the member id, member name, due date and date returned of the members who has returned the books after the due date. Hint: Date_return is due date and Date_returned is actual book return date.

select m.member_id,member_name,Date_return as due_date,Date_returned from LMS_MEMBERS as m join LMS_BOOK_ISSUE as bi on bi.MEMBER_ID=m.MEMBER_ID where DATE_RETURNED>DATE_RETURN;

-- Problem # 7:
-- Write a query to display the member id, member name and date of registration who have not taken any book.

select * from LMS_MEMBERS;
select * from LMS_BOOK_ISSUE;
select  member_id,member_name,date_register from LMS_MEMBERS
where MEMBER_ID not in(select MEMBER_ID from LMS_BOOK_ISSUE);


-- Problem # 8:
-- Write a Query to display the member id and member name of the members who has not paid any fine in the year 2012.
select member_id,member_name from LMS_MEMBERS where MEMBER_ID in (select MEMBER_ID from LMS_BOOK_ISSUE where year(DATE_RETURNED)=2012 and FINE_RANGE in(select FINE_RANGE from LMS_FINE_DETAILS where FINE_AMOUNT=0 ));



-- Problem # 10:
-- Write a query to list the book title and supplier id for the books authored by “Herbert Schildt" and the book edition is 5 and supplied by supplier ‘S01’.

select book_title,supplier_id from LMS_BOOK_DETAILS where AUTHOR='Herbert Schildt' and BOOK_EDITION=5 and SUPPLIER_ID='S01';


-- Problem # 11:
-- Write a query to display the rack number and the number of books in each rack with alias name “NOOFBOOKS” and sort by rack number in ascending order.

select rack_num,COUNT(book_code) as NOOFBOOKS from LMS_BOOK_DETAILS group by RACK_NUM;

-- Problem # 12:
-- Write a query to display book issue number, member name, date or registration, date of expiry, book title, category author, price, date of issue, date of return, actual returned date, issue status, fine amount.

select distinct book_issue_no,member_name,date_register,date_expire,book_title,category,author,price,date_issue,date_return,date_returned,fine_amount from LMS_BOOK_DETAILS as bd join LMS_BOOK_ISSUE as bi on bd.BOOK_CODE=bi.BOOK_CODE join LMS_MEMBERS as m on m.MEMBER_ID=bi.MEMBER_ID join LMS_FINE_DETAILS as fi on bi.FINE_RANGE=fi.FINE_RANGE;

-- Problem # 13:
-- Write a query to display the book code, title, publish date of the books which is been published in the month of December.
select book_code,book_title,publish_date from LMS_BOOK_DETAILS where MONTH(PUBLISH_DATE)=12 ; 


-- Problem # 14:
-- Write a query to display the book code, book title ,supplier name and price of the book witch takes maximum price based on each supplier.

select distinct book_code,book_title,sd.supplier_name,max(price) as maxPrice from LMS_BOOK_DETAILS as bd join LMS_SUPPLIERS_DETAILS as sd on bd.SUPPLIER_ID=sd.SUPPLIER_ID group by book_code,book_title,sd.SUPPLIER_NAME; 


-- simple Questions
-- Problem#17:
-- Write a query to display the member id, member name, city and member status of members with the total fine paid by them with alias name “Fine”.

select m.member_id,member_name,city,membership_status,fine_amount as Fine from LMS_MEMBERS as m join LMS_BOOK_ISSUE as bi on m.MEMBER_ID=bi.MEMBER_ID join LMS_FINE_DETAILS as fd on bi.FINE_RANGE=fd.FINE_RANGE;




