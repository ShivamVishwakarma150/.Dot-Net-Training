select * from employee;
select * from manager;
select * from department;
select * from location;
select * from Region;
select * from Countries;


-- select the employee details of HR department
-- the department id in the department table for HR=2 Hard Coding
select first_name,email,salary from employee where department_id=2;

-- by chance if sometimes the department HR's id is updated as 9 the above query will not give right answer.
update department set id=9 where name='HR';

-- Soft coding dynamic query
select first_name,email,salary from employee where department_id=(select id from department where name='HR');

-- Display the states of India
select state from location where country_id='IN';
select * from location;

select state from location where country_id=(select id from Countries where name='India');

select first_name from employee where id IN (Select employee_id from manager) and department_id = (select id from department where name='HR');


-- Display the employee details whose department's location is in state new Jersey.
-- multi-level subquery

select first_name from employee where department_id in(
select id from department where location_id=(
select id from location where state='new Jersey'));

-- find highest salary
select first_name from employee where salary=(select Max(salary) from employee);

-- find Min Salary
select first_name from employee where salary=(select Min(salary) from employee);


select first_name,salary from employee where salary<(select Avg(salary) from employee);

-- 2nd highest 
select Max(salary) from employee where salary!=(select max(salary) from employee);

select first_name,salary from employee where salary =(select Max(salary) from employee where salary!=(select max(salary) from employee));

-- 2.	Write a query to display the names of all states belonging to the country Canada. Display the records sorted in ascending order based on state name
select * from Countries;
select state from location where country_id=(select id from Countries where name='canada') order by state;



-- 3.	Write a query to display the first name of the managers of Accounts department. Display the records sorted in ascending order based on manager name.
select  * from department;
select * from employee;
select * from manager;
select first_name from employee where id IN(select employee_id from manager where department_id in(select id from department where name='Accounts' )) order by first_name;


-- 9. Write a query to display the names of all countries belonging to region Europe. Display the records sorted in ascending order based on country name.


select name from Countries where region_id=(select id from Region where name='Europe')order by name asc;


--  14.	Write a query to display the first name of the managers of HR department. Display the records sorted in ascending order based on manager name

select first_name from employee where  id in(select employee_id from manager where department_id = (select id from department where name='HR')) order by first_name ;


-- 15.	Write a query to display the first name of all employees who are managers. Display the records sorted in ascending order based on first name.

select first_name from employee where id in(select employee_id from manager) order by first_name asc;


-- how many employees are availabe in it department
select * from department;
select * from location;
select * from employee;

select count(id) as 'no_of_employees' from employee where department_id=(select id from department where name='IT'); 

-- Group by

select count(department_id) from employee group by department_id;


select department_id,count(id) from employee group by department_id ;

select * from location;

select country_id,count(state) as 'no_of_states' from location group by country_id;



-- Display dept id and each dept what is the maximum salary available

select department_id,max(salary) from employee group by department_id;

-- write a query to display the department id and the number of managers in the department. display the records sorted in ascending order based in department name given alias to the number of managers as.

select department_id,count(employee_id) from manager group by department_id;




