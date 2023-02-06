--Joins 

--

Select distinct supplier_id from LMS_BOOK_DETAILS;

Select supplier_id from LMS_SUPPLIERS_DETAILS;


--Outer Joins
--Left outer join
--Right outer join
--Full outer join 






Select l1.book_code, l1.book_title, l2.supplier_name ,l2.supplier_id from 
lms_book_details as l1 join LMS_SUPPLIERS_DETAILS as l2 
on l1.SUPPLIER_ID=l2.SUPPLIER_ID ;


Select l1.book_code, l1.book_title, l2.supplier_name ,l2.supplier_id from 
lms_book_details as l1 right outer join LMS_SUPPLIERS_DETAILS as l2 
on l1.SUPPLIER_ID=l2.SUPPLIER_ID ;


Select l2.member_id,l2.MEMBER_NAME,l1.book_code from 
lms_book_issue as l1 right join lms_members as l2 
on l1.MEMBER_ID= l2.member_id ;


--Left join

Select l1.book_code, l1.book_title, l2.supplier_name ,l2.supplier_id from 
lms_book_details as l1 left outer join LMS_SUPPLIERS_DETAILS as l2 
on l1.SUPPLIER_ID=l2.SUPPLIER_ID ;

--Full outer join

Select l1.book_code, l1.book_title, l2.supplier_name ,l2.supplier_id from 
lms_book_details as l1 full outer join LMS_SUPPLIERS_DETAILS as l2 
on l1.SUPPLIER_ID=l2.SUPPLIER_ID where l2.supplier_name like 'S%';

--Having clause
--Find the supplier details who has supplied maximum number of books.


Select * from lms_suppliers_details;
Select * from LMS_BOOK_DETAILS;

Select count(supplier_id) from LMS_BOOK_DETAILS group by supplier_id 
having count(supplier_id)>=All(
Select Count(supplier_id) from lms_book_details 
group by SUPPLIER_ID);


--subquery Answer
--4
--3
--1

--ALL(4,3,1)
--(0,4,3,1)>=All(0,4,3,1)

-- 0>=All(0,4,3,1)
--4>=All(0,4,3,1)--- For all the comparsion it will give a true 
--3>=All(0,4,3,1)
--1>=All(0,4,3,1)

update employee set salary=38000 where first_name='madhu';
Select supplier_id ,count(supplier_id) from LMS_BOOK_DETAILS 
group by supplier_id having count(supplier_id) >2;

Select member_name ,count(book_code) as NoOfBooks from LMS_BOOK_ISSUE as l1 join
LMS_MEMBERS as l2 on l1.member_id=l2.member_id where member_name like 'A%'
group by member_name having count(book_code)<2 order by member_name desc;


Select * from employee;


Select * from 
(Select first_name, salary, DENSE_RANK() over(order by salary desc) r from 
employee) as e where r=5


Select * from employee as e1 where 2= 
(Select count(distinct salary) from employee e2 where e2.salary>=e1.salary)

Select * from employee where salary =(Select Max(salary) from employee)

Create table Emp
(id int,
name char(10),
salary int
);


insert into Emp values(1,'Saran',45000),
(2,'Deepa',65000),(3,'Ram',76000),(4,'John',35000);

Select * from emp;

Select * from emp as e1 where 2= 
(Select count(distinct salary) from emp e2 where e2.salary>=e1.salary);