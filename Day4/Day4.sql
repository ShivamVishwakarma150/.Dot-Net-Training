select * from LMS_BOOK_DETAILS;
select * from LMS_BOOK_ISSUE;
select * from LMS_FINE_DETAILS;
select * from LMS_MEMBERS;
select * from LMS_SUPPLIERS_DETAILS;

-- 1,3,4,5,6,7,8,9,10,11,12,13,14,16





-- Problem#16:
-- Write a query to display the supplier id, supplier name and contact. If phone number is null then display ‘No’ else display ‘Yes’ with alias name “PHONENUMAVAILABLE”. Hint: Use ISNULL.


select SUPPLIER_ID,SUPPLIER_NAME,CONTACT ,
CASE
	WHEN CONTACT IS NULL THEN 'NO'
	ELSE 'YES'
END AS 'PHONENUM AVAILABLE'
from LMS_SUPPLIERS_DETAILS;


--- Display the book code,book name and suplier name of the books in library
-- inner join 
-- Note -> By default join is internally doing inner join
select b.book_code,b.book_title, s.supplier_name 
from LMS_BOOK_DETAILS as b join  lms_suppliers_details as s on b.SUPPLIER_ID=s.SUPPLIER_ID;

-- N tables will need N-1 joins


-- Display the book_title and the memeber_id who has taken books from library

select * from LMS_BOOK_DETAILS;
select  * from LMS_MEMBERS;
select * from LMS_BOOK_ISSUE;

select BOOK_TITLE,MEMBER_ID from LMS_BOOK_DETAILS as BD join LMS_BOOK_ISSUE as BI
 on BD.book_code = BI.BOOK_CODE;

 -- Employee DB

 
 --select * from employee;
 --select * from department;

 -- Display employee name , email and department name
 -- select concat(first_name,' ',last_name) as 'Full_Name',email,name from employee as e join department as d on d.id=e.department_id;


 -- Display empl name,dept name and the state location

-- select e.first_name,d.name as Dept ,l.state from employee as e join department as d on e.department_id=d.id join location as l on l.id=d.location_id;

-- Display department_id and number of employee in each department
--- select department_id, count(id) as countOfEmps from employee group by department_id;



--select * from department;
--select * from employee;
-- Display department name and number of employee in each department
--select department_id,COUNT(id) as countOfEmps from employee group by department_id;

--select name,count(e.id) as countOfEmps from department as d join employee as e on e.department_id=d.id group by name;


 -- Display the bookname and member name who has taken book from the library.

 select distinct l1.BOOK_TITLE,l3.MEMBER_NAME from LMS_BOOK_DETAILS as l1 
 join LMS_BOOK_ISSUE as l2 on
 l1.BOOK_CODE=l2.BOOK_CODE join LMS_MEMBERS as l3 on l2.MEMBER_ID=l3.MEMBER_ID;

 
 -- Display the supplier_id and number of book suplied by each supplier

 select s.supplier_id,count(b.book_code) as No_Of_Books from LMS_SUPPLIERS_DETAILS as s join LMS_BOOK_DETAILS as b on s.SUPPLIER_ID=b.SUPPLIER_ID group by s.SUPPLIER_ID;

 -- display the supplier_name and number of book supplied by each supplier
 select s.supplier_name,count(b.book_code) as No_Of_Books from LMS_SUPPLIERS_DETAILS as s join LMS_BOOK_DETAILS as b on s.SUPPLIER_ID=b.SUPPLIER_ID group by s.SUPPLIER_NAME;



















