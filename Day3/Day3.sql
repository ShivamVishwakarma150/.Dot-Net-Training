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












