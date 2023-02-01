select * from LMS_BOOK_DETAILS;
select * from LMS_BOOK_ISSUE;
select * from LMS_FINE_DETAILS;
select * from LMS_MEMBERS;
select * from LMS_SUPPLIERS_DETAILS;

-- 1,3,4,5,6,7,8,9,10,11,12,13,14,16


-- Problem # 1:
-- Write a query to display the member id, member name, city and membership status who are all having life time membership. Hint: Life time membership status is “Permanent”.

select MEMBER_ID,MEMBER_NAME,city,MEMBERSHIP_STATUS from LMS_MEMBERS where MEMBERSHIP_STATUS='Permanent';




-- Problem # 3:
-- Write a query to display the member id, member name who have taken the book with book code 'BL000002'.

select MEMBER_ID,MEMBER_NAME from LMS_MEMBERS where MEMBER_ID=(select MEMBER_ID from LMS_BOOK_ISSUE where BOOK_CODE='BL000002');




-- Problem # 4:
-- Write a query to display the book code, book title and author of the books whose author name begins with 'P'.

select BOOK_CODE,BOOK_TITLE,AUTHOR from LMS_BOOK_DETAILS where AUTHOR like 'p%';


-- Problem # 5:
-- Write a query to display the total number of Java books available in library with alias name ‘NO_OF_BOOKS’.

select count(category) as 'NO_OF_BOOKS' from LMS_BOOK_DETAILS where category='JAVA';



-- Problem # 6:
-- Write a query to list the category and number of books in each category with alias name ‘NO_OF_BOOKS’.

select category,count(CATEGORY) as 'NO_OF_BOOKS' from LMS_BOOK_DETAILS group by CATEGORY;


-- Problem # 7:
-- Write a query to display the number of books published by "Prentice Hall” with the alias name “NO_OF_BOOKS”.

select count(PUBLICATION) as 'NO_OF_BOOKS' from LMS_BOOK_DETAILS where PUBLICATION='Prentice Hall';


-- Problem # 8:
-- Write a query to display the book code, book title of the books which are issued on the date "1st April 2012".

select * from LMS_BOOK_ISSUE;
select * from LMS_BOOK_DETAILS;
select book_code,book_title from LMS_BOOK_DETAILS where BOOK_CODE in (select book_code from LMS_BOOK_ISSUE where DATE_ISSUE='2012-05-01');


-- Problem # 9:
-- Write a query to display the member id, member name, date of registration and expiry date of the members whose membership expiry date is before APR 2013.

select MEMBER_ID,MEMBER_NAME,DATE_REGISTER,DATE_EXPIRE from LMS_MEMBERS where DATE_EXPIRE<'2013-04-30';

-- Problem # 10:
-- write a query to display the member id, member name, date of registration, membership status of the members who registered before "March 2012" and membership status is "Temporary"

select MEMBER_ID,MEMBER_NAME,DATE_REGISTER,MEMBERSHIP_STATUS from LMS_MEMBERS where DATE_REGISTER<'2012-03-31' and MEMBERSHIP_STATUS='Temporary';

-- Problem #11:
-- Write a query to display the member id, member name who’s City is CHENNAI or DELHI. Hint: Display the member name in title case with alias name 'Name'.

select MEMBER_ID,MEMBER_NAME from LMS_MEMBERS where city in('chennai','delhi');


-- Problem #12:
-- Write a query to concatenate book title, author and display in the following format.
-- Book_Title_is_written_by_Author
-- Example: Let Us C_is_written_by_Yashavant Kanetkar
-- Hint: display unique books. Use “BOOK_WRITTEN_BY” as alias name.

select DISTINCT(CONCAT(BOOK_TITLE,'_is_written_by_',AUTHOR)) as 'BOOK_WRITTEN_BY' from LMS_BOOK_DETAILS;

-- Problem #13:
-- Write a query to display the average price of books which is belonging to ‘JAVA’ category with alias name “AVERAGEPRICE”.

SELECT AVG(PRICE) AS 'AVERAGEPRICE' FROM LMS_BOOK_DETAILS WHERE CATEGORY='JAVA';


-- Problem #14:
-- Write a query to display the supplier id, supplier name and email of the suppliers who are all having gmail account.

select SUPPLIER_ID,SUPPLIER_NAME from LMS_SUPPLIERS_DETAILS where email is not null;











